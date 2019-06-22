Imports System
Imports System.Text
Imports System.Security.Cryptography

Public Class frmRecuperar
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        'se envia email ade advertencia
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        'Dim att As New System.Net.Mail.Attachment("C:\Users\QUISPE\Source\Repos\Comercialidar\Presentacion\bin\Debug\123456.txt") ', System.Net.Mime.TransferEncoding.Base64
        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential("comercialidar@gmail.com", "comercialidar123456789")
        _SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = 465
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(txtEmail.Text) 'Para quién se lo envio.
        _Message.From = New System.Net.Mail.MailAddress("comercialidar@gmail.com", "", System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = "Recuperacion de contraseña"
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = "Hola"
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        '_Message.Attachments.Add(att)
        _Message.IsBodyHtml = False

        'ENVIO
        Try
            '_SMTP.Send(_Message)
            _SMTP.SendMailAsync(_Message)
            '_SMTP.SendAsync(_Message, _Message.To)
            MsgBox("Se ha Enviado el Email", MsgBoxStyle.Information, "EMail Enviado")
            Me.Hide()
            Dim frmaccesso As New frmAcceso
            frmaccesso.ShowDialog()
        Catch ex As Exception
            MsgBox("no se envio")
        End Try
    End Sub

    Function generarClave(ByVal cadena As String) As String
        Dim enc As New UTF8Encoding
        Dim data() As Byte = enc.GetBytes(cadena)
        Dim result() As Byte
        Dim sha As New SHA1CryptoServiceProvider

        result = sha.ComputeHash(data)

        Dim sb As New StringBuilder
        Dim max As Int32 = result.Length

        For i As Integer = 0 To max - 1
            'Convertimos los valores en hexadecimal
            'cuando tiene una cifra hay que rellenarlo con cero
            'para que siempre ocupen dos dígitos.
            If (result(i) < 16) Then
                sb.Append("0")
            End If

            sb.Append(result(i).ToString("x"))
        Next
        'Devolvemos la cadena con el hash :)
        generarClave = sb.ToString()

    End Function

    Private Sub frmRecuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class