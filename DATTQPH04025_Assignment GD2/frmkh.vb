Public Class frmkh
    Private _DBAccess As New DataBaseAccess
    'khai bao bien trang thai
    Private _isedit As Boolean = False
    Public Sub New(isedit As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _isedit = isedit
    End Sub
    'add
    Private Function insertkh() As Boolean
        Dim sqlquery As String = "Insert into KhachHang ( MAKH, TENKH, DIACHI, SDT )"
        sqlquery += String.Format("values('{0}','{1}','{2}','{3}')", txtmakh.Text, txttenkh.Text, txtdiachi.Text, txtsdt.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)

    End Function
    'UPDATE
    Private Function UPDATEKH() As Boolean
        Dim sqlquery As String = String.Format("UPDATE KhachHang SET TENKH = '{0}' , DIACHI = '{1}', SDT = '{2}' where MAKH = '{3}'", Me.txttenkh.Text, Me.txtdiachi.Text, Me.txtsdt.Text, Me.txtmakh.Text)
        Return _DBAccess.ExecuteNoneQuery(sqlquery)
    End Function

    'kiem tra
    Private Function kiemtra() As Boolean
        Return (String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) _
            OrElse String.IsNullOrEmpty(txtdiachi.Text) OrElse String.IsNullOrEmpty(txtsdt.Text))
    End Function

    Private Sub butok_Click(sender As Object, e As EventArgs) Handles butok.Click
        If kiemtra() Then ' kiem tra add
            MessageBox.Show("hay nhap gia tri truoc khi add", "erro", MessageBoxButtons.OK)
        Else
            If _isedit Then 'goi ham update
                If UPDATEKH() Then 'update thanh cong thi thong bao
                    MessageBox.Show("update thanh cong", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else ' co loi update thi thong bao
                    MessageBox.Show("loi update", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If
            Else
                If insertkh() Then
                    MessageBox.Show("thanh cong", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("loi them du lieu", "thong bao", MessageBoxButtons.OK)
                    Me.DialogResult = Windows.Forms.DialogResult.No
                End If

            End If
            Me.Close()
        End If
    End Sub

    Private Sub butcan_Click(sender As Object, e As EventArgs) Handles butcan.Click
        Me.Close()
    End Sub


End Class