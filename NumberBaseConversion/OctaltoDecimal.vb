Public Class OctaltoDecimal
    Dim OctIn, DecOut As String
    Dim rate = New PublicFunction
    Private Sub OctaltoDecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        OctIn = txtOctIn.Text
        DecOut = rate.Converting(OctIn, 8, 10)
        txtDecOut.Text = DecOut
    End Sub


End Class