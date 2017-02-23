using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01TheaThePhotographer
{
    class Pr01TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long pictures = int.Parse(Console.ReadLine());
            long downLoadSeconds = int.Parse(Console.ReadLine());
            long percentage = int.Parse(Console.ReadLine());
            long upLoadSeconds = int.Parse(Console.ReadLine());
            double filterTime = pictures * downLoadSeconds;
            double goodPictures = Math.Ceiling(pictures * (percentage / 100.0));
            double upLoadTime = goodPictures * upLoadSeconds;
            long totalTime = (long)(filterTime + upLoadTime);
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            string format = @"d\:hh\:mm\:ss";
            Console.WriteLine(time.ToString(format));
        }
    }
}
