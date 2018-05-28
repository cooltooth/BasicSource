﻿'' CSV Re-generator and manipulator for Elumatec's CSV files generated by IT
'' Daniel Hazelton
'' 27/06/17 - Start
'' 11/07/17 - Fixed table auto-sorting
''          - Made DataGridView1 edittable
Imports System.IO


Public Class Form2

    Public SERVERLOCATION As String
    Private ProfileLocation As String = ""
    Private SaveLocation As String = ""
    Private TextFileTable As DataTable = Nothing
    Private RemakeTable As New DataTable


    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Form Load
    '' Uses hard coded server location into public SERVERLOCATION.
    '' Checks if server directory exists, then loads each folder name from that 
    '' directory into the list combobox.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MinimumSize = New Size(375, 385)
        Me.Size = New Size(500, 500)
        Me.Show()
        Try
            If My.Computer.FileSystem.DirectoryExists(SERVERLOCATION) Then
                For Each Dir As String In System.IO.Directory.GetDirectories(SERVERLOCATION)
                    Dim dirInfo As New System.IO.DirectoryInfo(Dir)
                    'Console.WriteLine(dirInfo.Name)
                    LIST_CB.Items.Add(dirInfo.Name)
                Next
            Else
                MsgBox("Server Unreachable")
            End If
        Catch ex As Exception
            MsgBox("Could not connect to server: " & ex.Message)
        End Try
    End Sub

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' List ComboBox Selection
    '' Reads all file names from folder location and fills the list combo box.
    Private Sub LIST_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LIST_CB.SelectedIndexChanged
        ListBox1.Items.Clear()
        PROFILE_CB.Items.Clear()
        PROFILE_CB.Text = ""
        BOX_CB.Items.Clear()
        BOX_CB.Text = ""
        ID_CB.Items.Clear()
        ID_CB.Text = ""

        ProfileLocation = SERVERLOCATION + "\" + LIST_CB.SelectedItem

        For Each Dir As String In System.IO.Directory.GetFiles(ProfileLocation)

            Dim DirInfo = Path.GetFileNameWithoutExtension(Dir)

            PROFILE_CB.Items.Add(DirInfo)
            'Console.WriteLine(DirInfo + "- Directory info added.")
        Next
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Profile ComboBox Selection
    '' Pulls all rows from selected profile and puts them into a DataTable then uses
    '' row 12 (Box #) to fill the Box combo box. Then the schema is cloned from
    '' that database onto a new database to be generated and the first row is added.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub PROFILE_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PROFILE_CB.SelectedIndexChanged
        BOX_CB.Items.Clear()
        BOX_CB.Text = ""
        ID_CB.Items.Clear()
        ID_CB.Text = ""
        TextFileTable = Nothing

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''https://stackoverflow.com/questions/3485883/how-do-you-read-a-csv-file-and-display-the-results-in-a-grid-in-visual-basic-201''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        SaveLocation = ProfileLocation + "/" + PROFILE_CB.SelectedItem.ToString + "_remake.csv"
        Dim TextFileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(ProfileLocation + "/" + PROFILE_CB.SelectedItem.ToString + ".csv")
        TextFileReader.TextFieldType = FileIO.FieldType.Delimited
        TextFileReader.SetDelimiters(";")

        Dim Column As DataColumn
        Dim Row As DataRow
        Dim UpperBound As Int32
        Dim ColumnCount As Int32
        Dim CurrentRow As String()

        While Not TextFileReader.EndOfData
            Try
                CurrentRow = TextFileReader.ReadFields()
                If Not CurrentRow Is Nothing Then
                    ''# Check if DataTable has been created
                    If TextFileTable Is Nothing Then
                        TextFileTable = New DataTable("TextFileTable")
                        ''# Get number of columns
                        UpperBound = CurrentRow.GetUpperBound(0)
                        ''# Create new DataTable
                        For ColumnCount = 0 To UpperBound

                            Column = New DataColumn()
                            Column.DataType = System.Type.GetType("System.String")
                            Column.ColumnName = "Column" & ColumnCount
                            Column.Caption = "Column" & ColumnCount
                            Column.ReadOnly = False ''needs to be set to false even though default is False...
                            Column.Unique = False

                            TextFileTable.Columns.Add(Column)
                        Next
                    End If
                    Row = TextFileTable.NewRow
                    For ColumnCount = 0 To UpperBound
                        Row("Column" & ColumnCount) = CurrentRow(ColumnCount).ToString
                    Next
                    TextFileTable.Rows.Add(Row)
                End If
            Catch ex As _
            Microsoft.VisualBasic.FileIO.MalformedLineException
                MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
            End Try
        End While

        TextFileReader.Dispose()

        '' Write to datagridview table
        DataGridView1.DataSource = TextFileTable

        '' Find box number
        For Each Row In TextFileTable.Rows
            Dim resultIndex As Integer = -1
            resultIndex = BOX_CB.FindStringExact(Row(12))

            If IsNumeric(Row(12)) And resultIndex = -1 Then
                BOX_CB.Items.Add(Row(12))
            End If
        Next

        '' Setup new database for writing and add the first row.
        '' 11/07/17 - Will need safer check, currently adding first row to cloned table if listbox is empty
        ''            when it should be checking if the table itself is not empty.
        If ListBox1.Items.Count = 0 Then
            RemakeTable = TextFileTable.Clone
            RemakeTable.ImportRow(TextFileTable.Rows(0))
        End If

    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Box ComboBox Selection
    '' Extract row 12 (box number) and using select case based on variables in 
    '' the CSV, gives the parts ID's and adds them to the ID combo box.
    '' Current Defined Profile Series:
    '' 9500, 4500TI, 4503
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub BOX_CB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOX_CB.SelectedIndexChanged
        ID_CB.Items.Clear()
        ID_CB.Text = ""

        Dim Row As DataRow
        For Each Row In TextFileTable.Rows
            If BOX_CB.SelectedItem = Row(12) Then
                Select Case True
                        '''''''''''''''''''''''''''''''''''''''''''
                        '' 9500
                        '''''''''''''''''''''''''''''''''''''''''''
                    Case Row(1) = "9TRDM"
                        If Row(25) <> 0 And Row(26) <> 0 Then
                            ID_CB.Items.Add("Transom with Stayarm")
                        ElseIf Row(25) <> 0 And Row(26) = 0 Then
                            ID_CB.Items.Add("Head/UpperTransom")
                        ElseIf Row(22) <> 0 And Row(15) = 0 Then
                            ID_CB.Items.Add("Hinge on Right")
                        ElseIf Row(22) <> 0 And Row(15) = 1 Then
                            ID_CB.Items.Add("Hinge on Left")
                        ElseIf Row(24) <> 0 And Row(15) = 0 Then
                            ID_CB.Items.Add("Striker on Right")
                        ElseIf Row(24) <> 0 And Row(15) = 1 Then
                            ID_CB.Items.Add("Striker on Left")
                        Else
                            ID_CB.Items.Add("Vertical Transom")
                        End If
                    Case Row(1) = "9TRDJ"
                        If Row(22) <> 0 And Row(15) = 0 Then
                            ID_CB.Items.Add("Hinge on Right")
                        ElseIf Row(22) <> 0 And Row(15) = 1 Then
                            ID_CB.Items.Add("Hinge on Left")
                        ElseIf Row(24) <> 0 And Row(15) = 0 Then
                            ID_CB.Items.Add("Striker on Right")
                        ElseIf Row(24) <> 0 And Row(15) = 1 Then
                            ID_CB.Items.Add("Striker on Left")
                        Else
                            ID_CB.Items.Add("Unknown Item")
                        End If
                    Case Row(1) = "9TRSF"
                        If Row(15) = 0 And Row(16) > 0 Then
                            ID_CB.Items.Add("upper Rail Right")
                        ElseIf Row(15) = 1 And Row(16) > 0 Then
                            ID_CB.Items.Add("Upper Rail Left")
                        Else
                            ID_CB.Items.Add("Lower 9TRSF")
                        End If
                    Case Row(1) = "9TRSFJ"
                        If Row(15) = 0 And Row(16) > 0 Then
                            ID_CB.Items.Add("Hinge on Right ")
                        ElseIf Row(15) = 1 And Row(16) > 0 Then
                            ID_CB.Items.Add("Hinge on Left")
                        ElseIf Row(15) = 0 And Row(16) = 0 Then
                            ID_CB.Items.Add("Striker on Right")
                        ElseIf Row(15) = 1 And Row(16) = 0 Then
                            ID_CB.Items.Add("Striker on Left")
                        Else
                            ID_CB.Items.Add("ERROR_ITEM")
                        End If
                        '''''''''''''''''''''''''''''''''''''''''''
                        '' 4500TI
                        '''''''''''''''''''''''''''''''''''''''''''
                    Case Row(1) Like "4SD*"

                        If Row(20) = 0 Then
                            ID_CB.Items.Add("Bumper Side")
                        ElseIf Row(20) > 0 Then
                            ID_CB.Items.Add("Lock Side")
                        Else
                            ID_CB.Items.Add("ERROR_ITEM")
                        End If
                    Case Row(1) Like "4DISS*"
                        ID_CB.Items.Add("4DISS")
                        '''''''''''''''''''''''''''''''''''''''''''
                        '' 4503
                        '''''''''''''''''''''''''''''''''''''''''''
                    Case Row(1) Like "4LS*"
                        If Row(15) = 0 Then
                            ID_CB.Items.Add("Right Side")
                        ElseIf Row(15) > 0 Then
                            ID_CB.Items.Add("Left Side")
                        Else
                            ID_CB.Items.Add("ERROR_ITEM")
                        End If

                    Case Else
                        Console.WriteLine("ID_UNKNOWN: " & Row(1))
                        ID_CB.Items.Add("No ID")
                End Select
            End If
        Next


    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' ADD Button
    '' Adds the row based on the index of the ID from the related box numbers of that
    '' ID to the new database and listbox
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub ADD_BUTTON_Click(sender As Object, e As EventArgs) Handles ADD_BUTTON.Click
        Dim id_count As Int32 = 0
        If Not ID_CB.Text Is "" Then
            For Each Row In TextFileTable.Rows
                If BOX_CB.SelectedItem = Row(12) And (id_count) = ID_CB.SelectedIndex Then
                    RemakeTable.ImportRow(Row)
                    ListBox1.Items.Add(Row(0) & "_BOX:" & Row(12) & " : " & ID_CB.SelectedItem)
                    'Console.WriteLine("Row(0):" & Row(0) & " ID: " & ID_CB.SelectedItem)
                    id_count += 1
                    Exit For
                ElseIf BOX_CB.SelectedItem = Row(12) Then
                    id_count += 1
                End If
            Next

            DataGridView1.DataSource = RemakeTable
        End If


    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Save Button
    '' Builds a string with the row items delimiated by a ";" then writes to a new 
    '' CSV file (currently re-writing over any other similar remakes)
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub SAVE_BUTTON_Click(sender As Object, e As EventArgs) Handles SAVE_BUTTON.Click
        If ListBox1.Items.Count <> 0 Then
            Dim delim As String = ";"

            '' This looks ugly...
            Try
                Dim writer = New System.IO.StreamWriter(SaveLocation)

                For Each row As DataRow In RemakeTable.Rows
                    Dim builder = New System.Text.StringBuilder
                    For Each col As DataColumn In RemakeTable.Columns
                        builder.Append(row(col.ColumnName)).Append(delim)
                    Next
                    writer.WriteLine(builder.ToString())
                Next

                writer.Close()

            Catch ex As Exception
                MsgBox(ex)
            End Try

            '' Clean up
            ListBox1.Items.Clear()
            ListBox1.Items.Add("LIST:" & PROFILE_CB.Text & " REMAKE GENERATED")
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            LIST_CB.Text = ""
            PROFILE_CB.Items.Clear()
            PROFILE_CB.Text = ""
            BOX_CB.Items.Clear()
            BOX_CB.Text = ""
            ID_CB.Items.Clear()
            ID_CB.Text = ""

        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Expand Button
    '' Expands form window to reveal an editable datagrid view of the resulting CSV.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub EXPAND_BUTTON_Click(sender As Object, e As EventArgs) Handles EXPAND_BUTTON.Click
        Static oldSize As Size = Me.Size


        Console.WriteLine(Me.Size.ToString)
        If Me.Width = 1288 And Me.Height = 500 Then
            MinimumSize = New Size(375, 385)
            DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            Me.Size = New Size(oldSize)
        Else
            oldSize = Me.Size
            Me.Size = New Size(1288, 500)
            MinimumSize = New Size(1288, 500)
            DataGridView1.Anchor = AnchorStyles.Left Or AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
            DataGridView1.Size = New System.Drawing.Size(780, 440)
        End If

    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '' Delete Button
    '' Removes the row based on the selected index of the listbox.
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        If ListBox1.SelectedIndex >= 0 Then
            RemakeTable.Rows.RemoveAt(ListBox1.SelectedIndex + 1)
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            DataGridView1.DataSource = RemakeTable
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class