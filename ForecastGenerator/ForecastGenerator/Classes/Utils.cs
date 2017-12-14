using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForecastGenerator.Classes
{
    public static class Utils
    {
        public static void LoadForecastDTO(ForecastDTO loadObject, string historicalCSVPath)
        {
            using (var stream = new FileStream(historicalCSVPath, FileMode.Open))
            {
                using (var reader = new StreamReader(stream))
                {
                    reader.ReadLine();
                    //
                    List<string> splitRow = new List<string>();
                    while (reader.EndOfStream == false)
                    {
                        splitRow = reader.ReadLine().Split(',').ToList<string>();
                        if (splitRow.Count != 5) break;
                        loadObject.AddDataRow(DateTime.Parse(splitRow[0]), double.Parse(splitRow[1]), double.Parse(splitRow[2]), double.Parse(splitRow[3]), double.Parse(splitRow[4]));
                    }
                }
                //
                
            }
        }
    }
}
