using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoVse
{
    public partial class Form1 : Form
    {

        public static string TxtCon = "workstation id=TehnoVse.mssql.somee.com;packet size=4096;user id=HURTER_SQLLogin_1;pwd=ehkpjtoa9l;data source=TehnoVse.mssql.somee.com;persist security info=False;initial catalog=TehnoVse;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddRequest Frm = new FormAddRequest();
            Frm.ShowDialog();
        }

        public static List<string> ListIntens = new List<string>();
        private void BtnListRequest_Click(object sender, EventArgs e)
        { 
            FormRequest Frm = new FormRequest();
            Frm.ShowDialog();
        }

        private void BtnStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic Frm = new FormStatistic();
            Frm.ShowDialog();
        }

        public static int CountRows=0;
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            DateTime Fdt = DateTime.Parse(Dt.ToString("yyyy-MM-dd HH:mm"));

            SqlConnection Con = new SqlConnection(TxtCon);
            SqlCommand Cmd = new SqlCommand("select * from Request", Con);
            Con.Open();
            using (SqlDataReader Res = Cmd.ExecuteReader())
            {
                while (Res.Read())
                {
                    int requestId = int.Parse(Res["IdRequest"].ToString());
                    DateTime dateRequest = DateTime.Parse(Res["TimeRequest"].ToString());


                    if (Fdt < DateTime.Parse(Res["TimeRequest"].ToString()))
                    {
                        ListIntens.Add($"{Res["IdRequest"]}-{Res["TimeRequest"]}");
                        CountRows++;
                    }
                    else
                    {
                        using (SqlConnection ConTwo = new SqlConnection(TxtCon))
                        {
                            SqlCommand command = new SqlCommand($"delete from Request where IdRequest = {requestId}", ConTwo);
                            ConTwo.Open();
                            command.ExecuteNonQuery();
                            ConTwo.Close();
                        }
                    }
                }
            }
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "\\helps.chm");
        }
    }
}
