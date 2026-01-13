@ModelType ganaderiaMVC.vacunacion
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>vacunacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.vacFch)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.vacFch)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.vacDosis)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.vacDosis)
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
            @Html.DisplayNameFor(Function(model) model.profesional.profNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.profesional.profNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipoVacuna.tvNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipoVacuna.tvNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.vacCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
