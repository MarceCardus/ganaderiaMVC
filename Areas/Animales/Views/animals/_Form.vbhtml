@ModelType ganaderiaMVC.Animal

<div class="box-body">

    @Html.ValidationSummary(True, "", New With {.class = "text-danger"})

    <div class="form-horizontal">

        <div class="form-group">
            @Html.LabelFor(Function(m) m.aniCaravana, htmlAttributes:=New With {.class = "control-label col-sm-2"})
            <div class="col-sm-10">
                @Html.TextBoxFor(Function(m) m.aniCaravana, New With {.class = "form-control", .placeholder = "Caravana"})
                @Html.ValidationMessageFor(Function(m) m.aniCaravana, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(m) m.razaCod, htmlAttributes:=New With {.class = "control-label col-sm-2"})
            <div class="col-sm-10">
                @Html.DropDownListFor(Function(m) m.razaCod, CType(ViewBag.razaCod, SelectList), "-- Seleccione --", New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(m) m.razaCod, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(m) m.estCod, htmlAttributes:=New With {.class = "control-label col-sm-2"})
            <div class="col-sm-10">
                @Html.DropDownListFor(Function(m) m.estCod, CType(ViewBag.estCod, SelectList), "-- Seleccione --", New With {.class = "form-control"})
                @Html.ValidationMessageFor(Function(m) m.estCod, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(m) m.aniSexo, htmlAttributes:=New With {.class = "control-label col-sm-2"})
            <div class="col-sm-10">
                @Html.TextBoxFor(Function(m) m.aniSexo, New With {.class = "form-control", .placeholder = "M / H"})
                @Html.ValidationMessageFor(Function(m) m.aniSexo, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(m) m.aniFchNac, htmlAttributes:=New With {.class = "control-label col-sm-2"})
            <div class="col-sm-10">
                @Html.TextBoxFor(Function(m) m.aniFchNac, New With {.class = "form-control", .type = "date"})
                @Html.ValidationMessageFor(Function(m) m.aniFchNac, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(m) m.aniEstado, htmlAttributes:=New With {.class = "control-label col-sm-2"})
            <div class="col-sm-10">
                @Html.TextBoxFor(Function(m) m.aniEstado, New With {.class = "form-control", .placeholder = "A/V/M..."})
                @Html.ValidationMessageFor(Function(m) m.aniEstado, "", New With {.class = "text-danger"})
            </div>
        </div>

        @* 🚫 Auditoría: NO VA EN CREATE/EDIT *@
        @* aniFchIns, aniUsrIns, aniFchUpd, aniUsrUpd *@

    </div>
</div>
