@ModelType IEnumerable(Of ganaderiaMVC.departamento)
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
            @Html.DisplayNameFor(Function(model) model.depaNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.depaNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.depaCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.depaCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.depaCod })
        </td>
    </tr>
Next

</table>
