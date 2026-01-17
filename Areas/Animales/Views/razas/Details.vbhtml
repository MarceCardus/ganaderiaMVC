@ModelType ganaderiaMVC.raza

@Code
    ViewData("Title") = "Detalle de raza"
End Code

<div style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
    <h2 style="margin:0;">@ViewData("Title")</h2>
    <div>
        @Html.ActionLink("Editar", "Edit", New With {.id = Model.razaCod}, New With {.class = "btn btn-warning"})
        @Html.ActionLink("Volver", "Index", Nothing, New With {.class = "btn btn-default", .style = "margin-left:5px;"})
    </div>
</div>

<div class="row">
    <div class="col-md-7 col-lg-6">
        <dl class="dl-horizontal">
            <dt>Descripción</dt>
            <dd>@Html.DisplayFor(Function(m) m.razaDesc)</dd>
        </dl>
    </div>
</div>
