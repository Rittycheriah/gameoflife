using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {

        public bool IsAlive = true;
        public bool isDead = true;

        public Cell(bool state)
        {
            if (state)
            {
                this.IsAlive = true;
                this.isDead = false;
            }
            else
            {
                this.IsAlive = false;
                this.isDead = true;
            }
        }
    }
}
