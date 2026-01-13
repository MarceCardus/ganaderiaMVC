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
    Public Class tipoAlimentacionsController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: tipoAlimentacions
        Function Index() As ActionResult
            Return View(db.tipoAlimentacions.ToList())
        End Function

        ' GET: tipoAlimentacions/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipoAlimentacion As tipoAlimentacion = db.tipoAlimentacions.Find(id)
            If IsNothing(tipoAlimentacion) Then
                Return HttpNotFound()
            End If
            Return View(tipoAlimentacion)
        End Function

        ' GET: tipoAlimentacions/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: tipoAlimentacions/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="taCod,taNombre")> ByVal tipoAlimentacion As tipoAlimentacion) As ActionResult
            If ModelState.IsValid Then
                db.tipoAlimentacions.Add(tipoAlimentacion)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tipoAlimentacion)
        End Function

        ' GET: tipoAlimentacions/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipoAlimentacion As tipoAlimentacion = db.tipoAlimentacions.Find(id)
            If IsNothing(tipoAlimentacion) Then
                Return HttpNotFound()
            End If
            Return View(tipoAlimentacion)
        End Function

        ' POST: tipoAlimentacions/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="taCod,taNombre")> ByVal tipoAlimentacion As tipoAlimentacion) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tipoAlimentacion).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tipoAlimentacion)
        End Function

        ' GET: tipoAlimentacions/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tipoAlimentacion As tipoAlimentacion = db.tipoAlimentacions.Find(id)
            If IsNothing(tipoAlimentacion) Then
                Return HttpNotFound()
            End If
            Return View(tipoAlimentacion)
        End Function

        ' POST: tipoAlimentacions/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tipoAlimentacion As tipoAlimentacion = db.tipoAlimentacions.Find(id)
            db.tipoAlimentacions.Remove(tipoAlimentacion)
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
