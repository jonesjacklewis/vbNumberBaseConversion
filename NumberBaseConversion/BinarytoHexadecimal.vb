Public Class BinarytoHexadecimal
    Dim rate As New PublicFunction
    Dim BinIn, HexOut As String
    Private Sub BinarytoHexadecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        BinIn = txtBinIn.Text
        HexOut = Rate.Converting(BinIn, 2, 16)
        txtHexOut.Text = HexOut
    End Sub


End Class