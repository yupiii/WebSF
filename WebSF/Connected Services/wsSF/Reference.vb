﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace wsSF
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="wsSF.WebServiceSFSoap")>  _
    Public Interface WebServiceSFSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/FechaServidor", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function FechaServidor(ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/FechaServidor", ReplyAction:="*")>  _
        Function FechaServidorAsync(ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Acceso", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Acceso(ByVal Login As String, ByVal Password As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Acceso", ReplyAction:="*")>  _
        Function AccesoAsync(ByVal Login As String, ByVal Password As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Catalogos", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Catalogos(ByVal Catalogo As Integer, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Catalogos", ReplyAction:="*")>  _
        Function CatalogosAsync(ByVal Catalogo As Integer, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Registra_Ingresos", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Registra_Ingresos(ByVal Ingreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Registra_Ingresos", ReplyAction:="*")>  _
        Function Registra_IngresosAsync(ByVal Ingreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Registra_Egresos", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Registra_Egresos(ByVal Egreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Registra_Egresos", ReplyAction:="*")>  _
        Function Registra_EgresosAsync(ByVal Egreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Registra_Bitacora", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function Registra_Bitacora(ByVal Xml As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Registra_Bitacora", ReplyAction:="*")>  _
        Function Registra_BitacoraAsync(ByVal Xml As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros)
    End Interface
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class ListadoRegistros
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private datosField As System.Data.DataSet
        
        Private existeErrorField As Boolean
        
        Private mensajeErrorField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)>  _
        Public Property Datos() As System.Data.DataSet
            Get
                Return Me.datosField
            End Get
            Set
                Me.datosField = value
                Me.RaisePropertyChanged("Datos")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)>  _
        Public Property ExisteError() As Boolean
            Get
                Return Me.existeErrorField
            End Get
            Set
                Me.existeErrorField = value
                Me.RaisePropertyChanged("ExisteError")
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=2)>  _
        Public Property MensajeError() As String
            Get
                Return Me.mensajeErrorField
            End Get
            Set
                Me.mensajeErrorField = value
                Me.RaisePropertyChanged("MensajeError")
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebServiceSFSoapChannel
        Inherits wsSF.WebServiceSFSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebServiceSFSoapClient
        Inherits System.ServiceModel.ClientBase(Of wsSF.WebServiceSFSoap)
        Implements wsSF.WebServiceSFSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function FechaServidor(ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros Implements wsSF.WebServiceSFSoap.FechaServidor
            Return MyBase.Channel.FechaServidor(Codigo, CodigoAdicional)
        End Function
        
        Public Function FechaServidorAsync(ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros) Implements wsSF.WebServiceSFSoap.FechaServidorAsync
            Return MyBase.Channel.FechaServidorAsync(Codigo, CodigoAdicional)
        End Function
        
        Public Function Acceso(ByVal Login As String, ByVal Password As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros Implements wsSF.WebServiceSFSoap.Acceso
            Return MyBase.Channel.Acceso(Login, Password, Codigo, CodigoAdicional)
        End Function
        
        Public Function AccesoAsync(ByVal Login As String, ByVal Password As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros) Implements wsSF.WebServiceSFSoap.AccesoAsync
            Return MyBase.Channel.AccesoAsync(Login, Password, Codigo, CodigoAdicional)
        End Function
        
        Public Function Catalogos(ByVal Catalogo As Integer, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros Implements wsSF.WebServiceSFSoap.Catalogos
            Return MyBase.Channel.Catalogos(Catalogo, Codigo, CodigoAdicional)
        End Function
        
        Public Function CatalogosAsync(ByVal Catalogo As Integer, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros) Implements wsSF.WebServiceSFSoap.CatalogosAsync
            Return MyBase.Channel.CatalogosAsync(Catalogo, Codigo, CodigoAdicional)
        End Function
        
        Public Function Registra_Ingresos(ByVal Ingreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros Implements wsSF.WebServiceSFSoap.Registra_Ingresos
            Return MyBase.Channel.Registra_Ingresos(Ingreso, Codigo, CodigoAdicional)
        End Function
        
        Public Function Registra_IngresosAsync(ByVal Ingreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros) Implements wsSF.WebServiceSFSoap.Registra_IngresosAsync
            Return MyBase.Channel.Registra_IngresosAsync(Ingreso, Codigo, CodigoAdicional)
        End Function
        
        Public Function Registra_Egresos(ByVal Egreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros Implements wsSF.WebServiceSFSoap.Registra_Egresos
            Return MyBase.Channel.Registra_Egresos(Egreso, Codigo, CodigoAdicional)
        End Function
        
        Public Function Registra_EgresosAsync(ByVal Egreso As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros) Implements wsSF.WebServiceSFSoap.Registra_EgresosAsync
            Return MyBase.Channel.Registra_EgresosAsync(Egreso, Codigo, CodigoAdicional)
        End Function
        
        Public Function Registra_Bitacora(ByVal Xml As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As wsSF.ListadoRegistros Implements wsSF.WebServiceSFSoap.Registra_Bitacora
            Return MyBase.Channel.Registra_Bitacora(Xml, Codigo, CodigoAdicional)
        End Function
        
        Public Function Registra_BitacoraAsync(ByVal Xml As String, ByVal Codigo As String, ByVal CodigoAdicional As String) As System.Threading.Tasks.Task(Of wsSF.ListadoRegistros) Implements wsSF.WebServiceSFSoap.Registra_BitacoraAsync
            Return MyBase.Channel.Registra_BitacoraAsync(Xml, Codigo, CodigoAdicional)
        End Function
    End Class
End Namespace
