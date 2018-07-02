<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThemPhieuXuatFrm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxbMaPhieuXuat = New System.Windows.Forms.TextBox()
        Me.TxbTongTriGia = New System.Windows.Forms.TextBox()
        Me.CbMaDL = New System.Windows.Forms.ComboBox()
        Me.DtpNgayTiepNhan = New System.Windows.Forms.DateTimePicker()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm Phiếu Xuất"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Phiếu Xuất :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(125, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã Đại Lý :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(125, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tổng Trị Giá :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(125, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Ngày Lập Phiếu :"
        '
        'TxbMaPhieuXuat
        '
        Me.TxbMaPhieuXuat.Location = New System.Drawing.Point(252, 65)
        Me.TxbMaPhieuXuat.Name = "TxbMaPhieuXuat"
        Me.TxbMaPhieuXuat.Size = New System.Drawing.Size(233, 20)
        Me.TxbMaPhieuXuat.TabIndex = 2
        '
        'TxbTongTriGia
        '
        Me.TxbTongTriGia.Location = New System.Drawing.Point(252, 171)
        Me.TxbTongTriGia.Name = "TxbTongTriGia"
        Me.TxbTongTriGia.Size = New System.Drawing.Size(233, 20)
        Me.TxbTongTriGia.TabIndex = 2
        '
        'CbMaDL
        '
        Me.CbMaDL.FormattingEnabled = True
        Me.CbMaDL.Location = New System.Drawing.Point(252, 99)
        Me.CbMaDL.Name = "CbMaDL"
        Me.CbMaDL.Size = New System.Drawing.Size(121, 21)
        Me.CbMaDL.TabIndex = 3
        '
        'DtpNgayTiepNhan
        '
        Me.DtpNgayTiepNhan.Location = New System.Drawing.Point(252, 139)
        Me.DtpNgayTiepNhan.Name = "DtpNgayTiepNhan"
        Me.DtpNgayTiepNhan.Size = New System.Drawing.Size(200, 20)
        Me.DtpNgayTiepNhan.TabIndex = 4
        '
        'BtnNhap
        '
        Me.BtnNhap.Location = New System.Drawing.Point(250, 225)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(145, 55)
        Me.BtnNhap.TabIndex = 5
        Me.BtnNhap.Text = "Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'ThemPhieuXuatFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 332)
        Me.Controls.Add(Me.BtnNhap)
        Me.Controls.Add(Me.DtpNgayTiepNhan)
        Me.Controls.Add(Me.CbMaDL)
        Me.Controls.Add(Me.TxbTongTriGia)
        Me.Controls.Add(Me.TxbMaPhieuXuat)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemPhieuXuatFrm"
        Me.Text = "Thêm Phiếu Xuất"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxbMaPhieuXuat As TextBox
    Friend WithEvents TxbTongTriGia As TextBox
    Friend WithEvents CbMaDL As ComboBox
    Friend WithEvents DtpNgayTiepNhan As DateTimePicker
    Friend WithEvents BtnNhap As Button
End Class
