using System;
using System.Windows.Forms;

namespace OurTestForm
{
    public partial class FormForMultiply : Form
    {
        private System.ComponentModel.IContainer components = null; 

        private Button buttonToMultiClick;

        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout ();
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (422, 244);
            this.Name = "Form1";
            this.Text = "Form1";

            //
            // buttonToMultiClick
            //
            this.buttonToMultiClick = new Button();
            this.buttonToMultiClick.Text = "Jeszcze nie kliknięto";
            this.buttonToMultiClick.Top = (this.Height / 2) - (this.buttonToMultiClick.Height / 2);
            this.buttonToMultiClick.Left = (this.Width / 2) - (this.buttonToMultiClick.Width / 2);
            this.buttonToMultiClick.Click += buttonToMultiClick_Click;

            this.Controls.Add(buttonToMultiClick);

            this.ResumeLayout (false);
        }
    }
}

// To generuje VS jak tło pracy projektanta graficznego, 
// oczywiście rozbudowując to z czasem.
