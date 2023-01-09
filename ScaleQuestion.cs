using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class ScaleQuestion : Question
    {
        private int scale;
        public int Scale
        {
            get
            {
                return scale;
            }

            set
            {
                if (value >= 0 && value <= 5)
                {
                    this.scale = value;
                }
            }
        }
    }
}
