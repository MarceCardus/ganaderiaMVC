@ModelType ganaderiaMVC.auditoria
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
