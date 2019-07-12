using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace BasarAdministration
{
    public partial class InputForm : MaterialForm
    {
        public InputForm(string description, string label1, string label2)
        {
            InitializeComponent();

            materialLabel1.Text = description;
            materialLabel2.Text = label1;
            materialLabel3.Text = label2;
        }

        public void GetTexts(ref string[] inputText)
        {
            if(inputText.Length < 2)
            {
                Array.Resize(ref inputText, 2);
            }

            inputText[0] = materialLabel2.Text;
            inputText[1] = materialLabel3.Text;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
