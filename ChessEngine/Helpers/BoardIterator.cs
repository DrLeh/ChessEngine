using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    //public class BoardIterator : IEnumerable<Square>
    //{
    //    IBoardRepresentation board;
    //    public BoardIterator(IBoardRepresentation board)
    //    {
    //        this.board = board;
    //    }


    //    public IEnumerator<Square> GetEnumerator() => board.Squares.().GetEnumerator();

    //    IEnumerator IEnumerable.GetEnumerator() => board.Squares.GetEnumerator();
    //}

    public class RankIterator : IEnumerable<Square>
    {
        Square[] squares;
        public RankIterator(IBoardRepresentation board, File rank)
        {
            squares = new Square[8];
            for (int i = 0; i < BoardContants.HeightAndWidth; i++)
                squares[i] = board.GetSquare(rank, i);
        }

        public IEnumerator<Square> GetEnumerator() => squares.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => squares.GetEnumerator();
    }
}
