<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HexadecimaltoDecimal
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
        Me.LblDec = New System.Windows.Forms.Label()
        Me.LblHex = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtDecOut = New System.Windows.Forms.TextBox()
        Me.txtHexIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblDec
        '
        Me.LblDec.AutoSize = True
        Me.LblDec.Location = New System.Drawing.Point(243, 327)
        Me.LblDec.Name = "LblDec"
        Me.LblDec.Size = New System.Drawing.Size(58, 17)
        Me.LblDec.TabIndex = 31
        Me.LblDec.Text = "Decimal"
        Me.LblDec.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Location = New System.Drawing.Point(243, 109)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(88, 17)
        Me.LblHex.TabIndex = 32
        Me.LblHex.Text = "Hexadecimal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(457, 212)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 30
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtDecOut
        '
        Me.txtDecOut.Location = New System.Drawing.Point(457, 322)
        Me.txtDecOut.Name = "txtDecOut"
        Me.txtDecOut.Size = New System.Drawing.Size(100, 22)
        Me.txtDecOut.TabIndex = 28
        '
        'txtHexIn
        '
        Me.txtHexIn.Location = New System.Drawing.Point(457, 106)
        Me.txtHexIn.Name = "txtHexIn"
        Me.txtHexIn.Size = New System.Drawing.Size(100, 22)
        Me.txtHexIn.TabIndex = 29
        '
        'HexadecimaltoDecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblDec)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtDecOut)
        Me.Controls.Add(Me.txtHexIn)
        Me.Name = "HexadecimaltoDecimal"
        Me.Text = "HexadecimaltoDecimal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDec As Label
    Friend WithEvents LblHex As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtDecOut As TextBox
    Friend WithEvents txtHexIn As TextBox
End Class
