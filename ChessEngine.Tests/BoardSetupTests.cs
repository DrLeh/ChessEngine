using System;
using Xunit;

namespace ChessEngine.Tests
{
    public class BoardSetupTests
    {
        [Fact]
        public void CanSetupBoard()
        {
            IBoardRepresentation board = new SquareCentricBoard();
            board.SetupClassic();

            Assert.Equal($"{Team.Black} {PieceType.Rook}", board.PieceOnSquare(File.A, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Knight}", board.PieceOnSquare(File.B, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Bishop}", board.PieceOnSquare(File.C, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Queen}", board.PieceOnSquare(File.D, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.King}", board.PieceOnSquare(File.E, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Bishop}", board.PieceOnSquare(File.F, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Knight}", board.PieceOnSquare(File.G, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Rook}", board.PieceOnSquare(File.H, 8).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.A, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.B, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.C, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.D, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.E, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.F, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.G, 7).ID);
            Assert.Equal($"{Team.Black} {PieceType.Pawn}", board.PieceOnSquare(File.H, 7).ID);

            Assert.Equal($"{Team.White} {PieceType.Rook}", board.PieceOnSquare(File.A, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Knight}", board.PieceOnSquare(File.B, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Bishop}", board.PieceOnSquare(File.C, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Queen}", board.PieceOnSquare(File.D, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.King}", board.PieceOnSquare(File.E, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Bishop}", board.PieceOnSquare(File.F, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Knight}", board.PieceOnSquare(File.G, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Rook}", board.PieceOnSquare(File.H, 1).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.A, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.B, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.C, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.D, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.E, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.F, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.G, 2).ID);
            Assert.Equal($"{Team.White} {PieceType.Pawn}", board.PieceOnSquare(File.H, 2).ID);

            for (int i = 1; i <= 8; i++)
                for (int j = 3; j <= 6; j++)
                    Assert.Null(board.PieceOnSquare((File)i, j));


            bool light = false;
            for (int i = 1; i <= 8; i++)
                for (int j = 1; j <= 8; j++)
                {
                    Assert.Equal(light ? SquareColor.Light : SquareColor.Dark, board.GetSquare((File)i, j).Color);
                    light = !light;
                }
        }
    }
}
