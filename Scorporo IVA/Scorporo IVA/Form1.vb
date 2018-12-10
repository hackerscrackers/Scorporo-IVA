' Programma creato da: hackerscrackers
' Data creazione: 06/12/2018
' 
'Il programma tiene conto solo delle prime cinque cifre dopo la virgola.
'
'Formula usata:
'               (100 * prezzo lordo) / 122 = risultato
'               prezzo lordo - risultato = iva scorporata
'               risultato + iva = prezzo lordo
'
'Es:            (100 * 17) /122 = 13,93442
'               17 - 13,93442 = 3,06558
'               13,93442 + 3,06558 = 17
'

Option Strict Off

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Exit Sub

        End If

        Try
            Dim _vfisso As String = 100
            Dim lordo As Object = TextBox1.Text
            Dim netto As Double = (_vfisso * lordo) / 122
            Dim d5 As String

            'i valori da 0 a 8 comprendono i primi due numeri decimali la virgola e i 5 numeri dopo la virgola.
            d5 = netto 'netto.Substring(0, 8)

            Dim formata As String = FormatNumber(netto, 5)
            'visualizza il prezzo netto (decimali + i primi 5 numeri dopo la virgola)
            TextBox2.Text = formata

            Dim Senzaiva As String = lordo - d5
            Dim formata1 As String = FormatNumber(Senzaiva, 5)
            TextBox3.Text = formata1



            Dim a As Double = TextBox2.Text
            Dim b As Double = TextBox3.Text

            'Dim c = CUInt(a) + CUInt(b)
            TextBox4.Text = a + b 'CUInt(a) + CUInt(b)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim result As Double = TextBox4.Text
        Dim StringFormat As String
        StringFormat = String.Format(result, "###'###'###.#####")
    End Sub
        
End Class
