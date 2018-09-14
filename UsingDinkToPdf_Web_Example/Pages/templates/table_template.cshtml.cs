using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UsingDinkToPdf_Web_Example.Pages.templates
{
    public class table_templateModel : PageModel
    {

        public List<DataModel> DataModels = new List<DataModel>();

        public void OnGet()
        {
            DataModels.Add(new DataModel()
            {
                ProductCode = "0000.0000.00001",
                ProductName = "Material #1",
                UnitPrice = 1000
            });
            DataModels.Add(new DataModel()
            {
                ProductCode = "0000.0000.00002",
                ProductName = "Material #2",
                UnitPrice = 2500
            });
            DataModels.Add(new DataModel()
            {
                ProductCode = "0000.0000.00003",
                ProductName = "Material #3",
                UnitPrice = 1250
            });
            DataModels.Add(new DataModel()
            {
                ProductCode = "0000.0000.00004",
                ProductName = "Material #4",
                UnitPrice = 1399
            });
        }
    }


    public class DataModel
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}