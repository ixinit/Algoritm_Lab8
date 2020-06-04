using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackExpr
{
    public partial class StackExprF : Form
    {
        StackExprC PE = new StackExprC();
        public StackExprF()
        {
            InitializeComponent();
        }

        private void btnEvol_Click(object sender, EventArgs e)
        {
            lblExpr.Text = PE.InfToPostf(tbExpr.Text);
            PE.ShowId(dgVal);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (PE.PutVal(dgVal))
            {
                lblRes.Text = PE.CalcExpr();
            }
        }
    }
}
