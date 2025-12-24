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
    Public Class barriosController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: barrios
        Function Index() As ActionResult
            Dim barrios = db.barrios.Include(Function(b) b.ciudade)
            Return View(barrios.ToList())
        End Function

        ' GET: barrios/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim barrio As barrio = db.barrios.Find(id)
            If IsNothing(barrio) Then
                Return HttpNotFound()
            End If
            Return View(barrio)
        End Function

        ' GET: barrios/Create
        Function Create() As ActionResult
            ViewBag.ciudCod = New SelectList(db.ciudades, "ciudCod", "ciudNombre")
            Return View()
        End Function

        ' POST: barrios/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="barriosCod,barriosNombre,ciudCod")> ByVal barrio As barrio) As ActionResult
            If ModelState.IsValid Then
                db.barrios.Add(barrio)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ciudCod = New SelectList(db.ciudades, "ciudCod", "ciudNombre", barrio.ciudCod)
            Return View(barrio)
        End Function

        ' GET: barrios/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim barrio As barrio = db.barrios.Find(id)
            If IsNothing(barrio) Then
                Return HttpNotFound()
            End If
            ViewBag.ciudCod = New SelectList(db.ciudades, "ciudCod", "ciudNombre", barrio.ciudCod)
            Return View(barrio)
        End Function

        ' POST: barrios/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="barriosCod,barriosNombre,ciudCod")> ByVal barrio As barrio) As ActionResult
            If ModelState.IsValid Then
                db.Entry(barrio).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.ciudCod = New SelectList(db.ciudades, "ciudCod", "ciudNombre", barrio.ciudCod)
            Return View(barrio)
        End Function

        ' GET: barrios/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim barrio As barrio = db.barrios.Find(id)
            If IsNothing(barrio) Then
                Return HttpNotFound()
            End If
            Return View(barrio)
        End Function

        ' POST: barrios/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim barrio As barrio = db.barrios.Find(id)
            db.barrios.Remove(barrio)
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
