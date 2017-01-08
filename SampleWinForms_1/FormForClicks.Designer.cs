using System;
using System.Windows.Forms;

namespace OurTestForm
{
    public partial class FormForClics : Form
    {
        private System.ComponentModel.IContainer components = null; 

        #region ControlsObcjects

        private Button buttonToTest;

        #endregion

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
            this.Text = "FormForClicks";
            this.ResumeLayout (false);

            //
            // buttonToTest
            //
            this.buttonToTest = new Button();
            this.buttonToTest.Top = (this.Height / 2) - (buttonToTest.Height / 2);
            this.buttonToTest.Left = (this.Width / 2) - (buttonToTest.Width / 2);
            this.buttonToTest.Text = "Jeszcze nie kliknięto";
            this.buttonToTest.Click += buttonForTest_Click;
            this.Controls.Add (buttonToTest);

        }
    }
}

// To generuje VS jak tło pracy projektanta graficznego, 
// oczywiście rozbudowując to z czasem.

