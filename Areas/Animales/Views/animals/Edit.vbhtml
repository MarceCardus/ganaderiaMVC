@ModelType ganaderiaMVC.Animal

@Code
    ViewData("Title") = "Editar animal"
End Code

<div class="d-flex" style="display:flex; justify-content:space-between; align-items:center; margin-bottom:15px;">
    @Html.ActionLink("Volver", "Index", Nothing, New With {.class = "btn btn-default"})
</div>

<div class="row">
    <div class="col-md-7 col-lg-6">
        @Using Html.BeginForm()
            @Html.AntiForgeryToken()

            @Html.HiddenFor(Function(m) m.aniCod)
            @Html.HiddenFor(Function(m) m.rv) @* si rv no existe, borrá esta línea *@

            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

            @<div class="form-horizontal">

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.aniCaravana, htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.TextBoxFor(Function(m) m.aniCaravana, New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.aniCaravana, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.razaCod, "Raza", htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.DropDownListFor(Function(m) m.razaCod, Nothing, "-- Seleccione --", New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.razaCod, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.estCod, "Establecimiento", htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.DropDownListFor(Function(m) m.estCod, Nothing, "-- Seleccione --", New With {.class = "form-control"})
                        @Html.ValidationMessageFor(Function(m) m.estCod, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.aniSexo, htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.DropDownListFor(Function(m) m.aniSexo, Nothing, "-- Seleccione --", New With {.class = "form-control"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.aniFchNac, "Fecha Nac.", htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.TextBoxFor(Function(m) m.aniFchNac, "{0:yyyy-MM-dd}",
                        New With {.class = "form-control", .type = "date"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(m) m.aniEstado, htmlAttributes:=New With {.class = "control-label col-md-3"})
                    <div class="col-md-9">
                        @Html.DropDownListFor(Function(m) m.aniEstado, Nothing, "-- Seleccione --", New With {.class = "form-control"})
                    </div>
                </div>

                @* Auditoría NO va en Edit *@
                @* aniFchIns, aniUsrIns, aniFchUpd, aniUsrUpd *@

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
