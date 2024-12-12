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
        Me.TextBoxRed = New System.Windows.Forms.TextBox
        Me.TextBoxGreen = New System.Windows.Forms.TextBox
        Me.TextBoxBlue = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TrackBarRed = New System.Windows.Forms.TrackBar
        Me.TrackBarGreen = New System.Windows.Forms.TrackBar
        Me.TrackBarBlue = New System.Windows.Forms.TrackBar
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxRed
        '
        Me.TextBoxRed.Location = New System.Drawing.Point(354, 131)
        Me.TextBoxRed.Name = "TextBoxRed"
        Me.TextBoxRed.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxRed.TabIndex = 0
        '
        'TextBoxGreen
        '
        Me.TextBoxGreen.Location = New System.Drawing.Point(354, 182)
        Me.TextBoxGreen.Name = "TextBoxGreen"
        Me.TextBoxGreen.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxGreen.TabIndex = 1
        '
        'TextBoxBlue
        '
        Me.TextBoxBlue.Location = New System.Drawing.Point(354, 244)
        Me.TextBoxBlue.Name = "TextBoxBlue"
        Me.TextBoxBlue.Size = New System.Drawing.Size(72, 20)
        Me.TextBoxBlue.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(205, 131)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(65, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(205, 182)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(65, 20)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(205, 244)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(65, 20)
        Me.TextBox6.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'TrackBarRed
        '
        Me.TrackBarRed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarRed.Location = New System.Drawing.Point(479, 131)
        Me.TrackBarRed.Maximum = 255
        Me.TrackBarRed.Name = "TrackBarRed"
        Me.TrackBarRed.Size = New System.Drawing.Size(399, 45)
        Me.TrackBarRed.TabIndex = 7
        '
        'TrackBarGreen
        '
        Me.TrackBarGreen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarGreen.Location = New System.Drawing.Point(479, 182)
        Me.TrackBarGreen.Maximum = 255
        Me.TrackBarGreen.Name = "TrackBarGreen"
        Me.TrackBarGreen.Size = New System.Drawing.Size(399, 45)
        Me.TrackBarGreen.TabIndex = 8
        '
        'TrackBarBlue
        '
        Me.TrackBarBlue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TrackBarBlue.Location = New System.Drawing.Point(479, 244)
        Me.TrackBarBlue.Maximum = 255
        Me.TrackBarBlue.Name = "TrackBarBlue"
        Me.TrackBarBlue.Size = New System.Drawing.Size(399, 45)
        Me.TrackBarBlue.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 501)
        Me.Controls.Add(Me.TrackBarBlue)
        Me.Controls.Add(Me.TrackBarGreen)
        Me.Controls.Add(Me.TrackBarRed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBoxBlue)
        Me.Controls.Add(Me.TextBoxGreen)
        Me.Controls.Add(Me.TextBoxRed)
        Me.Name = "Form1"
        Me.Text = "Trackbar to change label backcolor & forecolor"
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxRed As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGreen As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBlue As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TrackBarRed As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarGreen As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarBlue As System.Windows.Forms.TrackBar

End Class
