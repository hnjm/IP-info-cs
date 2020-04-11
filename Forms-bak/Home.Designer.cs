namespace IP_info_cs.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkboxAstro = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtxtboxDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Controls.Add(this.chkboxAstro);
            this.flowLayoutPanel1.Controls.Add(this.checkBox2);
            this.flowLayoutPanel1.Controls.Add(this.checkBox3);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(461, 60);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // chkboxAstro
            // 
            this.chkboxAstro.AutoSize = true;
            this.chkboxAstro.BackColor = System.Drawing.Color.Transparent;
            this.chkboxAstro.Font = new System.Drawing.Font("Microsoft Himalaya", 18F);
            this.chkboxAstro.Location = new System.Drawing.Point(18, 13);
            this.chkboxAstro.Name = "chkboxAstro";
            this.chkboxAstro.Size = new System.Drawing.Size(147, 34);
            this.chkboxAstro.TabIndex = 1;
            this.chkboxAstro.Text = "Astronomical";
            this.chkboxAstro.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Himalaya", 18F);
            this.checkBox2.Location = new System.Drawing.Point(171, 13);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 34);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Geolocational";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Himalaya", 18F);
            this.checkBox3.Location = new System.Drawing.Point(327, 13);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(121, 34);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Time zone";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGray;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.DimGray;
            this.btnSubmit.Location = new System.Drawing.Point(459, -1);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(110, 60);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.MouseEnter += new System.EventHandler(this.btnSubmit_MouseEnter);
            this.btnSubmit.MouseLeave += new System.EventHandler(this.btnSubmit_MouseLeave);
            // 
            // rtxtboxDisplayInfo
            // 
            this.rtxtboxDisplayInfo.BackColor = System.Drawing.Color.DimGray;
            this.rtxtboxDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtboxDisplayInfo.Font = new System.Drawing.Font("Simplified Arabic Fixed", 9.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.rtxtboxDisplayInfo.ForeColor = System.Drawing.Color.White;
            this.rtxtboxDisplayInfo.Location = new System.Drawing.Point(12, 70);
            this.rtxtboxDisplayInfo.Name = "rtxtboxDisplayInfo";
            this.rtxtboxDisplayInfo.Size = new System.Drawing.Size(537, 531);
            this.rtxtboxDisplayInfo.TabIndex = 5;
            this.rtxtboxDisplayInfo.Text = "Click on submit to fetch info about your/the ip ...";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(566, 613);
            this.Controls.Add(this.rtxtboxDisplayInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = this.Size;
            this.Name = "Home";
            this.Text = "IP info";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkboxAstro;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtxtboxDisplayInfo;
    }
}