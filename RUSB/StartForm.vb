Public Class StartForm
    Dim Played As Boolean

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bmp_Button_Big(0) = My.Resources.PngResource.BigButton.Clone(New Rectangle(0, 0, 185, 65), Imaging.PixelFormat.Format32bppArgb)
        bmp_Button_Big(1) = My.Resources.PngResource.BigButton.Clone(New Rectangle(185, 0, 185, 65), Imaging.PixelFormat.Format32bppArgb)
        bmp_Button_Big(2) = My.Resources.PngResource.BigButton.Clone(New Rectangle(370, 0, 185, 65), Imaging.PixelFormat.Format32bppArgb)
        btn_Start.Image = bmp_Button_Big(0)

        bmp_Button_Small(0) = My.Resources.PngResource.button.Clone(New Rectangle(0, 0, 80, 26), Imaging.PixelFormat.Format32bppArgb)
        bmp_Button_Small(1) = My.Resources.PngResource.button.Clone(New Rectangle(80, 0, 80, 26), Imaging.PixelFormat.Format32bppArgb)
        bmp_Button_Small(2) = My.Resources.PngResource.button.Clone(New Rectangle(160, 0, 80, 26), Imaging.PixelFormat.Format32bppArgb)

        bmp_Close(0) = My.Resources.PngResource.btn_close.Clone(New Rectangle(0, 0, 39, 19), Imaging.PixelFormat.Format32bppArgb)
        bmp_Close(1) = My.Resources.PngResource.btn_close.Clone(New Rectangle(39, 0, 39, 19), Imaging.PixelFormat.Format32bppArgb)
        bmp_Close(2) = My.Resources.PngResource.btn_close.Clone(New Rectangle(78, 0, 39, 19), Imaging.PixelFormat.Format32bppArgb)
        btn_Close.Image = bmp_Close(0)
    End Sub

    Private Sub StartForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        MoveWindow(Me.Handle)
    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        Played = True
        TestForm.Show(Me)
        TestForm.Tag = 0
        Me.Enabled = False
    End Sub

    Private Sub btn_Start_MouseEnter(sender As Object, e As EventArgs) Handles btn_Start.MouseEnter
        btn_Start.Image = bmp_Button_Big(1)
    End Sub

    Private Sub btn_Start_MouseLeave(sender As Object, e As EventArgs) Handles btn_Start.MouseLeave
        btn_Start.Image = bmp_Button_Big(0)
    End Sub

    Private Sub btn_Start_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_Start.MouseUp
        btn_Start.Image = bmp_Button_Big(1)
    End Sub

    Private Sub btn_Start_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_Start.MouseDown
        btn_Start.Image = bmp_Button_Big(2)
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
        If Not Played Then
            TestForm.Show(Me)
            TestForm.Tag = 1
            Me.Enabled = False
            Beep()
            TestForm.Lbl_Image.Image = My.Resources.PngResource.msg_info
            TestForm.Lbl_Info.Text = "来都来了，测试一下再走吧！"
            TestForm.btn_Left.Visible = False
            TestForm.btn_Right.Visible = False
            TestForm.btn_OK.Visible = True
            TestForm.btn_Close.Visible = False
        Else
            TestForm.Dispose()
            Me.Close()
            Me.Dispose()
            End
        End If

    End Sub

End Class
