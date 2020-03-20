Imports System.Runtime.InteropServices

Public Class Form1

    Private Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> lParam As String) As Int32
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SendMessage(TextBox1.Handle, EM_SETCUEBANNER, 0, "Username")
        SendMessage(TextBox2.Handle, EM_SETCUEBANNER, 0, "Password")

    End Sub
End Class
