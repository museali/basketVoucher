using BasketVoucher.Models;

// Basket 1
Basket basket1 = new Basket();
basket1.AddItem(new Item("Coat", 20.00m, 1));
basket1.AddItem(new Item("Hat", 40.00m, 1));
basket1.AddVoucher(new GiftVoucher(5.00m));
basket1.AddVoucher(new DiscountVoucher(50.00m, 1.00m));
basket1.AddVoucher(new GiftVoucher(1.00m));
basket1.AddVoucher(new DiscountVoucher(50.00m, 2.00m));
basket1.AddVoucher(new GiftVoucher(5.00m));
basket1.AddVoucher(new DiscountVoucher(50.00m, 3.00m));
// Print receipt for Basket 1
basket1.PrintReceipt();
