using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string d = "";
            for (int a =0; a < orig.Length; a++)
            {
                
                for (int b = 0;b < n; b++)
                {
                    d += orig[a]; 
                }                                
            }
            return d ;
        }
    }
}
