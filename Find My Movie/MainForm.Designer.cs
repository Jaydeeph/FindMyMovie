
namespace Find_My_Movie
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainFormSkin = new FlatUI.FormSkin();
            this.SettingsPictureBox = new System.Windows.Forms.PictureBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.CloseButton = new FlatUI.FlatClose();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTabControl = new FlatUI.FlatTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TableLayoutPanelMovies = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NextMovieButton = new FlatUI.FlatButton();
            this.ShowMovieListButton = new FlatUI.FlatButton();
            this.SaveMovieListButton = new FlatUI.FlatButton();
            this.LoadMovieListButton = new FlatUI.FlatButton();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SearchMovieButton = new FlatUI.FlatButton();
            this.MovieNameTextBox = new FlatUI.FlatTextBox();
            this.MovieNameLabel = new FlatUI.FlatLabel();
            this.MainFormSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormSkin
            // 
            this.MainFormSkin.BackColor = System.Drawing.Color.White;
            this.MainFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.MainFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.MainFormSkin.Controls.Add(this.SettingsPictureBox);
            this.MainFormSkin.Controls.Add(this.flatMini1);
            this.MainFormSkin.Controls.Add(this.CloseButton);
            this.MainFormSkin.Controls.Add(this.MainPanel);
            this.MainFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.MainFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MainFormSkin.HeaderMaximize = false;
            this.MainFormSkin.Location = new System.Drawing.Point(0, 0);
            this.MainFormSkin.Name = "MainFormSkin";
            this.MainFormSkin.Size = new System.Drawing.Size(1100, 530);
            this.MainFormSkin.TabIndex = 0;
            this.MainFormSkin.Text = "Find My Movie";
            // 
            // SettingsPictureBox
            // 
            this.SettingsPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SettingsPictureBox.Image")));
            this.SettingsPictureBox.Location = new System.Drawing.Point(1022, 12);
            this.SettingsPictureBox.Name = "SettingsPictureBox";
            this.SettingsPictureBox.Size = new System.Drawing.Size(18, 18);
            this.SettingsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingsPictureBox.TabIndex = 6;
            this.SettingsPictureBox.TabStop = false;
            this.SettingsPictureBox.Click += new System.EventHandler(this.SettingsPictureBox_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(1046, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 4;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.White;
            this.CloseButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CloseButton.Font = new System.Drawing.Font("Marlett", 10F);
            this.CloseButton.Location = new System.Drawing.Point(1070, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 18);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "flatClose1";
            this.CloseButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CloseButton.Click += new System.EventHandler(this.OnClick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.MainPanel.Controls.Add(this.MainTabControl);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(0, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1100, 480);
            this.MainPanel.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.MainTabControl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MainTabControl.ItemSize = new System.Drawing.Size(120, 40);
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1100, 480);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.TableLayoutPanelMovies);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.TopPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Search Movie";
            // 
            // TableLayoutPanelMovies
            // 
            this.TableLayoutPanelMovies.AutoScroll = true;
            this.TableLayoutPanelMovies.ColumnCount = 2;
            this.TableLayoutPanelMovies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanelMovies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TableLayoutPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMovies.Location = new System.Drawing.Point(3, 77);
            this.TableLayoutPanelMovies.Name = "TableLayoutPanelMovies";
            this.TableLayoutPanelMovies.RowCount = 1;
            this.TableLayoutPanelMovies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMovies.Size = new System.Drawing.Size(1086, 301);
            this.TableLayoutPanelMovies.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NextMovieButton);
            this.panel2.Controls.Add(this.ShowMovieListButton);
            this.panel2.Controls.Add(this.SaveMovieListButton);
            this.panel2.Controls.Add(this.LoadMovieListButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 378);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 51);
            this.panel2.TabIndex = 3;
            // 
            // NextMovieButton
            // 
            this.NextMovieButton.BackColor = System.Drawing.Color.Transparent;
            this.NextMovieButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.NextMovieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextMovieButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NextMovieButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NextMovieButton.Location = new System.Drawing.Point(543, 0);
            this.NextMovieButton.Name = "NextMovieButton";
            this.NextMovieButton.Rounded = false;
            this.NextMovieButton.Size = new System.Drawing.Size(181, 51);
            this.NextMovieButton.TabIndex = 10;
            this.NextMovieButton.Text = "Next Movie";
            this.NextMovieButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.NextMovieButton.Click += new System.EventHandler(this.NextMovieButton_Click);
            // 
            // ShowMovieListButton
            // 
            this.ShowMovieListButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowMovieListButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.ShowMovieListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowMovieListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowMovieListButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShowMovieListButton.Location = new System.Drawing.Point(362, 0);
            this.ShowMovieListButton.Name = "ShowMovieListButton";
            this.ShowMovieListButton.Rounded = false;
            this.ShowMovieListButton.Size = new System.Drawing.Size(181, 51);
            this.ShowMovieListButton.TabIndex = 9;
            this.ShowMovieListButton.Text = "Show Movie List";
            this.ShowMovieListButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ShowMovieListButton.Click += new System.EventHandler(this.ShowMovieListButton_Click);
            // 
            // SaveMovieListButton
            // 
            this.SaveMovieListButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveMovieListButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.SaveMovieListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveMovieListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveMovieListButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SaveMovieListButton.Location = new System.Drawing.Point(181, 0);
            this.SaveMovieListButton.Name = "SaveMovieListButton";
            this.SaveMovieListButton.Rounded = false;
            this.SaveMovieListButton.Size = new System.Drawing.Size(181, 51);
            this.SaveMovieListButton.TabIndex = 7;
            this.SaveMovieListButton.Text = "Save Movie List";
            this.SaveMovieListButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SaveMovieListButton.Click += new System.EventHandler(this.SaveMovieListButton_Click);
            // 
            // LoadMovieListButton
            // 
            this.LoadMovieListButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadMovieListButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.LoadMovieListButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadMovieListButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadMovieListButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoadMovieListButton.Location = new System.Drawing.Point(0, 0);
            this.LoadMovieListButton.Name = "LoadMovieListButton";
            this.LoadMovieListButton.Rounded = false;
            this.LoadMovieListButton.Size = new System.Drawing.Size(181, 51);
            this.LoadMovieListButton.TabIndex = 6;
            this.LoadMovieListButton.Text = "Load Movie List";
            this.LoadMovieListButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LoadMovieListButton.Click += new System.EventHandler(this.LoadMovieListButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SearchMovieButton);
            this.TopPanel.Controls.Add(this.MovieNameTextBox);
            this.TopPanel.Controls.Add(this.MovieNameLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(3, 3);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1086, 74);
            this.TopPanel.TabIndex = 2;
            // 
            // SearchMovieButton
            // 
            this.SearchMovieButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchMovieButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.SearchMovieButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchMovieButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SearchMovieButton.Location = new System.Drawing.Point(851, 14);
            this.SearchMovieButton.Name = "SearchMovieButton";
            this.SearchMovieButton.Rounded = false;
            this.SearchMovieButton.Size = new System.Drawing.Size(121, 41);
            this.SearchMovieButton.TabIndex = 4;
            this.SearchMovieButton.Text = "Search Movie";
            this.SearchMovieButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.SearchMovieButton.Click += new System.EventHandler(this.SearchMovieButton_Click);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MovieNameTextBox.FocusOnHover = false;
            this.MovieNameTextBox.Location = new System.Drawing.Point(17, 33);
            this.MovieNameTextBox.MaxLength = 32767;
            this.MovieNameTextBox.Multiline = false;
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.ReadOnly = false;
            this.MovieNameTextBox.Size = new System.Drawing.Size(224, 29);
            this.MovieNameTextBox.TabIndex = 3;
            this.MovieNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MovieNameTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MovieNameTextBox.UseSystemPasswordChar = false;
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameLabel.ForeColor = System.Drawing.Color.White;
            this.MovieNameLabel.Location = new System.Drawing.Point(18, 9);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(102, 21);
            this.MovieNameLabel.TabIndex = 2;
            this.MovieNameLabel.Text = "Movie Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 530);
            this.Controls.Add(this.MainFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mind My Movie";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SettingsPictureBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private FlatUI.FlatClose CloseButton;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FormSkin MainFormSkin;
        private System.Windows.Forms.PictureBox SettingsPictureBox;
        private FlatUI.FlatTabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMovies;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatButton SaveMovieListButton;
        private FlatUI.FlatButton LoadMovieListButton;
        private System.Windows.Forms.Panel TopPanel;
        private FlatUI.FlatButton SearchMovieButton;
        private FlatUI.FlatTextBox MovieNameTextBox;
        private FlatUI.FlatLabel MovieNameLabel;
        private FlatUI.FlatButton ShowMovieListButton;
        private FlatUI.FlatButton NextMovieButton;
    }
}

