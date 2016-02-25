<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QLKH
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
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.butedit = New System.Windows.Forms.Button()
        Me.BUTDELETE = New System.Windows.Forms.Button()
        Me.lblclass = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.sreach = New System.Windows.Forms.Button()
        Me.cmbclass = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView.MultiSelect = False
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(487, 279)
        Me.DataGridView.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(516, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'butedit
        '
        Me.butedit.Location = New System.Drawing.Point(516, 101)
        Me.butedit.Name = "butedit"
        Me.butedit.Size = New System.Drawing.Size(75, 23)
        Me.butedit.TabIndex = 2
        Me.butedit.Text = "Edit"
        Me.butedit.UseVisualStyleBackColor = True
        '
        'BUTDELETE
        '
        Me.BUTDELETE.Location = New System.Drawing.Point(516, 144)
        Me.BUTDELETE.Name = "BUTDELETE"
        Me.BUTDELETE.Size = New System.Drawing.Size(75, 23)
        Me.BUTDELETE.TabIndex = 3
        Me.BUTDELETE.Text = "Delete"
        Me.BUTDELETE.UseVisualStyleBackColor = True
        '
        'lblclass
        '
        Me.lblclass.AutoSize = True
        Me.lblclass.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblclass.Location = New System.Drawing.Point(12, 22)
        Me.lblclass.Name = "lblclass"
        Me.lblclass.Size = New System.Drawing.Size(32, 13)
        Me.lblclass.TabIndex = 4
        Me.lblclass.Text = "Class"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(185, 19)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(314, 20)
        Me.txtsearch.TabIndex = 5
        '
        'sreach
        '
        Me.sreach.Location = New System.Drawing.Point(516, 22)
        Me.sreach.Name = "sreach"
        Me.sreach.Size = New System.Drawing.Size(75, 23)
        Me.sreach.TabIndex = 6
        Me.sreach.Text = "Search"
        Me.sreach.UseVisualStyleBackColor = True
        '
        'cmbclass
        '
        Me.cmbclass.FormattingEnabled = True
        Me.cmbclass.Items.AddRange(New Object() {"MAKH", "TENKH"})
        Me.cmbclass.Location = New System.Drawing.Point(50, 18)
        Me.cmbclass.Name = "cmbclass"
        Me.cmbclass.Size = New System.Drawing.Size(121, 21)
        Me.cmbclass.TabIndex = 7
        '
        'QLKH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 338)
        Me.Controls.Add(Me.cmbclass)
        Me.Controls.Add(Me.sreach)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lblclass)
        Me.Controls.Add(Me.BUTDELETE)
        Me.Controls.Add(Me.butedit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView)
        Me.Name = "QLKH"
        Me.Text = "KhachHang"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents butedit As System.Windows.Forms.Button
    Friend WithEvents BUTDELETE As System.Windows.Forms.Button
    Friend WithEvents lblclass As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents sreach As System.Windows.Forms.Button
    Friend WithEvents cmbclass As System.Windows.Forms.ComboBox

End Class
