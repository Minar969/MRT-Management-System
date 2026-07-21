namespace MRT_Management_System
{
    partial class Pdf_interface
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
            this.dataGridViewint = new System.Windows.Forms.DataGridView();
            this.btnint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewint)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MRT_Management_System.Properties.Resources.output_onlinepngtools;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 711);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewint
            // 
            this.dataGridViewint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewint.Location = new System.Drawing.Point(234, 112);
            this.dataGridViewint.Name = "dataGridViewint";
            this.dataGridViewint.RowHeadersWidth = 62;
            this.dataGridViewint.RowTemplate.Height = 28;
            this.dataGridViewint.Size = new System.Drawing.Size(466, 471);
            this.dataGridViewint.TabIndex = 1;
            // 
            // btnint
            // 
            this.btnint.BackColor = System.Drawing.Color.Red;
            this.btnint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnint.Location = new System.Drawing.Point(732, 603);
            this.btnint.Name = "btnint";
            this.btnint.Size = new System.Drawing.Size(167, 75);
            this.btnint.TabIndex = 2;
            this.btnint.Text = "Print";
            this.btnint.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 715);
            this.Controls.Add(this.btnint);
            this.Controls.Add(this.dataGridViewint);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Pdf_Imterface";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewint;
        private System.Windows.Forms.Button btnint;
    }
}

