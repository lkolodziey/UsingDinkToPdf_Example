using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsingDinkToPdf_Web_Example.Helpers
{
    public class PDFHelper
    {
        private readonly IConverter _converter;
        private readonly IConfiguration _configuration;

        public PDFHelper(IConverter converter, IConfiguration configuration)
        {
            _converter = converter;
            _configuration = configuration;
        }

        public void CreateReport()
        {
            var fileOutputFolderPath = _configuration.GetValue<string>("FileOutputFolderPath");
            var baseUrl = _configuration.GetValue<string>("BaseURL");
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings =
                {
                    ColorMode = ColorMode.Color,
                    Orientation = Orientation.Portrait,
                    PaperSize = PaperKind.A4,
                    Margins = new MarginSettings() { Top = 10 },
                    Out = fileOutputFolderPath + "Document_" + DateTime.Now.ToString("yyyy-MM-dd_HH-ss") + ".pdf"
                },
                Objects =
                {
                    new ObjectSettings()
                    {
                        Page = baseUrl +"/templates/table_template"
                    }
                }
            };
            _converter.Convert(doc);
        }

    }
}
