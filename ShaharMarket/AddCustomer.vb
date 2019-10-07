Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Public Class AddCustomer
    Dim customer_name, customer_area As String

    Private Sub bClose_Click(sender As System.Object, e As System.EventArgs) Handles bClose.Click
        Me.Close()

    End Sub

    Private Sub AddCustomer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("SELECT area_name FROM Areas", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")

        With cb_customer_area
            .DataSource = ds.Tables("0")
            .DisplayMember = "area_name"
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub bAddCustomer_Click(sender As System.Object, e As System.EventArgs) Handles bAddCustomer.Click
        customer_name = tb_customer_name.Text()
        customer_area = cb_customer_area.Text()

        If customer_name = "" Then
            MessageBox.Show("עליך למלא שם לקוח")
        Else
            Dim strSQL As String = "INSERT INTO Customers (customer_name,customer_area) VALUES('" & customer_name & "','" & customer_area & "')"
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

            MessageBox.Show("לקוח נוסף בהצלחה")

            da = New OleDbDataAdapter("SELECT * FROM Customers", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            ShaharMarket.DataGridView1.DataSource = ds.Tables(0).DefaultView()

            Me.Close()
        End If
    End Sub
End Class