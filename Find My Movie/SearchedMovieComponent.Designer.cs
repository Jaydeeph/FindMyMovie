
namespace Find_My_Movie
{
    partial class SearchedMovieComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MovieImdbLabel = new FlatUI.FlatLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MovieYearLabel = new FlatUI.FlatLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovieNameLabel = new FlatUI.FlatLabel();
            this.MoviePosterPictureBox = new System.Windows.Forms.PictureBox();
            this.TransparentMoviePanel = new Find_My_Movie.TransparentPanel();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.MoviePosterPictureBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(480, 233);
            this.MainPanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.MovieImdbLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(150, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 77);
            this.panel3.TabIndex = 6;
            // 
            // MovieImdbLabel
            // 
            this.MovieImdbLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieImdbLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieImdbLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieImdbLabel.ForeColor = System.Drawing.Color.White;
            this.MovieImdbLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieImdbLabel.Name = "MovieImdbLabel";
            this.MovieImdbLabel.Size = new System.Drawing.Size(330, 77);
            this.MovieImdbLabel.TabIndex = 3;
            this.MovieImdbLabel.Text = "Movie IMDB";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.MovieYearLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(150, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 77);
            this.panel2.TabIndex = 5;
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieYearLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieYearLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieYearLabel.ForeColor = System.Drawing.Color.White;
            this.MovieYearLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(330, 77);
            this.MovieYearLabel.TabIndex = 2;
            this.MovieYearLabel.Text = "Movie Year";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MovieNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 77);
            this.panel1.TabIndex = 4;
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameLabel.ForeColor = System.Drawing.Color.White;
            this.MovieNameLabel.Location = new System.Drawing.Point(0, 0);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(330, 77);
            this.MovieNameLabel.TabIndex = 1;
            this.MovieNameLabel.Text = "Movie Name";
            // 
            // MoviePosterPictureBox
            // 
            this.MoviePosterPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoviePosterPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MoviePosterPictureBox.Name = "MoviePosterPictureBox";
            this.MoviePosterPictureBox.Size = new System.Drawing.Size(150, 233);
            this.MoviePosterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePosterPictureBox.TabIndex = 0;
            this.MoviePosterPictureBox.TabStop = false;
            // 
            // TransparentMoviePanel
            // 
            this.TransparentMoviePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransparentMoviePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransparentMoviePanel.Location = new System.Drawing.Point(0, 0);
            this.TransparentMoviePanel.Name = "TransparentMoviePanel";
            this.TransparentMoviePanel.Size = new System.Drawing.Size(480, 233);
            this.TransparentMoviePanel.TabIndex = 7;
            this.TransparentMoviePanel.Click += new System.EventHandler(this.TransparentMoviePanel_Click);
            // 
            // SearchedMovieComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TransparentMoviePanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "SearchedMovieComponent";
            this.Size = new System.Drawing.Size(480, 233);
            this.Load += new System.EventHandler(this.SearchedMovieComponent_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.PictureBox MoviePosterPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FlatUI.FlatLabel MovieNameLabel;
        private FlatUI.FlatLabel MovieImdbLabel;
        private FlatUI.FlatLabel MovieYearLabel;
        public TransparentPanel TransparentMoviePanel;
    }
}
