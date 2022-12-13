using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomSniper
{
    public partial class Form2 : KryptonForm
    {
        public Form2(ref List<links> linkList)
        {
            InitializeComponent();
            MessageBox.Show(linkList[0].name);
        }
    }
}
