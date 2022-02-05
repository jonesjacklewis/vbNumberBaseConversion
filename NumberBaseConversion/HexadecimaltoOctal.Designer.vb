<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HexadecimaltoOctal
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
        Me.LblOct = New System.Windows.Forms.Label()
        Me.LblHex = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtOctOut = New System.Windows.Forms.TextBox()
        Me.txtHexIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblOct
        '
        Me.LblOct.AutoSize = True
        Me.LblOct.Location = New System.Drawing.Point(211, 291)
        Me.LblOct.Name = "LblOct"
        Me.LblOct.Size = New System.Drawing.Size(41, 17)
        Me.LblOct.TabIndex = 31
        Me.LblOct.Text = "Octal"
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Location = New System.Drawing.Point(211, 73)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(88, 17)
        Me.LblHex.TabIndex = 32
        Me.LblHex.Text = "Hexadecimal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(425, 176)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 30
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtOctOut
        '
        Me.txtOctOut.Location = New System.Drawing.Point(425, 286)
        Me.txtOctOut.Name = "txtOctOut"
        Me.txtOctOut.Size = New System.Drawing.Size(100, 22)
        Me.txtOctOut.TabIndex = 28
        '
        'txtHexIn
        '
        Me.txtHexIn.Location = New System.Drawing.Point(425, 70)
        Me.txtHexIn.Name = "txtHexIn"
        Me.txtHexIn.Size = New System.Drawing.Size(100, 22)
        Me.txtHexIn.TabIndex = 29
        '
        'HexadecimaltoOctal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblOct)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtOctOut)
        Me.Controls.Add(Me.txtHexIn)
        Me.Name = "HexadecimaltoOctal"
        Me.Text = "Hexadecimal to Octal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblOct As Label
    Friend WithEvents LblHex As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtOctOut As TextBox
    Friend WithEvents txtHexIn As TextBox
End Class
