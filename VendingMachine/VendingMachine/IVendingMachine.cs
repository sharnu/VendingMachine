using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public interface IVendingMachine
    {
        public void AddCollectedCash(int collectedCash);

        public VendingMachine SetCollectedCash(int collectedCash);

        public IState GetState();

        public VendingMachine SetState(IState state);

        public void RemoveProduct(String productCode);


        public void DispenseChange(String productCode);


        public void CancelTransaction();


        public int CalculateChange(String productCode);


        public void DispenseItem(String productCode);


        public int GetCollectedCash();

    }
}