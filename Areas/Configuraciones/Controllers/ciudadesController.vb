Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ganaderiaMVC

Namespace Areas.Configuraciones.Controllers
    Public Class ciudadesController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: ciudades
        Function Index() As ActionResult
            Dim ciudades = db.ciudades.Include(Function(c) c.departamento)
            Return View(ciudades.ToList())
        End Function

        ' GET: ciudades/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ciudade As ciudade = db.ciudades.Find(id)
            If IsNothing(ciudade) Then
                Return HttpNotFound()
            End If
            Return View(ciudade)
        End Function

        ' GET: ciudades/Create
        Function Create() As ActionResult
            ViewBag.depaCod = New SelectList(db.departamentos, "depaCod", "depaNombre")
            Return View()
        End Function

        ' POST: ciudades/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ciudCod,ciudNombre,depaCod")> ByVal ciudade As ciudade) As ActionResult
            If ModelState.IsValid Then
                db.ciudades.Add(ciudade)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.depaCod = New SelectList(db.departamentos, "depaCod", "depaNombre", ciudade.depaCod)
            Return View(ciudade)
        End Function

        ' GET: ciudades/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ciudade As ciudade = db.ciudades.Find(id)
            If IsNothing(ciudade) Then
                Return HttpNotFound()
            End If
            ViewBag.depaCod = New SelectList(db.departamentos, "depaCod", "depaNombre", ciudade.depaCod)
            Return View(ciudade)
        End Function

        ' POST: ciudades/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ciudCod,ciudNombre,depaCod")> ByVal ciudade As ciudade) As ActionResult
            If ModelState.IsValid Then
                db.Entry(ciudade).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.depaCod = New SelectList(db.departamentos, "depaCod", "depaNombre", ciudade.depaCod)
            Return View(ciudade)
        End Function

        ' GET: ciudades/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim ciudade As ciudade = db.ciudades.Find(id)
            If IsNothing(ciudade) Then
                Return HttpNotFound()
            End If
            Return View(ciudade)
        End Function

        ' POST: ciudades/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim ciudade As ciudade = db.ciudades.Find(id)
            db.ciudades.Remove(ciudade)
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
