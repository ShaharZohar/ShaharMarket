<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.bAddProduct = New System.Windows.Forms.Button()
        Me.bClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_product_name = New System.Windows.Forms.TextBox()
        Me.tb_product_cost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_product_amount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_product_doubt = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'bAddProduct
        '
        Me.bAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddProduct.Location = New System.Drawing.Point(138, 189)
        Me.bAddProduct.Name = "bAddProduct"
        Me.bAddProduct.Size = New System.Drawing.Size(151, 32)
        Me.bAddProduct.TabIndex = 8
        Me.bAddProduct.Text = "הוסף מוצר"
        Me.bAddProduct.UseVisualStyleBackColor = False
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bClose.Location = New System.Drawing.Point(295, 189)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(66, 32)
        Me.bClose.TabIndex = 9
        Me.bClose.Text = "<<<"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "שם המוצר:"
        '
        'tb_product_name
        '
        Me.tb_product_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_product_name.Location = New System.Drawing.Point(12, 26)
        Me.tb_product_name.Name = "tb_product_name"
        Me.tb_product_name.Size = New System.Drawing.Size(251, 29)
        Me.tb_product_name.TabIndex = 11
        '
        'tb_product_cost
        '
        Me.tb_product_cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_product_cost.Location = New System.Drawing.Point(164, 61)
        Me.tb_product_cost.Name = "tb_product_cost"
        Me.tb_product_cost.Size = New System.Drawing.Size(99, 29)
        Me.tb_product_cost.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(309, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "עלות:"
        '
        'tb_product_amount
        '
        Me.tb_product_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_product_amount.Location = New System.Drawing.Point(164, 96)
        Me.tb_product_amount.Name = "tb_product_amount"
        Me.tb_product_amount.Size = New System.Drawing.Size(99, 29)
        Me.tb_product_amount.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.Location = New System.Drawing.Point(309, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "כמות:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 24)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ספק:"
        '
        'cb_product_doubt
        '
        Me.cb_product_doubt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_product_doubt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cb_product_doubt.FormattingEnabled = True
        Me.cb_product_doubt.Location = New System.Drawing.Point(12, 131)
        Me.cb_product_doubt.Name = "cb_product_doubt"
        Me.cb_product_doubt.Size = New System.Drawing.Size(251, 32)
        Me.cb_product_doubt.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label5.Location = New System.Drawing.Point(118, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 24)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ש""ח"
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(373, 233)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_product_doubt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_product_amount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_product_cost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb_product_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bAddProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddProduct"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת מוצר"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bAddProduct As System.Windows.Forms.Button
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tb_product_name As System.Windows.Forms.TextBox
    Friend WithEvents tb_product_cost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_product_amount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cb_product_doubt As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
