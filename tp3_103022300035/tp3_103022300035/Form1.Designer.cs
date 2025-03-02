namespace tp3_103022300035
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOutput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtInput = new TextBox();
            btnSubmit = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.BackColor = Color.FromArgb(255, 128, 0);
            txtInput.ForeColor = Color.White;
            txtInput.Location = new Point(179, 196);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(279, 39);
            txtInput.TabIndex = 0;
            txtInput.Text = "Input";
            txtInput.TextAlign = HorizontalAlignment.Center;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(255, 128, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(464, 196);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(132, 39);
            btnSubmit.TabIndex = 1;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblOutput
            // 
            lblOutput.BackColor = Color.FromArgb(255, 128, 0);
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(179, 247);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(417, 43);
            lblOutput.TabIndex = 2;
            lblOutput.Text = "Output";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            lblOutput.Click += lblOutput_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(btnSubmit);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
