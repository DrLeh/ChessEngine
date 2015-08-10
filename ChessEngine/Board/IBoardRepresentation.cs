namespace ChessEngine
{
    public interface IBoardRepresentation
    {
        Square[,] Squares { get; set; }

        Square GetSquare(File file, int rank);
        Piece PieceOnSquare(File file, int rank);
        void SetSquare(File file, int rank, Piece p);
        void SetupClassic();
        bool SquareIsEmpty(File file, int rank);
    }
}