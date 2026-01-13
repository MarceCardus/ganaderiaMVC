@ModelType IEnumerable(Of ganaderiaMVC.establecimiento)
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
            @Html.DisplayNameFor(Function(model) model.estNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.barrio.barriosNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.estNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.barrio.barriosNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.estCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.estCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.estCod })
        </td>
    </tr>
Next

</table>
