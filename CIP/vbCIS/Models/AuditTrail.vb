'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class AuditTrail
    Public Property AuditTrailID As Integer
    Public Property TableName As String
    Public Property ColumnName As String
    Public Property RecordStatusCodeID As Integer
    Public Property Created As Date
    Public Property BeforeValue As String
    Public Property AfterValue As String
    Public Property Details As String
    Public Property RemoteObjectPrimaryKeyID As Integer

    Public Overridable Property RecordStatusCode As RecordStatusCode

End Class
