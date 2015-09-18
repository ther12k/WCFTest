Imports System.ServiceModel

Public Class Form1
    Dim Host As ServiceHost
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = "Result :"
        Button1.Text = "Starting..."
        Button1.Enabled = False
        Host = New ServiceHost(GetType(ValidatorService))
        Host.Open()
        Button1.Text = "Start"
        Button2.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Text = "Stopping..."
        Button2.Enabled = False
        Host.Close()
        Button2.Text = "Stop"
        Button1.Enabled = True
    End Sub

    Public Sub SetLabel(ByVal text As String)
        Label1.Text = "Result :" + text
    End Sub

End Class
