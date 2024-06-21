Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSubmissions()
        DisplaySubmission(currentIndex)
    End Sub

    Private Sub LoadSubmissions()
        ' Call API to get submissions and store in the list
        submissions = GetSubmissions()
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.Name
            txtEmail.Text = submission.Email
            txtPhone.Text = submission.Phone
            txtGitHub.Text = submission.GitHubLink
            txtStopwatchTime.Text = submission.StopwatchTime
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
