@ModelType IEnumerable(Of ganaderiaMVC.categoria)
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
            @Html.DisplayNameFor(Function(model) model.catDesc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.catDesc)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.catCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.catCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.catCod })
        </td>
    </tr>
Next

</table>
