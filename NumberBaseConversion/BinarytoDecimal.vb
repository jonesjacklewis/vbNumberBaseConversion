Public Class BinarytoDecimal
    Dim rate As New PublicFunction
    Dim BinIn, DecOut As String
    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        BinIn = txtBinIn.Text
        DecOut = rate.Converting(BinIn, 2, 10)
        txtDecOut.Text = DecOut
    End Sub

    Private Sub BinarytoDecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class