using System;


namespace FormMultidimencional_G2_GRAJ
{
    internal class MultiDimencional:Matriz
    {
        float[,] A;

        public MultiDimencional(int M, int N)
        {
            this.N = N;
            this.M = M;
            A= new float[this.M, this.N];
        }

        public static MultiDimencional Leer(string A)
        {

        }
    }
}
