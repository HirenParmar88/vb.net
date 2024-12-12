Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Const book1 As Integer = 100
        Const book2 As Integer = 200
        Const book3 As Integer = 300
        Const book4 As Integer = 400

        Dim sum As Integer

        If CheckBox1.Checked = True Then
            sum = sum + book1
        End If
        If CheckBox2.Checked = True Then
            sum = sum + book2
        End If
        If CheckBox3.Checked = True Then
            sum = sum + book3
        End If
        If CheckBox4.Checked = True Then
            sum = sum + book4
        End If

        TextBox1.Text = sum.ToString("c")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
