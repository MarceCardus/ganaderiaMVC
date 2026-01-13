@ModelType IEnumerable(Of ganaderiaMVC.vision_pesaje)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.fecha)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.pesoKg)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.confianza)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.metodo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.imgPath)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.medidasJson)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.notas)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.animal.aniCaravana)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.vision_dispositivo.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.vision_modelo.nombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fecha)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.pesoKg)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.confianza)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.metodo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.imgPath)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.medidasJson)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.notas)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.animal.aniCaravana)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.vision_dispositivo.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.vision_modelo.nombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.pesId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.pesId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.pesId })
        </td>
    </tr>
Next

</table>
