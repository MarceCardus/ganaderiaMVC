@ModelType ganaderiaMVC.usuario
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>usuario</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.usuLogin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuLogin)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuPass)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuPass)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuDescripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuDescripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuRol)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuRol)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuFchCrea)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuFchCrea)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuFchMod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuFchMod)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuActivo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuActivo)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.usuCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
