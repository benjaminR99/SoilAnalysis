using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Front
{
    public static class Calculations
    {
        public static List<float> CalcPassingPercentage(List<float> RetainigWheghts)
        {
            float TotalWhight = RetainigWheghts.Sum();
            List<float> Passing = new List<float>();
            float value = 0F;

            foreach (float i in RetainigWheghts)
            {
                value += (i / TotalWhight) * 100;
                Passing.Add(100 - value);
            }
            return Passing;
        }
        public static float DValue(int target, List<float> xValuese, List<float> yValues)
        {   
            xValuese.Sort(); yValues.Sort();
            float x = 0F;
            for (int i = 1; i < yValues.Count; i++)
            {
                if (yValues[i] >= target)
                {
                    // linear interpolation
                    float x1 = xValuese[i - 1];
                    float x2 = xValuese[i];
                    float y1 = yValues[i - 1];
                    float y2 = yValues[i];
                    x = x1 +(((x2 - x1) * (target - y1)) / (y2 - y1));
                    break; 
                }
            }
            return x;
        }

        public static float CUvalue(float D60, float D10)
        {
            return D60 / D10;
        }
        public static float CCvalue(float D60, float D30, float D10)
        {
            return (D30 * D30) / (D10 * D60);
        }
    }
}
