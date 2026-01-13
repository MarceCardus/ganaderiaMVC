@ModelType IEnumerable(Of ganaderiaMVC.vision_modelo)
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
            @Html.DisplayNameFor(Function(model) model.version)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.enfoque)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.hash)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.fechaCarga)
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
            @Html.DisplayFor(Function(modelItem) item.version)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.enfoque)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.hash)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fechaCarga)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rowversion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.modId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.modId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.modId })
        </td>
    </tr>
Next

</table>
