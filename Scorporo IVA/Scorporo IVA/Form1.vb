Option Strict Off

Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Exit Sub

        End If

        Try
            Dim _vfisso As String = 100
            Dim lordo As Object = TextBox1.Text
            Dim netto As String = (_vfisso * lordo) / 122
            Dim d5 As String

            'i valori da 0 a 8 comprendono i primi due numeri decimali la virgola e i 5 numeri dopo la virgola.
            d5 = netto 'netto.Substring(0, 8)

            Dim formata As String = FormatNumber(netto, 5)
            Dim op = formata.ToString
            'visualizza il prezzo netto (decimali + i primi 5 numeri dopo la virgola)
            TextBox2.Text = formata

            Dim Senzaiva As String = lordo - d5
            Dim formata1 As String = FormatNumber(Senzaiva, 5)
            Dim op1 = formata1.ToString
            TextBox3.Text = formata1



            Dim a = TextBox2.Text
            Dim b = TextBox3.Text

            Dim c = CInt(a) + CInt(b)
            TextBox4.Text = CInt(a) + CInt(b)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub


End Class
