Public Class Employee

    Private Sub dash_btn_Click(sender As Object, e As EventArgs) Handles dash_btn.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub pkg_btn_Click_1(sender As Object, e As EventArgs) Handles pkg_btn.Click
        Plan.Show()
        Me.Hide()
    End Sub

    Private Sub logout_btn_Click_1(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim ans As DialogResult = MessageBox.Show("Are you sure?", "Log out Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = vbYes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub client_btn_Click_1(sender As Object, e As EventArgs) Handles client_btn.Click
        Client.Show()
        Me.Hide()
    End Sub

    Private Sub bill_btn_Click(sender As Object, e As EventArgs) Handles bill_btn.Click
        Bills.Show()
        Me.Hide()
    End Sub
End Class