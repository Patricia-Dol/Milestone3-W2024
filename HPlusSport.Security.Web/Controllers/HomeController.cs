/*Course: 		Web Programming 3
* Assessment: 	Milestone 3
* Created by: 	Patricia Dolecki - 2152819
* Date: 		13 November 2024
* Class Name: 	HomeController.cs
* Description: 	Handles the error screen and the index screen 
* Time Task B):	2 hours. 
*/

using HPlusSport.Security.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HPlusSport.Security.Web.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
