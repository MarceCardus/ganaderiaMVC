Imports System.Web.Mvc

Public Class DashboardController
    Inherits Controller

    Private db As New ganaderiaEntities

    Function Index() As ActionResult
        Dim vm As New DashboardVM()

        vm.TotalAnimales = db.animals.Count()

        vm.Activos = db.animals.Count(Function(a) a.aniEstado = "A")
        vm.Vendidos = db.animals.Count(Function(a) a.aniEstado = "V")
        vm.Muertos = db.animals.Count(Function(a) a.aniEstado = "M")

        vm.PorSexo = db.animals.
            GroupBy(Function(a) a.aniSexo).
            Select(Function(g) New SerieItem With {.Label = g.Key, .Value = g.Count()}).
            ToList()

        vm.PorEstablecimiento = db.animals.
            GroupBy(Function(a) a.establecimiento.estNombre).
            Select(Function(g) New SerieItem With {.Label = g.Key, .Value = g.Count()}).
            OrderByDescending(Function(x) x.Value).
            Take(10).
            ToList()

        Return View(vm)
    End Function
End Class
