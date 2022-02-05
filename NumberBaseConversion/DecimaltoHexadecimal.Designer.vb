<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DecimaltoHexadecimal
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
        Me.LblDec = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtHexOut = New System.Windows.Forms.TextBox()
        Me.txtDecIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblHex
        '
        Me.LblHex.AutoSize = True
        Me.LblHex.Location = New System.Drawing.Point(206, 291)
        Me.LblHex.Name = "LblHex"
        Me.LblHex.Size = New System.Drawing.Size(88, 17)
        Me.LblHex.TabIndex = 21
        Me.LblHex.Text = "Hexadecimal"
        '
        'LblDec
        '
        Me.LblDec.AutoSize = True
        Me.LblDec.Location = New System.Drawing.Point(206, 73)
        Me.LblDec.Name = "LblDec"
        Me.LblDec.Size = New System.Drawing.Size(58, 17)
        Me.LblDec.TabIndex = 22
        Me.LblDec.Text = "Decimal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(420, 176)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 20
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtHexOut
        '
        Me.txtHexOut.Location = New System.Drawing.Point(420, 286)
        Me.txtHexOut.Name = "txtHexOut"
        Me.txtHexOut.Size = New System.Drawing.Size(100, 22)
        Me.txtHexOut.TabIndex = 18
        '
        'txtDecIn
        '
        Me.txtDecIn.Location = New System.Drawing.Point(420, 70)
        Me.txtDecIn.Name = "txtDecIn"
        Me.txtDecIn.Size = New System.Drawing.Size(100, 22)
        Me.txtDecIn.TabIndex = 19
        '
        'DecimaltoHexadecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblHex)
        Me.Controls.Add(Me.LblDec)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtHexOut)
        Me.Controls.Add(Me.txtDecIn)
        Me.Name = "DecimaltoHexadecimal"
        Me.Text = "Decimal to Hexadecimal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHex As Label
    Friend WithEvents LblDec As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtHexOut As TextBox
    Friend WithEvents txtDecIn As TextBox
End Class
