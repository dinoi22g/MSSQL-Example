Imports System.Data.SqlClient

Public Class FormInsert
    Public Fields() As String

    Private Sub FormInsert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim X As Integer = 10
        Dim Y As Integer = 10

        For Each Field As String In Fields
            Dim NewLabel As New Label
            NewLabel.Name = "Label" + Field
            NewLabel.Text = Field
            NewLabel.Width = 50
            NewLabel.Location = New Point(X, Y + 2)

            Dim NewTextBox As New TextBox
            NewTextBox.Name = "TextBox" + Field
            NewTextBox.Width = 150
            NewTextBox.Location = New Point(X + 55, Y)

            Controls.Add(NewLabel)
            Controls.Add(NewTextBox)

            Y += 30
        Next

        Dim SubmitButton As New Button
        SubmitButton.Name = "ButtonSubmit"
        SubmitButton.Text = "新增"
        SubmitButton.Width = 205
        SubmitButton.Height = 20
        SubmitButton.Location = New Point(X, Y)
        AddHandler SubmitButton.Click, AddressOf ButtonSubmit_Click

        Controls.Add(SubmitButton)

        Me.Size = New Size(250, Y + 70)
    End Sub

    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs)
        Dim ConnectionString As String
        ConnectionString = String.Format("Data Source={0};User ID={1};Password={2};Initial Catalog={3}", FormMain.TextBoxHost.Text, FormMain.TextBoxUsername.Text, FormMain.TextBoxPassword.Text, FormMain.ComboBoxDataBase.Text)

        Using Connection As New SqlConnection(ConnectionString)
            Try
                Connection.Open()

                ' 新增@
                Dim ModifiedFields() As String = Fields.Select(Function(field) "@" & field).ToArray()

                Dim QueryString As String = String.Format("INSERT INTO {0} ({1}) VALUES ({2})", FormMain.ComboBoxTable.Text, String.Join(", ", Fields), String.Join(", ", ModifiedFields))

                Using Command As New SqlCommand(QueryString, Connection)
                    For Each Field As String In Fields
                        Command.Parameters.AddWithValue("@" + Field, Controls("TextBox" + Field).Text)
                    Next

                    Command.ExecuteNonQuery()
                End Using
                Connection.Close()

                ' Reset DataGridView
                FormMain.ButtonLoad.PerformClick()
                Me.Close()

            Catch ex As Exception
                MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
            End Try
        End Using
    End Sub
End Class