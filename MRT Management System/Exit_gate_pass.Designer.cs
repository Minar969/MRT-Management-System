namespace MRT_Management_System
{
    partial class Exit_gate_pass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.Button();
            this.textBoxegp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblegp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(953, 719);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.lblegp);
            this.panel1.Controls.Add(this.btn);
            this.panel1.Controls.Add(this.textBoxegp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(241, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 436);
            this.panel1.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Red;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn.Location = new System.Drawing.Point(53, 323);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(377, 53);
            this.btn.TabIndex = 2;
            this.btn.Text = "Exit";
            this.btn.UseVisualStyleBackColor = false;
            // 
            // textBoxegp
            // 
            this.textBoxegp.Location = new System.Drawing.Point(53, 217);
            this.textBoxegp.Name = "textBoxegp";
            this.textBoxegp.Size = new System.Drawing.Size(377, 26);
            this.textBoxegp.TabIndex = 1;
            this.textBoxegp.TextChanged += new System.EventHandler(this.textBoxegp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metro Rail Bangladesh";
            // 
            // lblegp
            // 
            this.lblegp.AutoSize = true;
            this.lblegp.BackColor = System.Drawing.Color.White;
            this.lblegp.Location = new System.Drawing.Point(95, 220);
            this.lblegp.Name = "lblegp";
            this.lblegp.Size = new System.Drawing.Size(164, 20);
            this.lblegp.TabIndex = 3;
            this.lblegp.Text = "Enter Tocken Number";
            // 
            // Exit_gate_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Exit_gate_pass";
            this.Text = "Exit_gate_pass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.TextBox textBoxegp;
        private System.Windows.Forms.Label lblegp;
    }
}