using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueenAnswer
{
    public class Chessboard
    {
        public int size { get; private set; }
        public Layout layout {  get; private set; }

        public Chessboard() 
        { 
            size = 5;
            layout = new Layout(Layout.Empty);
        }

        public void Mapping(int serialNumber)
        {
            layout = new Layout(serialNumber);
        }

        public List<Queen> getLocations()
        {
            return layout.Deserialize(size);
        }
    }
}
