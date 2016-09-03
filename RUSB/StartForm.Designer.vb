<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.btn_Start = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Label()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Start
        '
        Me.btn_Start.BackColor = System.Drawing.Color.Transparent
        Me.btn_Start.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_Start.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Start.Image = Global.RUSB.My.Resources.PngResource.BigButton
        Me.btn_Start.Location = New System.Drawing.Point(68, 136)
        Me.btn_Start.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(185, 65)
        Me.btn_Start.TabIndex = 0
        Me.btn_Start.Text = "开始测试"
        Me.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.Image = Global.RUSB.My.Resources.PngResource.btn_close
        Me.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Close.Location = New System.Drawing.Point(281, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(39, 19)
        Me.btn_Close.TabIndex = 1
        '
        'Lbl_Info
        '
        Me.Lbl_Info.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.Lbl_Info.Location = New System.Drawing.Point(0, 218)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(320, 19)
        Me.Lbl_Info.TabIndex = 2
        Me.Lbl_Info.Text = "当你打开这个程序时，你的智商已经被侮辱了..."
        Me.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.RUSB.My.Resources.PngResource.StartBkg
        Me.ClientSize = New System.Drawing.Size(320, 240)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "开始测试："
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Start As Label
    Friend WithEvents btn_Close As Label
    Friend WithEvents Lbl_Info As Label
End Class
