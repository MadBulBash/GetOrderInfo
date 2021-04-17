using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOrderInfo
{
    public partial class FormBarCode : Form
    {
        public FormBarCode()
        {
            InitializeComponent();
        }
        public FormBarCode(string barCodeStr)
        {
            InitializeComponent();
            barCodeControlMain.Text = barCodeStr;
        }
    }
}
