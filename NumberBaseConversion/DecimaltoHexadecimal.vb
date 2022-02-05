Public Class DecimaltoHexadecimal
    Dim rate As New PublicFunction
    Dim DecIn, HexOut As String

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        DecIn = txtDecIn.Text
        HexOut = rate.Converting(DecIn, 10, 16)
        txtHexOut.Text = HexOut
    End Sub

    Private Sub DecimaltoHexadecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class