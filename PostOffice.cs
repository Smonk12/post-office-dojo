public class PostOffice
{
    private List<PostedItem> _items;
    public PostOffice()
    {
        _items = new List<PostedItem>();
    }
    public void PostItem(PostedItem item)
    {
        _items.Add(item); // Store items
    }
    public void PrintItemsBasedOnDate(string date)
    { 
      foreach (var item in _items)
        {
            if (item.PostedDate == date)
            {
                Console.WriteLine($"Item posted on {date}: {item.Address}, Price: {item.GetPrice()}");
            }
        }   
    }

    public void CalculateTotalByType(string type)
    {
        if(type == "letter")
        {
            double total = 0;
            foreach (var item in _items)
            {
                if (item is Letter letter)
                {
                    total += letter.GetPrice();
                }
            }
            Console.WriteLine($"Total price for letters: {total}");
        }
        else if (type == "small box")
        {
            double total = 0;
            foreach (var item in _items)
            {
                if (item is Box box && box.GetPrice() < 8)
                {
                    total += box.GetPrice();
                }
            }
            Console.WriteLine($"Total price for boxes: {total}");
        }
        else if (type == "big box")
        {
            double total = 0;
            foreach (var item in _items)
            {
                if (item is Box box && box.GetPrice() > 8)
                {
                    total += box.GetPrice();
                }
            }
            Console.WriteLine($"Total price for boxes: {total}");
        }
        else
        {
            Console.WriteLine("Unknown item type.");
        }
    }
}