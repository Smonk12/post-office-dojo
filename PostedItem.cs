namespace post_office_dojo;
public class PostedItem
{
    public string Address;
    public string PostedDate;

    public PostedItem(string address, string postedDate)
    {
        Address = address;
        PostedDate = postedDate;
    }

    public virtual double GetPrice()
    {
        return 0;
    }
}
