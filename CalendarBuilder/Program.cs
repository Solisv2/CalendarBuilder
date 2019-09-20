using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DataBuilder db = new DataBuilder();
            db.StartCount = 6;
            db.EndCount = 31;
            Console.WriteLine(db.GetData());


        }
    }
    public class DataBuilder
    {
        public int EndCount { get; set; }
        public int StartCount { get; set; }
        public string GetData()
        {
            StringBuilder sb = new StringBuilder();
            //StringBuilder sb = new StringBuilder($"{StartCount}", 20);
            //int l = StartCount;
            //while (l<=EndCount)
            //{
            //    sb.Append(" ");
            //    l++;
            //    sb.Append(l);
            //}
            int ModAns=0;
            for (int i = StartCount; i <= EndCount; i++)
            {
                sb.Append($"{i, 5}");
                sb.Append(" ");
                ModAns = i % 7;
                if (ModAns == 0)
                {
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
