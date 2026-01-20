@ModelType IEnumerable(Of ganaderiaMVC.vision_pesaje)
@Code
    ViewData("Title") = "Pesajes (Visión)"
End Code


<p>
    @Html.ActionLink("Nuevo Pesaje", "Create", New With {.area = "Vision"}, New With {.class = "btn btn-primary"})
</p>

<table class="table table-striped table-hover">
    <thead>
        <tr>
            <th>Fecha</th>
            <th>Animal</th>
            <th>Peso (Kg)</th>
            <th>Método</th>
            <th>Confianza</th>
            <th>Dispositivo</th>
            <th>Modelo</th>
            <th>Imagen</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<text>
                <tr>
                    <td>@item.fecha.ToString("dd/MM/yyyy HH:mm")</td>
                    <td>@(If(item.animal IsNot Nothing, item.animal.aniCaravana, item.aniCod.ToString()))</td>
                    <td>@String.Format("{0:N2}", item.pesoKg)</td>
                    <td>@item.metodo</td>
                    <td>
                        @If item.confianza.HasValue Then
                            @String.Format("{0:N2}%", item.confianza.Value)
                        End If
                    </td>
                    <td>@(If(item.vision_dispositivo IsNot Nothing, item.vision_dispositivo.nombre, ""))</td>
                    <td>@(If(item.vision_modelo IsNot Nothing, item.vision_modelo.nombre, ""))</td>
                    <td>
                        @If Not String.IsNullOrWhiteSpace(item.imgPath) Then
                            @<text><a href="@Url.Content(item.imgPath)" target="_blank">Ver</a></text>
                        End If
                    </td>
                    <td>
                        @Html.ActionLink("Detalles", "Details", New With {.id = item.pesId, .area = "Vision"}) |
                        @Html.ActionLink("Editar", "Edit", New With {.id = item.pesId, .area = "Vision"}) |
                        @Html.ActionLink("Eliminar", "Delete", New With {.id = item.pesId, .area = "Vision"})
                    </td>
                </tr>
            </text>
        Next
    </tbody>
</table>
