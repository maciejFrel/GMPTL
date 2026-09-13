using Console;
using Console.Parser;
using Newtonsoft.Json;

var otodomParser = new OtodomParser();

var criteria = new Criteria(
    1000,
    2000,
    70,
    1000,
    300000,
    7000000
);

var otodomResults = await otodomParser.ParseAsync(criteria);

System.Console.WriteLine(JsonConvert.SerializeObject(otodomResults, Formatting.Indented));
