using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows;
using System.Xml.Linq;
using System.IO;
using System.Configuration;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Path = @"C:\TestMigration\splitFiles";
         
          
            foreach (string file in Directory.EnumerateFiles(Path, "*.xml"))
            {             

            XDocument doc =  XDocument.Load(file);
            doc.Descendants("ns").Remove();
            doc.Descendants("id").Remove();
            doc.Descendants("parentid").Remove();
            doc.Descendants("timestamp").Remove();
            doc.Descendants("contributor").Remove();
            doc.Descendants("sha1").Remove();
            doc.Descendants("model").Remove();
            doc.Descendants("format").Remove();
            doc.Descendants("minor").Remove();
            doc.Descendants("comment").Remove();
                doc.Descendants("title").Remove();
     
                doc.Save(file);

            }
             
        }
    }
}

