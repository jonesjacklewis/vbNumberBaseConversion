Public Class MainMenu
    Private Sub OctalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OctalToolStripMenuItem1.Click
        BinarytoOctal.Show()
    End Sub

    Private Sub DecimalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DecimalToolStripMenuItem1.Click
        BinarytoDecimal.Show()
    End Sub

    Private Sub HexadecimalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HexadecimalToolStripMenuItem1.Click
        BinarytoHexadecimal.Show()
    End Sub

    Private Sub BinaryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BinaryToolStripMenuItem1.Click
        OctaltoBinary.Show()
    End Sub

    Private Sub DecimalToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DecimalToolStripMenuItem2.Click
        OctaltoDecimal.Show()
    End Sub

    Private Sub HexadecimalToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles HexadecimalToolStripMenuItem2.Click
        OctaltoHexadecimal.Show()
    End Sub

    Private Sub BinaryToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles BinaryToolStripMenuItem2.Click
        DecimaltoBinary.Show()
    End Sub

    Private Sub OctalToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OctalToolStripMenuItem2.Click
        DecimaltoOctal.Show()
    End Sub

    Private Sub HexadecimalToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles HexadecimalToolStripMenuItem3.Click
        DecimaltoHexadecimal.Show()
    End Sub

    Private Sub BinaryToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles BinaryToolStripMenuItem3.Click
        HexadecimaltoBinary.Show()
    End Sub

    Private Sub OctalToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles OctalToolStripMenuItem3.Click
        HexadecimaltoOctal.Show()
    End Sub

    Private Sub DecimalToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles DecimalToolStripMenuItem3.Click
        HexadecimaltoDecimal.Show()
    End Sub
End Class
