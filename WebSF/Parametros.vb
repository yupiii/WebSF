Public Class Parametros

    Public Const wsCodigoProduccion As String = "BF7DA84D-0697-49DA-9B39-6A83245F2624"

    Public Const wsCodigoPruebas As String = "3F96E9F5-1783-4BBF-A1BE-F4992FC81ED6"

    Public Const CodigoAdicional As String = "233E0E12-402A-4421-A3F9-B6EE889F842A"

    Public Const wsCodigo As String = wsCodigoPruebas 'wsCodigoProduccion

    Public FechaServidor As DateTime

    Public Structure AccesoUsuario
        Public CveUsuario As Integer
        Public Login As String
        Public Usuario As String
        Public Correo As String
        Public CveNivel As Integer
        Public Baja As Integer
    End Structure
End Class
