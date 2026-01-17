@ModelType IEnumerable(Of ganaderiaMVC.Animal)

@Code
    ViewData("Title") = "Animales"
End Code

<div class="row">
    <div class="col-md-10 col-lg-9">

        <div class="d-flex" style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
            @Html.ActionLink("Nuevo", "Create", Nothing, New With {.class = "btn btn-primary"})
        </div>

        <table class="table table-striped table-hover">
            <thead>
                <tr>
                    <th>Caravana</th>
                    <th>Sexo</th>
                    <th>F. Nac.</th>
                    <th>Estado</th>
                    <th>Establecimiento</th>
                    <th>Raza</th>
                    <th style="width:220px;"></th>
                </tr>
            </thead>

            <tbody>
                @For Each item In Model
                    @<tr>
                        <td>@Html.DisplayFor(Function(m) item.aniCaravana)</td>
                        <td>@Html.DisplayFor(Function(m) item.aniSexo)</td>
                        <td>
                            @If item.aniFchNac.HasValue Then
                                @item.aniFchNac.Value.ToString("dd/MM/yyyy")
                            End If
                        </td>
                        <td>@Html.DisplayFor(Function(m) item.aniEstado)</td>
                        <td>@Html.DisplayFor(Function(m) item.establecimiento.estNombre)</td>
                        <td>@Html.DisplayFor(Function(m) item.raza.razaDesc)</td>

                        <td class="text-right">
                            @Html.ActionLink("Editar", "Edit", New With {.id = item.aniCod}, New With {.class = "btn btn-sm btn-warning"})
                            @Html.ActionLink("Ver", "Details", New With {.id = item.aniCod}, New With {.class = "btn btn-sm btn-info"})
                            @Html.ActionLink("Eliminar", "Delete", New With {.id = item.aniCod}, New With {.class = "btn btn-sm btn-danger"})
                        </td>
                    </tr>
                Next
            </tbody>
        </table>

    </div>
</div>
