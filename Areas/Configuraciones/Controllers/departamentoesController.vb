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
    Public Class departamentoesController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: departamentoes
        Function Index() As ActionResult
            Return View(db.departamentos.ToList())
        End Function

        ' GET: departamentoes/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim departamento As departamento = db.departamentos.Find(id)
            If IsNothing(departamento) Then
                Return HttpNotFound()
            End If
            Return View(departamento)
        End Function

        ' GET: departamentoes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: departamentoes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="depaCod,depaNombre")> ByVal departamento As departamento) As ActionResult
            If ModelState.IsValid Then
                db.departamentos.Add(departamento)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(departamento)
        End Function

        ' GET: departamentoes/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim departamento As departamento = db.departamentos.Find(id)
            If IsNothing(departamento) Then
                Return HttpNotFound()
            End If
            Return View(departamento)
        End Function

        ' POST: departamentoes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="depaCod,depaNombre")> ByVal departamento As departamento) As ActionResult
            If ModelState.IsValid Then
                db.Entry(departamento).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(departamento)
        End Function

        ' GET: departamentoes/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim departamento As departamento = db.departamentos.Find(id)
            If IsNothing(departamento) Then
                Return HttpNotFound()
            End If
            Return View(departamento)
        End Function

        ' POST: departamentoes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim departamento As departamento = db.departamentos.Find(id)
            db.departamentos.Remove(departamento)
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
