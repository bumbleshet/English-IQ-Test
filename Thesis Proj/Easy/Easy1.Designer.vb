<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Easy1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Easy1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listBox = New System.Windows.Forms.CheckedListBox()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. " & Global.Microsoft.VisualBasic.ChrW(9) & "Which one of the five choices makes the best comparison?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Finger is " & _
            "to Hand as Leaves is to:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'listBox
        '
        Me.listBox.BackColor = System.Drawing.Color.White
        Me.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listBox.CheckOnClick = True
        Me.listBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.listBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listBox.FormattingEnabled = True
        Me.listBox.Items.AddRange(New Object() {"Twig    ", "Tree    ", "Branch    ", "Blossom    "})
        Me.listBox.Location = New System.Drawing.Point(25, 75)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(120, 90)
        Me.listBox.TabIndex = 1
        '
        'btnQuestion
        '
        Me.btnQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestion.Location = New System.Drawing.Point(151, 163)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(115, 37)
        Me.btnQuestion.TabIndex = 2
        Me.btnQuestion.Text = "Next Question"
        Me.btnQuestion.UseVisualStyleBackColor = True
        '
        'Easy1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(442, 212)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Easy1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents listBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnQuestion As System.Windows.Forms.Button
End Class
