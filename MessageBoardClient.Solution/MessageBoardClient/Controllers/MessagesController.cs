// using System;
using System.Collections.Generic;
// using System.Diagnostics;
using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MessageBoardClient.Models;

namespace MessageBoardClient.Controllers
{
  public class MessagesController : Controller
  {
    public IActionResult Index()
    {
      var allMessages = Message.GetMessages();
      return View(allMessages);
    }

    public IActionResult Groups()
    {
      var allMessages = Message.GetMessages().Distinct();
      return View(allMessages);

    }

    //     public IactionResult Group()
    //     {
    //       var group = Message.GetGroup();
    //       return View(allMessages);
    //     }

    // public IActionResult Details(int id)
    // {
    //   var animal = Animal.GetDetails(id);
    //   return View(animal);
    // }
  }
}