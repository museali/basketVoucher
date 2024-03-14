

namespace BasketVoucher.Models
{
    public class Basket {
        // Represents a shopping basket.
        private List<Item> items = new List<Item>();
        private List<Voucher> vouchers = new List<Voucher>();

        // Add items to basket
        public void AddItem(Item item)
        {
            items.Add(item);
        }

        // Add voucher
        public void AddVoucher(Voucher voucher)
        {
            vouchers.Add(voucher);
        }

        //Calculate total cost of items and quantity
        public decimal CalculateTotal()
        {
            decimal itemsTotal = items.Sum(item => item.Price * item.Quantity);

            return itemsTotal;
        }

        public void PrintReceipt()
        {
            decimal itemsTotal = CalculateTotal();

            Console.WriteLine("Basket:");

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Quantity} x {item.Name} @ {item.Price:C}");
            }

            Console.WriteLine("------------");
            Console.WriteLine($"Checkout Total:  {itemsTotal:C}");
            Console.WriteLine("------------");

            Console.WriteLine("Discounts applied:");

            foreach (var voucher in vouchers)
            {
                decimal discountedTotal = voucher.ApplyDiscount(itemsTotal);

                if (discountedTotal != itemsTotal)
                {
                    string voucherType = voucher is GiftVoucher ? "Gift Voucher" : "Discount Voucher";
                    Console.WriteLine($"- 1 x {voucherType} @ {voucher.GetDiscountAmount():C}: Applied");
                }
                else
                {
                    string voucherType = voucher is GiftVoucher ? "Gift Voucher" : "Discount Voucher";
                    Console.WriteLine($"- 1 x {voucherType}: Not applied (Basket total does not meet the threshold)");
                }

                itemsTotal = discountedTotal;
            }

            Console.WriteLine("------------");
            Console.WriteLine($"Total: {itemsTotal:C}");
        }
    }
}
