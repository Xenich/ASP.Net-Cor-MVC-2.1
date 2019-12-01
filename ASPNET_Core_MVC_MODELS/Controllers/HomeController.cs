﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc; 
using ASPNET_Core_MVC_MODELS.Models;        // ВАЖНО - подключаем пространства имён!!
using ASPNET_Core_MVC_MODELS.ViewModels;

namespace ASPNET_Core_MVC_MODELS.Controllers
{
    public class HomeController : Controller
    {  
            //
        public string Index()
        {
            Company microsoft = new Company()
            {
                Name = "Microsoft",
                Employees = 10000
            };
            string result = $"Name: {microsoft.Name}, Employees: {microsoft.Employees}";
            return result;
        }      
        
            // Передача одиночной модели в представление
        public IActionResult SingleModel()          // View, соответствующее этому контроллеру - Home/SingleModel.cshtml
        {
            Game counterStrike = new Game()
            {
                Name = "Counter Strike",
                Platform = "Windows",
                Engine = "HL"
            };
            return View(counterStrike);     // передаём модель в представление (на сторону клиента) Views/Home/SingleModel.cshtml
        }

            // передача коллекции моделей в представление
        public IActionResult CollectionModel()          
        {
            List<Game> collection = new List<Game>();
            Game counterStrike = new Game()
            {
                Name = "Counter Strike",
                Platform = "Windows",
                Engine = "HL"
            };

            Game hl = new Game()
            {
                Name = "Half Life",
                Platform = "Windows",
                Engine = "HL"
            };

            Game massEffect = new Game()
            {
                Name = "Mass Effect",
                Platform = "Windows",
                Engine = "Unreal Engine"
            };

            collection.Add(counterStrike);
            collection.Add(hl);
            collection.Add(massEffect);

            return View(collection);     // передаём коллекцию моделей в представление (на сторону клиента) Views/Home/CollectionModel.cshtml
        }

            // передача группы коллекций моделей разного типа в представление
            // осуществляется с помощью ViewModel - классов, которые содержат списки различных моделей
        public IActionResult DifferentModelsCollection()
        {
            
            Game counterStrike = new Game()
            {
                Name = "Counter Strike",
                Platform = "Windows",
                Engine = "HL"
            };

            Game hl = new Game()
            {
                Name = "Half Life",
                Platform = "Windows",
                Engine = "HL"
            };
                // список экземпляров Game
            List<Game> gameCollection = new List<Game>();
            gameCollection.Add(counterStrike);
            gameCollection.Add(hl);

            Company microsoft = new Company()
            {
                Name = "Microsoft",
                Employees = 10000
            };

            Company apple = new Company()
            {
                Name = "Apple",
                Employees = 10000
            };
                // список экземпляров Company
            List<Company> companyCollection = new List<Company>();
            companyCollection.Add(microsoft);
            companyCollection.Add(apple);

            DifferentViewModels differentViewModels = new DifferentViewModels();
            differentViewModels.Companies = companyCollection;
            differentViewModels.Games = gameCollection;

            return View(differentViewModels);     // передаём ViewModels - коллекции моделей разных типов в представление (на сторону клиента) Views/Home/DifferentModelsCollection.cshtml
        }
    }
}