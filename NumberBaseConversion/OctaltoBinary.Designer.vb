<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OctaltoBinary
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
        Me.LblOct = New System.Windows.Forms.Label()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.txtBinOut = New System.Windows.Forms.TextBox()
        Me.txtOctIn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblBin
        '
        Me.LblBin.AutoSize = True
        Me.LblBin.Location = New System.Drawing.Point(213, 284)
        Me.LblBin.Name = "LblBin"
        Me.LblBin.Size = New System.Drawing.Size(48, 17)
        Me.LblBin.TabIndex = 6
        Me.LblBin.Text = "Binary"
        '
        'LblOct
        '
        Me.LblOct.AutoSize = True
        Me.LblOct.Location = New System.Drawing.Point(213, 67)
        Me.LblOct.Name = "LblOct"
        Me.LblOct.Size = New System.Drawing.Size(41, 17)
        Me.LblOct.TabIndex = 7
        Me.LblOct.Text = "Octal"
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(408, 182)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 5
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'txtBinOut
        '
        Me.txtBinOut.Location = New System.Drawing.Point(408, 279)
        Me.txtBinOut.Name = "txtBinOut"
        Me.txtBinOut.Size = New System.Drawing.Size(100, 22)
        Me.txtBinOut.TabIndex = 3
        '
        'txtOctIn
        '
        Me.txtOctIn.Location = New System.Drawing.Point(408, 63)
        Me.txtOctIn.Name = "txtOctIn"
        Me.txtOctIn.Size = New System.Drawing.Size(100, 22)
        Me.txtOctIn.TabIndex = 4
        '
        'OctaltoBinary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblBin)
        Me.Controls.Add(Me.LblOct)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtBinOut)
        Me.Controls.Add(Me.txtOctIn)
        Me.Name = "OctaltoBinary"
        Me.Text = "Octal to Binary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBin As Label
    Friend WithEvents LblOct As Label
    Friend WithEvents BtnConvert As Button
    Friend WithEvents txtBinOut As TextBox
    Friend WithEvents txtOctIn As TextBox
End Class
