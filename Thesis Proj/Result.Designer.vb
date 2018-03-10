<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
        Me.txtBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCorrectEasy = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorrectHard = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.BackColor = System.Drawing.Color.White
        Me.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox.Location = New System.Drawing.Point(0, 113)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.ReadOnly = True
        Me.txtBox.Size = New System.Drawing.Size(669, 326)
        Me.txtBox.TabIndex = 0
        Me.txtBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(103, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "New Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(419, 447)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCorrectEasy
        '
        Me.txtCorrectEasy.AutoSize = True
        Me.txtCorrectEasy.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectEasy.ForeColor = System.Drawing.Color.Red
        Me.txtCorrectEasy.Location = New System.Drawing.Point(227, 26)
        Me.txtCorrectEasy.Name = "txtCorrectEasy"
        Me.txtCorrectEasy.Size = New System.Drawing.Size(82, 31)
        Me.txtCorrectEasy.TabIndex = 3
        Me.txtCorrectEasy.Text = "20/20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Your Correct Answers:"
        '
        'txtCorrectHard
        '
        Me.txtCorrectHard.AutoSize = True
        Me.txtCorrectHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorrectHard.ForeColor = System.Drawing.Color.Red
        Me.txtCorrectHard.Location = New System.Drawing.Point(227, 64)
        Me.txtCorrectHard.Name = "txtCorrectHard"
        Me.txtCorrectHard.Size = New System.Drawing.Size(82, 31)
        Me.txtCorrectHard.TabIndex = 5
        Me.txtCorrectHard.Text = "20/20"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Easy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(332, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hard"
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(673, 496)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorrectHard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCorrectEasy)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Result"
        Me.Text = "Result"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtCorrectEasy As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCorrectHard As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
