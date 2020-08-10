namespace VendingMachine.States
{
    public class ReadyState : State
    {
        private IVendingMachine vendingMachine;

        public ReadyState(IVendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public override void CollectCash(int cash)
        {
            this.vendingMachine.AddCollectedCash(cash);
        }
        public override void DispenseChange(string productCode)
        {
            this.vendingMachine.SetState(new DispenseChangeState(this.vendingMachine));
            this.vendingMachine.DispenseChange(productCode);
        }

        public override void CancelTransaction()
        {
            this.vendingMachine.SetState(new TransactionCancelledState(this.vendingMachine));
            this.vendingMachine.CancelTransaction();
        }
    }
}