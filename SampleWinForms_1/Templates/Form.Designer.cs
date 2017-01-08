/**********************************************************************************************************************/
// Wymagane referencje:
// System
// System.Widnows.Foms
// System.Drawing
/**********************************************************************************************************************/
using System;
using System.Windows.Forms;

namespace NameSpace
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null; 

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
            this.ResumeLayout (false);
        }
    }
}

// To generuje VS jak tło pracy projektanta graficznego, 
// oczywiście rozbudowując to z czasem.
