Public Class HexadecimaltoDecimal
    Dim HexIn, DecOut As String
    Dim rate As New PublicFunction

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        HexIn = txtHexIn.Text
        DecOut = rate.Converting(HexIn, 16, 10)
        txtDecOut.Text = DecOut
    End Sub

    Private Sub HexadecimaltoDecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class