using System;
using System.Windows.Forms;
using System.Drawing;

namespace OurTestForm
{
    public partial class FormForMultiply : Form
    {
        #region Private Fields

        private Form parent;

        #endregion

        public event EventHandler ButtonClicked;

        public FormForMultiply ()
        {
            InitializeComponent ();
        }

        public FormForMultiply(Form parent) : this()
        {
            this.parent = parent;
            if(this.parent is Form1)
                ((Form1)(this.parent)).MultiCounterChanged += ParentCounterChanged;
            UpdateButtonText ();
        }

        void ParentCounterChanged (object sender, EventArgs e)
        {
            UpdateButtonText ();
        }

        private void buttonToMultiClick_Click(object sender, EventArgs e)
        {
            if (ButtonClicked != null)
            {
                ButtonClicked (this, new EventArgs ());
            }
            UpdateButtonText ();
        }

        private void UpdateButtonText()
        {
            if (this.parent != null && this.parent is Form1)
            {
                this.buttonToMultiClick.Text = 
                    String.Format ("Kliknięto: {0} razy", ((Form1)parent).MultiClicks.ToString ());
            } 
            else
            {
                this.buttonToMultiClick.Text = "No Parent!";
            }
        }
    }
}
