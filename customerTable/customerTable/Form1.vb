Public Class Customer

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseCustomerDataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.DatabaseCustomerDataSet.customer)

    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnnext.Click
        Me.CustomerBindingSource.MoveNext()
    End Sub

    Private Sub Btnprev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnprev.Click
        Me.CustomerBindingSource.MovePrevious()

    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Me.CustomerBindingSource.EndEdit()

    End Sub

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        Me.CustomerBindingSource.AddNew()

    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        Me.CustomerBindingSource.CancelEdit()

    End Sub

    Private Sub Btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfirst.Click
        Me.CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        Me.CustomerBindingSource.MoveLast()

    End Sub
End Class
