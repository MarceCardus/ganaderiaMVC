@ModelType IEnumerable(Of ganaderiaMVC.usuario)
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
            @Html.DisplayNameFor(Function(model) model.usuLogin)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuNombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuPass)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuDescripcion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuRol)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuEmail)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuFchCrea)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuFchMod)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuActivo)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuLogin)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuNombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuPass)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuDescripcion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuRol)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuEmail)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuFchCrea)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuFchMod)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuActivo)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.usuCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.usuCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.usuCod })
        </td>
    </tr>
Next

</table>
