﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class CISEntitiesA
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CISEntitiesA")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property AuditTrails() As DbSet(Of AuditTrail)
    Public Overridable Property InsuranceCompanies() As DbSet(Of InsuranceCompany)
    Public Overridable Property Quotes() As DbSet(Of Quote)
    Public Overridable Property QuoteDetails() As DbSet(Of QuoteDetail)
    Public Overridable Property QuoteStatusCodes() As DbSet(Of QuoteStatusCode)
    Public Overridable Property QuoteStatusMaps() As DbSet(Of QuoteStatusMap)
    Public Overridable Property RecordStatusCodes() As DbSet(Of RecordStatusCode)
    Public Overridable Property SRGBrands() As DbSet(Of SRGBrand)

End Class
