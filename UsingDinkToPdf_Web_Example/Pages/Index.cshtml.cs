using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace UsingDinkToPdf_Web_Example.Pages
{
    public class IndexModel : PageModel
    {

        private readonly IConverter _converter;
        private readonly IConfiguration _configuration;
        public IndexModel(IConverter converter, IConfiguration configuration)
        {
            _converter = converter;
            _configuration = configuration;
        }


        public void OnGet()
        {

        }
        public void OnPost()
        {
            Helpers.PDFHelper helper = new Helpers.PDFHelper(_converter, _configuration);
            helper.CreateReport();

        }
    }
}
