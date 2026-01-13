@ModelType ganaderiaMVC.auditoria
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>auditoria</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.audTabla)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audTabla)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audAccion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audAccion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audRegistroId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audRegistroId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audFecha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audFecha)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audUsuario)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audUsuario)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audLoginSql)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audLoginSql)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audHost)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audHost)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audApp)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audApp)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.audDetalleJson)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.audDetalleJson)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuario.usuLogin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuario.usuLogin)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.audId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
