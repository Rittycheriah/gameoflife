using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class DaWorld
    {
        public bool Barren { get; set; }

        public DaWorld(int ExistentialDilemma)
        {
            if (ExistentialDilemma >= 9)
            {
                Cell initCell = new Cell(true);
                Cell initCell2 = new Cell(true);
                Cell initCell3 = new Cell(true);
                Cell initCell4 = new Cell(true);

                this.Barren = false;
            }
            else
            {
                this.Barren = true;      
            }
        }
    }
}
