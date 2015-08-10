using ChessEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Chess.Web.Models.Chess
{
    public class ChessBoardViewModel
    {
        public IBoardRepresentation Board { get; set; }
        public Square[,] Squares => Board.Squares;
    }
}