using System;

namespace VendingMachine.States
{
    public class TransactionCancelledState : State
    {
        private IVendingMachine vendingMachine;

        public TransactionCancelledState(IVendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public override void CancelTransaction()
        {
            Console.WriteLine($"Returning collcted cash.");
            this.vendingMachine.SetCollectedCash(0);
            this.vendingMachine.SetState(new ReadyState(this.vendingMachine));
        }
    }
}