using System;
using System.IO;

namespace TemplateMethod.Abstract
{
    public abstract class TxtConverterTemplate<TFormat>
    {
        private byte[] ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("File not found");
            }

            string ext = Path.GetExtension(path);

            if (ext != ".txt")
            {
                throw new Exception($"{ext} Not suported file extension");
            }

            return File.ReadAllBytes(path);
        }

        internal abstract TFormat Convert(byte[] fileBytes);

        public TFormat FormatTxt(string path)
        {
            byte[] fileBytes = ReadFile(path);
            return Convert(fileBytes);
        }
    }
}
