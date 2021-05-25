using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DeliverySystemClient.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DeliverySystemClient.Controllers
{
    public class ExecutiveController : Controller
    {
      
            public async Task<ActionResult> Index()
            {
                string Baseurl = "http://localhost:11752/";
                var ProdInfo = new List<Executive>();
                //HttpClient cl = new HttpClient();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Baseurl);
                    client.DefaultRequestHeaders.Clear();
                    //Define request data format  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                    HttpResponseMessage Res = await client.GetAsync("api/Executive");
                    //Checking the response is successful or not which is sent using HttpClient  
                    if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api   
                        var ProdResponse = Res.Content.ReadAsStringAsync().Result;

                        //Deserializing the response recieved from web api and storing into the Employee list  
                        ProdInfo = JsonConvert.DeserializeObject<List<Executive>>(ProdResponse);

                    }
                    //returning the employee list to view  
                    return View(ProdInfo);
                }
            }
            [HttpGet]
            public ActionResult Create()
            {
                return View();
            }
            [HttpPost]
            public async Task<ActionResult> Create(Executive p)
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(p), Encoding.UTF8, "application/json");

                    using (var response = await httpClient.PostAsync("http://localhost:11752/api/Executives", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    }
                }
                return RedirectToAction("Index");
            }
        }
    }

