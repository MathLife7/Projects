namespace WindowsFormsApplication1
{
    using System;

    class Transaction
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public Product Product { get; set; }
        public TransactionType Type { get; set; }
        public int Quantity { get; set; }
        public Employee Employee { get; set; }

        public enum TransactionType
        {
            ProductAdded = 1,
            ProductRemoved = 2
        }
    }
}
