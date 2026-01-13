@ModelType ganaderiaMVC.gestacion
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>gestacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.preFchMontura)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preFchMontura)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.preFchConfirma)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preFchConfirma)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.preFchparto)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preFchparto)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.preEstado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.preEstado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rv)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rv)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.animal.aniCaravana)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.animal.aniCaravana)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.animal1.aniCaravana)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.animal1.aniCaravana)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.establecimiento.estNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.establecimiento.estNombre)
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
