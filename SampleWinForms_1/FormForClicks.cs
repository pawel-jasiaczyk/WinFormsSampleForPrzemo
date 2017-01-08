using System;
using System.Windows.Forms;
using System.Drawing;

namespace OurTestForm
{
    public partial class FormForClics : Form
    {
        private Form parent;
        public event EventHandler ButtonClicked;

        public FormForClics ()
        {
            InitializeComponent ();
        }

        public FormForClics(Form parent) : this()
        {
            this.parent = parent;
        }

        private void buttonForTest_Click(object sender, EventArgs e)
        {
            if(this.ButtonClicked != null)
                ButtonClicked(buttonToTest, new EventArgs());
            if (this.parent != null && parent is Form1)
                this.buttonToTest.Text = string.Format ("Kliknięto: {0} razy", ((Form1)parent).Clicks);
        }
    }
}
