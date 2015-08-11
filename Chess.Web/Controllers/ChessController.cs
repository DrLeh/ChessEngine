using Chess.Web.Models.Chess;
using ChessEngine;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chess.Web.Controllers
{
    public partial class ChessController : Controller

    {
        [Dependency]
        public IBoardRepresentation Board { get; set; }

        public virtual ActionResult Index()
        {
            var vm = new ChessBoardViewModel();
            vm.Board = Board;
            vm.Board.SetupClassic();
            return View(vm);
        }
    }
}