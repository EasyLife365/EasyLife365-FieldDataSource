using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EL.FieldDataSource
{
    public static class DepartmentsHttpTrigger
    {
        [FunctionName(nameof(DepartmentsHttpTrigger))]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = "departments")] HttpRequest req,
            ILogger log)
        {
            string language = req.Query["lng"];

            List<DropdownOption> options = new List<DropdownOption>();
            options.Add(new DropdownOption() { Key = "Key1", Text = "Marketing" });
            options.Add(new DropdownOption() { Key = "Key2", Text = "Information Technology" });
            options.Add(new DropdownOption() { Key = "Key3", Text = "Production" });

            switch (language)
            {
                case "de":
                    options[0].Text = "Marketing";
                    options[1].Text = "Informationstechnologie";
                    options[2].Text = "Produktion";
                    break;
                case "fr":
                    options[0].Text = "Commercialisation";
                    options[1].Text = "Informatique";
                    options[2].Text = "Production";
                    break;
                default:
                    break;
            }

            return new OkObjectResult(options.OrderBy((p) => p.Text));
        }
    }
}
