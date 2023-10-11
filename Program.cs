using System;
using Syncfusion.HtmlConverter;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Syncfusion.Pdf;

using System.Threading.Tasks;


namespace ConsoleApp4
{
    public class Program
    {
        static void Main(string[] args)
        {
            // HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);
            //Initialize HTML to PDF converter with Blink rendering engine
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.Blink);
            BlinkConverterSettings blinkConverterSettings = new BlinkConverterSettings();
            //Set the BlinkBinaries folder path
            blinkConverterSettings.BlinkPath = @"C:\Users\vismun\source\repos\ConsoleApp4\packages\Syncfusion.HtmlToPdfConverter.Net.Windows.23.1.40\runtimes";
            //Assign Blink converter settings to HTML converter
            htmlConverter.ConverterSettings = blinkConverterSettings;
            //Convert URL to PDF
            PdfDocument document = htmlConverter.Convert("https://www.google.com");
            //Save and close the PDF document 

            FileStream fileStream = new FileStream("HTML-to-PDF.pdf", FileMode.CreateNew, FileAccess.ReadWrite);

            document.Save(fileStream);
            document.Close(true);

        }

    }
    
}
