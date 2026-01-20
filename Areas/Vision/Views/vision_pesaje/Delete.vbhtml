@ModelType ganaderiaMVC.vision_pesaje
@Code
    ViewData("Title") = "Eliminar Pesaje"
End Code



<h4>¿Seguro que querés eliminar este registro?</h4>

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
</dl>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.HiddenFor(Function(m) m.pesId)

    @<p>
        <input type="submit" value="Eliminar" class="btn btn-danger" />
        @Html.ActionLink("Cancelar", "Index", New With {.area = "Vision"}, New With {.class = "btn btn-default"})
    </p>
End Using
