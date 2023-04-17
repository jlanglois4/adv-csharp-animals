using System;
using System.IO;

namespace adv_csharp_animals
{
    public class InputFile
    {
        private string _fileName;
        public InputFile(string fileName)
        {
            _fileName = fileName;
        }

        public void ReadEntireFile()
        {
            try
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    string contents = reader.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} - {e}");
            }
        }
        
        public string IterateLines()
        {
            string line;
            try
            {
                using (StreamReader reader = new StreamReader(_fileName))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} - {e}");
                line = null;
            }
            
            return line;
        }
    }
}