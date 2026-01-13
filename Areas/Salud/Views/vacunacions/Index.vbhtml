@ModelType IEnumerable(Of ganaderiaMVC.vacunacion)
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
            @Html.DisplayNameFor(Function(model) model.vacFch)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.vacDosis)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rv)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.animal.aniCaravana)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.profesional.profNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tipoVacuna.tvNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.vacFch)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.vacDosis)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rv)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.animal.aniCaravana)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.profesional.profNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.tipoVacuna.tvNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.vacCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.vacCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.vacCod })
        </td>
    </tr>
Next

</table>
