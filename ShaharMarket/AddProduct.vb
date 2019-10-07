Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.DateTime

Public Class AddProduct
    Dim product_name, product_date, product_cost, product_amount, product_doubt As String

    Private Sub bClose_Click(sender As System.Object, e As System.EventArgs) Handles bClose.Click
        Me.Close()

    End Sub

    Private Sub bAddProduct_Click(sender As System.Object, e As System.EventArgs) Handles bAddProduct.Click
        product_name = tb_product_name.Text()
        product_date = Date.Today
        product_cost = tb_product_cost.Text()
        product_amount = tb_product_amount.Text()
        product_doubt = cb_product_doubt.Text()

        If product_name = "" Then
            MessageBox.Show("עליך למלא שם מוצר")
        ElseIf product_cost = "" Then
            MessageBox.Show("עליך למלא עלות מוצר")
        ElseIf product_amount = "" Then
            MessageBox.Show("עליך למלא כמות מהמוצר")
        Else
            Dim strSQL As String = "INSERT INTO Products (product_name,product_date,product_cost,product_amount,product_doubt) VALUES('" & product_name & "','" & product_date & "','" & product_cost & "','" & product_amount & "','" & product_doubt & "')"
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

            MessageBox.Show("מוצר נוסף בהצלחה")

            da = New OleDbDataAdapter("SELECT * FROM Products", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            ShaharMarket.DataGridView1.DataSource = ds.Tables(0).DefaultView()

            Me.Close()
        End If
    End Sub

    Private Sub AddProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("SELECT doubt_name FROM Doubts", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")

        With cb_product_doubt
            .DataSource = ds.Tables("0")
            .DisplayMember = "doubt_name"
            .SelectedIndex = 0
        End With
    End Sub
End Class