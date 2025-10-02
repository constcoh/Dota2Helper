// See https://aka.ms/new-console-template for more information
using Dota2Helper.Core;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.WriteLine("Hello, World!");


var json = string.Concat(await File.ReadAllLinesAsync("heroes.json"));

var jsonSerializerOptions = new JsonSerializerOptions();
jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

var heroes = JsonSerializer.Deserialize<List<HeroSettings>>(json, jsonSerializerOptions);

var minDistance = int.MaxValue;
for (int i = 0; i < heroes.Count; ++i)
{
    for (int j = i+1; j < heroes.Count; ++j)
    {
        var d = heroes[i].HeroName.GetDistanceTo(heroes[j].HeroName);

        if (d == 1) Console.WriteLine(heroes[i].Name + " " + heroes[j].Name);
        minDistance = Math.Min(minDistance, d);
    }
}



var windranger = heroes
    .FirstOrDefault(x => "windranger".Equals(x.Name, StringComparison.InvariantCultureIgnoreCase));

Console.WriteLine("end");