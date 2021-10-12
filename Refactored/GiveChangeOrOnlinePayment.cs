using System;

namespace TSP.NET.L3
{
    public abstract class OnlinePayment
    {
        public abstract bool TryToDispense(decimal changeAmount);

        public abstract void DispenseChange(TicketDetails ticket, Action onPayChangeToMobilePhone);

    }
}