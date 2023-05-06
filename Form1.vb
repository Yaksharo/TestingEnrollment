Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub LoadData()
        'create a connection to SQL Server using connection string
        Dim con As New SqlConnection("sqlconnectionstring")
        con.Open()
        'create a SQL query command to retrieve data from database
        Dim cmd As New SqlCommand("SELECT LastName + ', ' + FirstName + ' ' + LEFT(COALESCE(MiddleName,''),1) + '.' AS Name, BirthDate, DATEDIFF(year, BirthDate, GETDATE()) AS Age, Sex FROM testingStudentInfo", con)
        'create an adapter to fill the data from the query command into a DataTable
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        'fill the data into the DataTable
        adapter.Fill(table)
        'display the data in the DataGridView and auto-size columns to fill the control
        DataGridView1.DataSource = table
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        'close the connection to the database
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Connect to database
        con.ConnectionString = "sqlconnectionstring"
        'Opens the connection with the database
        con.Open()
        'If all the mentioned field below are empty, you put data on them.
        If (txtFName.Text = "" Or txtLName.Text = "" Or genderSelector.Text = "") Then
            MessageBox.Show("Please Enter Data at All the Fields")
            txtFName.Focus()
        Else
            'Calculates the age of the student based on the Birth Date and the current system date.
            Dim selectedDate As Date = birthDate.Value
            Dim age As Integer = DateDiff(DateInterval.Year, selectedDate, Date.Today)

            'Initializes the insert command.
            cmd = New SqlCommand("sqlconnectionstring)", con)
            'Specifies what values are used for the data that will be inserted to the database
            cmd.Parameters.AddWithValue("@Value1", txtLName.Text)
            cmd.Parameters.AddWithValue("@Value2", txtFName.Text)
            cmd.Parameters.AddWithValue("@Value3", txtMName.Text)
            cmd.Parameters.AddWithValue("@Value4", genderSelector.SelectedItem.ToString())
            cmd.Parameters.AddWithValue("@Value5", age)
            cmd.Parameters.AddWithValue("@selectedDate", selectedDate)
            'Executed the command and uploads them to the database
            cmd.ExecuteNonQuery()
            'Message Box is shown if the data is succesfully inserted to the databasse
            MsgBox("Successfully Enrolled", MsgBoxStyle.Information, "Ok")
            'Clears all the textbox fields.
            txtFName.Clear()
            txtLName.Clear()
            txtMName.Clear()
            'Connection to the database is closed.
            con.Close()
            ' Refresh the DataGridView to show the new data
            DataGridView1.DataSource = Nothing ' Clear the current data source
            DataGridView1.Rows.Clear() ' Clear the existing rows
            LoadData() ' Load the data again from the database
        End If
    End Sub

    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        con.ConnectionString = "sqlconnectionstring"
        con.Open()
        ' Parse the text values of the yearStart and yearEnd TextBoxes as Short integers.
        Dim yearStartValue As Short = Short.Parse(yearStart.Text)
        Dim yearEndValue As Short = Short.Parse(yearEnd.Text)
        ' Create a new SqlCommand object with a parameterized INSERT statement to insert the yearStart and yearEnd values into the testingSchoolYear table.
        cmd = New SqlCommand("INSERT INTO testingSchoolYear (YearStart, YearEnd) VALUES (@Value1, @Value2)", con)
        cmd.Parameters.AddWithValue("@Value1", yearStartValue)
        cmd.Parameters.AddWithValue("@Value2", yearEndValue)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub NoNumbers_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFName.KeyPress, txtLName.KeyPress, txtMName.KeyPress
        'Allows alphabetic characters only
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            'Tooltip popup if you press a number
            ToolTip1.Show("Only alphabetical characters are allowed", CType(sender, Control), 0, -20, 2000)
        Else
            ToolTip1.Hide(CType(sender, Control))
        End If
    End Sub
End Class
