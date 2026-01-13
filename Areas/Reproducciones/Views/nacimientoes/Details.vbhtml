@ModelType ganaderiaMVC.nacimiento
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>nacimiento</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nacFch)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nacFch)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nacSexo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nacSexo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.nacEstado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nacEstado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rv)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rv)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.animal.aniCaravana)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.animal.aniCaravana)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.animal1.aniCaravana)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.animal1.aniCaravana)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipoServicio.tsNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipoServicio.tsNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.nacCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
