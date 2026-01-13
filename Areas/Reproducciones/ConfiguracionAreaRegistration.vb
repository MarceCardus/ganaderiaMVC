Imports System.Web.Mvc

Public Class ReproduccionAreaRegistration
    Inherits AreaRegistration

    Public Overrides ReadOnly Property AreaName() As String
        Get
            Return "Reproducciones"
        End Get
    End Property

    Public Overrides Sub RegisterArea(context As AreaRegistrationContext)
        context.MapRoute(
            "Reproducciones_default",
            "Reproducciones/{controller}/{action}/{id}",
            New With {.action = "Index", .id = UrlParameter.Optional},
            namespaces:=New String() {"ganaderiaMVC.Areas.Reproducciones.Controllers"}
        )
    End Sub

End Class
