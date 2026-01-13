@ModelType IEnumerable(Of ganaderiaMVC.departamento)

@Code
    ViewData("Title") = "Departamentos"
End Code

<div class="d-flex" style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
    <h2 style="margin:0;">Departamentos</h2>
    @Html.ActionLink("Nuevo", "Create", Nothing, New With {.class = "btn btn-primary"})
</div>

<table class="table table-striped table-hover">
    <thead>
        <tr>
            <th>Nombre</th>
            <th style="width:220px;"></th>
        </tr>
    </thead>
    <tbody>
        @For Each item In Model
            @<tr>
                <td>@Html.DisplayFor(Function(m) item.depaNombre)</td>
                <td class="text-right">
                    @Html.ActionLink("Editar", "Edit", New With {.id = item.depaCod}, New With {.class = "btn btn-sm btn-warning"})
                    @Html.ActionLink("Ver", "Details", New With {.id = item.depaCod}, New With {.class = "btn btn-sm btn-info"})
                    @Html.ActionLink("Eliminar", "Delete", New With {.id = item.depaCod}, New With {.class = "btn btn-sm btn-danger"})
                </td>
            </tr>
        Next
    </tbody>
</table>