Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports ganaderiaMVC

Namespace Areas.Reproducciones.Controllers
    Public Class nacimientoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: nacimientoes
        Function Index() As ActionResult
            Dim nacimientoes = db.nacimientoes.Include(Function(n) n.animal).Include(Function(n) n.animal1).Include(Function(n) n.tipoServicio)
            Return View(nacimientoes.ToList())
        End Function

        ' GET: nacimientoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim nacimiento As nacimiento = db.nacimientoes.Find(id)
            If IsNothing(nacimiento) Then
                Return HttpNotFound()
            End If
            Return View(nacimiento)
        End Function

        ' GET: nacimientoes/Create
        Function Create() As ActionResult
            ViewBag.aniCodMadre = New SelectList(db.animals, "aniCod", "aniCaravana")
            ViewBag.aniCodCria = New SelectList(db.animals, "aniCod", "aniCaravana")
            ViewBag.tsCod = New SelectList(db.tipoServicios, "tsCod", "tsNombre")
            Return View()
        End Function

        ' POST: nacimientoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="nacCod,aniCodMadre,nacFch,nacSexo,nacEstado,aniCodCria,tsCod,rv")> ByVal nacimiento As nacimiento) As ActionResult
            If ModelState.IsValid Then
                db.nacimientoes.Add(nacimiento)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.aniCodMadre = New SelectList(db.animals, "aniCod", "aniCaravana", nacimiento.aniCodMadre)
            ViewBag.aniCodCria = New SelectList(db.animals, "aniCod", "aniCaravana", nacimiento.aniCodCria)
            ViewBag.tsCod = New SelectList(db.tipoServicios, "tsCod", "tsNombre", nacimiento.tsCod)
            Return View(nacimiento)
        End Function

        ' GET: nacimientoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim nacimiento As nacimiento = db.nacimientoes.Find(id)
            If IsNothing(nacimiento) Then
                Return HttpNotFound()
            End If
            ViewBag.aniCodMadre = New SelectList(db.animals, "aniCod", "aniCaravana", nacimiento.aniCodMadre)
            ViewBag.aniCodCria = New SelectList(db.animals, "aniCod", "aniCaravana", nacimiento.aniCodCria)
            ViewBag.tsCod = New SelectList(db.tipoServicios, "tsCod", "tsNombre", nacimiento.tsCod)
            Return View(nacimiento)
        End Function

        ' POST: nacimientoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="nacCod,aniCodMadre,nacFch,nacSexo,nacEstado,aniCodCria,tsCod,rv")> ByVal nacimiento As nacimiento) As ActionResult
            If ModelState.IsValid Then
                db.Entry(nacimiento).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.aniCodMadre = New SelectList(db.animals, "aniCod", "aniCaravana", nacimiento.aniCodMadre)
            ViewBag.aniCodCria = New SelectList(db.animals, "aniCod", "aniCaravana", nacimiento.aniCodCria)
            ViewBag.tsCod = New SelectList(db.tipoServicios, "tsCod", "tsNombre", nacimiento.tsCod)
            Return View(nacimiento)
        End Function

        ' GET: nacimientoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim nacimiento As nacimiento = db.nacimientoes.Find(id)
            If IsNothing(nacimiento) Then
                Return HttpNotFound()
            End If
            Return View(nacimiento)
        End Function

        ' POST: nacimientoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim nacimiento As nacimiento = db.nacimientoes.Find(id)
            db.nacimientoes.Remove(nacimiento)
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
