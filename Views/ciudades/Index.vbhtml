@ModelType IEnumerable(Of ganaderiaMVC.ciudade)
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
            @Html.DisplayNameFor(Function(model) model.ciudNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.departamento.depaNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ciudNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.departamento.depaNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ciudCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ciudCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ciudCod })
        </td>
    </tr>
Next

</table>
