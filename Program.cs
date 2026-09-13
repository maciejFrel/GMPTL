using Console;
using Newtonsoft.Json;

var parser = new Parser();

// System.Console.Write("Metraż domu: ");
// var metrazDomu = System.Console.ReadLine();
// System.Console.Write("Metraż dzialki: ");
// var metrazDzialki = System.Console.ReadLine();
// System.Console.Write("Cena MAX: ");
// var cenaMax = System.Console.ReadLine();
// System.Console.Write("Cena MIN: ");
// var cenaMin = System.Console.ReadLine();

// if (metrazDomu != null && metrazDzialki != null && cenaMin != null && cenaMax != null)
// {
// var criteria = new Criteria(
//     Decimal.Parse(metrazDomu),
//     Decimal.Parse(metrazDzialki),
//     Decimal.Parse(cenaMin),
//     Decimal.Parse(cenaMax)
// );

var criteria = new Criteria(
    1000,
    2000,
    70,
    1000,
    300000,
    7000000
);

var otodomResults = await parser.ParseOtodom(criteria);

System.Console.WriteLine(JsonConvert.SerializeObject(otodomResults, Formatting.Indented));
