Imports System.Web.Mvc

Public Class ConfiguracionAreaRegistration
    Inherits AreaRegistration

    Public Overrides ReadOnly Property AreaName() As String
        Get
            Return "Configuraciones"
        End Get
    End Property

    Public Overrides Sub RegisterArea(context As AreaRegistrationContext)
        context.MapRoute(
            "Configuraciones_default",
            "Configuraciones/{controller}/{action}/{id}",
            New With {.action = "Index", .id = UrlParameter.Optional},
            namespaces:=New String() {"ganaderiaMVC.Areas.Configuraciones.Controllers"}
        )
    End Sub

End Class
