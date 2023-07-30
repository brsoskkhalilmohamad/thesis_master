using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hierarchical_Community
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int n ;
        int[,] Edge;

        private void Read_Btn_Click(object sender, EventArgs e)
        {
            string str_line;
            List<string> list = new List<string>();
            string Addres;

            if (Dataset_Cmbo.SelectedIndex == 0)
            {

                Addres = "./Dataset/karate.gml";
                StreamReader sr = new StreamReader(Addres);
                int i = 0;
                while (sr.EndOfStream == false)
                {
                    str_line = sr.ReadLine();
                    list.Add(str_line);
                    i++;
                }
                Create_DataSet(list);
            }

            if (Dataset_Cmbo.SelectedIndex == 1)
            {

                Addres = "./Dataset/dolphins.gml";
                StreamReader sr = new StreamReader(Addres);
                int i = 0;
                while (sr.EndOfStream == false)
                {
                    str_line = sr.ReadLine();
                    list.Add(str_line);
                    i++;
                }
                Create_DataSet(list);
            }
        }

        private void Create_DataSet(List<string> S)
        {
            int Num_Edge = 0;
            if (Dataset_Cmbo.SelectedIndex == 0)
            {
                n = 34;
                Edge = new int[n, n];
                string[] temp;
                string str;
                int i, j;

                int Num = S.Count;
                for (int ii = 0; ii < Num; ii++)
                {
                    str = S[ii];
                    temp = str.Split(',');
                    i = Convert.ToInt32(temp[0])-1;
                    j = Convert.ToInt32(temp[1])-1;
                    Edge[i, j] = 1;
                    Edge[j, i] = 1;
                }
            }

            if (Dataset_Cmbo.SelectedIndex == 1)
            {
                n = 62;
                Edge = new int[n, n];
                string[] temp;
                string str;
                int i, j;

                int Num = S.Count;
                for (int ii = 0; ii < Num; ii++)
                {
                    str = S[ii];
                    temp = str.Split(',');
                    i = Convert.ToInt32(temp[0]) ;
                    j = Convert.ToInt32(temp[1]) ;
                    Edge[i, j] = 1;
                    Edge[j, i] = 1;
                }
            }
        }

        private void Run_Btn_Click(object sender, EventArgs e)
        {
            DateTime Start_Time = DateTime.Now;
            TimeSpan End;
            int ms = 0;
            int s = 0;
            int min = 0;

            Clustering cluster = new Clustering(Edge,n);
            NMI_Txt.Text = Math.Round(cluster.Run(),4).ToString();
            Mod_Txt.Text = Math.Round(cluster.Modol, 4).ToString();

            End = DateTime.Now.Subtract(Start_Time);
            ms = End.Milliseconds;
            s = End.Seconds;
            min = End.Minutes;
            int Time = min * 60 + s;
            Time_Txt.Text = Time.ToString() + "  Seconds";
        }


        private void Main_Load(object sender, EventArgs e)
        {
            Dataset_Cmbo.SelectedIndex = 0;
        }
    }
}
