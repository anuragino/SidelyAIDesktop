Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch = New Stopwatch()
    Private isStopwatchRunning As Boolean = False

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If Not ValidateForm() Then
            Return ' This line might cause the BC30491 error if ValidateForm() is not returning a Boolean.
        End If

        Dim submission As New Submission With {
        .Name = txtName.Text,
        .Email = txtEmail.Text,
        .Phone = txtPhone.Text,
        .GitHubLink = txtGitHub.Text,
        .StopwatchTime = txtStopwatchTime.Text
    }

        Debug.WriteLine(JsonConvert.SerializeObject(submission))

        Try
            Await ApiHelper.SubmitForm(submission)
        Catch ex As Exception
            MessageBox.Show($"Failed to submit form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function ValidateForm() As Boolean
        ' Implement your form validation logic here
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' Add more validation checks for other fields as needed...

        Return True ' Form is valid
    End Function


    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If isStopwatchRunning Then
            stopwatch.Stop()
            btnToggleStopwatch.Text = "Resume Stopwatch (CTRL + T)"
        Else
            stopwatch.Start()
            btnToggleStopwatch.Text = "Pause Stopwatch (CTRL + T)"
        End If
        isStopwatchRunning = Not isStopwatchRunning
        txtStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch_Click(sender, e)
        End If
    End Sub
End Class
