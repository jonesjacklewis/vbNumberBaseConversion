Public Class OctaltoBinary
    Dim rate As New PublicFunction
    Dim OctIn, BinOut As String
    Private Sub OctaltoBinary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        OctIn = txtOctIn.Text
        BinOut = Rate.Converting(OctIn, 8, 2)
        txtBinOut.Text = BinOut
    End Sub

End Class