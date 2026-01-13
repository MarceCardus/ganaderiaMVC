@ModelType IEnumerable(Of ganaderiaMVC.auditoria)
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
            @Html.DisplayNameFor(Function(model) model.audTabla)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audAccion)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audRegistroId)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audFecha)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audUsuario)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audLoginSql)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audHost)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audApp)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.audDetalleJson)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.usuario.usuLogin)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audTabla)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audAccion)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audRegistroId)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audFecha)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audUsuario)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audLoginSql)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audHost)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audApp)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.audDetalleJson)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.usuario.usuLogin)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.audId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.audId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.audId })
        </td>
    </tr>
Next

</table>
