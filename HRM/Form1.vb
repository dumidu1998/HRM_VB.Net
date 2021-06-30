Imports System.Data.OleDb
Imports System.Data

Public Class Login

    Dim connection As New OleDbConnection(My.Settings.HRMConnectionString)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Enter all Login details", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            If (ComboBox1.Text = "Admin") Then
                Dim cmd As New OleDbCommand("select count(*) from EmpDetails where EmployeeId=? and Password=? and UserType=1", connection)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar)

                If (count > 0) Then
                    MsgBox("Login Sucessfull as Admin", MsgBoxStyle.Information)
                    loggedID = Convert.ToInt32(TextBox1.Text)
                    Me.Hide()
                    AdminHome.Show()
                Else
                    MsgBox("Login details are incorrect. Please Try again", MsgBoxStyle.Critical)
                End If

            Else
                Dim cmd As New OleDbCommand("select count(*) from EmpDetails where EmployeeId=? and Password=? and UserType=0", connection)
                cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = TextBox1.Text
                cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = TextBox2.Text
                Dim count = Convert.ToInt32(cmd.ExecuteScalar)

                If (count > 0) Then
                    MsgBox("Login Sucessfull as User", MsgBoxStyle.Information)
                    loggedID = Convert.ToInt32(TextBox1.Text)
                    Me.Hide()
                    EmployeeHome.Show()
                Else
                    MsgBox("Login details are incorrect. Please Try again", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub


End Class
