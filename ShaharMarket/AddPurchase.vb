Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.DateTime

Public Class AddPurchase
    Dim purchase_customer, purchase_date, purchase_products As String

    Private Sub bClose_Click(sender As System.Object, e As System.EventArgs) Handles bClose.Click
        Me.Close()

    End Sub

    Private Sub AddPurchase_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        da = New OleDbDataAdapter("SELECT customer_name FROM Customers", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")

        With cb_customer_name
            .DataSource = ds.Tables("0")
            .DisplayMember = "customer_name"
            .SelectedIndex = 0
        End With

        da = New OleDbDataAdapter("SELECT product_name FROM Products", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")

        If ds.Tables.Count > 0 And ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count
                ListBox1.Items.Add(ds.Tables(0).Rows(i)("product_name").ToString())
            Next i
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim selectedItem As String = ListBox1.SelectedItem.ToString()
        ListBox2.Items.Add(selectedItem)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ListBox2.Items.Remove(ListBox2.SelectedItem)
    End Sub

    Private Sub bAddProduct_Click(sender As System.Object, e As System.EventArgs) Handles bAddProduct.Click
        If ListBox2.Items.Count = 0 Then
            MessageBox.Show("עליך לבחור לפחות פריט אחד מהמלאי")
        Else

            purchase_customer = cb_customer_name.Text()
            purchase_products = ""
            purchase_date = Date.Today

            For i = 0 To ListBox2.Items.Count - 1
                purchase_products = purchase_products & ListBox2.Items.Item(i).ToString & ","
            Next i

            Dim strSQL As String = "INSERT INTO Purchases (purchase_customer,purchase_date,purchase_products) VALUES('" & purchase_customer & "','" & purchase_date & "','" & purchase_products & "')"
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

            MessageBox.Show("הזמנה נוספה בהצלחה")

            da = New OleDbDataAdapter("SELECT * FROM Purchases", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            ShaharMarket.DataGridView1.DataSource = ds.Tables(0).DefaultView()

            Me.Close()
        End If

    End Sub
End Class