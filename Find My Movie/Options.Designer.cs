
namespace Find_My_Movie
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.OptionsSkin = new FlatUI.FormSkin();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovieStatsSaveGroupBox = new FlatUI.FlatGroupBox();
            this.ApplicationGroupBox = new FlatUI.FlatGroupBox();
            this.CustomFormatCheckBox = new FlatUI.FlatCheckBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.CloseButton = new FlatUI.FlatClose();
            this.OptionsSkin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ApplicationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OptionsSkin
            // 
            this.OptionsSkin.BackColor = System.Drawing.Color.White;
            this.OptionsSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.OptionsSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.OptionsSkin.Controls.Add(this.panel1);
            this.OptionsSkin.Controls.Add(this.flatMini1);
            this.OptionsSkin.Controls.Add(this.CloseButton);
            this.OptionsSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.OptionsSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.OptionsSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.OptionsSkin.HeaderMaximize = false;
            this.OptionsSkin.Location = new System.Drawing.Point(0, 0);
            this.OptionsSkin.Name = "OptionsSkin";
            this.OptionsSkin.Size = new System.Drawing.Size(712, 450);
            this.OptionsSkin.TabIndex = 0;
            this.OptionsSkin.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.MovieStatsSaveGroupBox);
            this.panel1.Controls.Add(this.ApplicationGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 399);
            this.panel1.TabIndex = 2;
            // 
            // MovieStatsSaveGroupBox
            // 
            this.MovieStatsSaveGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.MovieStatsSaveGroupBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.MovieStatsSaveGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MovieStatsSaveGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MovieStatsSaveGroupBox.Location = new System.Drawing.Point(0, 179);
            this.MovieStatsSaveGroupBox.Name = "MovieStatsSaveGroupBox";
            this.MovieStatsSaveGroupBox.ShowText = true;
            this.MovieStatsSaveGroupBox.Size = new System.Drawing.Size(712, 217);
            this.MovieStatsSaveGroupBox.TabIndex = 5;
            this.MovieStatsSaveGroupBox.Text = "Movie Stats Save";
            // 
            // ApplicationGroupBox
            // 
            this.ApplicationGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ApplicationGroupBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ApplicationGroupBox.Controls.Add(this.CustomFormatCheckBox);
            this.ApplicationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplicationGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ApplicationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ApplicationGroupBox.Name = "ApplicationGroupBox";
            this.ApplicationGroupBox.ShowText = true;
            this.ApplicationGroupBox.Size = new System.Drawing.Size(712, 179);
            this.ApplicationGroupBox.TabIndex = 4;
            this.ApplicationGroupBox.Text = "Application";
            // 
            // CustomFormatCheckBox
            // 
            this.CustomFormatCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.CustomFormatCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.CustomFormatCheckBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.CustomFormatCheckBox.Checked = false;
            this.CustomFormatCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomFormatCheckBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustomFormatCheckBox.Location = new System.Drawing.Point(25, 47);
            this.CustomFormatCheckBox.Name = "CustomFormatCheckBox";
            this.CustomFormatCheckBox.Options = FlatUI.FlatCheckBox._Options.Style1;
            this.CustomFormatCheckBox.Size = new System.Drawing.Size(158, 22);
            this.CustomFormatCheckBox.TabIndex = 0;
            this.CustomFormatCheckBox.Text = "Use Custom Format";
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(658, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseButton.Font = new System.Drawing.Font("Marlett", 10F);
            this.CloseButton.Location = new System.Drawing.Point(682, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "flatClose1";
            this.CloseButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CloseButton.Click += new System.EventHandler(this.OnClick);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.OptionsSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.OptionsSkin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ApplicationGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin OptionsSkin;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose CloseButton;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatGroupBox MovieStatsSaveGroupBox;
        private FlatUI.FlatGroupBox ApplicationGroupBox;
        private FlatUI.FlatCheckBox CustomFormatCheckBox;
    }
}