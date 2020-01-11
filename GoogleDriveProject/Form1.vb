Imports System.Data.SqlClient
Imports System.Configuration
Imports Google.Apis.Auth
Imports Google.Apis.Download
Imports Google.Apis.Drive.v2
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports System.Threading
Imports Google.Apis.Drive.v2.Data
Imports System.Windows.Forms.Application
Imports System.Text.RegularExpressions

Public Class Form1
    'SYSTEM'
    Dim service As New DriveService

    Private Sub createservice()
        Dim clientid = "clientid"
        Dim clientsecret = "secretid"
        Dim uc As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.clientid = clientid, .clientsecret = clientsecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
        service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = uc, .ApplicationName = "GoogleDriveProject"})

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New OpenFileDialog
        If f.ShowDialog = DialogResult.OK Then
            FilePath.Text = f.FileName
        Else
            Exit Sub
        End If
    End Sub


    Public Shared Function CopyFile(ByVal service As DriveService, ByVal originFileId As String, ByVal copyTitle As String) As File


        Dim copiedFile As File = New File()
        copiedFile.Title = printTitle(service, originFileId)
        copiedFile.MimeType = printMeme(service, originFileId)
        Try
            Return service.Files.Copy(copiedFile, originFileId).Execute()
        Catch e As Exception
            'MessageBox.Show("An error occurred: " & e.Message)
        End Try
        Return Nothing
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If service.ApplicationName <> "GoogleDriveProject" Then
            createservice()
        End If
        Dim myfile As New File()
        Dim bytearray As Byte() = System.IO.File.ReadAllBytes(FilePath.Text)
        Dim stream As New System.IO.MemoryStream(bytearray)
        Dim uploadrequest As FilesResource.InsertMediaUpload = service.Files.Insert(myfile, stream, myfile.MimeType)
        uploadrequest.Upload()
        Dim file As File = uploadrequest.ResponseBody
        TextBox1.Text = file.Id

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If service.ApplicationName <> "GoogleDriveProject" Then
            createservice()
        End If
        MessageBox.Show(CopyFile(service, TextBox1.Text, "test").Id)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
    End Sub

    Public Shared Sub DeleteFile(ByVal service As DriveService, ByVal fileId As String)
        Try
            service.Files.Delete(fileId).Execute()
        Catch e As Exception
            Console.WriteLine("An error occurred: " & e.Message)
        End Try
    End Sub
    Dim Data As String



    Public Shared Function printTitle(ByVal service As DriveService, ByVal fileId As String)
        Try
            Dim file As File = service.Files.[Get](fileId).Execute()
            Console.WriteLine("Title: " & file.Title)
            Console.WriteLine("Description: " & file.Description)
            Console.WriteLine("MIME type: " & file.MimeType)
            Return file.Title
        Catch e As Exception
            Console.WriteLine("An error occurred: " & e.Message)
            Return ""
        End Try
    End Function

    Public Shared Function printOwner(ByVal service As DriveService, ByVal fileId As String)
        Try
            Dim file As File = service.Files.[Get](fileId).Execute()
            Return file.OwnerNames(0)
        Catch e As Exception
            Return ""
        End Try
    End Function


    Public Shared Function printMeme(ByVal service As DriveService, ByVal fileId As String)
        Try
            Dim file As File = service.Files.[Get](fileId).Execute()
            Console.WriteLine("Title: " & file.Title)
            Console.WriteLine("Description: " & file.Description)
            Console.WriteLine("MIME type: " & file.MimeType)
            Return file.MimeType
        Catch e As Exception
            Console.WriteLine("An error occurred: " & e.Message)
            Return ""
        End Try
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If service.ApplicationName <> "GoogleDriveProject" Then
            createservice()
        End If
        DeleteFile(service, TextBox4.Text)
    End Sub



    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If service.ApplicationName <> "GoogleDriveProject" Then
            createservice()
        End If
        Dim title As String = printOwner(service, TextBox8.Text)
        MessageBox.Show(title)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
