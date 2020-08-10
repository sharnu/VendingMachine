using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.States
{
    public class DispenseChangeState : State 
    {
        private IVendingMachine vendingMachine { get; }

        public DispenseChangeState(IVendingMachine vendingMachine)
        {
            this.vendingMachine = vendingMachine;
        }

        public override void DispenseChange(string productCode)
        {
            int change = this.vendingMachine.CalculateChange(productCode);
            Console.WriteLine($"Change of { change} returned.");
            this.vendingMachine.SetState(new DispenseItemState(this.vendingMachine));
            this.vendingMachine.DispenseItem(productCode);
        }

       
    }
}
