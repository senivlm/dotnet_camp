using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Task2
    {
        public List<KeyValuePair<int, int[]>> LongestHorizontalLine(int[] mat)
        {
            Dictionary<int, int[]> dict = new Dictionary<int, int[]>();

            int color = mat[0];
            int start = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                if (color != mat[i])
                {
                    if (dict.ContainsKey(color))
                    {
                        if (dict[color][1] - dict[color][0] < (i - 1) - start)
                        {
                            dict[color][0] = start;
                            dict[color][1] = i - 1;
                            dict[color][2] = i - start;
                        }
                        color = mat[i];
                        start = i;
                        dict.Add(color, new int[] { start, i, 1 });
                    }
                    else
                    {
                        dict.Add(color, new int[] { start, i - 1, 1});
                        color = mat[i];
                        start = i;
                    }
                }
                else
                {
                    if (dict.ContainsKey(color))
                    {
                        ++dict[color][1];
                        ++dict[color][2];
                    }
                    else
                    {
                        dict.Add(color, new int[] { start, i, i - start + 1});
                    }
                }
            }

            int maxLength = dict.Max(x => (x.Value[1] - x.Value[0]));

            var list = dict.Where(x => (x.Value[1] - x.Value[0]) == maxLength).ToList();

            return list;
        }

        public void Print(List<KeyValuePair<int, int[]>> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"Color: {item.Key}; Start index: {item.Value[0]}, End inedx: {item.Value[1]}; Length: {item.Value[2]};");
            }
        }
    }
}
