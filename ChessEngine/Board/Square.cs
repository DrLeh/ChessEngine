using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class Square
    {
        public int Rank { get; set; }
        public File File { get; set; }

        public Square(File file, int rank)
        {
            Rank = rank;
            File = file;
        }

        public Piece Piece { get; set; }
        public bool HasPiece => Piece != null;

        public SquareColor Color => (((int)File - 1) + (Rank - 1)) % 2 == 0 ? SquareColor.Dark : SquareColor.Light;

        public override string ToString() => HasPiece ? Piece.ID : "";
        public string PieceFullName => HasPiece ? Piece.ToString() : "";
        public string PieceName => HasPiece ? Piece.PieceType.ShortName : "";
        public string PieceTeam => HasPiece ? Piece.Team.ToString() : "";
    }

    public enum SquareColor
    {
        Light,
        Dark,
    }
}
