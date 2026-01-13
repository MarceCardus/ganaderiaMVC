Imports System.Web.Mvc

Namespace ganaderiaMVC.Areas.Animales
    Public Class AnimalesAreaRegistration
        Inherits AreaRegistration

        Public Overrides ReadOnly Property AreaName() As String
            Get
                Return "Animales"
            End Get
        End Property

        Public Overrides Sub RegisterArea(context As AreaRegistrationContext)
            context.MapRoute(
                "Animales_default",
                "Animales/{controller}/{action}/{id}",
                New With {.action = "Index", .id = UrlParameter.Optional},
                namespaces:=New String() {"ganaderiaMVC.Areas.Animales.Controllers"}
            )
        End Sub

    End Class
End Namespace
