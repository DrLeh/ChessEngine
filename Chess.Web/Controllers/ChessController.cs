using Chess.Web.Models.Chess;
using ChessEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.Web.Controllers
{
    public class ChessController : Controller
    {
        public virtual ActionResult Index()
        {
            var vm = new ChessBoardViewModel();
            vm.Board = new SquareCentricBoard();
            vm.Board.SetupClassic();
            return View(vm);
        }
    }
}