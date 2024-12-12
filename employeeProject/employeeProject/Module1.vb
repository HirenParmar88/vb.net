Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public Con As New OleDbConnection

    Public Cmd As New OleDbCommand
    Public Dad As New OleDbDataAdapter
    Public Dst As New DataSet
    Public CurrentRow
End Module
