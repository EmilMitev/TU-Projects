namespace CheckoutModule.Contracts
{
    public interface ISellable
    {
        int Id { get; set; }

        string Name { get; set; }

        decimal Price { get; set; }

        string Measurement { get; set; }

        int Quantity { get; set; }

        decimal Total { get; }
    }
}