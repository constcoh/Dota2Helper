using System.Text.Json.Serialization;

namespace Dota2Helper.Core
{
    public class HeroSettings
    {
        [JsonPropertyName("name")]
        public string Name 
        {
            get => HeroName?.Name; 
            set => HeroName = new HeroName(value);
        }

        [JsonIgnore]
        public HeroName HeroName
        {
            get;
            private set; 
        }

        [JsonPropertyName("url_name")]
        public string UrlName { get; set; }


        [JsonPropertyName("primary_attr")]
        public PrimaryAttrEnum PrimaryAttr { get; set; }

        [JsonPropertyName("roles")]
        public string[] Roles { get; set; }

        [JsonPropertyName("strength_base")]
        public double StrengthBase { get; set; }

        [JsonPropertyName("strength_gain")]
        public double StrengthGain { get; set; }

        [JsonPropertyName("strength_max")]
        public double StrengthMax { get; set; }

        [JsonPropertyName("intelligence_base")]
        public double IntelligenceBase { get; set; }

        [JsonPropertyName("intelligence_gain")]
        public double IntelligenceGain { get; set; }

        [JsonPropertyName("intelligence_max")]
        public double IntelligenceMax { get; set; }

        [JsonPropertyName("agility_base")]
        public double AgilityBase { get; set; }

        [JsonPropertyName("agility_gain")]
        public double AgilityGain { get; set; }

        [JsonPropertyName("agility_max")]
        public double AgilityMax { get; set; }

        [JsonPropertyName("attributes_base")]
        public double AttributesBase { get; set; }

        [JsonPropertyName("attributes_gain")]
        public double AttributesGain { get; set; }

        [JsonPropertyName("attributes_max")]
        public double AttributesMax { get; set; }



        [JsonPropertyName("health_status")]
        public double HealthStatus { get; set; }

        [JsonPropertyName("health_gain")]
        public double HealthGain { get; set; }

        [JsonPropertyName("health_max")]
        public double HealthMax { get; set; }

        [JsonPropertyName("mana_status")]
        public double ManaStatus { get; set; }

        [JsonPropertyName("mana_max")]
        public double ManaMax { get; set; }

        [JsonPropertyName("attack_damage_max")]
        public double AttackDamageMax { get; set; }

        [JsonPropertyName("attack_damage_gain")]
        public double AttackDamageGain { get; set; }

        [JsonPropertyName("attack_damage_lvl30_max")]
        public double AttackDamageLvl30Max { get; set; }

        [JsonPropertyName("attack_range")]
        public double AttackRange { get; set; }

        [JsonPropertyName("armor")]
        public double Armor { get; set; }

        [JsonPropertyName("armor_gain")]
        public double ArmorGain { get; set; }

        [JsonPropertyName("armor_max")]
        public double ArmorMax { get; set; }

        [JsonPropertyName("movement_speed")]
        public double MovementSpeed { get; set; }

        public int[] GetRoleIndexes()
        {
            if (Roles == null) return new int[0];

            var result = new List<int>();

            var roleIndexNames = new Dictionary<string, int>
            {
                { "Carry",      1 },
                { "Support",    2 },
                { "Disabler",   3 },
                { "Escape",     4 },
                { "Nuker",      5 },
            };

            foreach (var indexName in roleIndexNames)
            {
                if(Roles.Any(x => indexName.Key.Equals(x, StringComparison.InvariantCultureIgnoreCase)))
                {
                    result.Add(indexName.Value);
                }
            }

            return result.ToArray();
        }

        public string GetProTrackerUrl()
        {
            return $"https://dota2protracker.com/hero/{UrlName?.Replace("-", "%20")}";
        }

        public string GetDota2Url()
        {
            return $"https://www.dota2.com/hero/{UrlName?.Replace("-", "")}";
        }
    }
}
