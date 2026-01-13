@ModelType ganaderiaMVC.tipoServicio
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>tipoServicio</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.tsNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tsNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.tsCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
