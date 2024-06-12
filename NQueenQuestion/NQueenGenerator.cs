using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueenQuestion
{
    /// <summary>
    /// NQueenの解を生成するサービスクラス
    /// </summary>
    public static class NQueenGenerator
    {
        /// <summary>
        /// NQueenの解となる座標を生成する
        /// </summary>
        /// <returns>NQueenの解のリスト</returns>
        public static List<Chessboard> Generate()
        {
            var numberCombinationsList = new List<Chessboard>();
            var solutionList = new List<Chessboard>();
            var combination = (int)Math.Pow(5, 5);

            for (var count = 0; count < combination; ++count)
            {
                var chessboard = new Chessboard();
                chessboard.Mapping(count);
                numberCombinationsList.Add(chessboard);
            }

            //適当な配置かどうかチェックする。
            foreach (var numComb in numberCombinationsList)
            {
                if (IsMatch(numComb))
                {
                    solutionList.Add(numComb);
                }
            }

            return solutionList;
        }

        /// <summary>
        /// NQueenの解として適切であるか判定する。
        /// </summary>
        /// <param name="solution">NQueen座標の組</param>
        /// <returns>NQueenの解として適切であればtrue</returns>
        private static bool IsMatch(Chessboard solution)
        {
            //Pointsの中から2つの座標を選んで、適当かどうかチェックする。(N > q > r >= 0)
            var solArray = solution.GetLocations().ToArray();
            for (var former = 0; former <= 5 - 1; former++)
            {
                for (var latter = 0; latter <= 5 - 1; latter++)
                {
                    if (latter != former)
                    {
                        var diff = former - latter;
                        if (solArray[former].x == solArray[latter].x          //同じ列に存在しないかチェック
                        || solArray[former].x == solArray[latter].x - diff    //左斜め前に存在しないかチェック
                        || solArray[former].x == solArray[latter].x + diff    //右斜め前存在しにないかチェック
                        )
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
