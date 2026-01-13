@ModelType ganaderiaMVC.vision_modelo
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>vision_modelo</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.version)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.version)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.enfoque)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.enfoque)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.hash)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hash)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.fechaCarga)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fechaCarga)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rowversion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rowversion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.modId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
