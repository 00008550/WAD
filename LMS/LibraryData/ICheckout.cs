using LibraryData.Models;
using System;
using System.Collections.Generic;

namespace LibraryData
{
    public interface ICheckout
    {
        void Add(Checkout newCheckout);
        IEnumerable<Hold> GetCurrentHolds(int id);
        IEnumerable<CheckoutHistory> GetCheckoutHistory(int id);
        IEnumerable<Checkout> GetAll();
        Checkout GetLatestCheckout(int assetId);
        Checkout GetById(int checkoutId);
        string GetCurrentCheckoutPatron(int assetId);
        string GetCurrentHoldPatronName(int id);
        DateTime GetCurrentHoldPlaced(int id);
        bool IsCheckedOut(int id);

        void PlaceHold(int assetId, int libraryCardId);
        void CheckOutItem(int assetId, int libraryCardId);
        void CheckInItem(int assetId, int libraryCardId);
        void MarkFound(int assetId);
        void MarkLost(int assetId);
        
    }
}
