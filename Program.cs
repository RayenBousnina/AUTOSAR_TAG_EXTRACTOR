using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace AUTOSAR_TAG_EXTRACTOR_577
{
    internal class Program
    {
        static void Main(string[] args)
        {
            extractTagFromARXMLbyStackWord();
            Console.ReadLine();
        }
        const string xsdFile = @"C:\Users\Rayen\source\repos\AUTOSAR_4-3-0_STRICT_COMPACT.xsd";
        static void extractTagFromARXMLbyStackWord()
        {
            XDocument xdoc = XDocument.Load(xsdFile);
            while (true)
            {
                Console.WriteLine("please insert the keyWord: ");
                string StackWord = Console.ReadLine();
                //Console.WriteLine( keyBrdValue + " is read by console"); //just besh n'tasti li heya dakhlet that's all
                var xroot = xdoc.Root;// l'contenu mtaa racine => ya3ni l fichier kollou
                var tagg = xroot.Descendants(StackWord.ToUpper());
                if (!tagg.Any())
                {
                    Console.WriteLine("parameter not provided! please check, and insert again");
                }
                else
                {
                    foreach (var tag in tagg)
                    {
                        Console.WriteLine(tag.ToString());
                    }
                }
            }


        }
    }
}
