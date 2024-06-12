using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueenQuestion
{
    /// <summary>
    /// チェス盤を表現するクラス
    /// </summary>
    public class Chessboard
    {
        // 大きさ(縦横)
        public int size { get; private set; }
        // クイーンの位置
        public Layout layout { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Chessboard() 
        { 
            size = 5;
            layout = new Layout(Layout.Empty);
        }

        /// <summary>
        /// チェス盤にクイーンの位置を設定する
        /// </summary>
        /// <param name="serialNumber">serialNumber(クイーンの位置を表現する一意な値)</param>
        public void Mapping(int serialNumber)
        {
            layout = new Layout(serialNumber);
        }

        /// <summary>
        /// チェス盤からクイーンの位置を取得する
        /// </summary>
        /// <returns>クイーンの位置</returns>
        public List<Queen> GetLocations()
        {
            return layout.Deserialize(size);
        }
    }
}
