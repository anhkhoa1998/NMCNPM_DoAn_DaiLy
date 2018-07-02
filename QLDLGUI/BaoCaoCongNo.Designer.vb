<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoCongNo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxbThang = New System.Windows.Forms.TextBox()
        Me.DgvCongNo = New System.Windows.Forms.DataGridView()
        Me.BtnCongNo = New System.Windows.Forms.Button()
        CType(Me.DgvCongNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Báo Cáo Công Nợ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng :"
        '
        'TxbThang
        '
        Me.TxbThang.Location = New System.Drawing.Point(220, 65)
        Me.TxbThang.Name = "TxbThang"
        Me.TxbThang.Size = New System.Drawing.Size(283, 20)
        Me.TxbThang.TabIndex = 2
        '
        'DgvCongNo
        '
        Me.DgvCongNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCongNo.Location = New System.Drawing.Point(119, 136)
        Me.DgvCongNo.Name = "DgvCongNo"
        Me.DgvCongNo.Size = New System.Drawing.Size(513, 225)
        Me.DgvCongNo.TabIndex = 3
        '
        'BtnCongNo
        '
        Me.BtnCongNo.Location = New System.Drawing.Point(509, 53)
        Me.BtnCongNo.Name = "BtnCongNo"
        Me.BtnCongNo.Size = New System.Drawing.Size(123, 43)
        Me.BtnCongNo.TabIndex = 4
        Me.BtnCongNo.Text = "Lấy Công Nợ"
        Me.BtnCongNo.UseVisualStyleBackColor = True
        '
        'BaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCongNo)
        Me.Controls.Add(Me.DgvCongNo)
        Me.Controls.Add(Me.TxbThang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BaoCaoCongNo"
        Me.Text = "BaoCaoCongNo"
        CType(Me.DgvCongNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbThang As TextBox
    Friend WithEvents DgvCongNo As DataGridView
    Friend WithEvents BtnCongNo As Button
End Class
