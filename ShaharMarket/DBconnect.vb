Imports System.Data.OleDb

Module DBconnect
    Public connstr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\ShaharMarket\ShaharMarket\myDB.mdb"
    Public DBConn = New OleDb.OleDbConnection(connstr)
    Public dbCommand As New OleDb.OleDbCommand()
    Public ds As DataSet = New DataSet()
    Public da As OleDbDataAdapter = New OleDbDataAdapter
    Public sum As Integer
End Module
