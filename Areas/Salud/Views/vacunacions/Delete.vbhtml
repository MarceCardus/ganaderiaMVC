@ModelType ganaderiaMVC.vacunacion
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>vacunacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.vacFch)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.vacFch)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.vacDosis)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.vacDosis)
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
            @Html.DisplayNameFor(Function(model) model.profesional.profNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.profesional.profNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.tipoVacuna.tvNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.tipoVacuna.tvNombre)
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
