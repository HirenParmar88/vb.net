Public Class Form1

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxState.SelectedIndexChanged
        TextBoxState.Text = ComboBoxState.Text
    End Sub

    Private Sub TextBoxState_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxState.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxDist.SelectedIndexChanged
        TextBoxDist.Text = ComboBoxDist.Text
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       

    End Sub
End Class
