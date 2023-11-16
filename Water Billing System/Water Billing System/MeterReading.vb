Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient ' Replace with the appropriate namespace for your database connection
Public Class MeterReading
    Dim sqlConn As New MySqlConnection
    Dim sqlCmd As New MySqlCommand
    Dim sqLData As New DataTable
    Dim Dta As New MySqlDataAdapter


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click

    End Sub

    Private Sub MeterReading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fetch customer names from the database and populate the dropdown.
        PopulateCustomerNames()
    End Sub

    Private Function GetConnectionString() As String
        Dim server As String = "localhost"
        Dim username As String = "root"
        Dim password As String = "rootuser"
        Dim database As String = "water_billing"

        Return $"server={server};database={database};uid={username};password={password};"
    End Function

    Private Sub PopulateCustomerNames()
        ' Replace the connection string with your actual connection details.
        Dim connectionString As String = GetConnectionString()

        Dim query As String = "SELECT CustomerID FROM Customers"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    While reader.Read()
                        cmbCustomer.Items.Add(reader("CustomerID").ToString())
                    End While

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error while fetching customer names: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cmdMeterRdng_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Dim customerName As String = cmbCustomer.SelectedItem.ToString()
        Dim meterReading As Integer = Integer.Parse(MeterReadingBox.Text)
        Dim readingDate As DateTime = DpReadingDate.Value

        ' Replace the connection string with your actual connection details.
        Dim connectionString As String = GetConnectionString()


        Dim query As String = "INSERT INTO MeterReadings (CustomerID, MeterReading, ReadingDate) VALUES (@CustomerName, @MeterReading, @ReadingDate)"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerName", customerName)
                command.Parameters.AddWithValue("@MeterReading", meterReading)
                command.Parameters.AddWithValue("@ReadingDate", readingDate)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()

                    MessageBox.Show("Meter reading data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Clear input fields for the next entry.
                    cmbCustomer.SelectedIndex = -1
                    MeterReadingBox.Text = ""
                    DpReadingDate.Value = Date.Now
                Catch ex As Exception
                    MessageBox.Show("Error while saving meter reading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class