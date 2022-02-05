Public Class DecimaltoBinary
    Dim rate As New PublicFunction
    Dim DecIn, BinOut As String

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        DecIn = txtDecIn.Text
        BinOut = rate.Converting(DecIn, 10, 2)
        txtBinOut.Text = BinOut
    End Sub

    Private Sub DecimaltoBinary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class