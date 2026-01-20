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
            Dim a As New animal()
            a.aniEstado = "A" ' default Activo
            CargarCombos(a, permitirEstado:=False)
            Return View(a)
        End Function

        ' POST: Animales/animals/Create
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="aniCaravana,razaCod,aniSexo,aniFchNac,estCod")> ByVal animal As animal) As ActionResult

            ' Forzar reglas del negocio
            animal.aniEstado = "A"

            ' Validación simple para sexo (por si te mandan cualquier cosa)
            If String.IsNullOrWhiteSpace(animal.aniSexo) OrElse Not {"M", "H"}.Contains(animal.aniSexo) Then
                ModelState.AddModelError("aniSexo", "Seleccione Macho (M) o Hembra (H).")
            End If

            If ModelState.IsValid Then
                Dim usuCodObj As Object = If(Session("usuCod"), DBNull.Value)

                db.Database.Connection.Open()
                Dim tx = db.Database.Connection.BeginTransaction()
                db.Database.UseTransaction(tx)

                Try
                    db.Database.ExecuteSqlCommand(
                "EXEC sys.sp_set_session_context @key=N'usuCod', @value=@p0; SET NOCOUNT OFF;",
                usuCodObj
            )

                    Dim newId As Integer = db.Database.SqlQuery(Of Integer)(
                "SELECT NEXT VALUE FOR dbo.SeqAnimales;"
            ).Single()

                    animal.aniCod = newId

                    db.animals.Add(animal)
                    db.SaveChanges()

                    tx.Commit()
                Catch
                    tx.Rollback()
                    Throw
                Finally
                    db.Database.Connection.Close()
                End Try

                Return RedirectToAction("Index")
            End If

            CargarCombos(animal, permitirEstado:=False)
            Return View(animal)
        End Function


        ' GET: Animales/animals/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If Not id.HasValue Then Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)

            Dim a = db.animals.Find(id.Value)
            If IsNothing(a) Then Return HttpNotFound()

            If a.aniSexo IsNot Nothing Then a.aniSexo = a.aniSexo.Trim()
            If a.aniEstado IsNot Nothing Then a.aniEstado = a.aniEstado.Trim()

            ModelState.Clear() ' en GET, por las dudas

            CargarCombos(a, permitirEstado:=True)
            Return View(a)
        End Function

        ' POST: Animales/animals/Edit/5
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="aniCod,aniCaravana,razaCod,aniSexo,aniFchNac,aniEstado,estCod")> ByVal animal As animal) As ActionResult
            If Not ModelState.IsValid Then
                CargarCombos(animal, permitirEstado:=True)
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



        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then db.Dispose()
            MyBase.Dispose(disposing)
        End Sub


        Private Sub CargarCombos(ByVal a As animal, Optional ByVal permitirEstado As Boolean = False)

            Dim estSel As String = If(a Is Nothing OrElse a.estCod Is Nothing, Nothing, a.estCod.ToString().Trim())
            Dim razaSel As String = If(a Is Nothing OrElse a.razaCod Is Nothing, Nothing, a.razaCod.ToString().Trim())
            Dim sexoSel As String = If(a Is Nothing OrElse a.aniSexo Is Nothing, Nothing, a.aniSexo.Trim())
            Dim estadoSel As String = If(a Is Nothing OrElse a.aniEstado Is Nothing, Nothing, a.aniEstado.Trim())

            ' Establecimientos (Value como string trim)
            Dim estItems = db.establecimientoes.AsEnumerable().
                Select(Function(e) New With {.Value = e.estCod.ToString().Trim(), .Text = e.estNombre}).ToList()
            ViewBag.estCod = New SelectList(estItems, "Value", "Text", estSel)

            ' Razas (Value como string trim)
            Dim razaItems = db.razas.AsEnumerable().
                Select(Function(r) New With {.Value = r.razaCod.ToString().Trim(), .Text = r.razaDesc}).ToList()
            ViewBag.razaCod = New SelectList(razaItems, "Value", "Text", razaSel)

            ' Sexo
            Dim sexoItems = New List(Of Object) From {
                New With {.Value = "M", .Text = "Macho"},
                New With {.Value = "H", .Text = "Hembra"}
            }
            ViewBag.aniSexo = New SelectList(sexoItems, "Value", "Text", sexoSel)

            ' Estado (solo Edit)
            If permitirEstado Then
                Dim estadoItems = New List(Of Object) From {
                    New With {.Value = "A", .Text = "Activo"},
                    New With {.Value = "V", .Text = "Vendido"},
                    New With {.Value = "M", .Text = "Muerto"}
                }
                ViewBag.aniEstado = New SelectList(estadoItems, "Value", "Text", estadoSel)
            End If

        End Sub

    End Class
End Namespace
