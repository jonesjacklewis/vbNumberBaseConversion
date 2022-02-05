Public Class PublicFunction
    Public Function Converting(Input As String, i As Integer, j As Integer) As String
        If Input <> "" Then
            Return (Convert.ToString(Convert.ToInt32(Input, i), j)).ToUpper
        Else
            MsgBox("Must have an input")
            Exit Function
        End If
    End Function

End Class
