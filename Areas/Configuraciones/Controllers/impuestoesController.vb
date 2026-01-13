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
    Public Class impuestoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: impuestoes
        Function Index() As ActionResult
            Return View(db.impuestoes.ToList())
        End Function

        ' GET: impuestoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim impuesto As impuesto = db.impuestoes.Find(id)
            If IsNothing(impuesto) Then
                Return HttpNotFound()
            End If
            Return View(impuesto)
        End Function

        ' GET: impuestoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: impuestoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="impCod,impDesc,impDivisor")> ByVal impuesto As impuesto) As ActionResult
            If ModelState.IsValid Then
                db.impuestoes.Add(impuesto)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(impuesto)
        End Function

        ' GET: impuestoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim impuesto As impuesto = db.impuestoes.Find(id)
            If IsNothing(impuesto) Then
                Return HttpNotFound()
            End If
            Return View(impuesto)
        End Function

        ' POST: impuestoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="impCod,impDesc,impDivisor")> ByVal impuesto As impuesto) As ActionResult
            If ModelState.IsValid Then
                db.Entry(impuesto).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(impuesto)
        End Function

        ' GET: impuestoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim impuesto As impuesto = db.impuestoes.Find(id)
            If IsNothing(impuesto) Then
                Return HttpNotFound()
            End If
            Return View(impuesto)
        End Function

        ' POST: impuestoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim impuesto As impuesto = db.impuestoes.Find(id)
            db.impuestoes.Remove(impuesto)
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
