Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Item.!!!")
        Else
            ListBox2.Items.Add(ListBox1.SelectedIndex)
            Dim i As Integer = 0
            i = ListBox1.SelectedIndex
            ListBox1.Items.RemoveAt(i)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Item.!!!")
        Else
            Dim SelectedItems = (From i In ListBox1.SelectedItems).ToList
            For Each SelectedItem In SelectedItems
                ListBox2.Items.Add(SelectedItem)
                ListBox1.Items.Remove(SelectedItem)
            Next
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Item.!!!")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            Dim i As Integer = 0
            i = ListBox2.SelectedIndex
            ListBox2.Items.RemoveAt(i)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If ListBox2.SelectedIndex = -1 Then
            MessageBox.Show("Please Select An Item.!!!")
        Else
            Dim SelectedItems = (From i In ListBox2.SelectedItems).ToList
            For Each SelectedItem In SelectedItems
                ListBox1.Items.Add(SelectedItem)
                ListBox2.Items.Remove(SelectedItem)
            Next
        End If
    End Sub
End Class
