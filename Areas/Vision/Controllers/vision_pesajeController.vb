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
    Public Class vision_pesajeController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: vision_pesaje
        Function Index() As ActionResult
            Dim vision_pesaje = db.vision_pesaje.Include(Function(v) v.animal).Include(Function(v) v.vision_dispositivo).Include(Function(v) v.vision_modelo)
            Return View(vision_pesaje.ToList())
        End Function

        ' GET: vision_pesaje/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_pesaje As vision_pesaje = db.vision_pesaje.Find(id)
            If IsNothing(vision_pesaje) Then
                Return HttpNotFound()
            End If
            Return View(vision_pesaje)
        End Function

        ' GET: vision_pesaje/Create
        Function Create() As ActionResult
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana")
            ViewBag.dispId = New SelectList(db.vision_dispositivo, "dispId", "nombre")
            ViewBag.modId = New SelectList(db.vision_modelo, "modId", "nombre")
            Return View()
        End Function

        ' POST: vision_pesaje/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="pesId,aniCod,fecha,pesoKg,confianza,metodo,dispId,modId,imgPath,medidasJson,notas")> ByVal vision_pesaje As vision_pesaje) As ActionResult
            If ModelState.IsValid Then
                db.vision_pesaje.Add(vision_pesaje)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana", vision_pesaje.aniCod)
            ViewBag.dispId = New SelectList(db.vision_dispositivo, "dispId", "nombre", vision_pesaje.dispId)
            ViewBag.modId = New SelectList(db.vision_modelo, "modId", "nombre", vision_pesaje.modId)
            Return View(vision_pesaje)
        End Function

        ' GET: vision_pesaje/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_pesaje As vision_pesaje = db.vision_pesaje.Find(id)
            If IsNothing(vision_pesaje) Then
                Return HttpNotFound()
            End If
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana", vision_pesaje.aniCod)
            ViewBag.dispId = New SelectList(db.vision_dispositivo, "dispId", "nombre", vision_pesaje.dispId)
            ViewBag.modId = New SelectList(db.vision_modelo, "modId", "nombre", vision_pesaje.modId)
            Return View(vision_pesaje)
        End Function

        ' POST: vision_pesaje/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="pesId,aniCod,fecha,pesoKg,confianza,metodo,dispId,modId,imgPath,medidasJson,notas")> ByVal vision_pesaje As vision_pesaje) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vision_pesaje).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana", vision_pesaje.aniCod)
            ViewBag.dispId = New SelectList(db.vision_dispositivo, "dispId", "nombre", vision_pesaje.dispId)
            ViewBag.modId = New SelectList(db.vision_modelo, "modId", "nombre", vision_pesaje.modId)
            Return View(vision_pesaje)
        End Function

        ' GET: vision_pesaje/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_pesaje As vision_pesaje = db.vision_pesaje.Find(id)
            If IsNothing(vision_pesaje) Then
                Return HttpNotFound()
            End If
            Return View(vision_pesaje)
        End Function

        ' POST: vision_pesaje/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim vision_pesaje As vision_pesaje = db.vision_pesaje.Find(id)
            db.vision_pesaje.Remove(vision_pesaje)
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
