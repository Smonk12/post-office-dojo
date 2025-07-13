namespace post_office_dojo;
public class Box : PostedItem
{
    public string Size;
    public double Weight;

    public Box(string address, string postedDate, string size, double weight)
        : base(address, postedDate)
    {
        Size = size;
        Weight = weight;
    }

    public override double GetPrice()
    {
        if (Size == "small")
        {
            return 7.99;
        }
        else if (Size == "big")
        {
            return 10.29 + 0.29 * Weight;
        }
        else
        {
            return 0;
        }
    }
}
