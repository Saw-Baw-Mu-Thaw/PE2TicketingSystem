using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class TicketBLL
    {
        private TicketDAL ticketDAL = new TicketDAL();

        // Get destinations for display
        public DataTable GetDestinations()
        {
            return ticketDAL.GetDestinations();
        }

        // Process ticket purchase
        public string BuyTicket(int destinationID, string paymentMethod, decimal amount)
        {
            try
            {
                // Validate payment (e.g., check if amount matches destination price)
                DataTable destinations = ticketDAL.GetDestinations();
                DataRow destination = destinations.Select($"DestinationID = {destinationID}")[0];
                if (amount < Convert.ToDecimal(destination["Price"]))
                {
                    return "Insufficient amount for the selected destination.";
                }

                // Save payment
                int paymentID = ticketDAL.SavePayment(paymentMethod, amount);

                // Save ticket
                ticketDAL.SaveTicket(destinationID, paymentID);

                return "Ticket issued successfully! Barcode: " + GenerateBarcode();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        private string GenerateBarcode()
        {
            return Guid.NewGuid().ToString().Substring(0, 10); // Simplified barcode
        }
    }
}