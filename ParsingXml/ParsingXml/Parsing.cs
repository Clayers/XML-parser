using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParsingXml
{
    class Parsing
    {
        public List<string> DataAttribute; //data stored in arguments
     public Parsing()
        {
            DataAttribute = new List<string>();
        }
        public List<string> Pars(string XML, string Tag, string Attribute)
        {

            if (String.IsNullOrEmpty(XML)==false)
            {
                try
                {
                    XmlDocument Xdoc = new XmlDocument();
                    Xdoc.LoadXml(XML);
                    XmlNodeList ElemListTag = Xdoc.GetElementsByTagName(Tag);
                    for (int i = 0; i < ElemListTag.Count; i++)
                    {
                        if (ElemListTag[i].Attributes[Attribute].Value !=null)
                        {
                            DataAttribute.Clear();
                           
                            DataAttribute.Add(ElemListTag[i].Attributes[Attribute].Value);
                        }
                    }
                  
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    throw;
                }
            }
            return DataAttribute;
        }

      


    }
}
