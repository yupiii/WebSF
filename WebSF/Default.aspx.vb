Imports WebSF.Parametros
Public Class _Default
    Inherits System.Web.UI.Page
    Public funciones As New Funciones
    Public parametros As New Parametros
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("UsuarioConectado") = False

        Try

            parametros.FechaServidor = funciones.FechaServidor()
            If parametros.FechaServidor = Nothing Then
                Mensaje("error", "El Servidor No enviá la fecha, existe un error")
            Else
                Session("FechaServidor") = parametros.FechaServidor
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnIngresar_ServerClick(sender As Object, e As EventArgs) Handles btnIngresar.ServerClick
        Dim wsSAF As New wsSF.WebServiceSFSoapClient
        Dim Respuesta As New wsSF.ListadoRegistros
        Dim AccesoUsuario As New AccesoUsuario

        Try

            If TxtLogin.Text.Trim.Length = 0 Then
                MsgBox("Error: El Usuario debe tener valor, Verifique")
                Exit Sub
            End If
            If TxtPassword.Text.Trim.Length = 0 Then
                MsgBox("Error: La contraseña debe tener valor, Verifique")
                Exit Sub
            End If

            Respuesta = funciones.Acceso(TxtLogin.Text.Trim(), TxtPassword.Text.Trim())

            If Respuesta.ExisteError = False Then
                If Respuesta.Datos.Tables(0).Rows.Count > 0 Then
                    AccesoUsuario.CveUsuario = Respuesta.Datos.Tables(0).Rows(0).Item("CveUsuario").ToString
                    AccesoUsuario.Login = Respuesta.Datos.Tables(0).Rows(0).Item("Login").ToString
                    AccesoUsuario.Usuario = Respuesta.Datos.Tables(0).Rows(0).Item("Usuario").ToString
                    AccesoUsuario.Correo = Respuesta.Datos.Tables(0).Rows(0).Item("Correo").ToString
                    AccesoUsuario.CveNivel = Respuesta.Datos.Tables(0).Rows(0).Item("CveNivel").ToString
                    AccesoUsuario.Baja = Respuesta.Datos.Tables(0).Rows(0).Item("Baja").ToString
                    If AccesoUsuario.Baja = 0 Then
                        Session("Bienvenida") = 0
                        Session("UsuarioConectado") = True
                        Session("AccesoUsuario") = AccesoUsuario
                        Response.Redirect("Inicio.aspx")
                    Else
                        Session("UsuarioConectado") = False
                        Mensaje("error", "El Usuario esta dado de Baja")
                        Exit Sub
                    End If
                Else
                    Mensaje("error", "Usuario o Password incorrecto, verifique")
                    Exit Sub
                End If
            Else
                Mensaje("error", Respuesta.MensajeError)
                Exit Sub
            End If
            Exit Sub
        Catch ex As Exception
            Mensaje("error", ex.Message)
        Return

        End Try
    End Sub

    Protected Sub Mensaje(ByVal Opcion As String, ByVal Texto As String)
        ' Opcion = error, info, ok, warning
        'string Opcion = OpcionesMsj.SelectedValue;
        'string Texto = CualMensaje.Text;
        ' para cambiar el tipo de mensaje esta disponible ok, error, warning, info
        ClientScript.RegisterStartupScript(Me.GetType(), "texto texto", "mensaje('" + Opcion + "', '" + Texto + "')", True)
    End Sub
End Class