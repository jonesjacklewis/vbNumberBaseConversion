Public Class HexadecimaltoBinary
    Dim rate As New PublicFunction
    Dim HexIn, BinOut As String
    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        HexIn = txtHexIn.Text
        BinOut = rate.Converting(HexIn, 16, 2)
        txtBinOut.Text = BinOut
    End Sub
End Class