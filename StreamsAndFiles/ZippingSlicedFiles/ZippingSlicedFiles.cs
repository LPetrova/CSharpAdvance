using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZippingSlicedFiles
{
    internal class ZippingSlicedFiles
    {
        private static void Main(string[] args)
        {
            using (GZipStream unzipStream = new GZipStream(new MemoryStream(bufferZip), CompressionMode.Decompress))
            {
                byte[] buffer = new byte[4096];
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    int bytesRead = 0;
                    do
                    {
                        bytesRead = unzipStream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                            memoryStream.Write(buffer, 0, bytesRead);
                    } while (bytesRead > 0);
                    memoryStream.Write(buffer, 0, bytesRead);
                    unzipStream.Close();

                }
            }
        }

        public static byte[] bufferZip { get; set; }
    }
}
