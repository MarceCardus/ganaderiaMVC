@ModelType ganaderiaMVC.usuario
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>usuario</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.usuLogin)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuLogin)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuPass)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuPass)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuDescripcion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuDescripcion)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuRol)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuRol)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuEmail)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuEmail)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuFchCrea)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuFchCrea)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuFchMod)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuFchMod)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.usuActivo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.usuActivo)
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
