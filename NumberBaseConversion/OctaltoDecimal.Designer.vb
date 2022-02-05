<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OctaltoDecimal
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
        Me.LblOct = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtDecOut = New System.Windows.Forms.TextBox()
        Me.txtOctIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblDec
        '
        Me.LblDec.AutoSize = True
        Me.LblDec.Location = New System.Drawing.Point(233, 283)
        Me.LblDec.Name = "LblDec"
        Me.LblDec.Size = New System.Drawing.Size(58, 17)
        Me.LblDec.TabIndex = 11
        Me.LblDec.Text = "Decimal"
        '
        'LblOct
        '
        Me.LblOct.AutoSize = True
        Me.LblOct.Location = New System.Drawing.Point(233, 66)
        Me.LblOct.Name = "LblOct"
        Me.LblOct.Size = New System.Drawing.Size(41, 17)
        Me.LblOct.TabIndex = 12
        Me.LblOct.Text = "Octal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(428, 181)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 10
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtDecOut
        '
        Me.txtDecOut.Location = New System.Drawing.Point(428, 278)
        Me.txtDecOut.Name = "txtDecOut"
        Me.txtDecOut.Size = New System.Drawing.Size(100, 22)
        Me.txtDecOut.TabIndex = 8
        '
        'txtOctIn
        '
        Me.txtOctIn.Location = New System.Drawing.Point(428, 62)
        Me.txtOctIn.Name = "txtOctIn"
        Me.txtOctIn.Size = New System.Drawing.Size(100, 22)
        Me.txtOctIn.TabIndex = 9
        '
        'OctaltoDecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblDec)
        Me.Controls.Add(Me.LblOct)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtDecOut)
        Me.Controls.Add(Me.txtOctIn)
        Me.Name = "OctaltoDecimal"
        Me.Text = "Octal to Decimal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDec As Label
    Friend WithEvents LblOct As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtDecOut As TextBox
    Friend WithEvents txtOctIn As TextBox
End Class
