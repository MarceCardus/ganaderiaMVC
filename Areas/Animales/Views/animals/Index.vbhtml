@ModelType IEnumerable(Of ganaderiaMVC.Animal)
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
            @Html.DisplayNameFor(Function(model) model.aniCaravana)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniSexo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniFchNac)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniEstado)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniFchIns)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniUsrIns)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniFchUpd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.aniUsrUpd)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.rv)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.establecimiento.estNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.raza.razaDesc)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniCaravana)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniSexo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniFchNac)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniEstado)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniFchIns)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniUsrIns)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniFchUpd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.aniUsrUpd)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.rv)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.establecimiento.estNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.raza.razaDesc)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.aniCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.aniCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.aniCod })
        </td>
    </tr>
Next

</table>
