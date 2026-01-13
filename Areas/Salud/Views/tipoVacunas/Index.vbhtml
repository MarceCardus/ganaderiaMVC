@ModelType IEnumerable(Of ganaderiaMVC.tipoVacuna)
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
            @Html.DisplayNameFor(Function(model) model.tvNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tvNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.tvCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.tvCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.tvCod })
        </td>
    </tr>
Next

</table>
