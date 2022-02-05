<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinarytoDecimal
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
        Me.LblBin = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtDecOut = New System.Windows.Forms.TextBox()
        Me.txtBinIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblDec
        '
        Me.LblDec.AutoSize = True
        Me.LblDec.Location = New System.Drawing.Point(208, 298)
        Me.LblDec.Name = "LblDec"
        Me.LblDec.Size = New System.Drawing.Size(58, 17)
        Me.LblDec.TabIndex = 6
        Me.LblDec.Text = "Decimal"
        '
        'LblBin
        '
        Me.LblBin.AutoSize = True
        Me.LblBin.Location = New System.Drawing.Point(208, 80)
        Me.LblBin.Name = "LblBin"
        Me.LblBin.Size = New System.Drawing.Size(48, 17)
        Me.LblBin.TabIndex = 7
        Me.LblBin.Text = "Binary"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(422, 196)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 5
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtDecOut
        '
        Me.txtDecOut.Location = New System.Drawing.Point(422, 293)
        Me.txtDecOut.Name = "txtDecOut"
        Me.txtDecOut.Size = New System.Drawing.Size(100, 22)
        Me.txtDecOut.TabIndex = 3
        '
        'txtBinIn
        '
        Me.txtBinIn.Location = New System.Drawing.Point(422, 77)
        Me.txtBinIn.Name = "txtBinIn"
        Me.txtBinIn.Size = New System.Drawing.Size(100, 22)
        Me.txtBinIn.TabIndex = 4
        '
        'BinarytoDecimal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblDec)
        Me.Controls.Add(Me.LblBin)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtDecOut)
        Me.Controls.Add(Me.txtBinIn)
        Me.Name = "BinarytoDecimal"
        Me.Text = "Binary to Decimal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblDec As Label
    Friend WithEvents LblBin As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtDecOut As TextBox
    Friend WithEvents txtBinIn As TextBox
End Class
