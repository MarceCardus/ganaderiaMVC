@ModelType ganaderiaMVC.vision_pesaje

<div class="form-group">
    @Html.LabelFor(Function(m) m.aniCod, "Animal", New With {.class = "control-label col-md-2"})
    <div class="col-md-6">
        @Html.DropDownList("aniCod", Nothing, "-- Seleccionar --", New With {.class = "form-control"})
        @Html.ValidationMessageFor(Function(m) m.aniCod, "", New With {.class = "text-danger"})
    </div>
</div>

<div class="form-group">
    @Html.LabelFor(Function(m) m.fecha, "Fecha/Hora", New With {.class = "control-label col-md-2"})
    <div class="col-md-3">
        @Html.TextBoxFor(Function(m) m.fecha, "{0:yyyy-MM-ddTHH:mm}", New With {.class = "form-control", .type = "datetime-local"})
        @Html.ValidationMessageFor(Function(m) m.fecha, "", New With {.class = "text-danger"})
    </div>
</div>

<div class="form-group">
    @Html.LabelFor(Function(m) m.pesoKg, "Peso (Kg)", New With {.class = "control-label col-md-2"})
    <div class="col-md-3">
        @Html.TextBoxFor(Function(m) m.pesoKg, New With {.class = "form-control", .type = "number", .step = "0.01", .min = "0"})
        @Html.ValidationMessageFor(Function(m) m.pesoKg, "", New With {.class = "text-danger"})
    </div>
</div>

<div class="form-group">
    @Html.LabelFor(Function(m) m.metodo, "Método", New With {.class = "control-label col-md-2"})
    <div class="col-md-3">
        @Html.DropDownListFor(Function(m) m.metodo,
            New SelectList(New String() {"BALANZA", "MANUAL", "ESTIMADO", "VISION"}, Model.metodo),
            "-- Método --",
            New With {.class = "form-control", .id = "metodo"})
        @Html.ValidationMessageFor(Function(m) m.metodo, "", New With {.class = "text-danger"})
    </div>
</div>

<hr />

<div id="bloqueVision">
    <h4>Datos de Visión</h4>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.confianza, "Confianza (%)", New With {.class = "control-label col-md-2"})
        <div class="col-md-3">
            @Html.TextBoxFor(Function(m) m.confianza, New With {.class = "form-control", .type = "number", .step = "0.01", .min = "0", .max = "100"})
            @Html.ValidationMessageFor(Function(m) m.confianza, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.dispId, "Dispositivo", New With {.class = "control-label col-md-2"})
        <div class="col-md-6">
            @Html.DropDownList("dispId", Nothing, "-- (Opcional) --", New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(m) m.dispId, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.modId, "Modelo", New With {.class = "control-label col-md-2"})
        <div class="col-md-6">
            @Html.DropDownList("modId", Nothing, "-- (Opcional) --", New With {.class = "form-control"})
            @Html.ValidationMessageFor(Function(m) m.modId, "", New With {.class = "text-danger"})
        </div>
    </div>

    <div class="form-group">
        @Html.Label("Imagen", New With {.class = "control-label col-md-2"})
        <div class="col-md-6">
            <input type="file" name="Imagen" id="Imagen" class="form-control" accept="image/*" />
            <small class="text-muted">Si cargás una imagen nueva, reemplaza la anterior.</small>

            <div style="margin-top:10px;">
                @If Not String.IsNullOrWhiteSpace(Model.imgPath) Then
                    @<text>
                        <div>
                            <div><strong>Imagen actual:</strong></div>
                            <img src="@Url.Content(Model.imgPath)" style="max-width:320px; border:1px solid #ddd; padding:4px;" />
                        </div>
                    </text>
                End If

                <img id="preview" style="max-width:320px; border:1px solid #ddd; padding:4px; display:none;" />
            </div>
        </div>
    </div>

    <div class="form-group">
        @Html.LabelFor(Function(m) m.medidasJson, "Medidas (JSON)", New With {.class = "control-label col-md-2"})
        <div class="col-md-8">
            @Html.TextAreaFor(Function(m) m.medidasJson, New With {.class = "form-control", .rows = "6", .placeholder = "{ ""largo"": 120, ""alto"": 95 }"})
            @Html.ValidationMessageFor(Function(m) m.medidasJson, "", New With {.class = "text-danger"})
        </div>
    </div>
</div>

<hr />

<div class="form-group">
    @Html.LabelFor(Function(m) m.notas, "Notas", New With {.class = "control-label col-md-2"})
    <div class="col-md-8">
        @Html.TextBoxFor(Function(m) m.notas, New With {.class = "form-control", .maxlength = "200"})
        @Html.ValidationMessageFor(Function(m) m.notas, "", New With {.class = "text-danger"})
    </div>
</div>

<script>
    function toggleVision() {
        var m = (document.getElementById('metodo').value || '').toUpperCase();
        document.getElementById('bloqueVision').style.display = (m === 'VISION') ? '' : 'none';
    }
    document.getElementById('metodo').addEventListener('change', toggleVision);
    toggleVision();

    var fileInput = document.getElementById('Imagen');
    if (fileInput) {
        fileInput.addEventListener('change', function (e) {
            var f = e.target.files && e.target.files[0];
            if (!f) return;
            var img = document.getElementById('preview');
            img.src = URL.createObjectURL(f);
            img.style.display = '';
        });
    }
</script>
