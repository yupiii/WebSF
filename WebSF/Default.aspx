<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebSF._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Sistema de Finanzas</title>
  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="../plugins/fontawesome-free/css/all.min.css">
  <!-- icheck bootstrap -->
  <link rel="stylesheet" href="../plugins/icheck-bootstrap/icheck-bootstrap.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="../dist/css/adminlte.min.css">
</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <form id="form1" runat="server">
           <div class="card card-outline card-primary">
               <div class="card-header text-center">
               </div>
<%--               <!-- Preloader -->
              <div class="preloader flex-column justify-content-center align-items-center">
                <img class="animation__wobble" src="dist/img/AdminLTELogo.png" alt="AdminLTELogo" height="60" width="60">
              </div>--%>
                <div class="card-header text-center">
                    <a href="../public/templeates/AdminLTE-3.2.0/index2.html" class="h1"><b>Sistema de Ventas</b></a>
                </div>
               <div class="card-body">
                  <p class="login-box-msg">ACCESO AL SISTEMA</p>
                   <center>
                      <img src="https://img.freepik.com/foto-gratis/portatil-bolsas-compra-concepto-compras-linea_1423-189.jpg?w=740&t=st=1693037336~exp=1693037936~hmac=fffad4fd91d36b94e27c3f5468cf97e573356b6387ebb2dd5b192c51529045e4"
    alt="" width="320">
                   </center>
                    </br>
                    <div class="input-group mb-3">
                        <span class="input-group-addon"><%--<i class="fas fa-envelope"></i>--%></span>
                        <asp:TextBox ID="TxtLogin" type="text" class="form-control" placeholder="Login" runat="server"></asp:TextBox>
                        <div class="input-group-text">
                                <span class="fas fa-user"></span>
                            </div>
                    </div>
                   <div class="input-group mb-3">
                        <span class="input-group-addon"><i class="icon_key_alt"></i></span>
                        <asp:TextBox ID="TxtPassword" type="password" class="form-control" placeholder="Contraseña" runat="server"></asp:TextBox>
                       <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                    </div> 
                   <div class="col-12">
                       <button type="submit" class="btn btn-primary btn-block" id="btnIngresar" runat="server">Ingrese</button>
                   </div>
                   <%--<button id="BtnIngresar" class="btn btn-primary btn-block" type="button" runat="server">Ingrese</button>--%>
<%--             <div style="margin-bottom: 10px"></div>--%>
                    <%--<asp:ImageButton ID="BtnIngresarAzure" CssClass="logueazure" ImageUrl="https://bsp.slpfinanzas.gob.mx/img/btnloginmicrosoft.jpg" ImageAlign="AbsMiddle" runat="server" />--%>
                    <%--<div style="margin-bottom: 10px"></div>
                    <div class="input-group mb-3">
                        <input type="email" id = "email" runat="server" class="form-control" placeholder="correo"/>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-envelope"></span>
                            </div>
                        </div>
                    </div>--%>
                  <%-- <div class="input-group mb-3">
                        <input type="password" id = "password"  runat="server" class="form-control" placeholder="contraseña"/>
                        <div class="input-group-append">
                            <div class="input-group-text">
                                <span class="fas fa-lock"></span>
                            </div>
                        </div>
                   </div>--%>
                 <%--  <div class="col-12">
                        <button type="submit" class="btn btn-primary btn-block">Ingrese</button>
                   </div>--%>
                </div>
            </div>
        </form>
    </div>
</body>
</html>
