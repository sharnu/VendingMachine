using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class State : IState
    {
        public virtual void CancelTransaction()
        {
            throw new Exception("Unable to cancel transaction.");
        }

        public virtual void DispenseChange(string productCode)
        {
            throw new Exception("Unable to dispense change.");
        }

        public virtual void DispenseItem(string productCode)
        {
            throw new Exception("Unable to dispense item.");
        }

        public virtual void CollectCash(int cash)
        {
            throw new Exception("Unable to collect cash.");
        }
    }
}
