@ModelType IEnumerable(Of ganaderiaMVC.tipoAlimentacion)
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
            @Html.DisplayNameFor(Function(model) model.taNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.taNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.taCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.taCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.taCod })
        </td>
    </tr>
Next

</table>
