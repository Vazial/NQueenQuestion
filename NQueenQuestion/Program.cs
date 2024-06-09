using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace NQueenAnswer {
    ///*************************************************************************///
    ///*** 小問1 Nという変数を定義して、汎用化しよう。                       ***///
    ///*** 小問2 NQueenGenerator.IsMatch()を簡略化して、処理を効率化しよう。 ***///
    ///*** 小問3 回転させて一致する解を出力しないようにしよう。              ***///
    ///*** 小問4 左右反転させて一致する解を出力しないようにしよう。          ***///
    ///*************************************************************************///

    /// <summary>
    /// メイン処理を行うクラス
    /// </summary>
    public class Program {
        //解の個数Q
        //N=4 → 2, N=5 → 10, N=6 → 4, N=7 → 40, N=8 → 92

        //クイーンの個数
        // const int N = 5;

        static void Main()
        {
            var sw = new Stopwatch();
            sw.Start();

            Console.WriteLine("N = " + 5 + "のときのクイーンの配置");

            //全ての座標の組合わせを生成する。
            var solutionList = NQueenGenerator.Generate();

            //解を出力する。
            ChessboardDebugPrinter.PrintAll(solutionList);

            sw.Stop();

            Console.WriteLine("経過時間: " + sw.Elapsed.ToString("hh':'mm':'ss'.'fff"));

            //重複を削除した場合
            // Console.WriteLine();
            // Console.WriteLine("重複を削除した場合");
            // ChessboardDebugPrinter.PrintAll(重複を削除したsolutionList);
        }
    }
}