Public Class Form1

    Private Sub TrackBarRed_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarRed.Scroll
        TextBoxRed.Text = TrackBarRed.Value

    End Sub

    Private Sub TrackBarGreen_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarGreen.Scroll
        TextBoxGreen.Text = TrackBarGreen.Value
    End Sub

    Private Sub TrackBarBlue_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarBlue.Scroll
        TextBoxBlue.Text = TrackBarBlue.Value
    End Sub

    Private Sub TextBoxRed_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxRed.TextChanged
        Label1.BackColor = Color.FromArgb(Val(TextBoxRed.Text), Val(TextBoxGreen.Text), Val(TextBoxBlue.Text))
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBoxGreen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxGreen.TextChanged
        Label1.ForeColor = Color.FromArgb(Val(TextBoxRed.Text), Val(TextBoxGreen.Text), Val(TextBoxBlue.Text))
    End Sub

    Private Sub TextBoxBlue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBlue.TextChanged
        Label1.BackColor = Color.FromArgb(Val(TextBoxRed.Text), Val(TextBoxGreen.Text), Val(TextBoxBlue.Text))
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
