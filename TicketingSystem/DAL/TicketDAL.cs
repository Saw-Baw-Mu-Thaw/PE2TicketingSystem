using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class TicketDAL
    {
        private static string instanceName = "";
        //private string connectionString = "Server=LAPTOP-AUJ7RD2D;Database=TicketVendorDB;Trusted_Connection=True;";
        private string connectionString = "Server=(local)"+instanceName+";Database=TicketVendorDB;Trusted_Connection=True;";

        // Get available destinations
        public DataTable GetDestinations()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DestinationID, DestinationName, Price FROM Destinations";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        // Save payment and return PaymentID
        public int SavePayment(string paymentMethod, decimal amount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Payments (PaymentMethod, Amount, TransactionDate, Status) " +
                               "OUTPUT INSERTED.PaymentID " +
                               "VALUES (@Method, @Amount, @Date, @Status)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Method", paymentMethod);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Completed");
                return (int)cmd.ExecuteScalar();
            }
        }

        // Save ticket
        public void SaveTicket(int destinationID, int paymentID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string barcode = Guid.NewGuid().ToString().Substring(0, 10); // Simple barcode
                string query = "INSERT INTO Tickets (DestinationID, IssueDate, Barcode, PaymentID) " +
                               "VALUES (@DestID, @IssueDate, @Barcode, @PaymentID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@DestID", destinationID);
                cmd.Parameters.AddWithValue("@IssueDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Barcode", barcode);
                cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}