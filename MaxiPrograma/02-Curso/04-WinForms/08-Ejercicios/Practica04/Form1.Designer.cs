namespace Practica04
{
    partial class Form1
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
            this.txtbName = new System.Windows.Forms.TextBox();
            this.btnName = new System.Windows.Forms.Button();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbName
            // 
            this.txtbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbName.Location = new System.Drawing.Point(481, 150);
            this.txtbName.MaxLength = 1500;
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 20);
            this.txtbName.TabIndex = 0;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(344, 146);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 1;
            this.btnName.Text = "button1";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            this.btnName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnName_KeyPress);
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(481, 235);
            this.txtb2.Multiline = true;
            this.txtb2.Name = "txtb2";
            this.txtb2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtb2.Size = new System.Drawing.Size(100, 20);
            this.txtb2.TabIndex = 2;
            this.txtb2.Leave += new System.EventHandler(this.txtb2_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox txtb2;
    }
}

