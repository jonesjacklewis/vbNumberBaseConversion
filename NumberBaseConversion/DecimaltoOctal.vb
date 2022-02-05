Public Class DecimaltoOctal
    Dim DecIn, OctOut As String
    Dim rate As New PublicFunction

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        DecIn = txtDecIn.Text
        OctOut = rate.Converting(DecIn, 10, 8)
        txtOctOut.Text = OctOut
    End Sub

    Private Sub DecimaltoOctal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class