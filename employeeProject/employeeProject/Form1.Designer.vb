<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.employeeID = New System.Windows.Forms.TextBox
        Me.ID = New System.Windows.Forms.Label
        Me.Designation = New System.Windows.Forms.Label
        Me.employeeDesignation = New System.Windows.Forms.TextBox
        Me.LName = New System.Windows.Forms.Label
        Me.employeeLName = New System.Windows.Forms.TextBox
        Me.FName = New System.Windows.Forms.Label
        Me.employeeFName = New System.Windows.Forms.TextBox
        Me.Salary = New System.Windows.Forms.Label
        Me.employeeSalary = New System.Windows.Forms.TextBox
        Me.Insert = New System.Windows.Forms.Button
        Me.ButtonUpdate = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'employeeID
        '
        Me.employeeID.Location = New System.Drawing.Point(371, 114)
        Me.employeeID.Name = "employeeID"
        Me.employeeID.Size = New System.Drawing.Size(239, 20)
        Me.employeeID.TabIndex = 0
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(166, 119)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(97, 20)
        Me.ID.TabIndex = 1
        Me.ID.Text = "Employee ID"
        '
        'Designation
        '
        Me.Designation.AutoSize = True
        Me.Designation.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Designation.Location = New System.Drawing.Point(166, 274)
        Me.Designation.Name = "Designation"
        Me.Designation.Size = New System.Drawing.Size(93, 20)
        Me.Designation.TabIndex = 3
        Me.Designation.Text = "Designation"
        '
        'employeeDesignation
        '
        Me.employeeDesignation.Location = New System.Drawing.Point(371, 269)
        Me.employeeDesignation.Name = "employeeDesignation"
        Me.employeeDesignation.Size = New System.Drawing.Size(239, 20)
        Me.employeeDesignation.TabIndex = 2
        '
        'LName
        '
        Me.LName.AutoSize = True
        Me.LName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LName.Location = New System.Drawing.Point(166, 218)
        Me.LName.Name = "LName"
        Me.LName.Size = New System.Drawing.Size(84, 20)
        Me.LName.TabIndex = 5
        Me.LName.Text = "Last Name"
        '
        'employeeLName
        '
        Me.employeeLName.Location = New System.Drawing.Point(371, 218)
        Me.employeeLName.Name = "employeeLName"
        Me.employeeLName.Size = New System.Drawing.Size(239, 20)
        Me.employeeLName.TabIndex = 4
        '
        'FName
        '
        Me.FName.AutoSize = True
        Me.FName.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FName.Location = New System.Drawing.Point(166, 169)
        Me.FName.Name = "FName"
        Me.FName.Size = New System.Drawing.Size(86, 20)
        Me.FName.TabIndex = 7
        Me.FName.Text = "First Name"
        '
        'employeeFName
        '
        Me.employeeFName.Location = New System.Drawing.Point(371, 164)
        Me.employeeFName.Name = "employeeFName"
        Me.employeeFName.Size = New System.Drawing.Size(239, 20)
        Me.employeeFName.TabIndex = 6
        '
        'Salary
        '
        Me.Salary.AutoSize = True
        Me.Salary.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salary.Location = New System.Drawing.Point(166, 337)
        Me.Salary.Name = "Salary"
        Me.Salary.Size = New System.Drawing.Size(51, 20)
        Me.Salary.TabIndex = 9
        Me.Salary.Text = "Salary"
        '
        'employeeSalary
        '
        Me.employeeSalary.Location = New System.Drawing.Point(371, 332)
        Me.employeeSalary.Name = "employeeSalary"
        Me.employeeSalary.Size = New System.Drawing.Size(239, 20)
        Me.employeeSalary.TabIndex = 8
        '
        'Insert
        '
        Me.Insert.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.ForeColor = System.Drawing.Color.Lime
        Me.Insert.Location = New System.Drawing.Point(162, 426)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(75, 37)
        Me.Insert.TabIndex = 10
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.LightCoral
        Me.ButtonUpdate.Location = New System.Drawing.Point(371, 421)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(87, 47)
        Me.ButtonUpdate.TabIndex = 11
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.Red
        Me.ButtonDelete.Location = New System.Drawing.Point(545, 421)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(89, 47)
        Me.ButtonDelete.TabIndex = 12
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(263, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Employee Table"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 499)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Salary)
        Me.Controls.Add(Me.employeeSalary)
        Me.Controls.Add(Me.FName)
        Me.Controls.Add(Me.employeeFName)
        Me.Controls.Add(Me.LName)
        Me.Controls.Add(Me.employeeLName)
        Me.Controls.Add(Me.Designation)
        Me.Controls.Add(Me.employeeDesignation)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.employeeID)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeID As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents Designation As System.Windows.Forms.Label
    Friend WithEvents employeeDesignation As System.Windows.Forms.TextBox
    Friend WithEvents LName As System.Windows.Forms.Label
    Friend WithEvents employeeLName As System.Windows.Forms.TextBox
    Friend WithEvents FName As System.Windows.Forms.Label
    Friend WithEvents employeeFName As System.Windows.Forms.TextBox
    Friend WithEvents Salary As System.Windows.Forms.Label
    Friend WithEvents employeeSalary As System.Windows.Forms.TextBox
    Friend WithEvents Insert As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
