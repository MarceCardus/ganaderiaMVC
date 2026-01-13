Public Class DashboardVM
    Public Property TotalAnimales As Integer
    Public Property Activos As Integer
    Public Property Vendidos As Integer
    Public Property Muertos As Integer

    Public Property PorSexo As List(Of SerieItem)
    Public Property PorEstablecimiento As List(Of SerieItem)
End Class

Public Class SerieItem
    Public Property Label As String
    Public Property Value As Integer
End Class
