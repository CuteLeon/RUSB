Module PublicMethod
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessageA Lib "user32" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, lParam As VariantType) As Integer

    Public bmp_Button_Small(2) As Bitmap
    Public bmp_Button_Big(2) As Bitmap
    Public bmp_Close(2) As Bitmap

    Public Sub MoveWindow(ByVal WinHandle As Integer)
        ReleaseCapture()
        SendMessageA(WinHandle, &HA1, 2, 0&)
    End Sub
End Module
