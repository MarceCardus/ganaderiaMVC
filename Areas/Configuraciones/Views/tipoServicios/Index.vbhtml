@ModelType IEnumerable(Of ganaderiaMVC.tipoServicio)
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
            @Html.DisplayNameFor(Function(model) model.tsNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tsNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.tsCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.tsCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.tsCod })
        </td>
    </tr>
Next

</table>
