using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public interface IState : ICollectCash, IDispenseChange , IDispenseItem , ICancelTransaction
    {
    }

    public interface ICollectCash
    {
        public void CollectCash(int cash);
    }
    public interface IDispenseChange
    {
        public void DispenseChange(String productCode);
    }
    public interface IDispenseItem
    {
        public void DispenseItem(String productCode);
    }
    public interface ICancelTransaction
    {
        public void CancelTransaction();
    }


}
