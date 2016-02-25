Public Class QLKH

    'khai bao bien de truy xuat
    Private _DBAccess As New DataBaseAccess
    'dinh nghia thu tuc load du lieu
    Private Sub loaddataongridview()
        Dim sqlquery As String = "SELECT * FROM dbo.KhachHang"
        Dim dTtable As DataTable = _DBAccess.GetDataTable(sqlquery)
        Me.DataGridView.DataSource = dTtable
        With Me.DataGridView
            .Columns(0).HeaderText = "MAKH"
            .Columns(1).HeaderText = "TENKH"
            .Columns(2).HeaderText = "DIACHI"
            .Columns(3).HeaderText = "SDT"
        End With
    End Sub

    Private Sub searchh(value As String)
        Dim sqlquery As String = "SELECT * FROM dbo.KhachHang"
        If Me.cmbclass.SelectedIndex = 0 Then ' tim theo ma
            sqlquery += String.Format(" where MAKH like '{0}%'", value)
        ElseIf Me.cmbclass.SelectedIndex = 1 Then 'tim theo ten
            sqlquery += String.Format(" where TENKH like '{0}%'", value)
        End If
        Dim dTtable As DataTable = _DBAccess.GetDataTable(sqlquery)
        Me.DataGridView.DataSource = dTtable
    End Sub

    Private Sub QLKH_LOAD(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddataongridview()
    End Sub


    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        searchh(Me.txtsearch.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmkh(False)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            'load du lieu
        End If
    End Sub

    Private Sub butedit_Click(sender As Object, e As EventArgs) Handles butedit.Click
        Dim frm As New frmkh(True)
        frm.txtmakh.ReadOnly = True
        With Me.DataGridView
            frm.txtmakh.Text = .Rows(.CurrentCell.RowIndex).Cells("MAKH").Value
            frm.txttenkh.Text = .Rows(.CurrentCell.RowIndex).Cells("TENKH").Value
            frm.txtdiachi.Text = .Rows(.CurrentCell.RowIndex).Cells("DIACHI").Value
            frm.txtsdt.Text = .Rows(.CurrentCell.RowIndex).Cells("SDT").Value
        End With
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then 'sua thanh cong thi load
        End If
    End Sub

    Private Sub BUTDELETE_Click(sender As Object, e As EventArgs) Handles BUTDELETE.Click
        'khai bao bien de chon ma kh tren data
        Dim khid As String = Me.DataGridView.Rows(Me.DataGridView.CurrentCell.RowIndex).Cells("MAKH").Value

        'thuc hien xoa
        Dim sqlquery As String = String.Format("DELETE KhachHang WHERE MAKH = '{0}'", khid)
        'THUC HIEN XOA
        If _DBAccess.ExecuteNoneQuery(sqlquery) Then 'XOA THANH CONG THI THONG BAO
            MessageBox.Show("XOA THANH CONG", "THONG BAO", MessageBoxButtons.OK)
        Else
            MessageBox.Show("XOA KHONG THANH CONG", "THONG BAO", MessageBoxButtons.OK)
        End If

    End Sub
End Class
