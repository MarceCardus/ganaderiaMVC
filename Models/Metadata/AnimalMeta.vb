Imports System.ComponentModel.DataAnnotations

<MetadataType(GetType(AnimalMeta))>
Partial Public Class Animal
End Class

Public Class AnimalMeta

    <Display(Name:="Caravana")>
    Public Property aniCaravana As Integer

    <Display(Name:="Raza")>
    Public Property razaCod As Integer?

    <Display(Name:="Establecimiento")>
    Public Property estCod As Integer?

    <Display(Name:="Sexo")>
    Public Property aniSexo As String

    <Display(Name:="Fecha Nac.")>
    Public Property aniFchNac As Date?

    <Display(Name:="Estado")>
    Public Property aniEstado As String

End Class
