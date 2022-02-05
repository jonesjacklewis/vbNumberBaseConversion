<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OctaltoHexadecimal
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
        Me.LblHex = New System.Windows.Forms.Label()
        Me.LblOct = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtHexOut = New System.Windows.Forms.TextBox()
        Me.txtOctIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Location = New System.Drawing.Point(210, 300)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(88, 17)
        Me.LblHex.TabIndex = 16
        Me.LblHex.Text = "Hexadecimal"
        '
        'LblOct
        '
        Me.LblOct.AutoSize = True
        Me.LblOct.Location = New System.Drawing.Point(210, 83)
        Me.LblOct.Name = "LblOct"
        Me.LblOct.Size = New System.Drawing.Size(41, 17)
        Me.LblOct.TabIndex = 17
        Me.LblOct.Text = "Octal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(405, 198)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 15
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtHexOut
        '
        Me.txtHexOut.Location = New System.Drawing.Point(405, 295)
        Me.txtHexOut.Name = "txtHexOut"
        Me.txtHexOut.Size = New System.Drawing.Size(100, 22)
        Me.txtHexOut.TabIndex = 13
        '
        'txtOctIn
        '
        Me.txtOctIn.Location = New System.Drawing.Point(405, 79)
        Me.txtOctIn.Name = "txtOctIn"
        Me.txtOctIn.Size = New System.Drawing.Size(100, 22)
        Me.txtOctIn.TabIndex = 14
        '
        'OctaltoHexadecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.LblOct)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtHexOut)
        Me.Controls.Add(Me.txtOctIn)
        Me.Name = "OctaltoHexadecimal"
        Me.Text = "Octal to Hexadecimal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHex As Label
    Friend WithEvents LblOct As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtHexOut As TextBox
    Friend WithEvents txtOctIn As TextBox
End Class
