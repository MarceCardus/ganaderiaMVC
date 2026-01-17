Imports System.Web.Optimization
Imports System.Globalization

Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()
        Dim ci As New CultureInfo("es-PY")
        CultureInfo.DefaultThreadCurrentCulture = ci
        CultureInfo.DefaultThreadCurrentUICulture = ci

        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub

End Class
