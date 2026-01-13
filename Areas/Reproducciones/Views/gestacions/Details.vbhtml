@ModelType ganaderiaMVC.gestacion
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>gestacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.preFchMontura)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preFchMontura)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.preFchConfirma)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preFchConfirma)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.preFchparto)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preFchparto)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.preEstado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preEstado)
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
            @Html.DisplayNameFor(Function(model) model.establecimiento.estNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.establecimiento.estNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.preCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
