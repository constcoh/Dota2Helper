using System.Text.Json.Serialization;
using System.Text.Json;

namespace Dota2Helper.Core
{
    public static class AllHeroSettings
    {
        public static HeroSettings[] Heroes { get; }

        static AllHeroSettings()
        {
            var jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());

            var json = string.Concat(File.ReadAllLines("heroes.json"));

            Heroes = JsonSerializer.Deserialize<HeroSettings[]>(json, jsonSerializerOptions);
        }

        public static HeroSettings Find(string name)
        {
            var heroNameToFind = new HeroName(name);

            return Heroes
                .OrderBy(x => x.HeroName.GetDistanceTo(heroNameToFind))
                .FirstOrDefault();
        }
    }
}
