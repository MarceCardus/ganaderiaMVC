@ModelType DashboardVM
@Imports System.Web.Script.Serialization

@Code
    ViewData("Title") = "Panel"
    Dim js = New JavaScriptSerializer()
End Code

<h2>Panel</h2>

<div class="row">
    <div class="col-md-3">
        <div class="panel panel-primary">
            <div class="panel-heading">Total animales</div>
            <div class="panel-body"><h3 style="margin:0;">@Model.TotalAnimales</h3></div>
        </div>
    </div>

    <div class="col-md-3">
        <div class="panel panel-success">
            <div class="panel-heading">Activos</div>
            <div class="panel-body"><h3 style="margin:0;">@Model.Activos</h3></div>
        </div>
    </div>

    <div class="col-md-3">
        <div class="panel panel-warning">
            <div class="panel-heading">Vendidos</div>
            <div class="panel-body"><h3 style="margin:0;">@Model.Vendidos</h3></div>
        </div>
    </div>

    <div class="col-md-3">
        <div class="panel panel-danger">
            <div class="panel-heading">Muertos</div>
            <div class="panel-body"><h3 style="margin:0;">@Model.Muertos</h3></div>
        </div>
    </div>
</div>

<div class="row">
    <div class="col-md-6">
        <h4>Animales por sexo</h4>
        <canvas id="chSexo"></canvas>
    </div>
    <div class="col-md-6">
        <h4>Top establecimientos</h4>
        <canvas id="chEst"></canvas>
    </div>
</div>

@section Scripts
    @*' Opción 1 (rápida): CDN*@
    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

    <script>
        var sexoLabels = @Html.Raw(js.Serialize(Model.PorSexo.Select(Function(x) x.Label).ToList()))
        var sexoData   = @Html.Raw(js.Serialize(Model.PorSexo.Select(Function(x) x.Value).ToList()))

        new Chart(document.getElementById('chSexo'), {
            type: 'doughnut',
            data: { labels: sexoLabels, datasets: [{ data: sexoData }] }
        });

        var estLabels = @Html.Raw(js.Serialize(Model.PorEstablecimiento.Select(Function(x) x.Label).ToList()))
        var estData   = @Html.Raw(js.Serialize(Model.PorEstablecimiento.Select(Function(x) x.Value).ToList()))

        new Chart(document.getElementById('chEst'), {
            type: 'bar',
            data: { labels: estLabels, datasets: [{ data: estData }] }
        });
    </script>
End Section
