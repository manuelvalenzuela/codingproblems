namespace CodingProblems
{
    using System;

    public class ConvertToNumberClass
    {
        public static bool ConvertToNumber(string str)
        {
            bool canConvert = false;
            try
            {
                int n = Int16.Parse(str);

                if (n != 0)
                {
                    canConvert = true;
                }
            }
            catch (Exception ex)
            {
            }

            bool retval = false;
            if (canConvert == true)
            {
                retval = true;
            }

            return retval;
        }
    }
}