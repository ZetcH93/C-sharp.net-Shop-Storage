using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace shopIntegration
{
    

    class Program
    {
        static string relativSparvag = @"..\..\..\..\..\Labb4\SimpleMedia\bin\Debug\"; //default värden till sökväg som jag använde.

        static void Main(string[] args)
        {
           
            string relativSokvagEtt = @"..\..\..\..\..\labb3b\laboration 3b\bin\Debug\Export\";  //default värden till sökväg som jag använde.
            string relativSokvagTva = @"..\..\..\..\..\labb3b\laboration 3b\bin\Debug\";  //default värden till sökväg som jag använde.        

            Console.WriteLine("Mata in den sökväg där programmet ska leta efter ändringar: ");
            relativSokvagTva = Console.ReadLine();
            

            Console.WriteLine("Mata in den sökväg där programmet ska spara xml filerna: ");
            relativSparvag = Console.ReadLine();

            string fileExport = Path.GetFullPath(relativSokvagEtt);  // får den exakta sökvägen om användaren matat in en relativ
            string fileDebug = Path.GetFullPath(relativSokvagTva); // får den exakta sökvägen om användaren matat in en relativ


            Console.WriteLine("Nu körs shopIntegration");
            Console.WriteLine("Sökväg:" + fileDebug );   
            Console.WriteLine("Sparväg:" + Path.GetFullPath(relativSparvag));

            {
                // programmet körs, och letar efter ändringar i fwExport och FwDebug tills dess att användern matar in 'q' 

                FileSystemWatcher fwExport = new FileSystemWatcher(fileExport, "*.csv");
                FileSystemWatcher fwDebug = new FileSystemWatcher(fileDebug, "*.csv");
              
                fwExport.Changed += new FileSystemEventHandler(FilAndrad);   // event startas 
                fwDebug.Changed += new FileSystemEventHandler(FilAndrad);

                fwExport.EnableRaisingEvents = true;
                fwDebug.EnableRaisingEvents = true; // dessa två måste vara true för att watchersen ska ligga o lyssna

                Console.WriteLine("Tryck 'q' för att avsluta");
                while (Console.Read() != 'q') ;
            }
        }

        private static void FilAndrad(object s, FileSystemEventArgs e)
        {
            // listor som innehåller alla värden i .csv filen 
            List<string> namn = new List<string>();
            List<int> id = new List<int>();
            List<int> antal = new List<int>();
            List<double> price = new List<double>();
            string[] lines = File.ReadAllLines(e.FullPath);          
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');  
                
                namn.Add(fields[0].ToString());
                price.Add(double.Parse(fields[1]));
                id.Add(int.Parse(fields[2]));
                antal.Add(int.Parse(fields[3]));
                
            }
            
            toXMLConverter(namn, id, antal, price); // skickar dessa listor till en xmlconverter och gör om dem till xml
            
        }

        public static void toXMLConverter(List<string> namn, List<int> id, List<int> antal, List<double> price)
        {

            string fullPathSave = (Path.GetFullPath(relativSparvag) + "productList.xml"); // här sparas xml filen efter att den har konverteras
            XmlWriterSettings xwInstallningar = new XmlWriterSettings();
            xwInstallningar.Indent = true;

            XmlWriter xw = XmlWriter.Create(fullPathSave, xwInstallningar);

            xw.WriteStartDocument();
            xw.WriteStartElement("Inventory");
            for(int i = 0; i < namn.Count; i++)     // för de tomma rader så har jag användt mig av "Not defined" som då visas i SimpleMedia programmet.
            {
                xw.WriteStartElement("Item");
                xw.WriteStartElement("Name");
                xw.WriteString(namn[i]);
                xw.WriteEndElement();

                xw.WriteStartElement("Count");
                xw.WriteString(antal[i].ToString());
                xw.WriteEndElement();

                xw.WriteStartElement("Price");
                xw.WriteString(price[i].ToString());
                xw.WriteEndElement();

                xw.WriteStartElement("Comment");
                xw.WriteString("Not defined");
                xw.WriteEndElement();

                xw.WriteStartElement("Artist");
                xw.WriteString("Not defined");
                xw.WriteEndElement();

                xw.WriteStartElement("Publisher");
                xw.WriteString("Not defined");
                xw.WriteEndElement();

                xw.WriteStartElement("Genre");
                xw.WriteString("Not defined");
                xw.WriteEndElement();

                xw.WriteStartElement("Year");
                xw.WriteString("0000");
                xw.WriteEndElement();

                xw.WriteStartElement("ProductID");             
                xw.WriteString(id[i].ToString());
                xw.WriteEndElement(); 
                
                xw.WriteEndElement();
               
            }
            
         
            xw.WriteEndElement();
            xw.Close();
        }
      

   
    }
}
