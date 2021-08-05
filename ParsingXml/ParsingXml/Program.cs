using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingXml
{
    class Program
    {

        static string Path = @"F:\test";//folder path С:\Path
        static string FileType = "*.xml";// file type *.xml *.dtsx *.txt
        static string Tag= "filename"; // Tag
        static string Attribute = "id";// Attribute
        static List<string> files = new List<string>();
        static List<List<string>> Data; 
        static void Main(string[] args)
        {
            SerchFile SerchFile = new SerchFile(Path);
           files=SerchFile.GetAllFiles(FileType);
           // Console.ReadKey();
            Parsing Parsing = new Parsing();
            Data = new List<List<string>>();
            foreach (var file in files)
            {
                FullData(Parsing.Pars(SerchFile.GetStringFile(file),Tag,Attribute),file);
            }
            PrintData();
            Console.ReadKey();
        }
        static void FullData(List<string> XmlData, string file)
        {
            for (int i = 0; i < XmlData.Count; i++)
            {
                List<string> row = new List<string>();
                row.Add(file);
                row.Add(XmlData[i]);
                Data.Add(row);
                
            }

            XmlData.Clear();
           
        }

        static void PrintData()
        {
            for (int i = 0; i < Data.Count; i++)
            {
              
           
                    Console.WriteLine("file: "+Data[i][0]+ "    Atribute "+ Attribute+ ": "+Data[i][1] );
                
                
            }
        }
    }
}


//<? xml version = "1.0" encoding = "utf-8" ?>
//   < configuration >
//   < Settings >
//   < directory id = "backUpPath" value = "D:/BACKUPS/" ></ directory >
//      < filename id = "feilname" value = "SameName" ></ filename >
//         < period id = "period" value = "15" ></ period >
//           </ Settings >
//           </ configuration >