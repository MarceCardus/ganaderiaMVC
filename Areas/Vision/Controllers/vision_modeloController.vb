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
    Public Class vision_modeloController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: vision_modelo
        Function Index() As ActionResult
            Return View(db.vision_modelo.ToList())
        End Function

        ' GET: vision_modelo/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_modelo As vision_modelo = db.vision_modelo.Find(id)
            If IsNothing(vision_modelo) Then
                Return HttpNotFound()
            End If
            Return View(vision_modelo)
        End Function

        ' GET: vision_modelo/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: vision_modelo/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="modId,nombre,version,enfoque,hash,fechaCarga,rowversion")> ByVal vision_modelo As vision_modelo) As ActionResult
            If ModelState.IsValid Then
                db.vision_modelo.Add(vision_modelo)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vision_modelo)
        End Function

        ' GET: vision_modelo/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_modelo As vision_modelo = db.vision_modelo.Find(id)
            If IsNothing(vision_modelo) Then
                Return HttpNotFound()
            End If
            Return View(vision_modelo)
        End Function

        ' POST: vision_modelo/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="modId,nombre,version,enfoque,hash,fechaCarga,rowversion")> ByVal vision_modelo As vision_modelo) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vision_modelo).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(vision_modelo)
        End Function

        ' GET: vision_modelo/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vision_modelo As vision_modelo = db.vision_modelo.Find(id)
            If IsNothing(vision_modelo) Then
                Return HttpNotFound()
            End If
            Return View(vision_modelo)
        End Function

        ' POST: vision_modelo/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vision_modelo As vision_modelo = db.vision_modelo.Find(id)
            db.vision_modelo.Remove(vision_modelo)
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
