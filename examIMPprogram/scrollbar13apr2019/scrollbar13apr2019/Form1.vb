Public Class Form1

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub HScrollBar3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar3.Scroll
        TextBox2.Text = HScrollBar2.Value
    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        TextBox3.Text = HScrollBar3.Value
    End Sub

    Private Sub LabelRED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelRED.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        LabelGREEN.BackColor = Color.FromArgb(Val(TextBox4.Text), Val(TextBox5.Text), Val(TextBox6.Text))
    End Sub
End Class
