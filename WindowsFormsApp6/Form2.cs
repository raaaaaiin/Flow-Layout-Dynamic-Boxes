using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    
    public partial class Form2 : Form
    {
        public Form2(Color asd)
        {
            InitializeComponent();
            this.BackColor = asd;
            
        }
        public void process(Color asd)
        {
            this.BackColor = asd;
        }
    }
}
