using Dota2Helper.Core;

namespace Dota2Helper.WinFormApp.ui_images
{
    public static class UiImages
    {
        private const string BasePath = "ui-images";

        public static UiImage HeroUniversal =
            new UiImage(
                nameof(HeroUniversal),
                Path.Combine(BasePath, "hero_universal.png"));

        public static UiImage HeroAgility =
            new UiImage(
                nameof(HeroAgility),
                Path.Combine(BasePath, "hero_agility.png"));

        public static UiImage HeroStrength =
            new UiImage(
                nameof(HeroStrength),
                Path.Combine(BasePath, "hero_strength.png"));

        public static UiImage HeroIntelligence =
            new UiImage(
                nameof(HeroIntelligence),
                Path.Combine(BasePath, "hero_intelligence.png"));

        public static UiImage GetFor(PrimaryAttrEnum primaryAttrEnum)
        {
            switch (primaryAttrEnum)
            {
                case PrimaryAttrEnum.Agility:
                    return HeroAgility;
                case PrimaryAttrEnum.Intelligence:
                    return HeroIntelligence;
                case PrimaryAttrEnum.Strength:
                    return HeroStrength;
                case PrimaryAttrEnum.Universal:
                    return HeroUniversal;
                default:
                    return HeroUniversal;
            }
        }
    }
}
