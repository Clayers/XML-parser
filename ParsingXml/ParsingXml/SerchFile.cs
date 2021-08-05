using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingXml
{
   
    class SerchFile
    {
        public string folder;

        public SerchFile(string path)
        {
            folder=path;
        }
        public List<string> GetAllFiles( string FileExtensions)
        {
            try
            {
                List<string> files = new List<string>();
                files.AddRange(Directory.GetFiles(folder, FileExtensions, SearchOption.AllDirectories)); 
                return files;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string GetStringFile(string path)
        {
            string Date = @"";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    Date = sr.ReadToEnd();
                    return Date;
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        
        }
        public void Path()
        {
            string file = Directory.GetCurrentDirectory();
            file = file.Replace(@"\bin\Debug", string.Empty);
            folder = file + folder;
        
        }

    }
}
