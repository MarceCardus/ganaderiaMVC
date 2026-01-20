@Code
    Dim appName As String = "GanadoX"
End Code
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <title>@ViewData("Title") - @appName</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />

    @*' ============ CSS ============
    ' Bootstrap 3 (desde bower_components)*@
    <link rel="stylesheet" href="~/Content/adminlte/bower_components/bootstrap/dist/css/bootstrap.min.css" />

    @*' Font Awesome (si lo tenés dentro de bower_components)*@
    <link rel="stylesheet" href="~/Content/adminlte/bower_components/font-awesome/css/font-awesome.min.css" />

    @*' Ionicons (opcional)*@
    <link rel="stylesheet" href="~/Content/adminlte/bower_components/Ionicons/css/ionicons.min.css" />

    @*' AdminLTE*@
    <link rel="stylesheet" href="~/Content/adminlte/dist/css/AdminLTE.min.css" />
    <link rel="stylesheet" href="~/Content/adminlte/dist/css/skins/skin-blue.min.css" />

    @RenderSection("Styles", required:=False)
</head>

<body class="hold-transition skin-blue sidebar-mini">
    <div class="wrapper">

        <!-- Header -->
        <header class="main-header">
            <a href="@Url.Action("Index","Dashboard", New With {.area = ""})" class="logo">
                <span class="logo-mini"><b>GX</b></span>
                <span class="logo-lg"><b>Ganado</b>X</span>
            </a>

            <nav class="navbar navbar-static-top">
                <a href="#" class="sidebar-toggle" data-toggle="push-menu" role="button">
                    <span class="sr-only">Toggle navigation</span>
                </a>

                <div class="navbar-custom-menu">
                    <ul class="nav navbar-nav">
                        <li class="dropdown user user-menu">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                <span class="hidden-xs">Usuario</span>
                            </a>
                            <ul class="dropdown-menu">
                                <li class="user-footer">
                                    <div class="pull-left">
                                        <a href="#" class="btn btn-default btn-flat">Perfil</a>
                                    </div>
                                    <div class="pull-right">
                                        <a href="#" class="btn btn-default btn-flat">Salir</a>
                                    </div>
                                </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>

        <!-- Sidebar -->
        <aside class="main-sidebar">
            <section class="sidebar">

                <ul class="sidebar-menu" data-widget="tree">
                    <li class="header">MENÚ</li>

                    <li>
                        <a href="@Url.Action("Index","Dashboard", New With {.area = ""})">
                            <i class="fa fa-dashboard"></i> <span>Panel</span>
                        </a>
                    </li>

                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-cogs"></i> <span>Configuración</span>
                            <span class="pull-right-container">
                                <i class="fa fa-angle-left pull-right"></i>
                            </span>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="@Url.Action("Index", "departamentoes", New With {.area = "Configuraciones"})">
                                    <i class="fa fa-circle-o"></i> Departamentos
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index", "ciudades", New With {.area = "Configuraciones"})">
                                    <i class="fa fa-circle-o"></i> Ciudades
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index", "barrios", New With {.area = "Configuraciones"})">
                                    <i class="fa fa-circle-o"></i> Barrios
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index", "establecimientoes", New With {.area = "Configuraciones"})">
                                    <i class="fa fa-circle-o"></i> Establecimientos
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index", "vision_dispositivo", New With {.area = "Vision"})">
                                    <i class="fa fa-circle-o"></i> Dispositivos
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index", "vision_modelo", New With {.area = "Vision"})">
                                    <i class="fa fa-circle-o"></i> Modelos
                                </a>
                            </li>
                        </ul>
                    </li>

                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-paw"></i> <span>Animales</span>
                            <span class="pull-right-container">
                                <i class="fa fa-angle-left pull-right"></i>
                            </span>
                        </a>
                        <ul class="treeview-menu">
                            <li>
                                <a href="@Url.Action("Index", "razas", New With {.area = "Animales"})">
                                    <i class="fa fa-circle-o"></i> Razas
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index","animals", New With {.area="Animales"})">
                                    <i class="fa fa-circle-o"></i> Animales
                                </a>
                            </li>
                            <li>
                                <a href="@Url.Action("Index", "vision_pesaje", New With {.area = "Vision"})">
                                    <i class="fa fa-circle-o"></i> Pesaje
                                </a>
                            </li>
                        </ul>
                    </li>

                </ul>
            </section>
        </aside>

        <!-- Content -->
        <div class="content-wrapper">
            <section class="content-header">
                <h1>@ViewData("Title")</h1>
            </section>

            <section class="content">
                @RenderBody()
            </section>
        </div>

        <!-- Footer -->
        <footer class="main-footer">
            <div class="pull-right hidden-xs">@appName</div>
            <strong>&copy; @DateTime.Now.Year - KureTech</strong>
        </footer>

    </div>

    @*' ============ JS ============*@
    <script src="~/Content/adminlte/bower_components/jquery/dist/jquery.min.js"></script>
    <script src="~/Content/adminlte/bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
    <script src="~/Content/adminlte/dist/js/adminlte.min.js"></script>

    @RenderSection("Scripts", required:=False)
</body>
</html>
