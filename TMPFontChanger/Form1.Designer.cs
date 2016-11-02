namespace TMPFontChanger
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
            this.cb_InstalledFonts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_copy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_preview = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TMPlocation = new System.Windows.Forms.TextBox();
            this.btnLocation = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_restore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_InstalledFonts
            // 
            this.cb_InstalledFonts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_InstalledFonts.FormattingEnabled = true;
            this.cb_InstalledFonts.Location = new System.Drawing.Point(12, 105);
            this.cb_InstalledFonts.Name = "cb_InstalledFonts";
            this.cb_InstalledFonts.Size = new System.Drawing.Size(290, 21);
            this.cb_InstalledFonts.TabIndex = 0;
            this.cb_InstalledFonts.SelectedIndexChanged += new System.EventHandler(this.cb_InstalledFonts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select font";
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(12, 221);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(208, 23);
            this.btn_copy.TabIndex = 2;
            this.btn_copy.Text = "Apply font";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Preview";
            // 
            // lbl_preview
            // 
            this.lbl_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_preview.Location = new System.Drawing.Point(12, 142);
            this.lbl_preview.Name = "lbl_preview";
            this.lbl_preview.Size = new System.Drawing.Size(290, 76);
            this.lbl_preview.TabIndex = 4;
            this.lbl_preview.Text = "Trucking all night!";
            this.lbl_preview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location TruckersMP";
            // 
            // txt_TMPlocation
            // 
            this.txt_TMPlocation.Location = new System.Drawing.Point(12, 25);
            this.txt_TMPlocation.Name = "txt_TMPlocation";
            this.txt_TMPlocation.Size = new System.Drawing.Size(290, 20);
            this.txt_TMPlocation.TabIndex = 6;
            this.txt_TMPlocation.Text = "C:\\Program Files\\World of Trucks Multiplayer";
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(227, 51);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(75, 23);
            this.btnLocation.TabIndex = 7;
            this.btnLocation.Text = "Change";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select the location of TruckersMP";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // btn_restore
            // 
            this.btn_restore.Location = new System.Drawing.Point(226, 220);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(75, 23);
            this.btn_restore.TabIndex = 8;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Detect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 252);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_restore);
            this.Controls.Add(this.btnLocation);
            this.Controls.Add(this.txt_TMPlocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_preview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_InstalledFonts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TruckersMP Font Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_InstalledFonts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_preview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TMPlocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button button1;
    }
}

