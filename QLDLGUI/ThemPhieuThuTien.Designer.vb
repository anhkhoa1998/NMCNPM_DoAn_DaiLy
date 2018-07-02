<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThemPhieuThuTien
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxbMaPhieuThu = New System.Windows.Forms.TextBox()
        Me.TxbSoTienThu = New System.Windows.Forms.TextBox()
        Me.CbMaDaiLy = New System.Windows.Forms.ComboBox()
        Me.DtpNgayThuTien = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lập Phiếu Thu Tiền"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(114, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Phiếu Thu :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mã Đại Lý :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(114, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ngày Thu Tiền :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Số Tiền Thu :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(266, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 55)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Nhập"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxbMaPhieuThu
        '
        Me.TxbMaPhieuThu.Location = New System.Drawing.Point(266, 63)
        Me.TxbMaPhieuThu.Name = "TxbMaPhieuThu"
        Me.TxbMaPhieuThu.Size = New System.Drawing.Size(258, 20)
        Me.TxbMaPhieuThu.TabIndex = 3
        '
        'TxbSoTienThu
        '
        Me.TxbSoTienThu.Location = New System.Drawing.Point(266, 188)
        Me.TxbSoTienThu.Name = "TxbSoTienThu"
        Me.TxbSoTienThu.Size = New System.Drawing.Size(258, 20)
        Me.TxbSoTienThu.TabIndex = 3
        '
        'CbMaDaiLy
        '
        Me.CbMaDaiLy.FormattingEnabled = True
        Me.CbMaDaiLy.Location = New System.Drawing.Point(266, 106)
        Me.CbMaDaiLy.Name = "CbMaDaiLy"
        Me.CbMaDaiLy.Size = New System.Drawing.Size(121, 21)
        Me.CbMaDaiLy.TabIndex = 4
        '
        'DtpNgayThuTien
        '
        Me.DtpNgayThuTien.Location = New System.Drawing.Point(266, 145)
        Me.DtpNgayThuTien.Name = "DtpNgayThuTien"
        Me.DtpNgayThuTien.Size = New System.Drawing.Size(200, 20)
        Me.DtpNgayThuTien.TabIndex = 5
        '
        'ThemPhieuThuTien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 339)
        Me.Controls.Add(Me.DtpNgayThuTien)
        Me.Controls.Add(Me.CbMaDaiLy)
        Me.Controls.Add(Me.TxbSoTienThu)
        Me.Controls.Add(Me.TxbMaPhieuThu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemPhieuThuTien"
        Me.Text = "ThemPhieuThuTien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxbMaPhieuThu As TextBox
    Friend WithEvents TxbSoTienThu As TextBox
    Friend WithEvents CbMaDaiLy As ComboBox
    Friend WithEvents DtpNgayThuTien As DateTimePicker
End Class
