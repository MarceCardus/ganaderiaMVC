Imports System
Imports System.Data.Entity
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ganaderiaMVC

Namespace Areas.Vision.Controllers
    Public Class vision_pesajeController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        Function Index() As ActionResult
            Dim lista = db.vision_pesaje _
                .Include(Function(v) v.animal) _
                .Include(Function(v) v.vision_dispositivo) _
                .Include(Function(v) v.vision_modelo) _
                .OrderByDescending(Function(v) v.fecha) _
                .ToList()

            Return View(lista)
        End Function

        Function Details(ByVal id As Long?) As ActionResult
            If Not id.HasValue Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim e = db.vision_pesaje _
                .Include(Function(v) v.animal) _
                .Include(Function(v) v.vision_dispositivo) _
                .Include(Function(v) v.vision_modelo) _
                .SingleOrDefault(Function(v) v.pesId = id.Value)

            If e Is Nothing Then Return HttpNotFound()
            Return View(e)
        End Function

        Function Create() As ActionResult
            CargarCombos()
            Dim e As New vision_pesaje()
            e.fecha = DateTime.Now
            e.metodo = "BALANZA"
            Return View(e)
        End Function

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="pesId,aniCod,fecha,pesoKg,confianza,metodo,dispId,modId,imgPath,medidasJson,notas")> ByVal e As vision_pesaje,
                        ByVal Imagen As HttpPostedFileBase) As ActionResult

            NormalizarSegunMetodo(e)
            ValidarJsonMedidas(e)

            If ModelState.IsValid Then
                e.fecha = AsegurarUtc(e.fecha)

                db.vision_pesaje.Add(e)
                db.SaveChanges()

                If Imagen IsNot Nothing AndAlso Imagen.ContentLength > 0 Then
                    Dim rutaRelativa = GuardarImagen(e.pesId, Imagen)
                    e.imgPath = rutaRelativa
                    db.SaveChanges()
                End If

                Return RedirectToAction("Index")
            End If

            CargarCombos(e.aniCod, e.dispId, e.modId)
            Return View(e)
        End Function

        Function Edit(ByVal id As Long?) As ActionResult
            If Not id.HasValue Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim e = db.vision_pesaje.Find(id.Value)
            If e Is Nothing Then Return HttpNotFound()

            CargarCombos(e.aniCod, e.dispId, e.modId)
            Return View(e)
        End Function

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="pesId,aniCod,fecha,pesoKg,confianza,metodo,dispId,modId,imgPath,medidasJson,notas")> ByVal e As vision_pesaje,
                      ByVal Imagen As HttpPostedFileBase) As ActionResult

            NormalizarSegunMetodo(e)
            ValidarJsonMedidas(e)

            If ModelState.IsValid Then
                Dim dbEntity = db.vision_pesaje.Find(e.pesId)
                If dbEntity Is Nothing Then Return HttpNotFound()

                dbEntity.aniCod = e.aniCod
                dbEntity.fecha = AsegurarUtc(e.fecha)
                dbEntity.pesoKg = e.pesoKg
                dbEntity.metodo = e.metodo
                dbEntity.confianza = e.confianza
                dbEntity.dispId = e.dispId
                dbEntity.modId = e.modId
                dbEntity.medidasJson = e.medidasJson
                dbEntity.notas = e.notas

                ' ✅ FIX 1: usar If(e.metodo,"") en vez de (e.metodo Or "")
                If Not String.Equals(If(e.metodo, "").Trim(), "VISION", StringComparison.OrdinalIgnoreCase) Then
                    dbEntity.confianza = Nothing
                    dbEntity.dispId = Nothing
                    dbEntity.modId = Nothing
                    dbEntity.medidasJson = Nothing
                    dbEntity.imgPath = Nothing
                End If

                If Imagen IsNot Nothing AndAlso Imagen.ContentLength > 0 Then
                    Dim rutaRelativa = GuardarImagen(dbEntity.pesId, Imagen)
                    dbEntity.imgPath = rutaRelativa
                End If

                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            CargarCombos(e.aniCod, e.dispId, e.modId)
            Return View(e)
        End Function

        Function Delete(ByVal id As Long?) As ActionResult
            If Not id.HasValue Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If

            Dim e = db.vision_pesaje _
                .Include(Function(v) v.animal) _
                .Include(Function(v) v.vision_dispositivo) _
                .Include(Function(v) v.vision_modelo) _
                .SingleOrDefault(Function(v) v.pesId = id.Value)

            If e Is Nothing Then Return HttpNotFound()
            Return View(e)
        End Function

        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim e = db.vision_pesaje.Find(id)
            If e IsNot Nothing Then
                db.vision_pesaje.Remove(e)
                db.SaveChanges()
            End If
            Return RedirectToAction("Index")
        End Function

        ' =========================
        ' Helpers
        ' =========================

        Private Sub CargarCombos(Optional aniCodSel As Integer? = Nothing,
                                 Optional dispSel As Integer? = Nothing,
                                 Optional modSel As Integer? = Nothing)

            ViewBag.aniCod = New SelectList(db.animals.OrderBy(Function(a) a.aniCaravana), "aniCod", "aniCaravana", aniCodSel)
            ViewBag.dispId = New SelectList(db.vision_dispositivo.OrderBy(Function(d) d.nombre), "dispId", "nombre", dispSel)
            ViewBag.modId = New SelectList(db.vision_modelo.OrderBy(Function(m) m.nombre), "modId", "nombre", modSel)
        End Sub

        Private Sub NormalizarSegunMetodo(ByVal e As vision_pesaje)
            Dim m As String = (If(e.metodo, "")).Trim().ToUpperInvariant()
            e.metodo = m

            If m <> "VISION" Then
                e.confianza = Nothing
                e.dispId = Nothing
                e.modId = Nothing
                e.medidasJson = Nothing
                e.imgPath = Nothing
            End If
        End Sub

        Private Sub ValidarJsonMedidas(ByVal e As vision_pesaje)
            If String.IsNullOrWhiteSpace(e.medidasJson) Then Return

            Try
                ' ✅ FIX 2: usar el nombre completo para no chocar con Controller.Json(...)
                Dim tmp = System.Web.Helpers.Json.Decode(Of Object)(e.medidasJson)
            Catch ex As Exception
                ModelState.AddModelError("medidasJson", "El JSON de medidas no es válido.")
            End Try
        End Sub

        Private Function AsegurarUtc(ByVal dt As DateTime) As DateTime
            If dt = DateTime.MinValue Then Return DateTime.UtcNow
            If dt.Kind = DateTimeKind.Utc Then Return dt

            Dim local = DateTime.SpecifyKind(dt, DateTimeKind.Local)
            Return local.ToUniversalTime()
        End Function

        Private Function GuardarImagen(ByVal pesId As Long, ByVal archivo As HttpPostedFileBase) As String
            Dim ext = Path.GetExtension(archivo.FileName).ToLowerInvariant()
            Dim permitidas = New String() {".jpg", ".jpeg", ".png", ".webp", ".gif"}

            If Not permitidas.Contains(ext) Then
                Throw New InvalidOperationException("Formato de imagen no permitido.")
            End If

            Dim folderRel = "~/Uploads/VisionPesaje/"
            Dim folderFis = Server.MapPath(folderRel)
            If Not Directory.Exists(folderFis) Then Directory.CreateDirectory(folderFis)

            Dim fileName = $"pes_{pesId}_{DateTime.UtcNow:yyyyMMddHHmmss}{ext}"
            Dim fullPath = Path.Combine(folderFis, fileName)
            archivo.SaveAs(fullPath)

            Return "/Uploads/VisionPesaje/" & fileName
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then db.Dispose()
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
