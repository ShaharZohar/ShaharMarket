<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Me.tb_customer_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bAddCustomer = New System.Windows.Forms.Button()
        Me.cb_customer_area = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_customer_name
        '
        Me.tb_customer_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_customer_name.Location = New System.Drawing.Point(12, 12)
        Me.tb_customer_name.Name = "tb_customer_name"
        Me.tb_customer_name.Size = New System.Drawing.Size(251, 29)
        Me.tb_customer_name.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "שם הלקוח:"
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bClose.Location = New System.Drawing.Point(297, 95)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(66, 32)
        Me.bClose.TabIndex = 13
        Me.bClose.Text = "<<<"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'bAddCustomer
        '
        Me.bAddCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddCustomer.Location = New System.Drawing.Point(140, 95)
        Me.bAddCustomer.Name = "bAddCustomer"
        Me.bAddCustomer.Size = New System.Drawing.Size(151, 32)
        Me.bAddCustomer.TabIndex = 12
        Me.bAddCustomer.Text = "הוסף לקוח"
        Me.bAddCustomer.UseVisualStyleBackColor = False
        '
        'cb_customer_area
        '
        Me.cb_customer_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_customer_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cb_customer_area.FormattingEnabled = True
        Me.cb_customer_area.Location = New System.Drawing.Point(12, 47)
        Me.cb_customer_area.Name = "cb_customer_area"
        Me.cb_customer_area.Size = New System.Drawing.Size(251, 32)
        Me.cb_customer_area.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 24)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "אזור:"
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(378, 144)
        Me.ControlBox = False
        Me.Controls.Add(Me.cb_customer_area)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tb_customer_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bAddCustomer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddCustomer"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת לקוח"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_customer_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents bAddCustomer As System.Windows.Forms.Button
    Friend WithEvents cb_customer_area As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
