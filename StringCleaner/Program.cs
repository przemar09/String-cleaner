using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder text = new StringBuilder();
            string stringText;

            using (StreamReader reader = new StreamReader("C:\\plik.txt"))
            {
                string line;
                
                while((line = reader.ReadLine()) != null)
                {
                    text.Append(line);
                    text.Append("\n");
                }
            }

            stringText = text.ToString();
            stringText = StringCleaner(stringText);

            Console.Write(stringText);
            Console.ReadKey();
        }

        public static string StringCleaner(string name)
        {
            string result;
            result = name;
            char[] whitespaces = new char[] { ' ', '\n','\r', '\t'};

            foreach(char sign in whitespaces)
            {
                result = result.Replace(sign.ToString(), "");
            }
            result = result.ToLowerInvariant();

            if(result.Length != 0)
            {
                result = result[0].ToString().ToUpperInvariant() + result.Substring(1, result.Length - 1);
            }

            return result;
        }
    }
}
