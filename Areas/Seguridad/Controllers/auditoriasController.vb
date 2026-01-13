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
    Public Class auditoriasController
        Inherits System.Web.Mvc.Controller

        Private db As New ganaderiaEntities

        ' GET: auditorias
        Function Index() As ActionResult
            Dim auditorias = db.auditorias.Include(Function(a) a.usuario)
            Return View(auditorias.ToList())
        End Function

        ' GET: auditorias/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim auditoria As auditoria = db.auditorias.Find(id)
            If IsNothing(auditoria) Then
                Return HttpNotFound()
            End If
            Return View(auditoria)
        End Function

        ' GET: auditorias/Create
        Function Create() As ActionResult
            ViewBag.usuCod = New SelectList(db.usuarios, "usuCod", "usuLogin")
            Return View()
        End Function

        ' POST: auditorias/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="audId,audTabla,audAccion,audRegistroId,audFecha,audUsuario,audLoginSql,audHost,audApp,audDetalleJson,usuCod")> ByVal auditoria As auditoria) As ActionResult
            If ModelState.IsValid Then
                db.auditorias.Add(auditoria)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.usuCod = New SelectList(db.usuarios, "usuCod", "usuLogin", auditoria.usuCod)
            Return View(auditoria)
        End Function

        ' GET: auditorias/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim auditoria As auditoria = db.auditorias.Find(id)
            If IsNothing(auditoria) Then
                Return HttpNotFound()
            End If
            ViewBag.usuCod = New SelectList(db.usuarios, "usuCod", "usuLogin", auditoria.usuCod)
            Return View(auditoria)
        End Function

        ' POST: auditorias/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="audId,audTabla,audAccion,audRegistroId,audFecha,audUsuario,audLoginSql,audHost,audApp,audDetalleJson,usuCod")> ByVal auditoria As auditoria) As ActionResult
            If ModelState.IsValid Then
                db.Entry(auditoria).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.usuCod = New SelectList(db.usuarios, "usuCod", "usuLogin", auditoria.usuCod)
            Return View(auditoria)
        End Function

        ' GET: auditorias/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim auditoria As auditoria = db.auditorias.Find(id)
            If IsNothing(auditoria) Then
                Return HttpNotFound()
            End If
            Return View(auditoria)
        End Function

        ' POST: auditorias/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim auditoria As auditoria = db.auditorias.Find(id)
            db.auditorias.Remove(auditoria)
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
