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
        Me.lblRPS = New System.Windows.Forms.Label()
        Me.radRock = New System.Windows.Forms.RadioButton()
        Me.radPaper = New System.Windows.Forms.RadioButton()
        Me.radScissors = New System.Windows.Forms.RadioButton()
        Me.btnThrow = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLizard = New System.Windows.Forms.RadioButton()
        Me.radSpock = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRPS
        '
        Me.lblRPS.AutoSize = True
        Me.lblRPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPS.Location = New System.Drawing.Point(6, 9)
        Me.lblRPS.Name = "lblRPS"
        Me.lblRPS.Size = New System.Drawing.Size(281, 31)
        Me.lblRPS.TabIndex = 0
        Me.lblRPS.Text = "Rock Paper Scisssors"
        '
        'radRock
        '
        Me.radRock.AutoSize = True
        Me.radRock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRock.Location = New System.Drawing.Point(109, 46)
        Me.radRock.Name = "radRock"
        Me.radRock.Size = New System.Drawing.Size(79, 29)
        Me.radRock.TabIndex = 1
        Me.radRock.TabStop = True
        Me.radRock.Text = "Rock"
        Me.radRock.UseVisualStyleBackColor = True
        '
        'radPaper
        '
        Me.radPaper.AutoSize = True
        Me.radPaper.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPaper.Location = New System.Drawing.Point(304, 46)
        Me.radPaper.Name = "radPaper"
        Me.radPaper.Size = New System.Drawing.Size(87, 29)
        Me.radPaper.TabIndex = 2
        Me.radPaper.TabStop = True
        Me.radPaper.Text = "Paper"
        Me.radPaper.UseVisualStyleBackColor = True
        '
        'radScissors
        '
        Me.radScissors.AutoSize = True
        Me.radScissors.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radScissors.Location = New System.Drawing.Point(507, 46)
        Me.radScissors.Name = "radScissors"
        Me.radScissors.Size = New System.Drawing.Size(112, 29)
        Me.radScissors.TabIndex = 3
        Me.radScissors.TabStop = True
        Me.radScissors.Text = "Scissors"
        Me.radScissors.UseVisualStyleBackColor = True
        '
        'btnThrow
        '
        Me.btnThrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThrow.Location = New System.Drawing.Point(521, 208)
        Me.btnThrow.Name = "btnThrow"
        Me.btnThrow.Size = New System.Drawing.Size(84, 32)
        Me.btnThrow.TabIndex = 4
        Me.btnThrow.Text = "Throw"
        Me.btnThrow.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(28, 292)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(85, 25)
        Me.lblResult.TabIndex = 5
        Me.lblResult.Text = "Result: "
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(28, 366)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(80, 25)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSpock)
        Me.GroupBox1.Controls.Add(Me.radLizard)
        Me.GroupBox1.Controls.Add(Me.radRock)
        Me.GroupBox1.Controls.Add(Me.radPaper)
        Me.GroupBox1.Controls.Add(Me.radScissors)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1139, 120)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Your Throw"
        '
        'radLizard
        '
        Me.radLizard.AutoSize = True
        Me.radLizard.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radLizard.Location = New System.Drawing.Point(735, 46)
        Me.radLizard.Name = "radLizard"
        Me.radLizard.Size = New System.Drawing.Size(89, 29)
        Me.radLizard.TabIndex = 4
        Me.radLizard.TabStop = True
        Me.radLizard.Text = "Lizard"
        Me.radLizard.UseVisualStyleBackColor = True
        '
        'radSpock
        '
        Me.radSpock.AutoSize = True
        Me.radSpock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSpock.Location = New System.Drawing.Point(940, 46)
        Me.radSpock.Name = "radSpock"
        Me.radSpock.Size = New System.Drawing.Size(90, 29)
        Me.radSpock.TabIndex = 5
        Me.radSpock.TabStop = True
        Me.radSpock.Text = "Spock"
        Me.radSpock.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 447)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnThrow)
        Me.Controls.Add(Me.lblRPS)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRPS As System.Windows.Forms.Label
    Friend WithEvents radRock As System.Windows.Forms.RadioButton
    Friend WithEvents radPaper As System.Windows.Forms.RadioButton
    Friend WithEvents radScissors As System.Windows.Forms.RadioButton
    Friend WithEvents btnThrow As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radSpock As System.Windows.Forms.RadioButton
    Friend WithEvents radLizard As System.Windows.Forms.RadioButton

End Class
