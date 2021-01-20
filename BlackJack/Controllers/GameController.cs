using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlackJack.Models;
using BlackJack.Models.Deck;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackJack.Controllers
{
    public class GameController : Controller
    {
        public Game game { get; set; }
        public Deal deal { get; set; }

        // GET: Game
        public ActionResult NewGame()
        {
            game = new Game();
            deal = new Deal();
            deal.NewDeal(game);
            ViewBag.Message = game;
            return View();
        }
    }
}