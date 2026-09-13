using Console.Otodom;

namespace Console;

public class ParseResult
{
    public string Title { get; init; }
    public decimal LandSize { get; init; }
    public decimal InteriorSize { get; init; }
    public decimal Price { get; init; }
    
    // województwo
    public string Province { get; init; }
    public string City { get; init; }
    public string Street { get; init; }
    public string Url { get; init; }
    public SourceEnum Source { get; init; }

    public static IEnumerable<ParseResult> From(OtodomResult otodomResult) =>
        otodomResult.PageProps.Data.SearchAds.Items.Select(item => new ParseResult()
        {
            Title =  item.Title,
            InteriorSize = item.AreaInSquareMeters ?? 0,
            LandSize = 0,
            Price = item.TotalPrice?.Value ?? 0m,
            Province = item.Location?.Address?.Province?.Name ?? string.Empty,
            City = item.Location?.Address?.City?.Name ?? string.Empty,
            Street = item.Location?.Address?.Street?.Name ?? string.Empty,
            Url = $"https://www.otodom.pl/pl/oferta/{item.Slug}",
            Source = SourceEnum.Otodom,
        });
}