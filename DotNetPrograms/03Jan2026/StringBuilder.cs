using System;
using System.Text;
public class StringBuilding
    {
        public static void BuildString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("world!");
            sb.AppendLine();
            sb.AppendFormat("Current Date and Time: {0}", DateTime.Now);
            Console.WriteLine(sb.ToString());
        }
            
    }
