using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            Poker p = new Poker();
            List<int> poker = p.GetPoker(52);
            string msg = "";
            for (int i = 0; i < poker.Count; i++)
            {
                msg += $"{poker[i]} ,";

            }

            RTB1.Text = msg + "\n";

        }



    }
}
