

namespace BuilderPattern
{
    public class OnlineOrder
    {
        public List<string> Items { get; }
        public string ShippingAddress { get; }
        public decimal TotalAmount { get; }
        public decimal DiscountAmount { get; }

        // Private constructor for immutability
        private OnlineOrder(List<string> items, string shippingAddress, decimal totalAmount, decimal discountAmount)
        {
            Items = items;
            ShippingAddress = shippingAddress;
            TotalAmount = totalAmount;
            DiscountAmount = discountAmount;
        }

        // Builder class
        public class Builder
        {
            private List<string> items = new List<string>();
            private string shippingAddress = string.Empty;
            private decimal totalAmount;
            private decimal discountAmount;

            public Builder AddItem(string item)
            {
                items.Add(item);
                return this;
            }

            public Builder SetShippingAddress(string address)
            {
                shippingAddress = address;
                return this;
            }

            public Builder SetTotalAmount(decimal amount)
            {
                totalAmount = amount;
                return this;
            }

            public Builder ApplyDiscount(decimal discount)
            {
                discountAmount = discount;
                return this;
            }

            public OnlineOrder Build()
            {
                // Perform any additional logic or validation if needed before creating the OnlineOrder object
                // For example, calculate the total amount based on items and apply discounts.

                // Simulating some logic to calculate the total amount and apply discount
                decimal calculatedTotal = CalculateTotalAmount(items);
                decimal calculatedDiscount = CalculateDiscount(calculatedTotal, discountAmount);

                return new OnlineOrder(items, shippingAddress, calculatedTotal, calculatedDiscount);
            }

            private decimal CalculateTotalAmount(List<string> items)
            {
                // Simulated logic to calculate the total amount based on items
                return items.Count * 10.0m; // Assuming each item costs $10
            }

            private decimal CalculateDiscount(decimal totalAmount, decimal discountAmount)
            {
                // Simulated logic to apply discount
                return Math.Min(totalAmount, discountAmount);
            }
        }
    }

}
