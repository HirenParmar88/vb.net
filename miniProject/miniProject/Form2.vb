Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UnivercityDataSet.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.UnivercityDataSet.Subject)
        'TODO: This line of code loads data into the 'UnivercityDataSet.Subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.UnivercityDataSet.Subject)


    End Sub

    Private Sub ButtonFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFirst.Click
        Me.SubjectBindingSource.MoveFirst()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ButtonNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNext.Click
        Me.SubjectBindingSource.MoveNext()
    End Sub

    Private Sub ButtonPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrevious.Click
        Me.SubjectBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLast.Click
        Me.SubjectBindingSource.MoveLast()
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        Me.SubjectBindingSource.AddNew()
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        Me.SubjectBindingSource.EndEdit()
    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click
        Me.SubjectBindingSource.RemoveCurrent()
    End Sub
End Class