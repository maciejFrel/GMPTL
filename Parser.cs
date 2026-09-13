using Console.Otodom;
using Newtonsoft.Json;

namespace Console;

public class Parser
{
    public static int ResultCountLimit = 24;
    public static int Radius = 100;
    
    public async Task<IEnumerable<ParseResult>> ParseOtodom(Criteria criteria)
    {
        HttpClient client = new HttpClient();
        
        client.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
            "(KHTML, like Gecko) Chrome/140.0.0.0 Safari/537.36");
        
        var url = $"https://www.otodom.pl/_next/data/SWJkN54wyeYZynSvwFsw7/pl/wyniki/sprzedaz/mieszkanie/pomorskie/nowodworski/nowy-dwor-gdanski/nowy-dwor-gdanski.json?distanceRadius={Radius}&limit={ResultCountLimit}&ownerTypeSingleSelect=ALL&priceMin={criteria.priceMin}&priceMax={criteria.priceMax}&areaMin={criteria.interiorAreaMin}&areaMax={criteria.interiorAreaMax}&buildingType=%5BHOUSE%5D&by=DEFAULT&direction=DESC&searchingCriteria=sprzedaz&searchingCriteria=mieszkanie&searchingCriteria=pomorskie&searchingCriteria=nowodworski&searchingCriteria=nowy-dwor-gdanski&searchingCriteria=nowy-dwor-gdanski";
        
        try {
            var response = await client.GetAsync(url);

            // System.Console.WriteLine($"Status: {(int)response.StatusCode} {response.StatusCode}");
            // System.Console.WriteLine($"Content-Type: {response.Content.Headers.ContentType}");
            
            var content = await response.Content.ReadAsStringAsync();
            
            var contentObject = JsonConvert.DeserializeObject<OtodomResult>(content);
            if (contentObject == null)
            {
                return new List<ParseResult>();
            }
            
            // System.Console.WriteLine(contentObject);
            // System.Console.WriteLine(content[..Math.Min(2000, content.Length)]);

            return ParseResult.From(contentObject);
        }
        catch (HttpRequestException ex)
        {
            System.Console.WriteLine(ex.Message);
            return new List<ParseResult>();
        }
    }

    public async Task<IEnumerable<ParseResult>> ParseOlx(Criteria criteria)
    {
        // todo: implement olx parser
        return new List<ParseResult>();
    }
}