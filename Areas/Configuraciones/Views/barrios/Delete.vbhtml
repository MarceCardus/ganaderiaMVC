@ModelType ganaderiaMVC.barrio
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>barrio</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.barriosNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.barriosNombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ciudade.ciudNombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ciudade.ciudNombre)
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
