@ModelType ganaderiaMVC.establecimiento
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>establecimiento</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.estNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.barrio.barriosNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.barrio.barriosNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.estCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
