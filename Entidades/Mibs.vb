'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Collections.Specialized

Partial Public Class Mibs
    #Region "Primitive Properties"

    Public Overridable Property IdentificadorMib As Integer

    Public Overridable Property Nombre As String

    Public Overridable Property PathHumano As String

    Public Overridable Property IdObj As String

    #End Region
    #Region "Navigation Properties"
    Public Overridable Property Objetos As ICollection(Of Objetos)
        Get
            If _objetos Is Nothing Then
                Dim newCollection As New FixupCollection(Of Objetos)
                AddHandler newCollection.CollectionChanged, AddressOf FixupObjetos
                _objetos = newCollection
            End If
            Return _objetos
        End Get
        Set(ByVal value As ICollection(Of Objetos))
            If _objetos IsNot value Then
                Dim previousValue As FixupCollection(Of Objetos) = TryCast(_objetos, FixupCollection(Of Objetos))
                If previousValue IsNot Nothing Then
                    RemoveHandler previousValue.CollectionChanged, AddressOf FixupObjetos
                End If
                _objetos = value
                Dim newValue As FixupCollection(Of Objetos) = TryCast(value, FixupCollection(Of Objetos))
                If newValue IsNot Nothing Then
                    AddHandler newValue.CollectionChanged, AddressOf FixupObjetos
                End If
            End If
        End Set
    End Property
    Private _objetos As ICollection(Of Objetos)

    #End Region
    #Region "Association Fixup"
    Private Sub FixupObjetos(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
        If e.NewItems IsNot Nothing Then
            For Each item As Objetos In e.NewItems
                item.Mibs = Me
            Next
        End If
        If e.OldItems IsNot Nothing Then
            For Each item As Objetos In e.OldItems
                If item.Mibs Is Me Then
                    item.Mibs = Nothing
                End If
            Next
        End If
    End Sub

    #End Region
End Class
