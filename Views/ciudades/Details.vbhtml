@ModelType ganaderiaMVC.ciudade
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ciudade</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.ciudNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ciudNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.departamento.depaNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.departamento.depaNombre)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ciudCod }) |
    @Html.ActionLink("Back to List", "Index")
</p>
