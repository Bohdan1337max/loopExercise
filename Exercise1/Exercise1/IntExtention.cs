namespace Exercise1
{
    public static class IntExtention
    {
        public static int Count(this int num)
        {
            int counter = 0;
            while (num >0)
            {
                counter++;
                num /= 10;
            }
            return counter;
        }
        
    }
}