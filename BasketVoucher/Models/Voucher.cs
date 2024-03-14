namespace BasketVoucher.Models
{
    public interface Voucher {
        //interface for voucher types
        decimal ApplyDiscount(decimal basketTotal);
        decimal GetDiscountAmount();
    }
}
