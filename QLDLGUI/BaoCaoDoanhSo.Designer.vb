<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoDoanhSo
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DgvBaoCao = New System.Windows.Forms.DataGridView()
        CType(Me.DgvBaoCao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Báo Cáo Doanh Số"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tháng :"
        '
        'TxbThang
        '
        Me.TxbThang.Location = New System.Drawing.Point(212, 63)
        Me.TxbThang.Name = "TxbThang"
        Me.TxbThang.Size = New System.Drawing.Size(109, 20)
        Me.TxbThang.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lấy Doanh Số"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DgvBaoCao
        '
        Me.DgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBaoCao.Location = New System.Drawing.Point(71, 114)
        Me.DgvBaoCao.Name = "DgvBaoCao"
        Me.DgvBaoCao.Size = New System.Drawing.Size(477, 203)
        Me.DgvBaoCao.TabIndex = 3
        '
        'BaoCaoDoanhSo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 450)
        Me.Controls.Add(Me.DgvBaoCao)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxbThang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BaoCaoDoanhSo"
        Me.Text = "BaoCaoDoanhSo"
        CType(Me.DgvBaoCao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxbThang As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DgvBaoCao As DataGridView
End Class
