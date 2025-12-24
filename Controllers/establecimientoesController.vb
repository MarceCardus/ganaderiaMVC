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
    Public Class establecimientoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: establecimientoes
        Function Index() As ActionResult
            Dim establecimientoes = db.establecimientoes.Include(Function(e) e.barrio)
            Return View(establecimientoes.ToList())
        End Function

        ' GET: establecimientoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim establecimiento As establecimiento = db.establecimientoes.Find(id)
            If IsNothing(establecimiento) Then
                Return HttpNotFound()
            End If
            Return View(establecimiento)
        End Function

        ' GET: establecimientoes/Create
        Function Create() As ActionResult
            ViewBag.estBarrio = New SelectList(db.barrios, "barriosCod", "barriosNombre")
            Return View()
        End Function

        ' POST: establecimientoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="estCod,estNombre,estBarrio")> ByVal establecimiento As establecimiento) As ActionResult
            If ModelState.IsValid Then
                db.establecimientoes.Add(establecimiento)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.estBarrio = New SelectList(db.barrios, "barriosCod", "barriosNombre", establecimiento.estBarrio)
            Return View(establecimiento)
        End Function

        ' GET: establecimientoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim establecimiento As establecimiento = db.establecimientoes.Find(id)
            If IsNothing(establecimiento) Then
                Return HttpNotFound()
            End If
            ViewBag.estBarrio = New SelectList(db.barrios, "barriosCod", "barriosNombre", establecimiento.estBarrio)
            Return View(establecimiento)
        End Function

        ' POST: establecimientoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="estCod,estNombre,estBarrio")> ByVal establecimiento As establecimiento) As ActionResult
            If ModelState.IsValid Then
                db.Entry(establecimiento).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.estBarrio = New SelectList(db.barrios, "barriosCod", "barriosNombre", establecimiento.estBarrio)
            Return View(establecimiento)
        End Function

        ' GET: establecimientoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim establecimiento As establecimiento = db.establecimientoes.Find(id)
            If IsNothing(establecimiento) Then
                Return HttpNotFound()
            End If
            Return View(establecimiento)
        End Function

        ' POST: establecimientoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim establecimiento As establecimiento = db.establecimientoes.Find(id)
            db.establecimientoes.Remove(establecimiento)
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
