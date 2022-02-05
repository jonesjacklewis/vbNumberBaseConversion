<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DecimaltoOctal
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
        Me.LblDec = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtOctOut = New System.Windows.Forms.TextBox()
        Me.txtDecIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblOct
        '
        Me.LblOct.AutoSize = True
        Me.LblOct.Location = New System.Drawing.Point(217, 297)
        Me.LblOct.Name = "LblOct"
        Me.LblOct.Size = New System.Drawing.Size(41, 17)
        Me.LblOct.TabIndex = 16
        Me.LblOct.Text = "Octal"
        '
        'LblDec
        '
        Me.LblDec.AutoSize = True
        Me.LblDec.Location = New System.Drawing.Point(217, 79)
        Me.LblDec.Name = "LblDec"
        Me.LblDec.Size = New System.Drawing.Size(58, 17)
        Me.LblDec.TabIndex = 17
        Me.LblDec.Text = "Decimal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(431, 182)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 15
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtOctOut
        '
        Me.txtOctOut.Location = New System.Drawing.Point(431, 292)
        Me.txtOctOut.Name = "txtOctOut"
        Me.txtOctOut.Size = New System.Drawing.Size(100, 22)
        Me.txtOctOut.TabIndex = 13
        '
        'txtDecIn
        '
        Me.txtDecIn.Location = New System.Drawing.Point(431, 76)
        Me.txtDecIn.Name = "txtDecIn"
        Me.txtDecIn.Size = New System.Drawing.Size(100, 22)
        Me.txtDecIn.TabIndex = 14
        '
        'DecimaltoOctal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblOct)
        Me.Controls.Add(Me.LblDec)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtOctOut)
        Me.Controls.Add(Me.txtDecIn)
        Me.Name = "DecimaltoOctal"
        Me.Text = "Decimal to Octal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblOct As Label
    Friend WithEvents LblDec As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtOctOut As TextBox
    Friend WithEvents txtDecIn As TextBox
End Class
