Imports System
Imports System.Data.Entity
Imports System.Net
Imports System.Web.Mvc
Imports ganaderiaMVC

Namespace Areas.Animales.Controllers
    Public Class animalsController
        Inherits Controller

        Private db As New ganaderiaEntities

        ' GET: Animales/animals
        Function Index() As ActionResult
            Dim animals = db.animals.Include(Function(a) a.establecimiento).Include(Function(a) a.raza)
            Return View(animals.ToList())
        End Function

        ' GET: Animales/animals/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If Not id.HasValue Then Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)

            Dim animal = db.animals.Include(Function(a) a.establecimiento).Include(Function(a) a.raza).
                                 FirstOrDefault(Function(a) a.aniCod = id.Value)

            If IsNothing(animal) Then Return HttpNotFound()
            Return View(animal)
        End Function

        ' GET: Animales/animals/Create
        Function Create() As ActionResult
            CargarCombos(Nothing)
            Return View()
        End Function

        ' POST: Animales/animals/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="aniCaravana,razaCod,aniSexo,aniFchNac,aniEstado,estCod,rv")> ByVal animal As animal) As ActionResult
            If ModelState.IsValid Then
                db.animals.Add(animal)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If

            CargarCombos(animal)
            Return View(animal)
        End Function

        ' GET: Animales/animals/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If Not id.HasValue Then Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)

            Dim animal = db.animals.Find(id.Value)
            If IsNothing(animal) Then Return HttpNotFound()

            CargarCombos(animal)
            Return View(animal)
        End Function

        ' POST: Animales/animals/Edit/5
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="aniCod,aniCaravana,razaCod,aniSexo,aniFchNac,aniEstado,estCod,rv")> ByVal animal As animal) As ActionResult
            If Not ModelState.IsValid Then
                CargarCombos(animal)
                Return View(animal)
            End If

            ' IMPORTANTE: no usar EntityState.Modified con auditoría por triggers/campos que no vienen
            Dim dbAnimal = db.animals.Find(animal.aniCod)
            If IsNothing(dbAnimal) Then Return HttpNotFound()

            ' Actualizamos SOLO los campos editables
            dbAnimal.aniCaravana = animal.aniCaravana
            dbAnimal.razaCod = animal.razaCod
            dbAnimal.aniSexo = animal.aniSexo
            dbAnimal.aniFchNac = animal.aniFchNac
            dbAnimal.aniEstado = animal.aniEstado
            dbAnimal.estCod = animal.estCod

            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        ' GET: Animales/animals/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If Not id.HasValue Then Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)

            Dim animal = db.animals.Find(id.Value)
            If IsNothing(animal) Then Return HttpNotFound()

            Return View(animal)
        End Function

        ' POST: Animales/animals/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim animal = db.animals.Find(id)
            If Not IsNothing(animal) Then
                db.animals.Remove(animal)
                db.SaveChanges()
            End If
            Return RedirectToAction("Index")
        End Function

        Private Sub CargarCombos(ByVal animal As animal)
            Dim estSel = If(IsNothing(animal), Nothing, CType(animal.estCod, Object))
            Dim razaSel = If(IsNothing(animal), Nothing, CType(animal.razaCod, Object))

            ViewBag.estCod = New SelectList(db.establecimientoes, "estCod", "estNombre", estSel)
            ViewBag.razaCod = New SelectList(db.razas, "razaCod", "razaDesc", razaSel)
        End Sub

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then db.Dispose()
            MyBase.Dispose(disposing)
        End Sub

    End Class
End Namespace
