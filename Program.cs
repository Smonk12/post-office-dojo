using System;
using System.Collections.Generic;
namespace post_office_dojo;
class Program
{
    static void Main(string[] args)
    {
        PostOffice office = new PostOffice();

        // Add some test items
        office.PostItem(new Letter("123 Street", "2025-07-10"));
        office.PostItem(new Letter("456 Avenue", "2025-07-10"));
        office.PostItem(new Box("789 Boulevard", "2025-07-10", "small", 0));
        office.PostItem(new Box("321 Road", "2025-07-10", "big", 200));

        // Test: print items posted on a specific date
        Console.WriteLine("Items posted on 2025-07-10:");
        office.PrintItemsBasedOnDate("2025-07-10");
        Console.WriteLine();

        // Test: calculate totals
        office.CalculateTotalByType("letter");
        office.CalculateTotalByType("small box");
        office.CalculateTotalByType("big box");
    }
}
