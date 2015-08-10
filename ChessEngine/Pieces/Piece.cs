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
    public enum Team
    {
        White,
        Black
    }

    public enum PieceTypeEnum
    {
        Pawn,
        Bishop,
        Knight,
        Rook,
        Queen,
        King
    }
    public class PieceType
    {
        private PieceType() { }
        public PieceTypeEnum Type { get; set; } = PieceTypeEnum.Pawn;
        public int Material
        {
            get
            {
                switch (Type)
                {
                    case PieceTypeEnum.Pawn: return 1;
                    case PieceTypeEnum.Bishop:
                    case PieceTypeEnum.Knight:
                        return 3;
                    case PieceTypeEnum.Rook: return 5;
                    case PieceTypeEnum.Queen: return 9;
                    case PieceTypeEnum.King: return 0;
                }
                throw new ArgumentException("Invalid Piece Type");
            }
        }
        public string ShortName
        {
            get
            {
                switch (Type)
                {
                    case PieceTypeEnum.Pawn: return string.Empty;
                    case PieceTypeEnum.Bishop: return "B";
                    case PieceTypeEnum.Knight: return "N";
                    case PieceTypeEnum.Rook: return "R";
                    case PieceTypeEnum.Queen: return "Q";
                    case PieceTypeEnum.King: return "K";
                }
                throw new ArgumentException("Invalid Piece Type");
            }
        }
        public string GlyphiconName
        {
            get
            {
                switch (Type)
                {
                    case PieceTypeEnum.Rook: return "tower";
                    default: return Type.ToString().ToLower();
                }
            }
        }

        public override string ToString() => ShortName;

        public static PieceType Pawn = new PieceType { Type = PieceTypeEnum.Pawn };
        public static PieceType Bishop = new PieceType { Type = PieceTypeEnum.Bishop };
        public static PieceType Knight = new PieceType { Type = PieceTypeEnum.Knight };
        public static PieceType Rook = new PieceType { Type = PieceTypeEnum.Rook };
        public static PieceType Queen = new PieceType { Type = PieceTypeEnum.Queen };
        public static PieceType King = new PieceType { Type = PieceTypeEnum.King };
        public static PieceType None = null;
    }
}
