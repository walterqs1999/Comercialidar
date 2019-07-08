Public Class frmPresentacion
    Dim porciento
    Public frmLogin As New frmLogin()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(3)

        porciento = ProgressBar1.Value

        Label1.Text = porciento


        If porciento = 100 Then
            frmLogin.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class
