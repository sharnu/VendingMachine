using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private int collectedCash;
        private IState state;
        //private Dictionary<String, String> productCodeItemMap;
        private Dictionary<String, int> productCodePriceMap;
        public VendingMachine()
        {
            this.productCodePriceMap = new Dictionary<string, int>();
            this.productCodePriceMap.Add("snacks", 10);
            this.productCodePriceMap.Add("chips", 20);
            this.productCodePriceMap.Add("kurkure", 25);
        }

        public void AddCollectedCash(int collectedCash)
        {
            this.collectedCash += collectedCash;
        }

        public VendingMachine SetCollectedCash(int collectedCash)
        {
            this.collectedCash = collectedCash;
            return this;
        }

        public IState GetState()
        {
            return state;
        }

        public VendingMachine SetState(IState state)
        {
            this.state = state;
            return this;
        }

        public void RemoveProduct(String productCode)
        {

        }

        public void DispenseChange(String productCode)
        {
            this.state.DispenseChange(productCode);
        }

        public void CancelTransaction()
        {
            this.state.CancelTransaction();
        }

        public int CalculateChange(String productCode)
        {
            return collectedCash - this.productCodePriceMap[productCode];
        }

        public void DispenseItem(String productCode)
        {
            this.state.DispenseItem(productCode);
        }

        public int GetCollectedCash()
        {
            return collectedCash;
        }
    }
}
