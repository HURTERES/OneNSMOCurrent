using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoVse
{
    public partial class FormAddRequest : Form
    {
        public FormAddRequest()
        {
            InitializeComponent();
        }

        void Refreshs() 
        {
            LblNow.Text = "Текущее время: " + DateTime.Now.ToString("dd/MM HH:mm");
        }

        private void FormAddRequest_Load(object sender, EventArgs e)
        {
            Timer.Start();
            Refreshs();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Refreshs();
        }

        private void TbxAddress_MouseEnter(object sender, EventArgs e)
        {
            TbxPhone.Text = "";
        }

        private void TbxPhone_MouseLeave(object sender, EventArgs e)
        {
            if (TbxPhone.Text == "")
                TbxPhone.Text = "Введите номер телефона";
        }

        private void TbxDevice_MouseDown(object sender, MouseEventArgs e)
        {
            TbxDevice.Text = "";
        }

        private void TbxDevice_MouseLeave(object sender, EventArgs e)
        {
            if (TbxDevice.Text == "")
                TbxDevice.Text = "Введите неисправное устройство";

        }

        private void TbxDesc_MouseDown(object sender, MouseEventArgs e)
        {
            TbxDesc.Text = "";
        }

        private void TbxDesc_MouseLeave(object sender, EventArgs e)
        {
            if (TbxDesc.Text == "")
                TbxDesc.Text = "Введите описание поломки";
        }
        int t=120;
        private void BtnAddRequest_Click(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            DateTime Fdt = DateTime.Parse(Dt.ToString("yyyy/MM/dd HH:mm"));
            Fdt.AddMinutes(t*Form1.CountRows);
            string Fddt;
            try
            { Fddt = Fdt.ToString().Split('/')[2].Split(' ')[0] + "/" + Fdt.ToString().Split('/')[1] + "/" + Fdt.ToString().Split('/')[0] + " " + Fdt.ToString().Split('/')[2].Split(' ')[1];}
            catch { Fddt = Fdt.ToString().Split('.')[2].Split(' ')[0] + "/" + Fdt.ToString().Split('.')[1] + "/" + Fdt.ToString().Split('.')[0] + " " + Fdt.ToString().Split('.')[2].Split(' ')[1]; }
            SqlConnection Con = new SqlConnection(Form1.TxtCon);
            Con.Open();
            SqlCommand Cmd = new SqlCommand($"insert into Request (TimeRequest, NumPhone, Device, [Desc]) values ('{Fddt}',N'{TbxPhone.Text}',N'{TbxDevice.Text}',N'{TbxDesc.Text}')",Con);
            Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Заявка добавлена");
            Form1.CountRows++;
            Form1.ListIntens.Add("");
        }
    }
}
