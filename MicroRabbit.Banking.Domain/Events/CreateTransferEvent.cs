using MicroRabbit.Domain.Core.Events;

namespace MicroRabbit.Banking.Domain.Events
{
    public class CreateTransferEvent : Event
    {

        public int From { get; set; }   
        public int To { get; set; } 
        public decimal Amount { get; set; }

        public CreateTransferEvent(int from , int to, decimal amount)
        {
            From = from;
            To = to;
            Amount = amount;
        }

    }
}
