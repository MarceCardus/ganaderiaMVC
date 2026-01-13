@ModelType ganaderiaMVC.categoria
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>categoria</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.catDesc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.catDesc)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.catCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
