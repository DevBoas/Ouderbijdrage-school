using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Ouderbijdrage_school
{
    public partial class Form1 : Form
    {
        int hoeveel = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (hoeveel > 1)
            {
                Output.Location += new Size(0, 20);
                Bereken.Location += new Size(0, 20);
                OuderStatus.Location += new Size(0, 20);
                Voegtoe.Location += new Size(0, 20);
                this.Size += new Size(0, 20);
            }
            Point loc = Voegtoe.Location;
            DateTimePicker dateTimePick = new DateTimePicker();
            dateTimePick.Location = loc - new Size(20, 40);
            Label kind = new Label();
            kind.Location = dateTimePick.Location - new Size(40,-2);
            kind.Text = "Kind " + hoeveel.ToString();
            kind.Size = new System.Drawing.Size(40, 13);
            this.Controls.Add(kind);
            this.Controls.Add(dateTimePick);
            hoeveel++;
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            int kindOnder10 = 0;
            int kindBoven10 = 0;
            float geld = 50;
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(DateTimePicker))
                {
                    DateTimePicker kindDate = (DateTimePicker) c;
                    DateTime zeroTime = new DateTime(1, 1, 1);
                    DateTime now = DateTime.Now;
                    TimeSpan span = now - kindDate.Value;
                    int years = (zeroTime + span).Year - 1;
                    if (years < 10)
                    {
                        kindOnder10++;
                    }
                    else
                        kindBoven10++;
                    //MessageBox.Show("Yrs elapsed: " + years.ToString());
                }
            }
            MessageBox.Show("Onder 10 " + kindOnder10.ToString());
            MessageBox.Show("Boven 10 " + kindBoven10.ToString());
            if (kindOnder10 <= 3)
            {
                geld += kindOnder10 * 25;
            }
            else
            {
                geld += 75;
            }
            if (kindBoven10 <= 2)
            {
                geld += kindBoven10 * 37;
            }
            else
            {
                geld += 74;
            }

            if (OuderStatus.Checked)
            {
                geld = geld * 0.75f;
            }

            if (geld > 150)
            {
                geld = 150;
            }
            Output.Text = "Ouderbijdrage: " + geld.ToString();
        }
    }
}
