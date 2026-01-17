Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ganaderiaMVC

Namespace Areas.Animales.Controllers
    Public Class razasController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: Animales/razas
        Function Index() As ActionResult
            Return View(db.razas.ToList())
        End Function

        ' GET: Animales/razas/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim raza As raza = db.razas.Find(id)
            If IsNothing(raza) Then
                Return HttpNotFound()
            End If
            Return View(raza)
        End Function

        ' GET: Animales/razas/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Animales/razas/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="razaCod,razaDesc")> ByVal raza As raza) As ActionResult
            If ModelState.IsValid Then
                db.razas.Add(raza)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(raza)
        End Function

        ' GET: Animales/razas/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim raza As raza = db.razas.Find(id)
            If IsNothing(raza) Then
                Return HttpNotFound()
            End If
            Return View(raza)
        End Function

        ' POST: Animales/razas/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="razaCod,razaDesc")> ByVal raza As raza) As ActionResult
            If ModelState.IsValid Then
                db.Entry(raza).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(raza)
        End Function

        ' GET: Animales/razas/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim raza As raza = db.razas.Find(id)
            If IsNothing(raza) Then
                Return HttpNotFound()
            End If
            Return View(raza)
        End Function

        ' POST: Animales/razas/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim raza As raza = db.razas.Find(id)
            db.razas.Remove(raza)
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
