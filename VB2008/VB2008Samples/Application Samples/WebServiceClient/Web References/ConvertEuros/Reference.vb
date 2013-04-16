﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1360
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.1360.
'
Namespace ConvertEuros
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1360"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="IEurobinding", [Namespace]:="http://tempuri.org/")>  _
    Partial Public Class IEuroservice
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private FromEuroOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ToEuroOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.WebServiceClient.Settings.Default.WebServiceClient_ConvertEuros_IEuroservice
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event FromEuroCompleted As FromEuroCompletedEventHandler
        
        '''<remarks/>
        Public Event ToEuroCompleted As ToEuroCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Euro-IEuro#FromEuro", RequestNamespace:="urn:Euro-IEuro", ResponseNamespace:="urn:Euro-IEuro")>  _
        Public Function FromEuro(ByVal Currency As String, ByVal Amount As Double) As <System.Xml.Serialization.SoapElementAttribute("return")> Double
            Dim results() As Object = Me.Invoke("FromEuro", New Object() {Currency, Amount})
            Return CType(results(0),Double)
        End Function
        
        '''<remarks/>
        Public Overloads Sub FromEuroAsync(ByVal Currency As String, ByVal Amount As Double)
            Me.FromEuroAsync(Currency, Amount, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub FromEuroAsync(ByVal Currency As String, ByVal Amount As Double, ByVal userState As Object)
            If (Me.FromEuroOperationCompleted Is Nothing) Then
                Me.FromEuroOperationCompleted = AddressOf Me.OnFromEuroOperationCompleted
            End If
            Me.InvokeAsync("FromEuro", New Object() {Currency, Amount}, Me.FromEuroOperationCompleted, userState)
        End Sub
        
        Private Sub OnFromEuroOperationCompleted(ByVal arg As Object)
            If (Not (Me.FromEuroCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent FromEuroCompleted(Me, New FromEuroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:Euro-IEuro#ToEuro", RequestNamespace:="urn:Euro-IEuro", ResponseNamespace:="urn:Euro-IEuro")>  _
        Public Function ToEuro(ByVal Currency As String, ByVal Amount As Double) As <System.Xml.Serialization.SoapElementAttribute("return")> Double
            Dim results() As Object = Me.Invoke("ToEuro", New Object() {Currency, Amount})
            Return CType(results(0),Double)
        End Function
        
        '''<remarks/>
        Public Overloads Sub ToEuroAsync(ByVal Currency As String, ByVal Amount As Double)
            Me.ToEuroAsync(Currency, Amount, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ToEuroAsync(ByVal Currency As String, ByVal Amount As Double, ByVal userState As Object)
            If (Me.ToEuroOperationCompleted Is Nothing) Then
                Me.ToEuroOperationCompleted = AddressOf Me.OnToEuroOperationCompleted
            End If
            Me.InvokeAsync("ToEuro", New Object() {Currency, Amount}, Me.ToEuroOperationCompleted, userState)
        End Sub
        
        Private Sub OnToEuroOperationCompleted(ByVal arg As Object)
            If (Not (Me.ToEuroCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ToEuroCompleted(Me, New ToEuroCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1360")>  _
    Public Delegate Sub FromEuroCompletedEventHandler(ByVal sender As Object, ByVal e As FromEuroCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1360"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class FromEuroCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Double
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Double)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1360")>  _
    Public Delegate Sub ToEuroCompletedEventHandler(ByVal sender As Object, ByVal e As ToEuroCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.1360"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class ToEuroCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Double
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Double)
            End Get
        End Property
    End Class
End Namespace
