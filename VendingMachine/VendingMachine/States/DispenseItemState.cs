using System;

namespace VendingMachine.States
{
    public class DispenseItemState : State
    {
        private IVendingMachine vendingMachine;

        public DispenseItemState(IVendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public override void DispenseItem(string productCode)
        {
            this.vendingMachine.RemoveProduct(productCode);
            Console.WriteLine($"Dispensing item {productCode}");
            this.vendingMachine.SetState(new ReadyState(this.vendingMachine));
        }

    }
}