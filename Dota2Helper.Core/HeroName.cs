using Quickenshtein;

namespace Dota2Helper.Core
{
    public class HeroName
    {
        public const string Alphabet = "ABCDEFGHIJKLMNOPQRTUVWXYZ";

        public HeroName(string name)
        {
            Name = name;
            FormattedName = CalcFormattedName(name);
            Z = CalcZ(FormattedName);
        }

        public string Name { get; }

        public string FormattedName { get; }

        public int[] Z { get; }

        public int GetDistanceTo(HeroName heroName)
        {
            return Levenshtein.GetDistance(FormattedName, heroName.FormattedName);
        }

        //public int GetDistanceTo(HeroName heroName)
        //{
        //    var res = 0;
        //    for (int i = 0; i < Alphabet.Length; ++i)
        //    {
        //        res += Math.Abs(Z[i] - heroName.Z[i]);
        //    }

        //    return res;
        //}

        private static string CalcFormattedName(string name)
        {
            return new string(
                name
                    .ToUpper()
                    .Where(x => Alphabet.Contains(x))
                    .ToArray());
        }

        private int[] CalcZ(string formattedName)
        {
            var z = new int[Alphabet.Length];

            foreach(var a in formattedName)
            {
                ++z[Alphabet.IndexOf(a)];
            }

            return z;
        }
    }
}
