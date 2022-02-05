Public Class HexadecimaltoOctal
    Dim rate As New PublicFunction
    Dim hexin, octout As String
    Private Sub HexadecimaltoOctal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        hexin = txtHexIn.Text
        octout = rate.Converting(hexin, 16, 8)
        txtOctOut.Text = octout
    End Sub
End Class