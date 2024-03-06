Imports System.Data.SqlClient

' 1. 尚未整理Code
' 2. 將SQL Oper整理成一個Module or Class
' 3. 目前僅依據Id作為PrimaryKey，若Table沒有該Column的話會報錯，待修正

Public Class FormMain
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        If TextBoxHost.TextLength = 0 Or TextBoxUsername.TextLength = 0 Or TextBoxPassword.TextLength = 0 And ComboBoxDataBase.Text.Length = 0 Or ComboBoxTable.Text.Length = 0 Then
            MsgBox("伺服器、帳號、密碼、資料庫、資料表不得為空", vbCritical, "錯誤")
            Exit Sub
        End If

        Dim ConnectionString As String
        ConnectionString = String.Format("Data Source={0};User ID={1};Password={2};Initial Catalog={3}", TextBoxHost.Text, TextBoxUsername.Text, TextBoxPassword.Text, ComboBoxDataBase.Text)

        Using Connection As New SqlConnection(ConnectionString)
            Try
                Connection.Open()

                Dim QueryString As String = String.Format("SELECT * FROM {0};", ComboBoxTable.Text)
                Using Adapter As New SqlDataAdapter(QueryString, Connection)
                    Dim DataTable As New DataTable()
                    Adapter.Fill(DataTable)

                    DataGridView1.DataSource = DataTable
                End Using
                Connection.Close()
            Catch ex As Exception
                MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
            End Try
        End Using
    End Sub

    Private Sub ButtonAddDatabase_Click(sender As Object, e As EventArgs) Handles ButtonAddDatabase.Click
        If TextBoxHost.TextLength = 0 Or TextBoxUsername.TextLength = 0 Or TextBoxPassword.TextLength = 0 Then
            MsgBox("伺服器、帳號、密碼不得為空", vbCritical, "錯誤")
            Exit Sub
        End If

        Dim ConnectionString As String
        ConnectionString = String.Format("Data Source={0};User ID={1};Password={2};", TextBoxHost.Text, TextBoxUsername.Text, TextBoxPassword.Text)

        Using Connection As New SqlConnection(ConnectionString)
            Try
                Connection.Open()

                Dim QueryString As String = "SELECT * FROM master.dbo.sysdatabases;"
                Using Command As New SqlCommand(QueryString, Connection)
                    Using Reader As SqlDataReader = Command.ExecuteReader()
                        ComboBoxDataBase.Items.Clear()
                        While Reader.Read()
                            Dim DatabaseName As String = Reader("name").ToString()
                            ComboBoxDataBase.Items.Add(DatabaseName)
                        End While
                    End Using
                End Using
                Connection.Close()
            Catch ex As Exception
                MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
            End Try
        End Using
    End Sub

    Private Sub ButtonAddTable_Click(sender As Object, e As EventArgs) Handles ButtonAddTable.Click
        If TextBoxHost.TextLength = 0 Or TextBoxUsername.TextLength = 0 Or TextBoxPassword.TextLength = 0 And ComboBoxDataBase.Text.Length = 0 Then
            MsgBox("伺服器、帳號、密碼、資料庫不得為空", vbCritical, "錯誤")
            Exit Sub
        End If

        Dim ConnectionString As String
        ConnectionString = String.Format("Data Source={0};User ID={1};Password={2};Initial Catalog={3}", TextBoxHost.Text, TextBoxUsername.Text, TextBoxPassword.Text, ComboBoxDataBase.Text)

        Using Connection As New SqlConnection(ConnectionString)
            Try
                Connection.Open()

                Dim QueryString As String = "SELECT * FROM INFORMATION_SCHEMA.TABLES"
                Using Command As New SqlCommand(QueryString, Connection)
                    Using Reader As SqlDataReader = Command.ExecuteReader()
                        ComboBoxTable.Items.Clear()
                        While Reader.Read()
                            Dim TableSchema As String = Reader("TABLE_SCHEMA").ToString()
                            Dim TableName As String = Reader("TABLE_NAME").ToString()
                            ComboBoxTable.Items.Add(String.Format("{0}.{1}", TableSchema, TableName))
                        End While
                    End Using
                End Using
                Connection.Close()
            Catch ex As Exception
                MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Try
            Dim Id As Integer = CInt(e.Row.Cells("id").Value)

            Dim ConnectionString As String
            ConnectionString = String.Format("Data Source={0};User ID={1};Password={2};Initial Catalog={3}", TextBoxHost.Text, TextBoxUsername.Text, TextBoxPassword.Text, ComboBoxDataBase.Text)

            Using Connection As New SqlConnection(ConnectionString)
                Try
                    Connection.Open()

                    Dim QueryString As String = String.Format("DELETE FROM {0} WHERE id=@ID;", ComboBoxTable.Text)

                    Using Command As New SqlCommand(QueryString, Connection)
                        Command.Parameters.AddWithValue("@ID", Id)
                        Command.ExecuteNonQuery()
                    End Using
                    Connection.Close()
                Catch ex As Exception
                    MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
                End Try
            End Using
        Catch ex As Exception
            MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
        End Try
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim Id As Object = DataGridView1.Rows(e.RowIndex).Cells("id").Value
        Dim ColumnName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If Not IsDBNull(Id) Then
            Dim ConnectionString As String
            ConnectionString = String.Format("Data Source={0};User ID={1};Password={2};Initial Catalog={3}", TextBoxHost.Text, TextBoxUsername.Text, TextBoxPassword.Text, ComboBoxDataBase.Text)

            Using Connection As New SqlConnection(ConnectionString)
                Try
                    Connection.Open()

                    Dim QueryString As String = String.Format("UPDATE {0} SET {1} = @{2} WHERE id=@ID", ComboBoxTable.Text, ColumnName, ColumnName)

                    Using Command As New SqlCommand(QueryString, Connection)
                        Command.Parameters.AddWithValue("@ID", Id)
                        Command.Parameters.AddWithValue(String.Format("@{0}", ColumnName), DataGridView1.Rows(e.RowIndex).Cells(ColumnName).Value)
                        Command.ExecuteNonQuery()
                    End Using
                    Connection.Close()
                Catch ex As Exception
                    MsgBox("錯誤: " & ex.Message, vbCritical, "錯誤")
                End Try
            End Using
        End If
    End Sub

    Private Sub 新增IToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新增IToolStripMenuItem.Click
        If DataGridView1.DataSource Is Nothing Then
            MsgBox("請先設定資料來源", vbCritical, "錯誤")
        Else
            Dim StringList As New List(Of String)

            For Each Column As DataGridViewTextBoxColumn In DataGridView1.Columns
                If Column.Name.ToUpper <> "ID" Then
                    StringList.Add(Column.Name)
                End If
            Next

            Dim InsertForm As New FormInsert
            InsertForm.Fields = StringList.ToArray
            InsertForm.Show()
        End If
    End Sub
End Class
