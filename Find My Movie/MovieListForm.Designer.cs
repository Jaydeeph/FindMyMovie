
namespace Find_My_Movie
{
    partial class MovieListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieListForm));
            this.MovieListFormSkin = new FlatUI.FormSkin();
            this.flatClose1 = new FlatUI.FlatClose();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TableLayoutPanelMovies = new System.Windows.Forms.TableLayoutPanel();
            this.flatMini1 = new FlatUI.FlatMini();
            this.MovieListFormSkin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieListFormSkin
            // 
            this.MovieListFormSkin.BackColor = System.Drawing.Color.White;
            this.MovieListFormSkin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(84)))), ((int)(((byte)(87)))));
            this.MovieListFormSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.MovieListFormSkin.Controls.Add(this.flatClose1);
            this.MovieListFormSkin.Controls.Add(this.panel1);
            this.MovieListFormSkin.Controls.Add(this.flatMini1);
            this.MovieListFormSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieListFormSkin.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(250)))));
            this.MovieListFormSkin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MovieListFormSkin.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MovieListFormSkin.HeaderMaximize = false;
            this.MovieListFormSkin.Location = new System.Drawing.Point(0, 0);
            this.MovieListFormSkin.Name = "MovieListFormSkin";
            this.MovieListFormSkin.Size = new System.Drawing.Size(690, 420);
            this.MovieListFormSkin.TabIndex = 0;
            this.MovieListFormSkin.Text = "Movie List";
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(660, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.OnClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.TableLayoutPanelMovies);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 370);
            this.panel1.TabIndex = 2;
            // 
            // TableLayoutPanelMovies
            // 
            this.TableLayoutPanelMovies.AutoScroll = true;
            this.TableLayoutPanelMovies.ColumnCount = 1;
            this.TableLayoutPanelMovies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMovies.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanelMovies.Name = "TableLayoutPanelMovies";
            this.TableLayoutPanelMovies.RowCount = 2;
            this.TableLayoutPanelMovies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMovies.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TableLayoutPanelMovies.Size = new System.Drawing.Size(690, 370);
            this.TableLayoutPanelMovies.TabIndex = 4;
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(636, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // MovieListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 420);
            this.Controls.Add(this.MovieListFormSkin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MovieListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie List";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SearchedMovieForm_Load);
            this.MovieListFormSkin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin MovieListFormSkin;
        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMovies;
        private FlatUI.FlatClose flatClose1;
    }
}