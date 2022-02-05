<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinarytoHexadecimal
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
        Me.LblBin = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtHexOut = New System.Windows.Forms.TextBox()
        Me.txtBinIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Location = New System.Drawing.Point(221, 298)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(88, 17)
        Me.LblHex.TabIndex = 11
        Me.LblHex.Text = "Hexadecimal"
        '
        'LblBin
        '
        Me.LblBin.AutoSize = True
        Me.LblBin.Location = New System.Drawing.Point(221, 80)
        Me.LblBin.Name = "LblBin"
        Me.LblBin.Size = New System.Drawing.Size(48, 17)
        Me.LblBin.TabIndex = 12
        Me.LblBin.Text = "Binary"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(435, 196)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 10
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtHexOut
        '
        Me.txtHexOut.Location = New System.Drawing.Point(435, 293)
        Me.txtHexOut.Name = "txtHexOut"
        Me.txtHexOut.Size = New System.Drawing.Size(100, 22)
        Me.txtHexOut.TabIndex = 8
        '
        'txtBinIn
        '
        Me.txtBinIn.Location = New System.Drawing.Point(435, 77)
        Me.txtBinIn.Name = "txtBinIn"
        Me.txtBinIn.Size = New System.Drawing.Size(100, 22)
        Me.txtBinIn.TabIndex = 9
        '
        'BinarytoHexadecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.LblBin)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtHexOut)
        Me.Controls.Add(Me.txtBinIn)
        Me.Name = "BinarytoHexadecimal"
        Me.Text = "Binary to Hexadecimal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHex As Label
    Friend WithEvents LblBin As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtHexOut As TextBox
    Friend WithEvents txtBinIn As TextBox
End Class
