Public Class BinarytoOctal
    Dim BinIn, OctOut As String
    Dim rate As New PublicFunction

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        BinIn = txtBinIn.Text
        OctOut = rate.Converting(BinIn, 2, 8)
        txtOctOut.Text = OctOut
    End Sub

    Private Sub BinarytoOctal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class