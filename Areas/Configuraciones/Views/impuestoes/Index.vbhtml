@ModelType IEnumerable(Of ganaderiaMVC.impuesto)
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
            @Html.DisplayNameFor(Function(model) model.impDesc)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.impDivisor)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.impDesc)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.impDivisor)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.impCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.impCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.impCod })
        </td>
    </tr>
Next

</table>
