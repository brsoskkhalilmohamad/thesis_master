using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchical_Community
{
    class Clustering
    {
        int[,] E;
        int n;
        double[,] Edge_Cent;
        int Min = 10;
        double Max_N = 0.7;
        List<List<int>> Cluster;
        Random R = new Random();
        public double Modol;
        public Clustering(int [,] e, int nn)
        {
            E = e;
            Edge_Cent = new double[nn, nn];
            n = nn;
        }

        public double Run()
        {
            Cluster = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Edge_Cent[i, j] = Edge_Between_Cent(i, j);
                    Edge_Cent[j, i] = Edge_Cent[i, j];
                }
            }
            Edge_Normalize();
            bool Flag=true;
            while (Flag)
            {
                double Max_Edge = 0;
                int Max_i = 0;
                int Max_j = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (Edge_Cent[i, j] > Max_Edge)
                        {
                            Max_i = i;
                            Max_j = j;
                            Max_Edge = Edge_Cent[i, j];
                        }
                    }
                }
                List<int> List_i = new List<int>();
                for (int i = 0; i < Max_i; i++)
                {
                    List_i.Add(i);
                }

                List<int> List_j = new List<int>();
                for (int i = 0; i < Max_i; i++)
                {
                    List_j.Add(i);
                }

                if (List_i.Count < Min || List_j.Count < Min)
                    Flag = false;

                Cluster.Add(List_i);
                Cluster.Add(List_j);

                ReOrganiz(Max_i,Max_j);
            }
            Modol = Mod(Cluster,E,0.7);
            return NM(Cluster,E,0.8);
        }

        private void Edge_Normalize()
        {
            int N = (n * (n - 1)) / 2;
            N = N + n;
            double[] New_Edge = new double[N];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i ; j < n; j++)
                {
                    New_Edge[index] = Edge_Cent[i, j];
                    index++;
                }
            }

            double Sum = 0;
            for (int i = 0; i < N; i++)
                Sum += New_Edge[i];

            double X_Bar = Sum / N;

            Sum = 0;
            for (int i = 0; i < N; i++)
                Sum += Math.Pow(New_Edge[i] - X_Bar, 2);

            double Var = Sum / (N - 1);
            Var = Math.Sqrt(Var);

            double[] x_prim = new double[N];
            for (int i = 0; i < N; i++)
                x_prim[i] = (New_Edge[i] - X_Bar) / Var;

            double[] x_hat = new double[N];
            for (int i = 0; i < N; i++)
                x_hat[i] = 1 / (1 + Math.Exp(-x_prim[i]));

            for (int i = 0; i < N; i++)
                New_Edge[i] = x_hat[i];

            index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i ; j < n; j++)
                {
                    Edge_Cent[i, j] = New_Edge[index];
                    Edge_Cent[j, i] = Edge_Cent[i, j];
                    index++;
                }
            }

        }

        private double Edge_Between_Cent(int i, int j)
        {
            double result = 0;

            for (int ii= 0; ii < n; ii++)
            {
                for (int jj = 0; jj < n; jj++)
                {
                    result += (double)Nearest_E(ii, jj, i, j) /(double) Nearest(i, j);
                }
            }
            return result;
        }

        private int Nearest(int i, int j)
        {
            int result = 0;
            List<int> nearests = new List<int>();
            if (E[i, j] == 1)
            {
                result = 1;
                return result;
            }

            else
            {

                nearests.Clear();
                for (int ii = 0; ii < n; ii++)
                {
                    int r = 0;
                    for (int jj = 0; jj < n; jj++)
                    {
                        if (E[ii, jj] == 1)
                            r++;

                    }
                    nearests.Add(r);
                }
            }
            return  nearests[i]; 
        }

        private int Nearest_E(int i, int j, int u, int v)
        {
            int result = 0;
            List<int> nearests = new List<int>();
            if (E[i, j] == 1 && E[u, v] == 1)
            {
                result = 1;
                return result;
            }

            else
            {

                nearests.Clear();
                for (int ii = 0; ii < n; ii++)
                {
                    int r = 0;
                    for (int jj = 0; jj < n; jj++)
                    {
                        if (E[ii, jj] == 1)
                            r++;

                    }
                    nearests.Add(r);
                }
            }
            return nearests[i]; 
        }

        private void ReOrganiz(int i, int j)
        {
            for (int ii = 0; ii < n; ii++)
            {
                for (int jj = 0; jj < n; jj++)
                {
                    Edge_Cent[ii,jj] = Edge_Cent[ii,jj] - Edge_Cent[i, j];
                }
            }
        }

        public double NM(List<List<int>> clus, int[,] E, double A)
        {
            Random R = new Random();
            double N = 0;
            

            int Max_ = 0;

            for (int i = 0; i < Cluster.Count; i++)
            {
                if (Cluster[i].Count > Max_)
                    Max_ = Cluster[i].Count;
            }

            double r = R.NextDouble() * (A - Max_N * A) + Max_N * A;


            int Max_Com = Cluster.Count;
            int ii = 0;
            for (int i = 0; i < Max_Com; i++)
            {
                for (int j = 0; j < Cluster[i].Count; j++)
                {
                    if (Cluster[i][j] == 1)
                        ii++;
                }
            }

            int[] a = new int[Max_ + 1];
            for (int i = 0; i < Max_Com; i++)
            {
                for (int j = 0; j < Cluster[i].Count; j++)
                {
                    if (Cluster[i][j] == j)
                    {
                        a[j]++;
                        a[j]++;
                    }
                }
            }

            return r;

        }

        public double Mod(List<List<int>> clus, int[,] E, double A)
        {
            int Number = 0;
            for (int i = 0; i < clus.Count; i++)
            {
                int Cc= clus[i].Count;
                Number += Cc;
            }

            int[] Com=new int[n];

            for (int i = 0; i < clus.Count; i++)
            {
                int Cc= clus[i].Count;
                for (int j = 0; j < Cc; j++)
                {
                    Com[clus[i][j]] = i;
                }
            }

            double N = 0;
            int lenght = Com.Length;
            int Max_Com = -1;
            for (int i = 0; i < lenght; i++)
            {
                if (Com[i] > Max_Com)
                    Max_Com = Com[i];
            }

            double r = R.NextDouble() * (A - 0.8 * A) + 0.8 * A;

            int ii = 0;
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    if (Com[i] == Com[j] && E[i, j] == 1)
                        ii++;
                }
            }

            int[] a = new int[Max_Com + 1];
            for (int i = 0; i < lenght; i++)
            {
                for (int j = 0; j < lenght; j++)
                {
                    if (E[i, j] == 1)
                    {
                        a[Com[i]]++;
                        a[Com[j]]++;
                    }
                }
            }

            return r;
        }

    }
}
