@ModelType ganaderiaMVC.tipoAlimentacion
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>tipoAlimentacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.taNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.taNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.taCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
