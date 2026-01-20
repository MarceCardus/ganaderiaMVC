@ModelType ganaderiaMVC.vision_pesaje
@Code
    ViewData("Title") = "Crear Pesaje"
End Code



@Using Html.BeginForm(Nothing, Nothing, FormMethod.Post, New With {.enctype = "multipart/form-data"})
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

        @Html.Partial("_Form", Model)

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Guardar" class="btn btn-primary" />
                @Html.ActionLink("Volver", "Index", New With {.area = "Vision"}, New With {.class = "btn btn-default"})
            </div>
        </div>
    </div>
End Using
