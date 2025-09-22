namespace Dota2Helper.WinFormApp
{
    public static class SizeHelper
    {
        public static int ToRange(this int arg, int min, int max)
        {
            if (max < min) throw new Exception($"Wrong interval min: {min}, max: {max}");
            if (min > arg) return min;
            if (max < arg) return max;
            return arg;
        }
    }
}
