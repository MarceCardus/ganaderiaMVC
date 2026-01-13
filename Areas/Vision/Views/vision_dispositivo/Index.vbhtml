@ModelType IEnumerable(Of ganaderiaMVC.vision_dispositivo)
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
            @Html.DisplayNameFor(Function(model) model.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tipo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.serie)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ubicacion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.activo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rowversion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tipo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.serie)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ubicacion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.activo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rowversion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.dispId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.dispId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.dispId })
        </td>
    </tr>
Next

</table>
