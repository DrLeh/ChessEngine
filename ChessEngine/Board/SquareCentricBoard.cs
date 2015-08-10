using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    public class SquareCentricBoard : IBoardRepresentation
    {
        public SquareCentricBoard()
        {
            for (int f = (int)File.A; f <= BoardContants.HeightAndWidth; f++)
            {
                for (int r = 1; r <= BoardContants.HeightAndWidth; r++)
                    SetSquare(new Square((File)f, r));
            }
        }
        public Square[,] Squares { get; set; } = new Square[BoardContants.HeightAndWidth, BoardContants.HeightAndWidth];

        /// <summary>
        /// Rank is 1-8
        /// </summary>
        /// <param name="rank">1-8</param>
        public Square GetSquare(File file, int rank) => Squares[(int)file - 1, rank - 1];
        /// <summary>
        /// Rank is 1-8
        /// </summary>
        /// <param name="rank">1-8</param>
        public void SetSquare(File file, int rank, Piece p)
        {
            Squares[(int)file - 1, rank - 1].Piece = p;
        }
        public void SetSquare(Square s)
        {
            Squares[(int)s.File - 1, s.Rank - 1] = s;
        }

        public Piece PieceOnSquare(File file, int rank)
        {
            var square = GetSquare(file, rank);
            return square.Piece;
        }

        public bool SquareIsEmpty(File file, int rank)
        {
            return GetSquare(file, rank).HasPiece;
        }
        public void SetupClassic()
        {
            SetSquare(File.A, 8, new Piece(Team.Black, PieceType.Rook));
            SetSquare(File.B, 8, new Piece(Team.Black, PieceType.Knight));
            SetSquare(File.C, 8, new Piece(Team.Black, PieceType.Bishop));
            SetSquare(File.D, 8, new Piece(Team.Black, PieceType.Queen));
            SetSquare(File.E, 8, new Piece(Team.Black, PieceType.King));
            SetSquare(File.F, 8, new Piece(Team.Black, PieceType.Bishop));
            SetSquare(File.G, 8, new Piece(Team.Black, PieceType.Knight));
            SetSquare(File.H, 8, new Piece(Team.Black, PieceType.Rook));
            SetSquare(File.A, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.B, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.C, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.D, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.E, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.F, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.G, 7, new Piece(Team.Black, PieceType.Pawn));
            SetSquare(File.H, 7, new Piece(Team.Black, PieceType.Pawn));

            SetSquare(File.A, 1, new Piece(Team.White, PieceType.Rook));
            SetSquare(File.B, 1, new Piece(Team.White, PieceType.Knight));
            SetSquare(File.C, 1, new Piece(Team.White, PieceType.Bishop));
            SetSquare(File.D, 1, new Piece(Team.White, PieceType.Queen));
            SetSquare(File.E, 1, new Piece(Team.White, PieceType.King));
            SetSquare(File.F, 1, new Piece(Team.White, PieceType.Bishop));
            SetSquare(File.G, 1, new Piece(Team.White, PieceType.Knight));
            SetSquare(File.H, 1, new Piece(Team.White, PieceType.Rook));
            SetSquare(File.A, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.B, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.C, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.D, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.E, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.F, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.G, 2, new Piece(Team.White, PieceType.Pawn));
            SetSquare(File.H, 2, new Piece(Team.White, PieceType.Pawn));
        }

    }
}
