﻿Public Class Form3
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\bcaSem4\vb.net\mini project\University.accdb")
    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim i As Integer
    Dim c As Integer
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter("SELECT * FROM studentreg", con)
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            TextBox1.Text = ds.Tables(0).Rows(c).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(c).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(c).Item(2)
            DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)


        Catch ex As Exception
            MsgBox(ex.Message & "Cant load the form")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            cmd = New OleDb.OleDbCommand("INSERT INTO studentreg VALUES(" & TextBox1.Text & ",'" & TextBox2.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Value & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record Inserted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Load()
        End Try
    End Sub
    Public Sub load()
        Try
            ds.Clear()
            da = New OleDb.OleDbDataAdapter("SELECT * FROM studentreg", con)
            da.Fill(ds)
            DataGridView1.DataSource = ds.Tables(0)
            TextBox1.Text = ds.Tables(0).Rows(c).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(c).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(c).Item(2)
            DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)
        Catch ex As Exception
            MsgBox("Table Is Empty")
        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            cmd = New OleDb.OleDbCommand("UPDATE studentreg SET StudentName='" & TextBox2.Text & "', CourseID= " & TextBox3.Text & ", RegirstrationDate= '" & DateTimePicker1.Value & "' WHERE StudentID=" & TextBox1.Text & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record Updated")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            load()
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            cmd = New OleDb.OleDbCommand("DELETE FROM studentreg WHERE StudentID= " & TextBox1.Text & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Record Deleted")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            load()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value
        DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            c = 0
            TextBox1.Text = ds.Tables(0).Rows(c).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(c).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(c).Item(2)
            DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)

        Catch ex As Exception
            MsgBox("First record Reached")

        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            c -= 1
            TextBox1.Text = ds.Tables(0).Rows(c).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(c).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(c).Item(2)
            DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)

        Catch ex As Exception
            MsgBox("First record Reached")

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            c += 1
            TextBox1.Text = ds.Tables(0).Rows(c).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(c).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(c).Item(2)
            DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)
        Catch ex As Exception
            MsgBox("last record Reached")

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            c = ds.Tables(0).Rows.Count - 1
            TextBox1.Text = ds.Tables(0).Rows(c).Item(0)
            TextBox2.Text = ds.Tables(0).Rows(c).Item(1)
            TextBox3.Text = ds.Tables(0).Rows(c).Item(2)
            DateTimePicker1.Value = ds.Tables(0).Rows(c).Item(3)
        Catch ex As Exception
            MsgBox("Lst record Reached")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Report3.Show()

    End Sub
End Class