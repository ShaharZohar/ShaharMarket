<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShaharMarket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShaharMarket))
        Me.bProducts = New System.Windows.Forms.Button()
        Me.bDoubts = New System.Windows.Forms.Button()
        Me.bCustomers = New System.Windows.Forms.Button()
        Me.bPurchases = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.bDeleteProduct = New System.Windows.Forms.Button()
        Me.bAddProduct = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bDeleteDoubt = New System.Windows.Forms.Button()
        Me.bAddDoubt = New System.Windows.Forms.Button()
        Me.bExit = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bDeleteCustomer = New System.Windows.Forms.Button()
        Me.bAddCustomer = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.bDeletePurchase = New System.Windows.Forms.Button()
        Me.bAddPurchase = New System.Windows.Forms.Button()
        Me.MyDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cb_customer_area = New System.Windows.Forms.ComboBox()
        Me.bCustomersArea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tb_date2 = New System.Windows.Forms.TextBox()
        Me.tb_date1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bPurchasesDate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.MyDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'bProducts
        '
        Me.bProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bProducts.Location = New System.Drawing.Point(813, 43)
        Me.bProducts.Name = "bProducts"
        Me.bProducts.Size = New System.Drawing.Size(151, 32)
        Me.bProducts.TabIndex = 0
        Me.bProducts.Text = "מלאי מוצרים"
        Me.bProducts.UseVisualStyleBackColor = False
        '
        'bDoubts
        '
        Me.bDoubts.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bDoubts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bDoubts.Location = New System.Drawing.Point(813, 81)
        Me.bDoubts.Name = "bDoubts"
        Me.bDoubts.Size = New System.Drawing.Size(151, 32)
        Me.bDoubts.TabIndex = 1
        Me.bDoubts.Text = "ספקים"
        Me.bDoubts.UseVisualStyleBackColor = False
        '
        'bCustomers
        '
        Me.bCustomers.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bCustomers.Location = New System.Drawing.Point(813, 119)
        Me.bCustomers.Name = "bCustomers"
        Me.bCustomers.Size = New System.Drawing.Size(151, 32)
        Me.bCustomers.TabIndex = 2
        Me.bCustomers.Text = "לקוחות"
        Me.bCustomers.UseVisualStyleBackColor = False
        '
        'bPurchases
        '
        Me.bPurchases.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bPurchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bPurchases.Location = New System.Drawing.Point(813, 157)
        Me.bPurchases.Name = "bPurchases"
        Me.bPurchases.Size = New System.Drawing.Size(151, 32)
        Me.bPurchases.TabIndex = 3
        Me.bPurchases.Text = "הזמנות"
        Me.bPurchases.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 285)
        Me.Panel1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.Black
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.Size = New System.Drawing.Size(789, 279)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.bDeleteProduct)
        Me.Panel2.Controls.Add(Me.bAddProduct)
        Me.Panel2.Location = New System.Drawing.Point(810, 233)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(157, 77)
        Me.Panel2.TabIndex = 6
        Me.Panel2.Visible = False
        '
        'bDeleteProduct
        '
        Me.bDeleteProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bDeleteProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bDeleteProduct.Location = New System.Drawing.Point(3, 41)
        Me.bDeleteProduct.Name = "bDeleteProduct"
        Me.bDeleteProduct.Size = New System.Drawing.Size(151, 32)
        Me.bDeleteProduct.TabIndex = 8
        Me.bDeleteProduct.Text = "מחק מוצר"
        Me.bDeleteProduct.UseVisualStyleBackColor = False
        '
        'bAddProduct
        '
        Me.bAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddProduct.Location = New System.Drawing.Point(3, 3)
        Me.bAddProduct.Name = "bAddProduct"
        Me.bAddProduct.Size = New System.Drawing.Size(151, 32)
        Me.bAddProduct.TabIndex = 7
        Me.bAddProduct.Text = "הוסף מוצר"
        Me.bAddProduct.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.bDeleteDoubt)
        Me.Panel3.Controls.Add(Me.bAddDoubt)
        Me.Panel3.Location = New System.Drawing.Point(810, 316)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(157, 77)
        Me.Panel3.TabIndex = 7
        Me.Panel3.Visible = False
        '
        'bDeleteDoubt
        '
        Me.bDeleteDoubt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bDeleteDoubt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bDeleteDoubt.Location = New System.Drawing.Point(3, 39)
        Me.bDeleteDoubt.Name = "bDeleteDoubt"
        Me.bDeleteDoubt.Size = New System.Drawing.Size(151, 32)
        Me.bDeleteDoubt.TabIndex = 10
        Me.bDeleteDoubt.Text = "מחק ספק"
        Me.bDeleteDoubt.UseVisualStyleBackColor = False
        '
        'bAddDoubt
        '
        Me.bAddDoubt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bAddDoubt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddDoubt.Location = New System.Drawing.Point(3, 3)
        Me.bAddDoubt.Name = "bAddDoubt"
        Me.bAddDoubt.Size = New System.Drawing.Size(151, 32)
        Me.bAddDoubt.TabIndex = 9
        Me.bAddDoubt.Text = "הוסף ספק"
        Me.bAddDoubt.UseVisualStyleBackColor = False
        '
        'bExit
        '
        Me.bExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bExit.Location = New System.Drawing.Point(813, 195)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(151, 32)
        Me.bExit.TabIndex = 8
        Me.bExit.Text = "יציאה"
        Me.bExit.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.bDeleteCustomer)
        Me.Panel4.Controls.Add(Me.bAddCustomer)
        Me.Panel4.Location = New System.Drawing.Point(810, 399)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(157, 78)
        Me.Panel4.TabIndex = 9
        Me.Panel4.Visible = False
        '
        'bDeleteCustomer
        '
        Me.bDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bDeleteCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bDeleteCustomer.Location = New System.Drawing.Point(3, 41)
        Me.bDeleteCustomer.Name = "bDeleteCustomer"
        Me.bDeleteCustomer.Size = New System.Drawing.Size(151, 32)
        Me.bDeleteCustomer.TabIndex = 12
        Me.bDeleteCustomer.Text = "מחק לקוח"
        Me.bDeleteCustomer.UseVisualStyleBackColor = False
        '
        'bAddCustomer
        '
        Me.bAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddCustomer.Location = New System.Drawing.Point(3, 3)
        Me.bAddCustomer.Name = "bAddCustomer"
        Me.bAddCustomer.Size = New System.Drawing.Size(151, 32)
        Me.bAddCustomer.TabIndex = 11
        Me.bAddCustomer.Text = "הוסף לקוח"
        Me.bAddCustomer.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.bDeletePurchase)
        Me.Panel5.Controls.Add(Me.bAddPurchase)
        Me.Panel5.Location = New System.Drawing.Point(810, 483)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(157, 77)
        Me.Panel5.TabIndex = 10
        Me.Panel5.Visible = False
        '
        'bDeletePurchase
        '
        Me.bDeletePurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bDeletePurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bDeletePurchase.Location = New System.Drawing.Point(3, 41)
        Me.bDeletePurchase.Name = "bDeletePurchase"
        Me.bDeletePurchase.Size = New System.Drawing.Size(151, 32)
        Me.bDeletePurchase.TabIndex = 14
        Me.bDeletePurchase.Text = "מחק הזמנה"
        Me.bDeletePurchase.UseVisualStyleBackColor = False
        '
        'bAddPurchase
        '
        Me.bAddPurchase.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bAddPurchase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddPurchase.Location = New System.Drawing.Point(3, 3)
        Me.bAddPurchase.Name = "bAddPurchase"
        Me.bAddPurchase.Size = New System.Drawing.Size(151, 32)
        Me.bAddPurchase.TabIndex = 13
        Me.bAddPurchase.Text = "הוסף הזמנה"
        Me.bAddPurchase.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(792, 212)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cb_customer_area)
        Me.Panel6.Controls.Add(Me.bCustomersArea)
        Me.Panel6.Location = New System.Drawing.Point(12, 521)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(792, 39)
        Me.Panel6.TabIndex = 12
        Me.Panel6.Visible = False
        '
        'cb_customer_area
        '
        Me.cb_customer_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_customer_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cb_customer_area.FormattingEnabled = True
        Me.cb_customer_area.Location = New System.Drawing.Point(538, 4)
        Me.cb_customer_area.Name = "cb_customer_area"
        Me.cb_customer_area.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cb_customer_area.Size = New System.Drawing.Size(251, 32)
        Me.cb_customer_area.TabIndex = 20
        '
        'bCustomersArea
        '
        Me.bCustomersArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bCustomersArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bCustomersArea.Location = New System.Drawing.Point(462, 3)
        Me.bCustomersArea.Name = "bCustomersArea"
        Me.bCustomersArea.Size = New System.Drawing.Size(70, 32)
        Me.bCustomersArea.TabIndex = 15
        Me.bCustomersArea.Text = "הצג"
        Me.bCustomersArea.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(813, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.tb_date2)
        Me.Panel7.Controls.Add(Me.tb_date1)
        Me.Panel7.Controls.Add(Me.Label3)
        Me.Panel7.Controls.Add(Me.Label2)
        Me.Panel7.Controls.Add(Me.bPurchasesDate)
        Me.Panel7.Location = New System.Drawing.Point(12, 521)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(792, 39)
        Me.Panel7.TabIndex = 21
        Me.Panel7.Visible = False
        '
        'tb_date2
        '
        Me.tb_date2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_date2.Location = New System.Drawing.Point(304, 6)
        Me.tb_date2.Name = "tb_date2"
        Me.tb_date2.Size = New System.Drawing.Size(110, 29)
        Me.tb_date2.TabIndex = 19
        '
        'tb_date1
        '
        Me.tb_date1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_date1.Location = New System.Drawing.Point(492, 6)
        Me.tb_date1.Name = "tb_date1"
        Me.tb_date1.Size = New System.Drawing.Size(110, 29)
        Me.tb_date1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "לתאריך"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "הצג הזמנות בין תאריך"
        '
        'bPurchasesDate
        '
        Me.bPurchasesDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bPurchasesDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bPurchasesDate.Location = New System.Drawing.Point(227, 4)
        Me.bPurchasesDate.Name = "bPurchasesDate"
        Me.bPurchasesDate.Size = New System.Drawing.Size(71, 32)
        Me.bPurchasesDate.TabIndex = 15
        Me.bPurchasesDate.Text = "הצג"
        Me.bPurchasesDate.UseVisualStyleBackColor = False
        '
        'ShaharMarket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(975, 565)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.bPurchases)
        Me.Controls.Add(Me.bCustomers)
        Me.Controls.Add(Me.bDoubts)
        Me.Controls.Add(Me.bProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ShaharMarket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShaharMarket - By Shahar Zohar"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.MyDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bProducts As System.Windows.Forms.Button
    Friend WithEvents bDoubts As System.Windows.Forms.Button
    Friend WithEvents bCustomers As System.Windows.Forms.Button
    Friend WithEvents bPurchases As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MyDBDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents bDeleteProduct As System.Windows.Forms.Button
    Friend WithEvents bAddProduct As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents bDeleteDoubt As System.Windows.Forms.Button
    Friend WithEvents bAddDoubt As System.Windows.Forms.Button
    Friend WithEvents bExit As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents bDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents bAddCustomer As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents bDeletePurchase As System.Windows.Forms.Button
    Friend WithEvents bAddPurchase As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents bCustomersArea As System.Windows.Forms.Button
    Friend WithEvents cb_customer_area As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents tb_date2 As System.Windows.Forms.TextBox
    Friend WithEvents tb_date1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bPurchasesDate As System.Windows.Forms.Button

End Class
