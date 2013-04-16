﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1360
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class DataBaseCreationScripts
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("StoredProcedures.DataBaseCreationScripts", GetType(DataBaseCreationScripts).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE MASTER
        '''IF EXISTS (
        '''           SELECT * 
        '''             FROM master..sysdatabases
        '''            WHERE Name = &apos;StoredProceduresDemo&apos;
        '''           )
        '''  DROP DATABASE StoredProceduresDemo
        '''  CREATE DATABASE StoredProceduresDemo
        '''.
        '''</summary>
        Friend Shared ReadOnly Property CreateDatabase() As String
            Get
                Return ResourceManager.GetString("CreateDatabase", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE StoredProceduresDemo
        '''GO
        '''if exists (select * from sysobjects where id = object_id(&apos;dbo.Employees&apos;) and sysstat &amp; 0xf = 3)
        '''	drop table &quot;dbo&quot;.&quot;Employees&quot;
        '''GO
        '''CREATE TABLE &quot;Employees&quot; (
        '''	&quot;EmployeeID&quot; &quot;int&quot; IDENTITY (1, 1) NOT NULL ,
        '''	&quot;LastName&quot; nvarchar (20) NOT NULL ,
        '''	&quot;FirstName&quot; nvarchar (10) NOT NULL ,
        '''	&quot;Title&quot; nvarchar (30) NULL ,
        '''	&quot;TitleOfCourtesy&quot; nvarchar (25) NULL ,
        '''	&quot;BirthDate&quot; &quot;datetime&quot; NULL ,
        '''	&quot;HireDate&quot; &quot;datetime&quot; NULL ,
        '''	&quot;Address&quot; nvarchar (60) NULL ,
        '''	&quot;City&quot; nvarchar (15) NULL , [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property CreateEmployeesTable() As String
            Get
                Return ResourceManager.GetString("CreateEmployeesTable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to USE StoredProceduresDemo
        '''IF EXISTS (
        '''           SELECT *
        '''             FROM sysobjects
        '''            WHERE Name = &apos;GetEmployees&apos;
        '''              AND TYPE = &apos;p&apos;)
        '''  DROP PROCEDURE GetEmployees
        '''GO
        '''CREATE PROCEDURE GetEmployees AS
        '''SELECT EmployeeID, FirstName, LastName, HireDate
        '''  FROM Employees
        '''GO
        '''IF EXISTS (
        '''           SELECT *
        '''             FROM sysobjects
        '''            WHERE Name = &apos;GetFirstNames&apos;
        '''              AND TYPE = &apos;p&apos;)
        '''
        '''  DROP PROCEDURE GetFirstNames
        '''GO
        '''CREATE PROCEDURE GetFirstNames
        '''AS [rest of string was truncated]&quot;;.
        '''</summary>
        Friend Shared ReadOnly Property CreateSprocs() As String
            Get
                Return ResourceManager.GetString("CreateSprocs", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
