<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ThemLoaiDaiLyFrm
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
        Me.TxbMaldl = New System.Windows.Forms.TextBox()
        Me.TxbTenldl = New System.Windows.Forms.TextBox()
        Me.TxbNoToiDa = New System.Windows.Forms.TextBox()
        Me.BtnNhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thêm Loại Đại Lý"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Loại Đại Lý :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tên Loại Đại Lý :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nợ Tối Đa :"
        '
        'TxbMaldl
        '
        Me.TxbMaldl.Location = New System.Drawing.Point(165, 83)
        Me.TxbMaldl.Name = "TxbMaldl"
        Me.TxbMaldl.Size = New System.Drawing.Size(249, 20)
        Me.TxbMaldl.TabIndex = 4
        '
        'TxbTenldl
        '
        Me.TxbTenldl.Location = New System.Drawing.Point(165, 117)
        Me.TxbTenldl.Name = "TxbTenldl"
        Me.TxbTenldl.Size = New System.Drawing.Size(249, 20)
        Me.TxbTenldl.TabIndex = 4
        '
        'TxbNoToiDa
        '
        Me.TxbNoToiDa.Location = New System.Drawing.Point(165, 153)
        Me.TxbNoToiDa.Name = "TxbNoToiDa"
        Me.TxbNoToiDa.Size = New System.Drawing.Size(249, 20)
        Me.TxbNoToiDa.TabIndex = 4
        '
        'BtnNhap
        '
        Me.BtnNhap.Location = New System.Drawing.Point(165, 208)
        Me.BtnNhap.Name = "BtnNhap"
        Me.BtnNhap.Size = New System.Drawing.Size(157, 56)
        Me.BtnNhap.TabIndex = 5
        Me.BtnNhap.Text = "Nhập"
        Me.BtnNhap.UseVisualStyleBackColor = True
        '
        'ThemLoaiDaiLyFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 312)
        Me.Controls.Add(Me.BtnNhap)
        Me.Controls.Add(Me.TxbNoToiDa)
        Me.Controls.Add(Me.TxbTenldl)
        Me.Controls.Add(Me.TxbMaldl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ThemLoaiDaiLyFrm"
        Me.Text = "ThemLoaiDaiLy"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxbMaldl As TextBox
    Friend WithEvents TxbTenldl As TextBox
    Friend WithEvents TxbNoToiDa As TextBox
    Friend WithEvents BtnNhap As Button
End Class
