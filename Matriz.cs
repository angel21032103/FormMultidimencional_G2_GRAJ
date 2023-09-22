using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMultidimencional_G2_GRAJ
{
    internal class Matriz
    {
        #region Atributos

        private int m;
        private int n;

        public int M 
        { 
            get => m;
            set
            {            
                if(value <0)
                {
                    m = 2;
                }
                else
                {
                    m = value; 
                }
            }
        }

        public int N
        {
            get => n;
            set
            {
                if (value < 0)
                {
                    n = 2;
                }
                else
                {
                    n = value;
                }
            }
        }

        #endregion

    }
}
