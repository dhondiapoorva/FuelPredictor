using FuelQuoteApp_p1.EntModels.Models;
using FuelQuoteApp_p1.Models.Client_Profile;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace FuelQuoteApp_p1.Controllers
{
    public class ClientController : Controller
    {
        [HttpGet]
        [ExcludeFromCodeCoverage]
        public IActionResult ClientDashBoard()
        {
            int usrID = 1; //HardCoded
            Client client = new Client
            {
                User_ID = new User()
                {
                    Id = usrID,
                    Email="sainarne15@gmail.com",
                    UserName="sainarne15@gmail.com"
                },
                FullName = "Narne Lakshmi Narasimha Sai",
                Address1 = "Kirby Dr",
                Address2 = "",
                City = "Houston",
                State = States.TX.ToString(),
                ZipCode = 77054.ToString()
            };
            HttpContext.Session.SetString("ClientDetails", JsonConvert.SerializeObject(client));

            return View();
        }

        [HttpGet]
        [ExcludeFromCodeCoverage]
        public IActionResult ClientProfile()
        {
            return View();
        }


        [HttpPost]
        [ExcludeFromCodeCoverage]
        public ActionResult ClientProfile(Profile clientProfile)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client
                {
                    FullName = clientProfile.FullName,
                    Address1 = clientProfile.Address1,
                    Address2 = clientProfile.Address2,
                    City = clientProfile.City,
                    State = clientProfile.State.ToString(),
                    ZipCode = clientProfile.ZipCode,
                    Email = User.Identity.Name

                };

                User usrDetails = new User();
                client.User_ID = usrDetails;
             

                return RedirectToAction("GetQuote", "Quote");
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        [ExcludeFromCodeCoverage]
        public IActionResult DisplayProfile()
        {
            Client client = new Client();
            client = JsonConvert.DeserializeObject<Client>(HttpContext.Session.GetString("ClientDetails"));


            Profile cl = new Profile()
            {
                FullName = client.FullName,
                Address1 = client.Address1,
                Address2 = client.Address2,
                City = client.City,
                State = States.TX,
                ZipCode = client.ZipCode
            };

            return View(cl);
        }


        public bool ClientProfileDataValidation(Profile data)
        {
            bool flag = false;
            if ((data.FullName.Length <= 50) && (data.FullName != String.Empty))
            {
                if (((data.Address1.Length <= 100) && (data.Address1 != String.Empty)) && (data.Address2.Length <= 100))
                {
                    if ((data.City.Length <= 100) && (data.City != String.Empty))
                    {
                        if (data.ZipCode.Length <= 9 && data.ZipCode.Length >= 5)
                        {
                            flag = true;
                        }
                    }
                }
            }
            else
            {
                flag = false;
            }

            return flag;
        }
    }
}