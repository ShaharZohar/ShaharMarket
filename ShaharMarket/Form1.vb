' programmed and designed by Shahar Zohar
' all rights reserved (c)
' this application programmed as a final project in VB.NET
' 6.2013

Imports System.Data.OleDb
Imports System.DateTime

Public Class ShaharMarket

    Private Sub ShaharMarket_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Date.Today

        da = New OleDbDataAdapter("SELECT area_name FROM Areas", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")

        With cb_customer_area
            .DataSource = ds.Tables("0")
            .DisplayMember = "area_name"
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub bProducts_Click(sender As System.Object, e As System.EventArgs) Handles bProducts.Click
        da = New OleDbDataAdapter("SELECT * FROM Products", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")
        DataGridView1.DataSource = ds.Tables(0).DefaultView()

        Panel3.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub bDoubts_Click(sender As System.Object, e As System.EventArgs) Handles bDoubts.Click
        da = New OleDbDataAdapter("SELECT (SELECT COUNT(*) FROM Products WHERE product_doubt=doubt_name) AS total_products , * FROM Doubts", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")
        DataGridView1.DataSource = ds.Tables(0).DefaultView()

        Panel2.Visible = False
        Panel4.Visible = False
        Panel5.Visible = False
        Panel6.Visible = False
        Panel7.Visible = False
        Panel3.Visible = True
    End Sub

    Private Sub bCustomers_Click(sender As System.Object, e As System.EventArgs) Handles bCustomers.Click
        da = New OleDbDataAdapter("SELECT * FROM Customers", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")
        DataGridView1.DataSource = ds.Tables(0).DefaultView()

        Panel2.Visible = False
        Panel3.Visible = False
        Panel5.Visible = False
        Panel7.Visible = False
        Panel4.Visible = True
        Panel6.Visible = True

    End Sub

    Private Sub bPurchases_Click(sender As System.Object, e As System.EventArgs) Handles bPurchases.Click
        da = New OleDbDataAdapter("SELECT * FROM Purchases", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")
        DataGridView1.DataSource = ds.Tables(0).DefaultView()

        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
        Panel6.Visible = False
        Panel5.Visible = True
        Panel7.Visible = True

    End Sub

    Private Sub bAddProduct_Click(sender As System.Object, e As System.EventArgs) Handles bAddProduct.Click
        AddProduct.Show()

    End Sub

    Private Sub bDeleteProduct_Click(sender As System.Object, e As System.EventArgs) Handles bDeleteProduct.Click
        Dim id_to_delete As Object
        id_to_delete = 0
        id_to_delete = InputBox("הכנס את מזהה המוצר שברצונך למחוק", "", id_to_delete)
        If id_to_delete <> "" Then
            Dim strSQL2 As String = "DELETE FROM Products WHERE ID=" & id_to_delete & ""
            Dim dbComm As New OleDbCommand(strSQL2, DBConn)

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

            MessageBox.Show("מוצר נמחק בהצלחה")

            da = New OleDbDataAdapter("SELECT * FROM Products", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            DataGridView1.DataSource = ds.Tables(0).DefaultView()
        End If
    End Sub

    Private Sub bExit_Click(sender As System.Object, e As System.EventArgs) Handles bExit.Click
        Me.Close()

    End Sub

    Private Sub bAddDoubt_Click(sender As System.Object, e As System.EventArgs) Handles bAddDoubt.Click
        AddDoubt.Show()

    End Sub

    Private Sub bDeleteDoubt_Click(sender As System.Object, e As System.EventArgs) Handles bDeleteDoubt.Click
        Dim id_to_delete As Object
        id_to_delete = 0
        id_to_delete = InputBox("הכנס את מזהה הספק שברצונך למחוק", "", id_to_delete)
        If id_to_delete <> "" Then
            Dim strSQL3 As String = "DELETE FROM Doubts WHERE ID=" & id_to_delete & ""
            Dim dbComm As New OleDbCommand(strSQL3, DBConn)

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

            MessageBox.Show("ספק נמחק בהצלחה")

            da = New OleDbDataAdapter("SELECT (SELECT COUNT(*) FROM Products WHERE product_doubt=doubt_name) AS total_products , * FROM Doubts", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            DataGridView1.DataSource = ds.Tables(0).DefaultView()
        End If
    End Sub

    Private Sub bAddCustomer_Click(sender As System.Object, e As System.EventArgs) Handles bAddCustomer.Click
        AddCustomer.Show()

    End Sub

    Private Sub bDeleteCustomer_Click(sender As System.Object, e As System.EventArgs) Handles bDeleteCustomer.Click
        Dim id_to_delete As Object
        id_to_delete = 0
        id_to_delete = InputBox("הכנס את מזהה הלקוח שברצונך למחוק", "", id_to_delete)
        If id_to_delete <> "" Then
            Dim strSQL3 As String = "DELETE FROM Customers WHERE ID=" & id_to_delete & ""
            Dim dbComm As New OleDbCommand(strSQL3, DBConn)

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

            MessageBox.Show("לקוח נמחק בהצלחה")

            da = New OleDbDataAdapter("SELECT * FROM Customers", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            DataGridView1.DataSource = ds.Tables(0).DefaultView()
        End If
    End Sub

    Private Sub bAddPurchase_Click(sender As System.Object, e As System.EventArgs) Handles bAddPurchase.Click
        AddPurchase.Show()

    End Sub

    Private Sub bDeletePurchase_Click(sender As System.Object, e As System.EventArgs) Handles bDeletePurchase.Click
        Dim id_to_delete As Object
        id_to_delete = 0
        id_to_delete = InputBox("הכנס את מזהה ההזמנה שברצונך למחוק", "", id_to_delete)
        If id_to_delete <> "" Then
            Dim strSQL3 As String = "DELETE FROM Purchases WHERE ID=" & id_to_delete & ""
            Dim dbComm As New OleDbCommand(strSQL3, DBConn)

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

            MessageBox.Show("הזמנה נמחקה בהצלחה")

            da = New OleDbDataAdapter("SELECT * FROM Purchases", connstr)
            ds.Tables.Clear()
            da.Fill(ds, "0")
            DataGridView1.DataSource = ds.Tables(0).DefaultView()
        End If
    End Sub

    Private Sub bCustomersArea_Click(sender As System.Object, e As System.EventArgs) Handles bCustomersArea.Click
        da = New OleDbDataAdapter("SELECT * FROM Customers WHERE customer_area = '" & cb_customer_area.Text().ToString() & "'", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")
        DataGridView1.DataSource = ds.Tables(0).DefaultView()
    End Sub

    Private Sub bPurchasesDate_Click(sender As System.Object, e As System.EventArgs) Handles bPurchasesDate.Click
        Dim date1, date2 As Date

        date1 = tb_date1.Text()
        date2 = tb_date2.Text()

        da = New OleDbDataAdapter("SELECT * FROM Purchases WHERE purchase_date BETWEEN " & date1.ToOADate & " AND " & date2.ToOADate & "", connstr)
        ds.Tables.Clear()
        da.Fill(ds, "0")


        DataGridView1.DataSource = ds.Tables(0).DefaultView()
    End Sub
End Class
