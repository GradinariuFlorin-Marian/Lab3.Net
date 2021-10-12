using System;

namespace TSP.NET.L3
{
    public class ICanPayViaCreditCard : PaymentModel
    {
        public void BuyTicket(TicketDetails ticket, PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            ChargeCard(ticket, payment);
        }

        private void ChargeCard(TicketDetails ticket, PaymentDetails payment)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price, payment);
        }
    }
}