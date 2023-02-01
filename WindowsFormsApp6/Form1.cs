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
    public partial class Form1 : Form
    {
        Random ran = new Random();
        Color asd;
        Color[] asds = new Color[100];
        Form2[] form2 = new Form2[12];
        static int count = 0;
        
        static int arrcounter = 0;
        public Form1()
        {
            InitializeComponent();
            for (int x = 0; x < 12; x++)
            {

                //made this black to see if the form is printing 
                //will chanbe back to transparent soon V
                form2[x] = new Form2(Color.Black) { TopLevel = false };
                flowLayoutPanel3.Controls.Add(form2[x]);
                form2[x].Show();

            }

        }
        public void pangkulay()
        {
            asd = Color.FromArgb(ran.Next(256), ran.Next(256), ran.Next(256));

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pangkulay();
            Form3 form3 = new Form3(asd) { TopLevel = false };
            flowLayoutPanel2.Controls.Add(form3);
            panel1.BackColor = asd;
            form3.Show();
            asds[count] = asd;
            count++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            for (int x = 0; x <= 11; x++)
            {
                /*This whaht makes the error
                 * form2[x] = new Form2(asds[arrcounter]) { TopLevel = false };
                 * flowLayoutPanel3.Controls.AddRange(form2); (Redundant, na add mo na sya sa initialization tas nag add ka ulit dito) 
                 * //may form2[x].process na para i change color nya
                 * 
                 * */
                form2[x].process(asds[arrcounter]);
                form2[x].Show();
                arrcounter++;
                
            }
            arrcounter = 0;
            MessageBox.Show(arrcounter.ToString());
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel3.Controls.Clear();
        }
        
    }
}
