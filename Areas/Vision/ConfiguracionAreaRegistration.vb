Imports System.Web.Mvc

Public Class VisionAreaRegistration
    Inherits AreaRegistration

    Public Overrides ReadOnly Property AreaName() As String
        Get
            Return "Vision"
        End Get
    End Property

    Public Overrides Sub RegisterArea(context As AreaRegistrationContext)
        context.MapRoute(
            "Vision_default",
            "Vision/{controller}/{action}/{id}",
            New With {.action = "Index", .id = UrlParameter.Optional},
            namespaces:=New String() {"ganaderiaMVC.Areas.Vision.Controllers"}
        )
    End Sub

End Class
