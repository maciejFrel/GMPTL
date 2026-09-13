namespace Console.Otodom;

public class OtodomResult
{
    public PageProps PageProps { get; set; }
}

public class PageProps
{
    public Data Data { get; set; }
}

public class Data
{
    public SearchAds SearchAds { get; set; }
}

public class SearchAds
{
    public IEnumerable<Item> Items { get; set; }
}

public class Item
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public TotalPrice? TotalPrice { get; set; }
    public decimal? AreaInSquareMeters { get; set; }
    public Location? Location { get; set; }
}

public class Location
{
    public Address? Address { get; set; }
}

public class Address
{
    public Street? Street { get; set; }
    public City? City { get; set; }
    public Province? Province { get; set; }
}
public class Street
{
    public string Name { get; set; }
}

public class City
{
    public string Name { get; set; }
}

public class Province
{
    public string Name { get; set; }
}

public class TotalPrice
{
    public decimal Value { get; set; }
    public string Currency { get; set; }
}