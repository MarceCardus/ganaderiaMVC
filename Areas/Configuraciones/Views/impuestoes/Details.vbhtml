@ModelType ganaderiaMVC.impuesto
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>impuesto</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.impDesc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.impDesc)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.impDivisor)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.impDivisor)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.impCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
