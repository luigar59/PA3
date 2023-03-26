Imports System.Data.SQLite

Public Class Form1

    Private dbCommand As String = ""
    Private bindingScr As BindingSource

    Private dbName As String = "Movies.accdb"
    Private dbPath As String = Application.StartupPath & "\" & dbName
    Private conString As String = "Data Source=" & dbPath & "Version=3;New=False;Compress=True;"

    Private connection As New SQLiteConnection(constring)
    Private command As New SQLiteCommand("", connection)

    Private sql As String = ""

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        bindingScr.MoveFirst()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        bindingScr.MovePrevious()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        bindingScr.MoveNext()
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        bindingScr.MoveLast()
    End Sub

    Private Sub btnData_Click(sender As Object, e As EventArgs) Handles btnData.Click
        If btnData.Text = "Cancel" Then
            Exit Sub
        End If

        Update()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        With btnNew

            If .Text = "Add New" Then
                .Text = "Cancel"
                ActorsDataGridView.ClearSelection()
                ActorsDataGridView.Enabled = False
            Else
                .Text = "Add New"
                Exit Sub
            End If
        End With

        Dim tb As TextBox
        For Each ctr As Control In GroupBox1.Controls
            If TypeOf ctr Is TextBox Then
                tb = CType(ctr, TextBox)
                tb.DataBindings.Clear()
                tb.Text = ""
                If tb.Name.Equals("FirstNameTextBox") Then
                    If tb.CanFocus Then
                        tb.Focus()
                    End If
                End If
            End If
        Next

    End Sub
End Class
