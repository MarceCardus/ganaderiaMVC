@ModelType IEnumerable(Of ganaderiaMVC.gestacion)
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
            @Html.DisplayNameFor(Function(model) model.preFchMontura)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.preFchConfirma)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.preFchparto)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.preEstado)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rv)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.animal.aniCaravana)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.animal1.aniCaravana)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.establecimiento.estNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.preFchMontura)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.preFchConfirma)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.preFchparto)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.preEstado)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rv)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.animal.aniCaravana)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.animal1.aniCaravana)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.establecimiento.estNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.preCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.preCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.preCod })
        </td>
    </tr>
Next

</table>
