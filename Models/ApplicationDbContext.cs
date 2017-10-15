//Challenge 2 (Set Up DbContext on QuestController)
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ForgingAhead.Models;

namespace ForgingAhead.Controllers
{
 public class QuestController : Controller
 {
   //Add Context Property Here
   private readonly ApplicationDbContext _context;
   public QuestController (ApplicationDbContext context)
     {
       _context = context;
     }
   public QuestController( )
   {
    //Inject ApplicationDbContext here

   }

   public IActionResult Index()
   {
     return View();
   }
 }
}
