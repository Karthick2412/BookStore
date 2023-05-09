using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;

namespace BookStore.Controllers
{
    public class Task2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost,ActionName("Index")]
        public IActionResult Index(TableCreate? table)
        {
            Console.WriteLine("TABLE IS ");
            Console.WriteLine(table);
            
            List<TableCreateres> result = new List<TableCreateres>();
            for (int i=1;i<=table.Id;i++)
            {
                TableCreateres eachRow = new TableCreateres();
                List<int> eachRowNumbers = new List<int>();
                int sum = 0;
                for (int j = 1; j <= table.Id; j++)
                {
                    sum += i * j;
                    eachRowNumbers.Add(i*j);
                }
                eachRow.Rows = eachRowNumbers;
                eachRow.Sum = sum;
                float avg=(float)sum / table.Id;
                eachRow.Average= avg;
                
                result.Add(eachRow);
            }
            Console.WriteLine("result IS ");
            string k = JsonConvert.SerializeObject(result);
            Console.WriteLine(JsonConvert.SerializeObject(result));
           // TempData["fileNames"] = JsonConvert.SerializeObject(result);
            //return RedirectToAction("TableResult","Task2", JsonConvert.SerializeObject(result),k);
            return View("TableResult", result);
        }

        
        public IActionResult TableResult(List<TableCreateres> res) {
            
            Console.WriteLine("KKKKKK IS ");
            Console.WriteLine(res);
            //List<TableCreateres> TableRes = JsonConvert.DeserializeObject<List<TableCreateres>>(res);
           // List<TableCreateres> TableRes = TempData["fileNames"] as List<TableCreateres>;
           // Console.WriteLine("TableRes IS ");
            //Console.WriteLine(TableRes);
            return View(res);
        }
    }
}
