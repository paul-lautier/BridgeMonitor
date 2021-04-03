using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BridgeMonitor.Models;

namespace BridgeMonitor.Controllers
{
    public class ClosingController : Controller
    {


        private readonly ILogger<ClosingController> _logger;

        public ClosingController(ILogger<ClosingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllClosing()
        {
            var BoatData = GetBoatDataFromApi();
            return View(BoatData);
        }
        public IActionResult DetailsClosing()
        {
            return View();
        }
        public IActionResult NextClosing()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
     private static List<Closing> GetBoatDataFromApi()
        {
            //Création un HttpClient (= outil qui va permettre d'interroger une URl via une requête HTTP)
            using (var client = new HttpClient())
            {
                //Interrogation de l'URL censée me retourner les données
                var response = client.GetAsync("https://api.alexandredubois.com/pont-chaban/api.php");
                //Récupération du corps de la réponse HTTP sous forme de chaîne de caractères
                var stringResult = response.Result.Content.ReadAsStringAsync();
                //Conversion de mon flux JSON (string) en une collection d'objets BikeStation
                //d'un flux de données vers des objets => Déserialisation
                //d'objets vers un flux de données => Sérialisation
                var result = JsonConvert.DeserializeObject<List<Closing>>(stringResult.Result);
                return result;
            }
        }
    }
}