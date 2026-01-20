@ModelType ganaderiaMVC.vision_pesaje
@Code
    ViewData("Title") = "Detalle Pesaje"
End Code



<dl class="dl-horizontal">
    <dt>ID</dt>
    <dd>@Model.pesId</dd>

    <dt>Animal</dt>
    <dd>@(If(Model.animal IsNot Nothing, Model.animal.aniCaravana, Model.aniCod.ToString()))</dd>

    <dt>Fecha</dt>
    <dd>@Model.fecha.ToString("dd/MM/yyyy HH:mm")</dd>

    <dt>Peso (Kg)</dt>
    <dd>@String.Format("{0:N2}", Model.pesoKg)</dd>

    <dt>Método</dt>
    <dd>@Model.metodo</dd>

    <dt>Confianza</dt>
    <dd>
        @If Model.confianza.HasValue Then
            @String.Format("{0:N2}%", Model.confianza.Value)
        Else
            @<text>-</text>
        End If
    </dd>

    <dt>Dispositivo</dt>
    <dd>@(If(Model.vision_dispositivo IsNot Nothing, Model.vision_dispositivo.nombre, ""))</dd>

    <dt>Modelo</dt>
    <dd>@(If(Model.vision_modelo IsNot Nothing, Model.vision_modelo.nombre, ""))</dd>

    <dt>Imagen</dt>
    <dd>
        @If Not String.IsNullOrWhiteSpace(Model.imgPath) Then
            @<text>
                <div>
                    <img src="@Url.Content(Model.imgPath)" style="max-width:420px; border:1px solid #ddd; padding:4px;" />
                    <div><a href="@Url.Content(Model.imgPath)" target="_blank">Abrir imagen</a></div>
                </div>
            </text>
        Else
            @<text>-</text>
        End If
    </dd>

    <dt>Medidas JSON</dt>
    <dd>
        <pre style="white-space:pre-wrap;">@Model.medidasJson</pre>
    </dd>

    <dt>Notas</dt>
    <dd>@Model.notas</dd>
</dl>

<p>
    @Html.ActionLink("Editar", "Edit", New With {.id = Model.pesId, .area = "Vision"}, New With {.class = "btn btn-primary"})
    @Html.ActionLink("Volver", "Index", New With {.area = "Vision"}, New With {.class = "btn btn-default"})
</p>
