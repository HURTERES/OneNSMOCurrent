using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TehnoVse
{
    public partial class FormRequest : Form
    {
        public FormRequest()
        {
            InitializeComponent();
        }

        private void FormRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tehnoVseDataSet.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.tehnoVseDataSet.Request);

        }
    }
}
