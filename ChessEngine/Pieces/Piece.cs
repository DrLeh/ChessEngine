using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{

    public class Piece
    {
        public Piece(Team team, PieceType pieceType)
        {
            Team = team;
            PieceType = pieceType;
        }

        public PieceType PieceType { get; set; }
        public Team Team { get; set; }

        public string ID => $"{Team} {PieceType.ShortName}";
    }

}
