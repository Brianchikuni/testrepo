Imports MySql.Data.MySqlClient ' Replace with the appropriate namespace for your MySQL database connection

Public Class FormPaymentStatus
    Private Sub FormPaymentStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        ' Fetch and display the customer details and bill amount for the selected customer.
        Dim customerName As String = cmbCustomer.SelectedItem.ToString()

        ' Replace the connection string with your actual connection details.
        Dim connectionString As String = GetConnectionString()

        Dim query As String = "SELECT CustomerID, BillAmount, Paid, PaymentDate FROM Bills WHERE CustomerID = @CustomerName"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerName", customerName)

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        ' Display customer details and bill amount.
                        Dim customerID As Integer = Convert.ToInt32(reader("CustomerID"))
                        Dim billAmount As Decimal = Convert.ToDecimal(reader("BillAmount"))
                        Dim isPaid As Boolean = Convert.ToBoolean(reader("Paid"))
                        Dim paymentDate As DateTime = If(reader.IsDBNull(reader.GetOrdinal("PaymentDate")), Date.MinValue, Convert.ToDateTime(reader("PaymentDate")))

                        ' Display customer details.
                        lblCustomerID.Text = "Customer ID: " & customerID.ToString()
                        lblBillAmount.Text = billAmount.ToString("0.00")

                        ' Display payment status.
                        chkPaid.Checked = isPaid
                        dpPayment.Value = If(paymentDate = Date.MinValue, Date.Now, paymentDate)
                    Else
                        ' Clear the fields if the selected customer has no bill.
                        lblCustomerID.Text = "Customer ID:"
                        txtBillAmount.Text = ""
                        chkPaid.Checked = False
                        dpPayment.Value = Date.Now
                    End If

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("Error while fetching customer details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
    Private Sub btnUpdateStatus_Click(sender As Object, e As EventArgs) Handles btnUpdateStatus.Click
        Dim customerName As String = cmbCustomer.SelectedItem.ToString()
        Dim isPaid As Boolean = chkPaid.Checked
        Dim paymentDate As DateTime = dpPayment.Value

        ' Replace the connection string with your actual connection details.
        Dim connectionString As String = GetConnectionString()

        ' Update the payment status and payment date in the "Bills" table for the selected customer.
        Dim updateQuery As String = "UPDATE Bills SET Paid = @IsPaid, PaymentDate = @PaymentDate WHERE CustomerID = @CustomerName"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(updateQuery, connection)
                command.Parameters.AddWithValue("@IsPaid", isPaid)
                command.Parameters.AddWithValue("@PaymentDate", paymentDate)
                command.Parameters.AddWithValue("@CustomerName", customerName)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Payment status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ' If no records were updated, it means the selected customer has no existing bill.
                        ' Let's insert a new record into the "Bills" table for the selected customer with the updated payment status.
                        Dim insertQuery As String = "INSERT INTO Bills (CustomerName, Paid, PaymentDate) VALUES (@CustomerName, @IsPaid, @PaymentDate)"

                        command.CommandText = insertQuery
                        rowsAffected = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Payment status added successfully for the selected customer.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Error: No records were updated or inserted. Please select a valid customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error while updating payment status: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub
End Class
