Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Sql


Public Class Form1

#Region "Variables"

    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dsuser As DataSet
    Dim adp As OleDbDataAdapter


#End Region

#Region "FUNCTIONS"

#End Region


#Region "EVENTS"

#End Region

    Public Sub dbconnect()
        Try
            con = New OleDbConnection()

            con.ConnectionString = ""
            con.Open()
        Catch ex As Exception
            MessageBox.Show("dbconnect: " + ex.Message.ToString)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "Insert" Then
                Button1.Text = "Save"
                Button2.Enabled = False
                Button3.Enabled = False
                txtName.Clear()
                txtEmail.Clear()
                txtMobile.Clear()
                txtPassword.Clear()
                txtName.Focus()
            Else
                If (con.State = ConnectionState.Closed) Then
                    con.Open()
                    cmd = New OleDbCommand()
                    cmd.Connection = con
                    cmd.CommandType = CommandType.Text
                    cmd.CommandText = "insert into tmuser(name,email,mobile,password)values(@u_name,@u_email,@u_mobile,@u_password)"
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@mobile", txtMobile.Text)
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                    If (cmd.ExecuteNonQuery() > 0) Then
                        MessageBox.Show("recored Inserted")

                        Button1.Text = "Insert"
                        Button2.Enabled = True
                        Button3.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("insert: " + ex.Message.ToString)
        Finally

        End Try
    End Sub
End Class
