<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGitHub
        '
        Me.txtGitHub.Location = New System.Drawing.Point(364, 228)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(226, 22)
        Me.txtGitHub.TabIndex = 19
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(364, 184)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(226, 22)
        Me.txtPhone.TabIndex = 18
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(364, 135)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(226, 22)
        Me.txtEmail.TabIndex = 17
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(363, 86)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(226, 22)
        Me.txtName.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Phone No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "GitHub Link"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(211, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Name"
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(214, 275)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(181, 43)
        Me.btnToggleStopwatch.TabIndex = 20
        Me.btnToggleStopwatch.Text = "TOGGLE STOPWATCH"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = True
        '
        'txtStopwatchTime
        '
        Me.txtStopwatchTime.Location = New System.Drawing.Point(464, 286)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(125, 22)
        Me.txtStopwatchTime.TabIndex = 21
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(305, 353)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(188, 66)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Anurag Kumar , Sidely Task 2 - Create Submission "
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label3 As Label
End Class
