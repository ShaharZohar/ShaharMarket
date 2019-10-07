Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class AddDoubt
    Dim doubt_name As String


    Private Sub bClose_Click(sender As System.Object, e As System.EventArgs) Handles bClose.Click
        Me.Close()

    End Sub

    Private Sub bAddProduct_Click(sender As System.Object, e As System.EventArgs) Handles bAddProduct.Click
        doubt_name = tb_doubt_name.Text()

        If doubt_name = "" Then
            MessageBox.Show("עליך למלא שם ספק")
        Else
            Dim strSQL As String = "INSERT INTO Doubts (doubt_name) VALUES('" & doubt_name & "')"
            Dim dbComm As New OleDbCommand(strSQL, DBConn)

            Try
                DBConn.Open()
                dbComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("בעיית חיבור למסד נתונים")
            Finally
                If DBConn.State = ConnectionState.Open Then
                    DBConn.Close()

                End If
            End Try

            MessageBox.Show("ספק נוסף בהצלחה")

            da = New OleDbDataAdapter("SELECT (SELECT COUNT(*) FROM Products WHERE product_doubt=doubt_name) AS total_products , * FROM Doubts", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            ShaharMarket.DataGridView1.DataSource = ds.Tables(0).DefaultView()

            Me.Close()
        End If

    End Sub
End Class