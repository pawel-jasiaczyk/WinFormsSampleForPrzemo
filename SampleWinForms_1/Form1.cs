/**********************************************************************************************************************/
// Wymagane referencje:
// System
// System.Widnows.Foms
// System.Drawing
/**********************************************************************************************************************/

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace OurTestForm
{
    public partial class Form1 : Form
    {
        #region Private Fields

        private int clicks = 0;
        private int multiClicks = 0;
        private int multiFormsCount = 0;
        private FormForClics formForClicks;
        private List<FormForMultiply> multiForms;

        #endregion

        #region Properties

        public int Clicks{ get { return this.clicks; } }
        public int MultiClicks
        { 
            get { return this.multiClicks; } 
            private set 
            { 
                this.multiClicks = value; 
                if (this.MultiCounterChanged != null)
                    MultiCounterChanged (this, new EventArgs ());
            }
        }

        #endregion

        #region Events

        public event EventHandler MultiCounterChanged;

        #endregion

        #region C'tors

        public Form1 ()
        {
            this.multiForms = new List<FormForMultiply> ();
            InitializeComponent ();
        }

        #endregion

        private void button1_Click (object sender, EventArgs e)
        {
            if (this.formForClicks == null)
            {
                this.formForClicks = new FormForClics (this);
                this.formForClicks.ButtonClicked += formForClics_ButtonClicked;
                this.formForClicks.FormClosed += (object sender_1, FormClosedEventArgs e_1) => 
                {
                    this.formForClicks = null;
                    this.clicks = 0;
                    this.label_counter.Text = "Zresetowano licznik";
                };
                this.formForClicks.Show ();
            } 
            else
            {
                this.formForClicks.Activate ();
            }
        }

        private void formForClics_ButtonClicked(object sender, EventArgs e)
        {
            this.clicks++;
            this.label_counter.Text = string.Format ("Kliknięto {0} razy", this.clicks.ToString());
        }

        private void buttonMulti_Click (object sender, EventArgs e)
        {
            this.multiFormsCount++;
            FormForMultiply form = new FormForMultiply (this);
            form.Text = string.Format ("Form: {0}", multiFormsCount.ToString());
            this.multiForms.Add (form);
            form.FormClosed += (object sender_1, FormClosedEventArgs e_1) => 
            {
                this.multiForms.Remove((FormForMultiply)sender_1);
                UpdateMultiFormCounterLabel();
            };
            form.ButtonClicked += (object sender_1, EventArgs e_1) => 
            {
                this.MultiClicks++;
                this.labelMulti_counter.Text = String.Format("Kliknięto: {0} razy", this.MultiClicks);
            };
            UpdateMultiFormCounterLabel ();
            form.Show ();
            form.Activate ();
        }

        private void UpdateMultiFormCounterLabel()
        {
            this.labelMultiForm_counter.Text = string.Format ("Otwartych okient: {0}", multiForms.Count);
        }
    }
}

