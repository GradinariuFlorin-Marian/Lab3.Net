using System;

namespace TSP.NET.L3
{
    public class ICanOperateWithCash :OnlinePayment, PaymentModel
    {
        private decimal _cashAccepted;

        public void BuyTicket(TicketDetails ticket, PaymentDetails payment, Action onPayChangeToMobilePhone)
        {
            AcceptCash(ticket);
            DispenseChange(ticket, onPayChangeToMobilePhone);
        }
        
        private void AcceptCash(TicketDetails ticket)
        {
            var r = new Random();
            _cashAccepted = r.Next((int)ticket.Price, (int)ticket.Price + 1000);
        }

        public override void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            if (_cashAccepted > ticket.Price &&
                !TryToDispense(_cashAccepted - ticket.Price))
                onPayChangeToMobilePhone?.Invoke();
        }

        public override bool TryToDispense(decimal changeAmount)
        {
            return false; //or true :)
        }

    }
}