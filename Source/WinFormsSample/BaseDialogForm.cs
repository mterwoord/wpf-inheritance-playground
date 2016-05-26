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
    public partial class BaseDialogForm : Form
    {
        public BaseDialogForm()
        {
            InitializeComponent();
        }

        protected virtual bool CanAcceptForm()
        {
            return true;
        }

        protected virtual void AcceptForm()
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CanAcceptForm())
            {
                DialogResult = DialogResult.OK;
                AcceptForm();
                Close();
            }
        }
    }
}
