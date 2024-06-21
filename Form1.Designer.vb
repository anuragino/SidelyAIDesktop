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
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmissions
        '
        Me.btnViewSubmissions.Location = New System.Drawing.Point(264, 137)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(298, 89)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "VIEW SUBMISSION"
        Me.btnViewSubmissions.UseVisualStyleBackColor = True
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(264, 268)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(298, 90)
        Me.btnCreateNewSubmission.TabIndex = 1
        Me.btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(292, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Anurag Kumar , Sidely Task 2 - Sidely Form App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents Label3 As Label
End Class
