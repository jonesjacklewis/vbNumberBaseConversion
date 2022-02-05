<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DecimaltoBinary
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
        Me.LblDec = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtBinOut = New System.Windows.Forms.TextBox()
        Me.txtDecIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblBin
        '
        Me.LblBin.AutoSize = True
        Me.LblBin.Location = New System.Drawing.Point(213, 283)
        Me.LblBin.Name = "LblBin"
        Me.LblBin.Size = New System.Drawing.Size(48, 17)
        Me.LblBin.TabIndex = 11
        Me.LblBin.Text = "Binary"
        '
        'LblDec
        '
        Me.LblDec.AutoSize = True
        Me.LblDec.Location = New System.Drawing.Point(213, 65)
        Me.LblDec.Name = "LblDec"
        Me.LblDec.Size = New System.Drawing.Size(58, 17)
        Me.LblDec.TabIndex = 12
        Me.LblDec.Text = "Decimal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(427, 168)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 10
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtBinOut
        '
        Me.txtBinOut.Location = New System.Drawing.Point(427, 278)
        Me.txtBinOut.Name = "txtBinOut"
        Me.txtBinOut.Size = New System.Drawing.Size(100, 22)
        Me.txtBinOut.TabIndex = 8
        '
        'txtDecIn
        '
        Me.txtDecIn.Location = New System.Drawing.Point(427, 62)
        Me.txtDecIn.Name = "txtDecIn"
        Me.txtDecIn.Size = New System.Drawing.Size(100, 22)
        Me.txtDecIn.TabIndex = 9
        '
        'DecimaltoBinary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblBin)
        Me.Controls.Add(Me.LblDec)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtBinOut)
        Me.Controls.Add(Me.txtDecIn)
        Me.Name = "DecimaltoBinary"
        Me.Text = "Decimal to Binary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBin As Label
    Friend WithEvents LblDec As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtBinOut As TextBox
    Friend WithEvents txtDecIn As TextBox
End Class
