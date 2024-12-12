Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please Select an Item..........")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim selectedItems = (From i In ListBox1.SelectedItems).ToList

        For Each selectedItem In selectedItems
            ListBox2.Items.Add(selectedItem)
            ListBox1.Items.Remove(selectedItem)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please Select an Item..........")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim selectedItems = (From i In ListBox2.SelectedItems).ToList

        For Each selectedItem In selectedItems
            ListBox1.Items.Add(selectedItem)
            ListBox2.Items.Remove(selectedItem)
        Next
    End Sub
End Class
