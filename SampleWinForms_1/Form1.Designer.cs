using System;
using System.Windows.Forms;

namespace OurTestForm
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null; 

        #region Cntrols objetcs

        private Button button1;
        private Button buttonMulti;
        private Label label_counter;
        private Label labelMulti_counter;
        private Label labelMultiForm_counter;

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
            this.Text = "Form1";


            //
            // button_1
            //
            button1 = new Button ();
            button1.Top = 30;
            button1.Left = 30;
            button1.Text = "Guzik 1";
            button1.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.Controls.Add (button1);
            button1.Click += this.button1_Click;

            //
            // label_counter 
            //
            label_counter = new Label();
            label_counter.Top = 30;
            label_counter.Left = 180;
            label_counter.Text = "Nie rozpoczęto klikania";
            this.Controls.Add (label_counter);


            //
            // buttonMulti
            //
            this.buttonMulti = new Button();
            this.buttonMulti.AutoSize = true;
            this.buttonMulti.Text = "Dodaj nowe okno";
            this.buttonMulti.Top = this.button1.Top + 30;
            this.buttonMulti.Left = this.button1.Left;
            this.buttonMulti.Click += buttonMulti_Click;
            this.Controls.Add (buttonMulti);

            //
            // labelMulti_counter
            //
            this.labelMulti_counter = new Label();
            this.labelMulti_counter.Top = this.buttonMulti.Top;
            this.labelMulti_counter.Left = this.label_counter.Left;
            this.labelMulti_counter.Text = "Kliknięto 0 razy";
            this.Controls.Add (labelMulti_counter);

            //
            // labelMultiForm_counter
            //
            this.labelMultiForm_counter = new Label();
            this.labelMultiForm_counter.Top = this.buttonMulti.Top + 30;
            this.labelMultiForm_counter.Left = this.label_counter.Left;
            this.labelMultiForm_counter.Text = string.Format ("Otwartych okien: 0");
            this.Controls.Add (labelMultiForm_counter);


            this.ResumeLayout (false);
        }
    }
}

// To generuje VS jak tło pracy projektanta graficznego, 
// oczywiście rozbudowując to z czasem.

