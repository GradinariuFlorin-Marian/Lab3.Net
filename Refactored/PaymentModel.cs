using System;
namespace TSP.NET.L3
{
    public interface PaymentModel
    {
        public void BuyTicket(TicketDetails ticket,
            PaymentDetails payment, Action onPayChangeToMobilePhone);
    }
}
