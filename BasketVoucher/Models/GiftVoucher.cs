namespace BasketVoucher.Models
{
    public class GiftVoucher : Voucher {
        // The GiftVoucher class implements the Voucher interface
        
        private decimal discountAmount;

        public GiftVoucher(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        //Subtract total amount from basket
        public decimal ApplyDiscount(decimal basketTotal)
        {
            return basketTotal - discountAmount;
        }

        //retrun discount amount
        public decimal GetDiscountAmount()
        {
            return discountAmount;
        }
    }
}
