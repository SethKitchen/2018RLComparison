using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParseNNLog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("alien.txt"))
            {
                using (StreamWriter sw = new StreamWriter("xyalien.csv"))
                {
                    using (StreamWriter sw2 = new StreamWriter("xyalienaveraged.csv"))
                    {
                        sw.AutoFlush = true;
                        double x = 0, y = 0;
                        double trainfpssum = 0;
                        double trainfpscount = 0;
                        double trainYsSum=0;
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line.Contains("train_frames:") && line.Contains("reward:"))
                            {
                                var split = line.Split(' ');
                                x = double.Parse(split[1]);
                                y = double.Parse(split[3]);
                                long toAdd = (long)Math.Round(double.Parse(split[5]));
                                trainYsSum += y;
                                trainfpssum += toAdd;
                                trainfpscount++;
                                sw.WriteLine(x + "," + y);
                                sw2.WriteLine(x + "," + trainYsSum / trainfpscount);
                            }
                        }
                        double avFPS = trainfpssum / trainfpscount;
                        Console.WriteLine("Average FPS:" + avFPS);
                        Console.WriteLine("Run time (s): " + x / avFPS);
                    }
                }
            }
        }
    }
}
