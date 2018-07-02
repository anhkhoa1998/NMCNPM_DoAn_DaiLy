<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThemDonViTinhFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxbMaDVT = New System.Windows.Forms.TextBox()
        Me.TxbTenDVT = New System.Windows.Forms.TextBox()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm Đơn Vị Tính"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Đơn Vị Tính :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Đơn Vị Tính :"
        '
        'TxbMaDVT
        '
        Me.TxbMaDVT.Location = New System.Drawing.Point(180, 82)
        Me.TxbMaDVT.Name = "TxbMaDVT"
        Me.TxbMaDVT.Size = New System.Drawing.Size(222, 20)
        Me.TxbMaDVT.TabIndex = 3
        '
        'TxbTenDVT
        '
        Me.TxbTenDVT.Location = New System.Drawing.Point(180, 133)
        Me.TxbTenDVT.Name = "TxbTenDVT"
        Me.TxbTenDVT.Size = New System.Drawing.Size(218, 20)
        Me.TxbTenDVT.TabIndex = 3
        '
        'BtnNhap
        '
        Me.BtnNhap.Location = New System.Drawing.Point(184, 219)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(119, 47)
        Me.BtnNhap.TabIndex = 4
        Me.BtnNhap.Text = "Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'ThemDonViTinhFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 312)
        Me.Controls.Add(Me.BtnNhap)
        Me.Controls.Add(Me.TxbTenDVT)
        Me.Controls.Add(Me.TxbMaDVT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemDonViTinhFrm"
        Me.Text = "ThemDonViTinhFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxbMaDVT As TextBox
    Friend WithEvents TxbTenDVT As TextBox
    Friend WithEvents BtnNhap As Button
End Class
