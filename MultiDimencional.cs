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
            //Matriz A asignada 
            //1,2;3,4 Matriz Ejemplo
            string[] renglones = A.Split(';') ;

            string[] columnas = renglones[0].Split(',') ;

            MultiDimencional m1 = new MultiDimencional(renglones.Length, columnas.Length);

            for (int i=0;i<m1.M;i++)
            {
                columnas = renglones[i].Split(',');
                for (int j = 0; j < m1.N;j++)
                {
                    m1.A[i,j] = float.Parse(columnas[j]);
                }
            }
            return m1;
        }
        public static MultiDimencional operator+(MultiDimencional m1,MultiDimencional m2)
        {
            MultiDimencional m3= new MultiDimencional(m1.M, m1.N);
            for(int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];              
                }
            }

            return m3;

        }
        public static MultiDimencional operator -(MultiDimencional m1, MultiDimencional m2)
        {
            MultiDimencional m3 = new MultiDimencional(m1.M, m1.N);
            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] - m2.A[i, j];
                }
            }

            return m3;

        }

        public static MultiDimencional operator *(MultiDimencional m1, MultiDimencional m2)
        {

          

            MultiDimencional m3 = new MultiDimencional(m1.M, m1.N);

            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = 0;
                    for (int k = 0; k < m1.N; k++)
                    {
                        m3.A[i, j] += m1.A[i, k] * m2.A[k, j];
                    }

                    
                }
            }

            return m3;

        }

       
        public static MultiDimencional CalcularSenoDeg(MultiDimencional m1)
        {
      
            MultiDimencional m3 = new MultiDimencional(m1.M, m1.N);

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                        m3.A[i, j] = (float)Math.Sin(m3.A[i, j] * Math.PI / 180.0);               
                }
            }

            return m3;
        }
        


        public override string ToString()
        {
            string A = "";

            for(int i =0; i<M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A= A+ " "+this.A[i,j].ToString();
                }
                A+="\n";
            }


            return A;
        }

    }
}
