Imports System.IO
Public Class Funciones
    Public Structure RespuestaValor
        Dim Valor As Integer
        Dim Mensaje As String
    End Structure
    Public Structure RespuestaProceso
        Dim Ruta As String
        Dim ExisteError As Boolean
        Dim MensajeError As String
    End Structure

    Public Function FechaServidor() As DateTime
        Dim m_wsSAF As New wsSF.WebServiceSFSoapClient
        Dim Respuesta As wsSF.ListadoRegistros = Nothing
        Dim BFecha As New DateTime
        Try
            Respuesta = m_wsSAF.FechaServidor(Parametros.wsCodigo, Parametros.CodigoAdicional)

            If Respuesta.ExisteError = False Then
                BFecha = Respuesta.Datos.Tables(0).Rows(0).Item("FechaServidor")
            Else
                BFecha = Nothing
            End If
        Catch ex As Exception
            BFecha = Nothing
        End Try
        Return BFecha
    End Function
    Public Function Acceso(ByVal Login As String, ByVal Password As String) As wsSF.ListadoRegistros
        Dim m_wsSF As New wsSF.WebServiceSFSoapClient
        Dim Respuesta As wsSF.ListadoRegistros = Nothing
        Try
            Respuesta = m_wsSF.Acceso(Login, Password, Parametros.wsCodigo, Parametros.CodigoAdicional)

        Catch ex As Exception
            Respuesta.ExisteError = True
            Respuesta.Datos = Nothing
            Respuesta.MensajeError = ex.Message
        End Try
        Return Respuesta
    End Function
    'Public Function Catalogos(ByVal Catalogo As String) As wsSAF.ListadoRegistros
    '    Dim m_wsSAF As New wsSAF.WebServiceSAFSoapClient
    '    Dim Respuesta As wsSAF.ListadoRegistros = Nothing

    '    Dim par As Integer
    '    Try
    '        Select Case Catalogo
    '            Case "TipoContribuyente"
    '                par = 1
    '            Case "Entidades"
    '                par = 2
    '            Case "Municipios"
    '                par = 3
    '            Case "Actividad"
    '                par = 4
    '            Case "Situación"
    '                par = 5
    '            Case "ALR"
    '                par = 6
    '            Case "CRH"
    '                par = 7
    '            Case "Motivo"
    '                par = 8
    '            Case "SitDomicilio"
    '                par = 9
    '            Case "Tipos de Propuesta"
    '                par = 10
    '            Case "Modulo"
    '                par = 11
    '            Case "Pantalla"
    '                par = 12
    '            Case "MetodoRevision"
    '                par = 13
    '            Case "Programa"
    '                par = 14
    '            Case "TipoRevision"
    '                par = 15
    '            Case "Origen"
    '                par = 16
    '            Case "Estatus"
    '                par = 17
    '            Case "SubPrograma"
    '                par = 18
    '            Case "Jefatura"
    '                par = 19
    '            Case "Verificacion"
    '                par = 20
    '            Case "Formatos"
    '                par = 21
    '            Case "Usuarios"
    '                par = 23
    '            Case "Roles"
    '                par = 22
    '            Case Else
    '                par = 0
    '        End Select

    '        If par = 0 Then
    '            Respuesta.Datos = Nothing
    '            Respuesta.ExisteError = True
    '            Respuesta.MensajeError = "No Existe ese Catálogo, Verifique"
    '            'MsgBox(Resultado.MensajeError, vbCritical)
    '            Return Respuesta
    '            Exit Function
    '        End If

    '        Respuesta = m_wsSAF.Catalogos(par, parametros.wsCodigo)

    '    Catch ex As Exception
    '        'Respuesta.Datos = Nothing
    '        Respuesta.ExisteError = True
    '        Respuesta.MensajeError = "Error:" & ex.Message
    '        'MsgBox(Resultado.MensajeError, vbCritical)
    '        Return Respuesta
    '    End Try

    '    Return Respuesta
    'End Function
End Class
