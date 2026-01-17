@ModelType ganaderiaMVC.raza

@Code
    ViewData("Title") = "Editar raza"
End Code

<div style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
    <h2 style="margin:0;">@ViewData("Title")</h2>
    @Html.ActionLink("Volver", "Index", Nothing, New With {.class = "btn btn-default"})
</div>

<div class="row">
    <div class="col-md-7 col-lg-6">

        @Using Html.BeginForm()
            @Html.AntiForgeryToken()
            @Html.HiddenFor(Function(m) m.razaCod)

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            @<div class="form-horizontal">

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.razaDesc, "Descripción", htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.TextBoxFor(Function(m) m.razaDesc, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.razaDesc, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-3 col-md-9">
                        <button type="submit" class="btn btn-warning">Guardar cambios</button>
                        @Html.ActionLink("Cancelar", "Index", Nothing, New With {.class = "btn btn-default", .style = "margin-left:5px;"})
                    </div>
                </div>

            </div>
        End Using

    </div>
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
