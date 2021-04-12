using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyLoger
{
    public static class Loger
    {
        public static void WriteLog(string information)
        {
            using (FileStream writer = new FileStream("Bulding.log", FileMode.Append, FileAccess.Write))
            {
                information = Convert.ToString(DateTime.Now) + "  " + information + '\n';
                byte[] inf = Encoding.UTF8.GetBytes(information);
                writer.Write(inf, 0, inf.Length);
            }
        }
    }
}
