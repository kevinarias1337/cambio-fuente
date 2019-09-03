using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codigofuenteletra
{
    public partial class programa : Form
    {
        public programa()
        {
            InitializeComponent();
        }

        private void Programa_Load(object sender, EventArgs e)
        {
            lblresultado.Visible = false;
            nombretxt.Focus();
        }

        private void Btncontinuar_Click(object sender, EventArgs e)
        {
            lblresultado.Text = (nombretxt.Text);
            
            lblresultado.Font = new Font(FontFamily.GenericMonospace, 30.0F,
            FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout, GraphicsUnit.Pixel);
            lblresultado.ForeColor = Color.Red;
            nombretxt.Text = "";
            nombretxt.Focus();
            lblresultado.Visible = true;
        }
    }
}
