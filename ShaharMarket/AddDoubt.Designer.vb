<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDoubt
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
        Me.tb_doubt_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bClose = New System.Windows.Forms.Button()
        Me.bAddProduct = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_doubt_name
        '
        Me.tb_doubt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tb_doubt_name.Location = New System.Drawing.Point(12, 12)
        Me.tb_doubt_name.Name = "tb_doubt_name"
        Me.tb_doubt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tb_doubt_name.Size = New System.Drawing.Size(251, 29)
        Me.tb_doubt_name.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "שם הספק:"
        '
        'bClose
        '
        Me.bClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bClose.Location = New System.Drawing.Point(291, 56)
        Me.bClose.Name = "bClose"
        Me.bClose.Size = New System.Drawing.Size(66, 32)
        Me.bClose.TabIndex = 13
        Me.bClose.Text = "<<<"
        Me.bClose.UseVisualStyleBackColor = False
        '
        'bAddProduct
        '
        Me.bAddProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bAddProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.bAddProduct.Location = New System.Drawing.Point(134, 56)
        Me.bAddProduct.Name = "bAddProduct"
        Me.bAddProduct.Size = New System.Drawing.Size(151, 32)
        Me.bAddProduct.TabIndex = 12
        Me.bAddProduct.Text = "הוסף ספק"
        Me.bAddProduct.UseVisualStyleBackColor = False
        '
        'AddDoubt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(369, 98)
        Me.ControlBox = False
        Me.Controls.Add(Me.tb_doubt_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bClose)
        Me.Controls.Add(Me.bAddProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "AddDoubt"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "הוספת ספק"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_doubt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bClose As System.Windows.Forms.Button
    Friend WithEvents bAddProduct As System.Windows.Forms.Button
End Class
