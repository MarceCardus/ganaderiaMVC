@ModelType ganaderiaMVC.Animal

@Code
    ViewData("Title") = "Detalle de animal"
End Code

<div class="d-flex" style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
       <div>
        @Html.ActionLink("Editar", "Edit", New With {.id = Model.aniCod}, New With {.class = "btn btn-warning"})
        @Html.ActionLink("Volver", "Index", Nothing, New With {.class = "btn btn-default", .style = "margin-left:5px;"})
    </div>
</div>

<div class="row">
    <div class="col-md-7 col-lg-6">

        <h4 style="margin-top:0;">Datos</h4>
        <dl class="dl-horizontal">
            <dt>Caravana</dt>
            <dd>@Html.DisplayFor(Function(m) m.aniCaravana)</dd>

            <dt>Sexo</dt>
            <dd>@Html.DisplayFor(Function(m) m.aniSexo)</dd>

            <dt>Fecha Nac.</dt>
            <dd>
                @If Model.aniFchNac.HasValue Then
                    @Model.aniFchNac.Value.ToString("dd/MM/yyyy")
                End If
            </dd>

            <dt>Estado</dt>
            <dd>@Html.DisplayFor(Function(m) m.aniEstado)</dd>

            <dt>Establecimiento</dt>
            <dd>@Html.DisplayFor(Function(m) m.establecimiento.estNombre)</dd>

            <dt>Raza</dt>
            <dd>@Html.DisplayFor(Function(m) m.raza.razaDesc)</dd>
        </dl>

        <hr />

        <h4>Auditoría</h4>
        <dl class="dl-horizontal">
            <dt>Creado</dt>
            <dd>
                @Html.DisplayFor(Function(m) m.aniFchIns) -
                @Html.DisplayFor(Function(m) m.aniUsrIns)
            </dd>

            <dt>Actualizado</dt>
            <dd>
                @Html.DisplayFor(Function(m) m.aniFchUpd) -
                @Html.DisplayFor(Function(m) m.aniUsrUpd)
            </dd>
        </dl>

        @* Si querés mostrar rv (rowversion) solo para debug, descomentá *@
        @*
            <hr />
            <dl class="dl-horizontal">
                <dt>RV</dt>
                <dd>@Html.DisplayFor(Function(m) m.rv)</dd>
            </dl>
        *@

    </div>
</div>
