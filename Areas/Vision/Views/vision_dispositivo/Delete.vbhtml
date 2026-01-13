@ModelType ganaderiaMVC.vision_dispositivo
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>vision_dispositivo</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.serie)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.serie)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ubicacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ubicacion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.activo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.activo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rowversion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rowversion)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
