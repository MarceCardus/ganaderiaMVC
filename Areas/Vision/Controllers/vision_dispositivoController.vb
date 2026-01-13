Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ganaderiaMVC

Namespace Controllers
    Public Class vision_dispositivoController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: vision_dispositivo
        Function Index() As ActionResult
            Return View(db.vision_dispositivo.ToList())
        End Function

        ' GET: vision_dispositivo/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_dispositivo As vision_dispositivo = db.vision_dispositivo.Find(id)
            If IsNothing(vision_dispositivo) Then
                Return HttpNotFound()
            End If
            Return View(vision_dispositivo)
        End Function

        ' GET: vision_dispositivo/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: vision_dispositivo/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="dispId,nombre,tipo,serie,ubicacion,activo,rowversion")> ByVal vision_dispositivo As vision_dispositivo) As ActionResult
            If ModelState.IsValid Then
                db.vision_dispositivo.Add(vision_dispositivo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vision_dispositivo)
        End Function

        ' GET: vision_dispositivo/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_dispositivo As vision_dispositivo = db.vision_dispositivo.Find(id)
            If IsNothing(vision_dispositivo) Then
                Return HttpNotFound()
            End If
            Return View(vision_dispositivo)
        End Function

        ' POST: vision_dispositivo/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="dispId,nombre,tipo,serie,ubicacion,activo,rowversion")> ByVal vision_dispositivo As vision_dispositivo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vision_dispositivo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vision_dispositivo)
        End Function

        ' GET: vision_dispositivo/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_dispositivo As vision_dispositivo = db.vision_dispositivo.Find(id)
            If IsNothing(vision_dispositivo) Then
                Return HttpNotFound()
            End If
            Return View(vision_dispositivo)
        End Function

        ' POST: vision_dispositivo/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vision_dispositivo As vision_dispositivo = db.vision_dispositivo.Find(id)
            db.vision_dispositivo.Remove(vision_dispositivo)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
