<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkh
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
        Me.butok = New System.Windows.Forms.Button()
        Me.butcan = New System.Windows.Forms.Button()
        Me.makh = New System.Windows.Forms.Label()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.tenkh = New System.Windows.Forms.Label()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.diachi = New System.Windows.Forms.Label()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.sdt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'butok
        '
        Me.butok.Location = New System.Drawing.Point(42, 217)
        Me.butok.Name = "butok"
        Me.butok.Size = New System.Drawing.Size(75, 23)
        Me.butok.TabIndex = 0
        Me.butok.Text = "OK"
        Me.butok.UseVisualStyleBackColor = True
        '
        'butcan
        '
        Me.butcan.Location = New System.Drawing.Point(166, 217)
        Me.butcan.Name = "butcan"
        Me.butcan.Size = New System.Drawing.Size(75, 23)
        Me.butcan.TabIndex = 1
        Me.butcan.Text = "CanCel"
        Me.butcan.UseVisualStyleBackColor = True
        '
        'makh
        '
        Me.makh.AutoSize = True
        Me.makh.Location = New System.Drawing.Point(39, 28)
        Me.makh.Name = "makh"
        Me.makh.Size = New System.Drawing.Size(38, 13)
        Me.makh.TabIndex = 2
        Me.makh.Text = "MAKH"
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(141, 25)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(100, 20)
        Me.txtmakh.TabIndex = 3
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(141, 71)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(100, 20)
        Me.txttenkh.TabIndex = 5
        '
        'tenkh
        '
        Me.tenkh.AutoSize = True
        Me.tenkh.Location = New System.Drawing.Point(39, 74)
        Me.tenkh.Name = "tenkh"
        Me.tenkh.Size = New System.Drawing.Size(44, 13)
        Me.tenkh.TabIndex = 4
        Me.tenkh.Text = "TENKH"
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(141, 117)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(100, 20)
        Me.txtdiachi.TabIndex = 7
        '
        'diachi
        '
        Me.diachi.AutoSize = True
        Me.diachi.Location = New System.Drawing.Point(39, 120)
        Me.diachi.Name = "diachi"
        Me.diachi.Size = New System.Drawing.Size(43, 13)
        Me.diachi.TabIndex = 6
        Me.diachi.Text = "DIACHI"
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(141, 163)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(100, 20)
        Me.txtsdt.TabIndex = 9
        '
        'sdt
        '
        Me.sdt.AutoSize = True
        Me.sdt.Location = New System.Drawing.Point(39, 166)
        Me.sdt.Name = "sdt"
        Me.sdt.Size = New System.Drawing.Size(29, 13)
        Me.sdt.TabIndex = 8
        Me.sdt.Text = "SDT"
        '
        'frmkh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.sdt)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.diachi)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.tenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.makh)
        Me.Controls.Add(Me.butcan)
        Me.Controls.Add(Me.butok)
        Me.Name = "frmkh"
        Me.Text = "frmkh"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents butok As System.Windows.Forms.Button
    Friend WithEvents butcan As System.Windows.Forms.Button
    Friend WithEvents makh As System.Windows.Forms.Label
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents tenkh As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents diachi As System.Windows.Forms.Label
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents sdt As System.Windows.Forms.Label
End Class
