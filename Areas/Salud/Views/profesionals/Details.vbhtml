@ModelType ganaderiaMVC.profesional
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>profesional</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.profNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.profNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.profCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
