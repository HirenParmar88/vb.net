Imports System.Data
Imports System.Data.OleDb
Public Class Form1

    Private Sub ButtonInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert.Click
        Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\bcaSem4\vb.net\visual_Studio_2008_In_Program\employeeProject\employee1.mdb")

        Try
            Cmd = New OleDbCommand("insert into empInfo(ID,FName,LName,Designation,Salary) values('" + employeeID.Text + "','" + employeeFName.Text + "','" + employeeLName.Text + "','" + employeeDesignation.Text + "','" + employeeSalary.Text + "')", con)
            con.Open()
            Dim i
            i = Cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Record Successfully saved.")

            Else
                MsgBox("Record Not saved", MsgBoxStyle.Critical)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, "Error")
            con.Close()
        End Try

    End Sub

    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrentRow = 0
        Con.Open()
        Dad = New OleDbDataAdapter("select * from empInfo", Con)
        Dim dst As DataSet
        Dad.Fill(dst, "empInfo")
        showData(CurrentRow)
        Con.Close()
    End Sub
    Private Sub showData(ByVal CurrentRow)
        Try
            ID.Text = Dst.Tables("empInfo").Rows(CurrentRow)("ID")
            FName.Text = Dst.Tables("empInfo").Rows(CurrentRow)("FName")
            LName.Text = Dst.Tables("empInfo").Rows(CurrentRow)("LName")
            Designation.Text = Dst.Tables("empInfo").Rows(CurrentRow)("Designation")
            Salary.Text = Dst.Tables("empInfo").Rows(CurrentRow)("Salary")

        Catch ex As Exception
            MsgBox(ex.Message, "error")
        End Try
    End Sub
End Class
