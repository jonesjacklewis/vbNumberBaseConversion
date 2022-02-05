Public Class OctaltoHexadecimal
    Dim rate = New PublicFunction
    Dim OctIn, HexOut As String
    Dim Up = ""
    Private Sub OctaltoHexadecimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        OctIn = txtOctIn.Text
        HexOut = rate.Converting(OctIn, 8, 16)
        txtHexOut.Text = HexOut
    End Sub
End Class