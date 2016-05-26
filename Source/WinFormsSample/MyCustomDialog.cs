using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSample
{
    public partial class MyCustomDialog : BaseDialogForm
    {
        public MyCustomDialog()
        {
            InitializeComponent();
        }

        protected override bool CanAcceptForm()
        {
            return MessageBox.Show("Do you want to accept?", "Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
