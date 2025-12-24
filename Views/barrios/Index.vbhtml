@ModelType IEnumerable(Of ganaderiaMVC.barrio)
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
            @Html.DisplayNameFor(Function(model) model.barriosNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.ciudade.ciudNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.barriosNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.ciudade.ciudNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.barriosCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.barriosCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.barriosCod })
        </td>
    </tr>
Next

</table>
