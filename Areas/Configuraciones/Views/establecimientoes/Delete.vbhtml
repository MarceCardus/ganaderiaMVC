@ModelType ganaderiaMVC.establecimiento
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>establecimiento</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.estNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.barrio.barriosNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.barrio.barriosNombre)
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
