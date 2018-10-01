using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScAnalyzer
{
    // Point contains a row and column
    class Point
    {
        // private data member specifying the row where the point lies
        private int row;
        // private data member specifying the column where the point lies
        private int column;
        // public property that accesses and sets row
        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }
        // public property that accesses and sets column
        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }
        // parameterized constructor taking in a desired row and column
        public Point(int r, int c)
        {
            row = r;
            column = c;
        }
        
    }
}
