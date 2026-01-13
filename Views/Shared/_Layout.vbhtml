<!DOCTYPE html>
<html>
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - GanadoX</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("GanadoX", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Alternar navegación" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <!-- Enlaces existentes -->
                    <li>@Html.ActionLink("Inicio", "Index", "Dashboard", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <!-- Dropdown para "Configuración" -->
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                            Configuración
                        </a>
                        <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <li>@Html.ActionLink("Departamentos", "Index", "departamentoes", New With {.area = "Configuraciones"}, New With {.class = "dropdown-item"})</li>
                            <li>@Html.ActionLink("Ciudades", "Index", "ciudades", New With {.area = "Configuraciones"}, New With {.class = "dropdown-item"})</li>
                            <li>@Html.ActionLink("Barrios", "Index", "barrios", New With {.area = "Configuraciones"}, New With {.class = "dropdown-item"})</li>
                            <li>@Html.ActionLink("Establecimientos", "Index", "establecimientoes", New With {.area = "Configuraciones"}, New With {.class = "dropdown-item"})</li>
                        </ul>
                    </li>
                    <li class="nav-item dropdown">
                        <a class="nav-link dropdown-toggle" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
                            Animales
                        </a>
                        <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
                            <li>@Html.ActionLink("Animales", "Index", "animals", New With {.area = "Animales"}, New With {.class = "dropdown-item"})</li>
                            <li>@Html.ActionLink("Gestación", "Index", "gestacions", New With {.area = "Reproducciones"}, New With {.class = "dropdown-item"})</li>
                            <li>@Html.ActionLink("Nacimientos", "Index", "nacimientoes", New With {.area = "Reproducciones"}, New With {.class = "dropdown-item"})</li>
                            <li>@Html.ActionLink("Vacunación", "Index", "vacunacions", New With {.area = "Reproducciones"}, New With {.class = "dropdown-item"})</li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - KureTech</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    <!-- Cargar Bootstrap y Popper.js juntos en un solo archivo -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"></script>
    @RenderSection("scripts", required:=False)
</body>
</html>
