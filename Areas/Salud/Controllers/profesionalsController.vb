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
    Public Class profesionalsController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: profesionals
        Function Index() As ActionResult
            Return View(db.profesionals.ToList())
        End Function

        ' GET: profesionals/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim profesional As profesional = db.profesionals.Find(id)
            If IsNothing(profesional) Then
                Return HttpNotFound()
            End If
            Return View(profesional)
        End Function

        ' GET: profesionals/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: profesionals/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="profCod,profNombre")> ByVal profesional As profesional) As ActionResult
            If ModelState.IsValid Then
                db.profesionals.Add(profesional)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(profesional)
        End Function

        ' GET: profesionals/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim profesional As profesional = db.profesionals.Find(id)
            If IsNothing(profesional) Then
                Return HttpNotFound()
            End If
            Return View(profesional)
        End Function

        ' POST: profesionals/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="profCod,profNombre")> ByVal profesional As profesional) As ActionResult
            If ModelState.IsValid Then
                db.Entry(profesional).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(profesional)
        End Function

        ' GET: profesionals/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim profesional As profesional = db.profesionals.Find(id)
            If IsNothing(profesional) Then
                Return HttpNotFound()
            End If
            Return View(profesional)
        End Function

        ' POST: profesionals/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim profesional As profesional = db.profesionals.Find(id)
            db.profesionals.Remove(profesional)
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
