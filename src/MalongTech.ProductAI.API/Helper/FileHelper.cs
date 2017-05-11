using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MalongTech.ProductAI.API.Helper
{
    internal class FileHelper
    {
        public static string GetBoundary()
        {
            return "---------------------------" + DateTime.Now.Ticks.ToString("x");
        }

        public static string GetContentType(string boundary)
        {
            return "multipart/form-data; boundary=" + boundary;
        }

        public static byte[] GetMultipartBytes(FileInfo file, string boundary, Dictionary<string, string> options, string paraName = "search")
        {
            var bytes = new List<byte>();
            bytes.AddRange(BoundaryBytes(boundary));
            if (options != null && options.Count > 0)
            {
                foreach (var opt in options)
                    bytes.AddRange(FieldBytes(opt.Key, opt.Value, boundary));
            }
            bytes.AddRange(FileHeaders(file, paraName));
            bytes.AddRange(File.ReadAllBytes(file.FullName));
            bytes.AddRange(TailBytes(boundary));
            return bytes.ToArray();
        }

        private static byte[] BoundaryBytes(string boundary)
        {
            return Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
        }

        private static byte[] FileHeaders(FileInfo file, string paraName = "search")
        {
            string header = "Content-Disposition: form-data;";
            header += string.Format(" name=\"{0}\";", paraName);
            header += string.Format(" filename=\"{0}\"\r\n", file.Name);
            header += string.Format("Content-Type: {0}\r\n\r\n", SimpleWebRequestHelper.Helper.FileHelper.GetFileType(file));
            return Encoding.UTF8.GetBytes(header);
        }

        private static byte[] FieldBytes(string key, string value, string boundary)
        {
            string field = "Content-Disposition: form-data;";
            field += string.Format(" name=\"{0}\"\r\n\r\n{1}", key, value);
            byte[] fdBytes = Encoding.UTF8.GetBytes(field);
            byte[] bdBytes = BoundaryBytes(boundary);
            var bytes = new List<byte>();
            bytes.AddRange(fdBytes);
            bytes.AddRange(bdBytes);
            return bytes.ToArray();
        }

        private static byte[] TailBytes(string boundary)
        {
            string tail = string.Format("\r\n--{0}--\r\n", boundary);
            return Encoding.UTF8.GetBytes(tail);
        }
    }
}