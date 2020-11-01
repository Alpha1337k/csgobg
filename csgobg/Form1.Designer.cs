namespace Phantom_s_CSBG_Converter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.progressLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.MediaLabel = new System.Windows.Forms.Label();
			this.Dirlabel = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(502, 202);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(78, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Change";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(421, 202);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(78, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Reset";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(-2, 202);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(78, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Media";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click);
			// 
			// progressLabel
			// 
			this.progressLabel.AutoSize = true;
			this.progressLabel.Location = new System.Drawing.Point(512, 212);
			this.progressLabel.Name = "progressLabel";
			this.progressLabel.Size = new System.Drawing.Size(0, 13);
			this.progressLabel.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(473, 156);
			this.label1.TabIndex = 7;
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.Click += new System.EventHandler(this.Label1_Click);
			// 
			// MediaLabel
			// 
			this.MediaLabel.AutoSize = true;
			this.MediaLabel.ForeColor = System.Drawing.Color.Red;
			this.MediaLabel.Location = new System.Drawing.Point(12, 182);
			this.MediaLabel.Name = "MediaLabel";
			this.MediaLabel.Size = new System.Drawing.Size(79, 13);
			this.MediaLabel.TabIndex = 8;
			this.MediaLabel.Text = "Media : Not set";
			// 
			// Dirlabel
			// 
			this.Dirlabel.AutoSize = true;
			this.Dirlabel.ForeColor = System.Drawing.Color.Orange;
			this.Dirlabel.Location = new System.Drawing.Point(308, 182);
			this.Dirlabel.Name = "Dirlabel";
			this.Dirlabel.Size = new System.Drawing.Size(269, 13);
			this.Dirlabel.TabIndex = 9;
			this.Dirlabel.Text = "CSGO Directory : Automatically using version on C drive";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(82, 203);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(78, 23);
			this.button5.TabIndex = 10;
			this.button5.Text = "CSGO Dir";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click_1);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(166, 206);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(53, 17);
			this.checkBox1.TabIndex = 11;
			this.checkBox1.Text = "Audio";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "1";
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "nuke",
            "intro"});
			this.comboBox1.Location = new System.Drawing.Point(294, 204);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 12;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(225, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Change File:";
			this.label2.Click += new System.EventHandler(this.Label2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 239);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Dirlabel);
			this.Controls.Add(this.MediaLabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.progressLabel);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Phantom\'s CSBG Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MediaLabel;
        private System.Windows.Forms.Label Dirlabel;
        private System.Windows.Forms.Button button5;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
	}
}

