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
    Public Class vacunacionsController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: vacunacions
        Function Index() As ActionResult
            Dim vacunacions = db.vacunacions.Include(Function(v) v.animal).Include(Function(v) v.profesional).Include(Function(v) v.tipoVacuna)
            Return View(vacunacions.ToList())
        End Function

        ' GET: vacunacions/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacunacion As vacunacion = db.vacunacions.Find(id)
            If IsNothing(vacunacion) Then
                Return HttpNotFound()
            End If
            Return View(vacunacion)
        End Function

        ' GET: vacunacions/Create
        Function Create() As ActionResult
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana")
            ViewBag.profCod = New SelectList(db.profesionals, "profCod", "profNombre")
            ViewBag.tvCod = New SelectList(db.tipoVacunas, "tvCod", "tvNombre")
            Return View()
        End Function

        ' POST: vacunacions/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="vacCod,vacFch,tvCod,vacDosis,profCod,aniCod,rv")> ByVal vacunacion As vacunacion) As ActionResult
            If ModelState.IsValid Then
                db.vacunacions.Add(vacunacion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana", vacunacion.aniCod)
            ViewBag.profCod = New SelectList(db.profesionals, "profCod", "profNombre", vacunacion.profCod)
            ViewBag.tvCod = New SelectList(db.tipoVacunas, "tvCod", "tvNombre", vacunacion.tvCod)
            Return View(vacunacion)
        End Function

        ' GET: vacunacions/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacunacion As vacunacion = db.vacunacions.Find(id)
            If IsNothing(vacunacion) Then
                Return HttpNotFound()
            End If
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana", vacunacion.aniCod)
            ViewBag.profCod = New SelectList(db.profesionals, "profCod", "profNombre", vacunacion.profCod)
            ViewBag.tvCod = New SelectList(db.tipoVacunas, "tvCod", "tvNombre", vacunacion.tvCod)
            Return View(vacunacion)
        End Function

        ' POST: vacunacions/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="vacCod,vacFch,tvCod,vacDosis,profCod,aniCod,rv")> ByVal vacunacion As vacunacion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(vacunacion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.aniCod = New SelectList(db.animals, "aniCod", "aniCaravana", vacunacion.aniCod)
            ViewBag.profCod = New SelectList(db.profesionals, "profCod", "profNombre", vacunacion.profCod)
            ViewBag.tvCod = New SelectList(db.tipoVacunas, "tvCod", "tvNombre", vacunacion.tvCod)
            Return View(vacunacion)
        End Function

        ' GET: vacunacions/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim vacunacion As vacunacion = db.vacunacions.Find(id)
            If IsNothing(vacunacion) Then
                Return HttpNotFound()
            End If
            Return View(vacunacion)
        End Function

        ' POST: vacunacions/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim vacunacion As vacunacion = db.vacunacions.Find(id)
            db.vacunacions.Remove(vacunacion)
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
