@ModelType ganaderiaMVC.vision_pesaje
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>vision_pesaje</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.fecha)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fecha)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.pesoKg)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.pesoKg)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.confianza)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.confianza)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.metodo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.metodo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.imgPath)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.imgPath)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.medidasJson)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.medidasJson)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.notas)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.notas)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.animal.aniCaravana)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.animal.aniCaravana)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.vision_dispositivo.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.vision_dispositivo.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.vision_modelo.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.vision_modelo.nombre)
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
