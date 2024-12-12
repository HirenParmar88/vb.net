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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxState = New System.Windows.Forms.TextBox
        Me.TextBoxDist = New System.Windows.Forms.TextBox
        Me.ComboBoxState = New System.Windows.Forms.ComboBox
        Me.ComboBoxDist = New System.Windows.Forms.ComboBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "State"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(26, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "District"
        '
        'TextBoxState
        '
        Me.TextBoxState.Location = New System.Drawing.Point(422, 28)
        Me.TextBoxState.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxState.Name = "TextBoxState"
        Me.TextBoxState.Size = New System.Drawing.Size(207, 22)
        Me.TextBoxState.TabIndex = 4
        '
        'TextBoxDist
        '
        Me.TextBoxDist.Location = New System.Drawing.Point(422, 108)
        Me.TextBoxDist.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDist.Name = "TextBoxDist"
        Me.TextBoxDist.Size = New System.Drawing.Size(207, 22)
        Me.TextBoxDist.TabIndex = 5
        '
        'ComboBoxState
        '
        Me.ComboBoxState.FormattingEnabled = True
        Me.ComboBoxState.Items.AddRange(New Object() {"Gujrat", "Delhi", "Maharastra", "Goa", "Rajasthan", "Punjab", "Hariyana", "UP", "Bihar", "MP"})
        Me.ComboBoxState.Location = New System.Drawing.Point(167, 27)
        Me.ComboBoxState.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxState.Name = "ComboBoxState"
        Me.ComboBoxState.Size = New System.Drawing.Size(180, 24)
        Me.ComboBoxState.TabIndex = 6
        '
        'ComboBoxDist
        '
        Me.ComboBoxDist.FormattingEnabled = True
        Me.ComboBoxDist.Items.AddRange(New Object() {"Bhavnagar", "Rajkot", "Amreli", "Palitana", "Ahmedabad", "Surendranagar", "Surat", "Dwarka", "Somnath"})
        Me.ComboBoxDist.Location = New System.Drawing.Point(167, 108)
        Me.ComboBoxDist.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxDist.Name = "ComboBoxDist"
        Me.ComboBoxDist.Size = New System.Drawing.Size(180, 24)
        Me.ComboBoxDist.TabIndex = 7
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(235, 189)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(112, 28)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "ADD"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 257)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.ComboBoxDist)
        Me.Controls.Add(Me.ComboBoxState)
        Me.Controls.Add(Me.TextBoxDist)
        Me.Controls.Add(Me.TextBoxState)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxState As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDist As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxState As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxDist As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button

End Class
