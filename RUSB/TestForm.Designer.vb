<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestForm))
        Me.btn_Right = New System.Windows.Forms.Label()
        Me.btn_Left = New System.Windows.Forms.Label()
        Me.btn_Close = New System.Windows.Forms.Label()
        Me.Lbl_Image = New System.Windows.Forms.Label()
        Me.Lbl_Info = New System.Windows.Forms.Label()
        Me.btn_OK = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Right
        '
        Me.btn_Right.BackColor = System.Drawing.Color.Transparent
        Me.btn_Right.Image = Global.RUSB.My.Resources.PngResource.button
        Me.btn_Right.Location = New System.Drawing.Point(270, 135)
        Me.btn_Right.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_Right.Name = "btn_Right"
        Me.btn_Right.Size = New System.Drawing.Size(80, 26)
        Me.btn_Right.TabIndex = 1
        Me.btn_Right.Text = "是！"
        Me.btn_Right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Left
        '
        Me.btn_Left.BackColor = System.Drawing.Color.Transparent
        Me.btn_Left.Image = Global.RUSB.My.Resources.PngResource.button
        Me.btn_Left.Location = New System.Drawing.Point(178, 135)
        Me.btn_Left.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_Left.Name = "btn_Left"
        Me.btn_Left.Size = New System.Drawing.Size(80, 26)
        Me.btn_Left.TabIndex = 2
        Me.btn_Left.Text = "不是"
        Me.btn_Left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.btn_Close.Image = Global.RUSB.My.Resources.PngResource.btn_close
        Me.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Close.Location = New System.Drawing.Point(315, 0)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(39, 19)
        Me.btn_Close.TabIndex = 3
        '
        'Lbl_Image
        '
        Me.Lbl_Image.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Image.Image = Global.RUSB.My.Resources.PngResource.msg_ques
        Me.Lbl_Image.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_Image.Location = New System.Drawing.Point(33, 55)
        Me.Lbl_Image.Name = "Lbl_Image"
        Me.Lbl_Image.Size = New System.Drawing.Size(42, 42)
        Me.Lbl_Image.TabIndex = 4
        Me.Lbl_Image.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lbl_Info
        '
        Me.Lbl_Info.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Info.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lbl_Info.Location = New System.Drawing.Point(81, 55)
        Me.Lbl_Info.Name = "Lbl_Info"
        Me.Lbl_Info.Size = New System.Drawing.Size(267, 42)
        Me.Lbl_Info.TabIndex = 5
        Me.Lbl_Info.Text = "你是傻逼吗？"
        Me.Lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_OK
        '
        Me.btn_OK.BackColor = System.Drawing.Color.Transparent
        Me.btn_OK.Image = Global.RUSB.My.Resources.PngResource.button
        Me.btn_OK.Location = New System.Drawing.Point(140, 135)
        Me.btn_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_OK.Name = "btn_OK"
        Me.btn_OK.Size = New System.Drawing.Size(80, 26)
        Me.btn_OK.TabIndex = 6
        Me.btn_OK.Text = "确定"
        Me.btn_OK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_OK.Visible = False
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Yellow
        Me.BackgroundImage = Global.RUSB.My.Resources.PngResource.TestBkg
        Me.ClientSize = New System.Drawing.Size(360, 165)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.btn_Left)
        Me.Controls.Add(Me.btn_Right)
        Me.Controls.Add(Me.btn_OK)
        Me.Controls.Add(Me.Lbl_Info)
        Me.Controls.Add(Me.Lbl_Image)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "你是傻逼吗？"
        Me.TransparencyKey = System.Drawing.Color.Yellow
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Right As Label
    Friend WithEvents btn_Left As Label
    Friend WithEvents btn_Close As Label
    Friend WithEvents Lbl_Image As Label
    Friend WithEvents Lbl_Info As Label
    Friend WithEvents btn_OK As Label
End Class
