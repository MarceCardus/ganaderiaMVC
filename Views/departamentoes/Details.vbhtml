@ModelType ganaderiaMVC.departamento
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>departamento</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.depaNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.depaNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.depaCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
