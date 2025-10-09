namespace Dota2Helper.Core
{
    public static class CommonExtensions
    {
        public static int Trunc(this double arg)
        {
            return (int)Math.Truncate(arg);
        }

        public static string ToFixed(this double arg, int charAfterPointCount)
        {
            if (charAfterPointCount < 0) charAfterPointCount = 0;
            if (charAfterPointCount > 3) charAfterPointCount = 3;

            return arg.ToString($"F{charAfterPointCount}");
        }
    }
}
