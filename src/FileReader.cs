using System.IO;
using G1000Rx;

namespace GarminDataProcessor
{
    static class FileReader
    {
        public static byte[] ReadFile(string fileName)
        {
            byte[] data;

            using (FileStream fs = File.OpenRead(fileName))
            {
                data = new byte[fs.Length];
                fs.Read(data, 0, data.Length);
            }

            return data;
        }
    }
}
