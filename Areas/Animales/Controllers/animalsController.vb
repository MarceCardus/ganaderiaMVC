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
    Public Class animalsController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: animals
        Function Index() As ActionResult
            Dim animals = db.animals.Include(Function(a) a.establecimiento).Include(Function(a) a.raza)
            Return View(animals.ToList())
        End Function

        ' GET: animals/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim animal As animal = db.animals.Find(id)
            If IsNothing(animal) Then
                Return HttpNotFound()
            End If
            Return View(animal)
        End Function

        ' GET: animals/Create
        Function Create() As ActionResult
            ViewBag.estCod = New SelectList(db.establecimientoes, "estCod", "estNombre")
            ViewBag.razaCod = New SelectList(db.razas, "razaCod", "razaDesc")
            Return View()
        End Function

        ' POST: animals/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="aniCod,aniCaravana,razaCod,aniSexo,aniFchNac,aniEstado,aniFchIns,aniUsrIns,aniFchUpd,estCod,aniUsrUpd,rv")> ByVal animal As animal) As ActionResult
            If ModelState.IsValid Then
                db.animals.Add(animal)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.estCod = New SelectList(db.establecimientoes, "estCod", "estNombre", animal.estCod)
            ViewBag.razaCod = New SelectList(db.razas, "razaCod", "razaDesc", animal.razaCod)
            Return View(animal)
        End Function

        ' GET: animals/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim animal As animal = db.animals.Find(id)
            If IsNothing(animal) Then
                Return HttpNotFound()
            End If
            ViewBag.estCod = New SelectList(db.establecimientoes, "estCod", "estNombre", animal.estCod)
            ViewBag.razaCod = New SelectList(db.razas, "razaCod", "razaDesc", animal.razaCod)
            Return View(animal)
        End Function

        ' POST: animals/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="aniCod,aniCaravana,razaCod,aniSexo,aniFchNac,aniEstado,aniFchIns,aniUsrIns,aniFchUpd,estCod,aniUsrUpd,rv")> ByVal animal As animal) As ActionResult
            If ModelState.IsValid Then
                db.Entry(animal).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.estCod = New SelectList(db.establecimientoes, "estCod", "estNombre", animal.estCod)
            ViewBag.razaCod = New SelectList(db.razas, "razaCod", "razaDesc", animal.razaCod)
            Return View(animal)
        End Function

        ' GET: animals/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim animal As animal = db.animals.Find(id)
            If IsNothing(animal) Then
                Return HttpNotFound()
            End If
            Return View(animal)
        End Function

        ' POST: animals/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim animal As animal = db.animals.Find(id)
            db.animals.Remove(animal)
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
