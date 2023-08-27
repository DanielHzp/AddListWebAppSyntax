using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    //View start page
    public class HelloWorldController : Controller
    {

        private static List<DogViewModel> dogs = new List<DogViewModel>();



        public IActionResult Index()
        {

            /*
            DogViewModel dogyo = new DogViewModel()
            {
                Name = "Bruno",
                Age = 2
            };
            */
            //return View(dogyo);

            return View(dogs);
        }

        //Pick up video AT 41:28 MIN TO EXTEND ASP ACTIONS WITH 'CREATE NEW' BUTTON

        //Display form
        public IActionResult Create()
        {
            //Create empty dog view object for a new dog to be saved
            var dogVm = new DogViewModel();

            //If viwe name isn't provided, the method uses its own name to search the view
            //dogVm is data binding in the view
            return View(dogVm);
        }

        //Control for the save button for a new dog input
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            //Redirect to main page
            //return View("Index");

            //Need to redirect to Index method because input data is not saved in DB yet

            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }




        public string Hello()
        {

            return "Return test";
        }


    }
}
