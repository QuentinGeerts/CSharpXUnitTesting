namespace Tools
{
    public static class Int32Extensions
    {
        public static bool IsPrime (this int value)
        {
            if (value < 2)
            {
                throw new InvalidOperationException($"The value {value} must be > 1!");
            }

            int square = (int) Math.Sqrt (value);

            for( int divider = 2; divider <= square; divider++ )
            {
                if (value % divider == 0) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
