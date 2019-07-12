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

namespace BasarClient
{
    public partial class ManuelleEingabe : MaterialForm
    {
        public ManuelleEingabe()
        {
            InitializeComponent();
        }

        public int SellerId()
        {
            return Convert.ToInt32(textFieldSellerId.Text);
        }

        public int PartNumber()
        {
            return Convert.ToInt32(textFieldPartNumber.Text);
        }

        public double Price()
        {
            return Convert.ToDouble(textFieldPrice.Text);
        }
    }
}
