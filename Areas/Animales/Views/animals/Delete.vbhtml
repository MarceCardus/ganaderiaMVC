@ModelType ganaderiaMVC.Animal
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>animal</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.aniCaravana)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniCaravana)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniSexo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniSexo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniFchNac)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniFchNac)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniEstado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniEstado)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniFchIns)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniFchIns)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniUsrIns)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniUsrIns)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniFchUpd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniFchUpd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.aniUsrUpd)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.aniUsrUpd)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.rv)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.rv)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.establecimiento.estNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.establecimiento.estNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.raza.razaDesc)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.raza.razaDesc)
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
