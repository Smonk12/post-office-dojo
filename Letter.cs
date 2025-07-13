namespace post_office_dojo;
public class Letter : PostedItem
{
    public double Price = 1.99;

    public Letter(string address, string postedDate)
        : base(address, postedDate)
    {
    }

    public override double GetPrice()
    {
        return Price;
    }
}
