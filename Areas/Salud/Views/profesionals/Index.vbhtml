@ModelType IEnumerable(Of ganaderiaMVC.profesional)
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
            @Html.DisplayNameFor(Function(model) model.profNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.profNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.profCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.profCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.profCod })
        </td>
    </tr>
Next

</table>
