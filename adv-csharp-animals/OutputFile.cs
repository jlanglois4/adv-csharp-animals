using System;
using System.IO;

namespace adv_csharp_animals
{
    public class OutputFile
    {
        private readonly string _fileName;

        public OutputFile(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteNewLine(string line)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(_fileName))
                {
                    writer.WriteLine(line);
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Write Error: {_fileName} - {e}");
            }
        }
        


    }
}