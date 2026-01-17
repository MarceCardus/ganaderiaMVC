@ModelType IEnumerable(Of ganaderiaMVC.raza)

@Code
    ViewData("Title") = "Razas"
End Code

<div class="row">
    <div class="col-md-10 col-lg-9">

        <div style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
            <h2 style="margin:0;">@ViewData("Title")</h2>
            @Html.ActionLink("Nuevo", "Create", Nothing, New With {.class = "btn btn-primary"})
        </div>

        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th>Descripción</th>
                    <th style="width:220px;"></th>
                </tr>
            </thead>
            <tbody>
                @For Each item In Model
                    @<tr>
                        <td>@Html.DisplayFor(Function(m) item.razaDesc)</td>
                        <td class="text-right">
                            @Html.ActionLink("Editar", "Edit", New With {.id = item.razaCod}, New With {.class = "btn btn-sm btn-warning"})
                            @Html.ActionLink("Ver", "Details", New With {.id = item.razaCod}, New With {.class = "btn btn-sm btn-info"})
                            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.razaCod}, New With {.class = "btn btn-sm btn-danger"})
                        </td>
                    </tr>
                Next
            </tbody>
        </table>

    </div>
</div>
