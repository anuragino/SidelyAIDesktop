Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.ShowDialog()
    End Sub
End Class
