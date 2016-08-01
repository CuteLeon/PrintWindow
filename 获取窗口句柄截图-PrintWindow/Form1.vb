Public Class Form1
    Private Declare Function PrintWindow Lib "user32" (ByVal hWnd As IntPtr, ByVal hdcBlt As Integer, ByVal nFlags As Integer) As Integer
    Private Declare Function GetWindowDC Lib "user32" Alias "GetWindowDC" (ByVal hWnd As IntPtr) As Integer
    Private Declare Function CreateCompatibleBitmap Lib "gdi32" Alias "CreateCompatibleBitmap" (ByVal hdc As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer
    Private Declare Function CreateCompatibleDC Lib "gdi32" Alias "CreateCompatibleDC" (ByVal hdc As Integer) As Integer
    Private Declare Function SelectObject Lib "gdi32" Alias "SelectObject" (ByVal hdc As Integer, ByVal hObject As Integer) As Integer
    Private Declare Function DeleteDC Lib "gdi32" Alias "DeleteDC" (ByVal hdc As Integer) As Integer

    Private Declare Function GetWindowRect Lib "user32" Alias "GetWindowRect" (ByVal hWnd As IntPtr, ByRef lpRect As RECT) As Integer
    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If HandleTextBox.Text = vbNullString Then Exit Sub
        Dim tempRect As RECT
        Dim hWnd As IntPtr = Convert.ToInt32(HandleTextBox.Text)
        Dim hscrdc As IntPtr = GetWindowDC(hWnd)
        GetWindowRect(hWnd, tempRect)
        Dim hbitmap As IntPtr = CreateCompatibleBitmap(hscrdc, tempRect.Right - tempRect.Left, tempRect.Bottom - tempRect.Top)
        Dim hmemdc As IntPtr = CreateCompatibleDC(hscrdc)
        SelectObject(hmemdc, hbitmap)
        PrintWindow(hWnd, hmemdc, 0)
        Dim bmp As Bitmap = Bitmap.FromHbitmap(hbitmap)
        DeleteDC(hbitmap)
        DeleteDC(hscrdc)
        DeleteDC(hmemdc)

        HandleImageBox.Image = bmp
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label1.Parent = HandleImageBox
        HandleTextBox.Text = Button1.Handle
    End Sub
End Class
