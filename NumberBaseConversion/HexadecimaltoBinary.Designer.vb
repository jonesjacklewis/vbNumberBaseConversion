<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HexadecimaltoBinary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblBin = New System.Windows.Forms.Label()
        Me.LblHex = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtBinOut = New System.Windows.Forms.TextBox()
        Me.txtHexIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblBin
        '
        Me.LblBin.AutoSize = True
        Me.LblBin.Location = New System.Drawing.Point(211, 296)
        Me.LblBin.Name = "LblBin"
        Me.LblBin.Size = New System.Drawing.Size(48, 17)
        Me.LblBin.TabIndex = 26
        Me.LblBin.Text = "Binary"
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Location = New System.Drawing.Point(211, 78)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(88, 17)
        Me.LblHex.TabIndex = 27
        Me.LblHex.Text = "Hexadecimal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(425, 181)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 25
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtBinOut
        '
        Me.txtBinOut.Location = New System.Drawing.Point(425, 291)
        Me.txtBinOut.Name = "txtBinOut"
        Me.txtBinOut.Size = New System.Drawing.Size(100, 22)
        Me.txtBinOut.TabIndex = 23
        '
        'txtHexIn
        '
        Me.txtHexIn.Location = New System.Drawing.Point(425, 75)
        Me.txtHexIn.Name = "txtHexIn"
        Me.txtHexIn.Size = New System.Drawing.Size(100, 22)
        Me.txtHexIn.TabIndex = 24
        '
        'HexadecimaltoBinary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblBin)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtBinOut)
        Me.Controls.Add(Me.txtHexIn)
        Me.Name = "HexadecimaltoBinary"
        Me.Text = "Hexadecimal to Binary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBin As Label
    Friend WithEvents LblHex As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtBinOut As TextBox
    Friend WithEvents txtHexIn As TextBox
End Class
