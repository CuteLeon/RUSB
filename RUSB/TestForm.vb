Imports System.ComponentModel
Imports System.Threading

Public Class TestForm
    Dim MoveStep As Integer = 15
    Dim Move_ing As Boolean

    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False '允许多线访问UI
        btn_Left.Image = bmp_Button_Small(0)
        btn_Right.Image = bmp_Button_Small(0)
        btn_Close.Image = bmp_Close(0)
    End Sub

    Private Sub MoveButton(ByVal Btn As Label)
        Move_ing = True
        For StepCount As Int16 = 0 To 3
            Btn.Top -= MoveStep
            Threading.Thread.Sleep(20)
        Next
        MoveStep *= -1
        Move_ing = False
    End Sub


    Private Sub TestForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, Lbl_Image.MouseDown, Lbl_Info.MouseDown
        MoveWindow(Me.Handle)
    End Sub

    Private Sub btn_MouseEnter(sender As Object, e As EventArgs) Handles btn_Left.MouseEnter, btn_Right.MouseEnter, btn_OK.MouseEnter
        CType(sender, Label).Image = bmp_Button_Small(1)

        If (Not Move_ing And CType(sender, Label).Text = "不是") Then
            If (MoveStep < 0) Then
                ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf MoveButton), CType(sender, Label))
            Else
                If (VBMath.Rnd > 0.5) Then
                    ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf MoveButton), CType(sender, Label))
                Else
                    If CType(sender, Label) Is btn_Left Then
                        btn_Left.Text = "是！"
                        btn_Right.Text = "不是"
                    Else
                        btn_Left.Text = "不是"
                        btn_Right.Text = "是！"
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_MouseLeave(sender As Object, e As EventArgs) Handles btn_Left.MouseLeave, btn_Right.MouseLeave, btn_OK.MouseLeave
        CType(sender, Label).Image = bmp_Button_Small(0)
    End Sub

    Private Sub btn_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Left.MouseUp, btn_Right.MouseUp, btn_OK.MouseUp
        CType(sender, Label).Image = bmp_Button_Small(1)
        If (CType(sender, Label).Text = "确定") Then
            If Me.Tag = 1 Then Me.Close()

            Lbl_Image.Image = My.Resources.PngResource.msg_ques
            Lbl_Info.Text = "你是傻逼吗？"
            btn_Left.Visible = True
            btn_Right.Visible = True
            btn_OK.Visible = False
            btn_Close.Visible = True
        ElseIf (CType(sender, Label).Text = "是！") Then
            Lbl_Image.Image = My.Resources.PngResource.msg_info
            Beep()
            Lbl_Info.Text = "人贵有自知之明，承认就好！"
            btn_Left.Visible = False
            btn_Right.Visible = False
            btn_OK.Visible = True
            btn_Close.Visible = False

            Me.Tag = 1
        End If
    End Sub

    Private Sub btn_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Left.MouseDown, btn_Right.MouseDown， btn_OK.MouseDown
        CType(sender, Label).Image = bmp_Button_Small(2)
    End Sub

    Private Sub btn_Close_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Close.MouseDown
        btn_Close.Image = bmp_Close(2)
    End Sub

    Private Sub btn_Close_MouseEnter(sender As Object, e As EventArgs) Handles btn_Close.MouseEnter
        btn_Close.Image = bmp_Close(1)
    End Sub

    Private Sub btn_Close_MouseLeave(sender As Object, e As EventArgs) Handles btn_Close.MouseLeave
        btn_Close.Image = bmp_Close(0)
    End Sub

    Private Sub btn_Close_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Close.MouseUp
        btn_Close.Image = bmp_Close(1)
        NoClose()
    End Sub

    Private Sub NoClose()
        Lbl_Image.Image = My.Resources.PngResource.msg_error
        Lbl_Info.Text = "就算关掉我也不能改变你是傻逼的事实！"
        Beep()
        btn_Left.Visible = False
        btn_Right.Visible = False
        btn_OK.Visible = True
        btn_Close.Visible = False
    End Sub

    Private Sub TestForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Me.Tag = 0 Then
            e.Cancel = True
            NoClose()
        Else
            StartForm.Enabled = True
        End If
    End Sub

End Class