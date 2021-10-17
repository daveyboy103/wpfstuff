using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using WpfModels.Models;

namespace SampleRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WpfController : ControllerBase
    {
        [HttpGet("WpfTest")]
        public async Task<ActionResult<MainWindowModel>> GetTest(int id)
        {
            MainWindowModel ret = null;
            bool notFound = false;
            try
            {
                await Task.Factory.StartNew(() =>
                {
                    switch (id)
                    {
                        case 1:
                            ret = new MainWindowModel
                            {
                                Assembly = true,
                                Description = "Description one",
                                PurchaseInformation = "Sold in lots of ten",
                                SupplierCode = "ABC-347888",
                                SupplierName = "OddCo",
                                Length = 1200,
                                Status = "Active",
                                Revision = "2.8",
                                PartNumber = "12390-67899",
                                RawMaterial = "Copper",
                                Mass = 2345.90,
                                Drill = false,
                                Fold = true,
                                Plasma = false,
                                Saw = true,
                                Notes = "none"
                            };

                            break;
                        case 2:
                            ret = new MainWindowModel
                            {
                                Assembly = true,
                                Description = "Description two",
                                PurchaseInformation = "Sold single",
                                SupplierCode = "DFC-56888",
                                SupplierName = "DeftCo",
                                Length = 1200,
                                Status = "Active",
                                Revision = "3.8",
                                PartNumber = "12390-900",
                                RawMaterial = "Steel",
                                Mass = 2345.90,
                                Drill = true,
                                Fold = true,
                                Plasma = true,
                                Saw = true,
                                Laser = true,
                                Notes = "Out of production in December 2021"
                            };
                            break;
                        default:
                            notFound = true;
                            break;
                    }
                });

                if(notFound) 
                    return NotFound($"Id [{id}] was not found");

                return Ok(ret);
            }
            catch (System.Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    $"Error retrieving data from the database. Details: {e.Message}");
            }
        }

        [HttpPut("WpfTest/Apply")]
        public async Task<ActionResult> Apply(MainWindowModel model)
        {
            await Task.Factory.StartNew(() => Console.WriteLine($"Applied: {model.Description}"));
            return Ok();
        }
    }
}
