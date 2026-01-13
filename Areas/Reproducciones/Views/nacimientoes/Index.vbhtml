@ModelType IEnumerable(Of ganaderiaMVC.nacimiento)
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
            @Html.DisplayNameFor(Function(model) model.nacFch)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nacSexo)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.nacEstado)
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
            @Html.DisplayNameFor(Function(model) model.tipoServicio.tsNombre)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nacFch)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nacSexo)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nacEstado)
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
            @Html.DisplayFor(Function(modelItem) item.tipoServicio.tsNombre)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.nacCod }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.nacCod }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.nacCod })
        </td>
    </tr>
Next

</table>
