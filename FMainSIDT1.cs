using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQATEST
{
    public partial class FMainSIDT1 : UIForm
    {
        public FMainSIDT1()
        {
            InitializeComponent();
            //this.Style = UIStyle.White;
        }

        private void btnDetailsAnalysis_Click(object sender, EventArgs e)
        {
            FDetailsSID fdetails = new FDetailsSID();
            fdetails.ShowDialog();
        }
    }
}
