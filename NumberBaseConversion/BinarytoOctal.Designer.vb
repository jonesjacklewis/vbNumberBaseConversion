<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BinarytoOctal
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
        Me.txtBinIn = New System.Windows.Forms.TextBox()
        Me.txtOctOut = New System.Windows.Forms.TextBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.LblBinIn = New System.Windows.Forms.Label()
        Me.LblOctOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBinIn
        '
        Me.txtBinIn.Location = New System.Drawing.Point(337, 53)
        Me.txtBinIn.Name = "txtBinIn"
        Me.txtBinIn.Size = New System.Drawing.Size(100, 22)
        Me.txtBinIn.TabIndex = 0
        '
        'txtOctOut
        '
        Me.txtOctOut.Location = New System.Drawing.Point(337, 269)
        Me.txtOctOut.Name = "txtOctOut"
        Me.txtOctOut.Size = New System.Drawing.Size(100, 22)
        Me.txtOctOut.TabIndex = 0
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(337, 172)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(100, 23)
        Me.BtnConvert.TabIndex = 1
        Me.BtnConvert.Text = "Convert"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'LblBinIn
        '
        Me.LblBinIn.AutoSize = True
        Me.LblBinIn.Location = New System.Drawing.Point(142, 57)
        Me.LblBinIn.Name = "LblBinIn"
        Me.LblBinIn.Size = New System.Drawing.Size(48, 17)
        Me.LblBinIn.TabIndex = 2
        Me.LblBinIn.Text = "Binary"
        '
        'LblOctOut
        '
        Me.LblOctOut.AutoSize = True
        Me.LblOctOut.Location = New System.Drawing.Point(142, 274)
        Me.LblOctOut.Name = "LblOctOut"
        Me.LblOctOut.Size = New System.Drawing.Size(41, 17)
        Me.LblOctOut.TabIndex = 2
        Me.LblOctOut.Text = "Octal"
        '
        'BinarytoOctal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblOctOut)
        Me.Controls.Add(Me.LblBinIn)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.txtOctOut)
        Me.Controls.Add(Me.txtBinIn)
        Me.Name = "BinarytoOctal"
        Me.Text = "Binary to Octal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBinIn As TextBox
    Friend WithEvents txtOctOut As TextBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents LblBinIn As Label
    Friend WithEvents LblOctOut As Label
End Class
