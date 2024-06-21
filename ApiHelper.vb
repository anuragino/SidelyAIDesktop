Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Module ApiHelper
    Private ReadOnly client As New HttpClient()

    Public Function GetSubmissions() As List(Of Submission)
        Dim response As HttpResponseMessage = client.GetAsync("http://localhost:3000/read").Result
        Dim content As String = response.Content.ReadAsStringAsync().Result
        Return JsonConvert.DeserializeObject(Of List(Of Submission))(content)
    End Function

    Public Sub SubmitForm(submission As Submission)
        Dim content As New StringContent(JsonConvert.SerializeObject(submission), Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = client.PostAsync("http://localhost:3000/submit", content).Result

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim responseBody As String = response.Content.ReadAsStringAsync().Result
            MessageBox.Show($"Submission failed: {response.StatusCode} - {responseBody}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


End Module


Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class

