namespace BasketVoucher.Models
{
    public class DiscountVoucher : Voucher {
        //The DiscountVoucher class also implements the IVoucher interface

        private decimal threshold;
        private decimal discountAmount;

        //Discount voucher takes a thershold and amount
        public DiscountVoucher(decimal threshold, decimal discountAmount)
        {
            this.threshold = threshold;
            this.discountAmount = discountAmount;
        }

        // Apply discount if the threshold is met
        public decimal ApplyDiscount(decimal basketTotal)
        {
            if (basketTotal >= threshold)
            {
                return basketTotal - discountAmount;
            }
            else
            {
                // Returning the original basketTotal if the threshold is not met
                return basketTotal;
            }
        }

        public decimal GetDiscountAmount()
        {
            return discountAmount;
        }
    }
}
