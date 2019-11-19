namespace MadHatter_Video
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
            this.btnAlmovies = new System.Windows.Forms.Button();
            this.DgvMovies = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDelCus = new System.Windows.Forms.Button();
            this.btnDelMov = new System.Windows.Forms.Button();
            this.btnDelRenMov = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtJdate = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtRent_Cost = new System.Windows.Forms.TextBox();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDateRen = new System.Windows.Forms.TextBox();
            this.labCustID = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.labPhone = new System.Windows.Forms.Label();
            this.labJoinDate = new System.Windows.Forms.Label();
            this.labRating = new System.Windows.Forms.Label();
            this.labMovieID = new System.Windows.Forms.Label();
            this.labPlot = new System.Windows.Forms.Label();
            this.labRent_Cost = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labTitle = new System.Windows.Forms.Label();
            this.labDateRen = new System.Windows.Forms.Label();
            this.labGenre = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCutomer = new System.Windows.Forms.TabPage();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.tabRented_Movies = new System.Windows.Forms.TabPage();
            this.DgvRented_Movies = new System.Windows.Forms.DataGridView();
            this.txtDateRet = new System.Windows.Forms.TextBox();
            this.labDateRet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovies)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabCutomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.tabMovies.SuspendLayout();
            this.tabRented_Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRented_Movies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlmovies
            // 
            this.btnAlmovies.Location = new System.Drawing.Point(238, 588);
            this.btnAlmovies.Name = "btnAlmovies";
            this.btnAlmovies.Size = new System.Drawing.Size(75, 23);
            this.btnAlmovies.TabIndex = 0;
            this.btnAlmovies.Text = "All Movies";
            this.btnAlmovies.UseVisualStyleBackColor = true;
            this.btnAlmovies.Click += new System.EventHandler(this.BtnAlmovies_Click);
            // 
            // DgvMovies
            // 
            this.DgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvMovies.Location = new System.Drawing.Point(3, 3);
            this.DgvMovies.Name = "DgvMovies";
            this.DgvMovies.Size = new System.Drawing.Size(832, 357);
            this.DgvMovies.TabIndex = 1;
            this.DgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMovies_CellContentClick_1);
            this.DgvMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMovies_CellContentClick_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(928, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnAlmovies_Click);
            // 
            // btnDelCus
            // 
            this.btnDelCus.Location = new System.Drawing.Point(933, 189);
            this.btnDelCus.Name = "btnDelCus";
            this.btnDelCus.Size = new System.Drawing.Size(75, 40);
            this.btnDelCus.TabIndex = 3;
            this.btnDelCus.Text = "Del Customer";
            this.btnDelCus.UseVisualStyleBackColor = true;
            this.btnDelCus.Click += new System.EventHandler(this.BtnAlmovies_Click);
            // 
            // btnDelMov
            // 
            this.btnDelMov.Location = new System.Drawing.Point(1053, 198);
            this.btnDelMov.Name = "btnDelMov";
            this.btnDelMov.Size = new System.Drawing.Size(75, 40);
            this.btnDelMov.TabIndex = 4;
            this.btnDelMov.Text = "Del Movie";
            this.btnDelMov.UseVisualStyleBackColor = true;
            this.btnDelMov.Click += new System.EventHandler(this.BtnAlmovies_Click);
            // 
            // btnDelRenMov
            // 
            this.btnDelRenMov.Location = new System.Drawing.Point(1057, 244);
            this.btnDelRenMov.Name = "btnDelRenMov";
            this.btnDelRenMov.Size = new System.Drawing.Size(75, 40);
            this.btnDelRenMov.TabIndex = 5;
            this.btnDelRenMov.Text = "Lost Rented Movie";
            this.btnDelRenMov.UseVisualStyleBackColor = true;
            this.btnDelRenMov.Click += new System.EventHandler(this.BtnAlmovies_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(820, 588);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnAlmovies_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(116, 463);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(251, 463);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(387, 463);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(544, 463);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(690, 463);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // txtJdate
            // 
            this.txtJdate.Location = new System.Drawing.Point(823, 463);
            this.txtJdate.Name = "txtJdate";
            this.txtJdate.Size = new System.Drawing.Size(100, 20);
            this.txtJdate.TabIndex = 12;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(116, 551);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(100, 20);
            this.txtMovieID.TabIndex = 18;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(251, 551);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(100, 20);
            this.txtRating.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(387, 551);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 16;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(544, 551);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 15;
            // 
            // txtRent_Cost
            // 
            this.txtRent_Cost.Location = new System.Drawing.Point(677, 551);
            this.txtRent_Cost.Name = "txtRent_Cost";
            this.txtRent_Cost.Size = new System.Drawing.Size(100, 20);
            this.txtRent_Cost.TabIndex = 14;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(802, 551);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(100, 20);
            this.txtPlot.TabIndex = 13;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(908, 551);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 20;
            // 
            // txtDateRen
            // 
            this.txtDateRen.Location = new System.Drawing.Point(1034, 551);
            this.txtDateRen.Name = "txtDateRen";
            this.txtDateRen.Size = new System.Drawing.Size(100, 20);
            this.txtDateRen.TabIndex = 19;
            // 
            // labCustID
            // 
            this.labCustID.AutoSize = true;
            this.labCustID.Location = new System.Drawing.Point(141, 427);
            this.labCustID.Name = "labCustID";
            this.labCustID.Size = new System.Drawing.Size(39, 13);
            this.labCustID.TabIndex = 21;
            this.labCustID.Text = "CustID";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(273, 427);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(54, 13);
            this.labFirstName.TabIndex = 22;
            this.labFirstName.Text = "FirstName";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(407, 437);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(55, 13);
            this.labLastName.TabIndex = 23;
            this.labLastName.Text = "LastName";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(584, 437);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(45, 13);
            this.labAddress.TabIndex = 24;
            this.labAddress.Text = "Address";
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(724, 427);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(38, 13);
            this.labPhone.TabIndex = 28;
            this.labPhone.Text = "Phone";
            // 
            // labJoinDate
            // 
            this.labJoinDate.AutoSize = true;
            this.labJoinDate.Location = new System.Drawing.Point(841, 437);
            this.labJoinDate.Name = "labJoinDate";
            this.labJoinDate.Size = new System.Drawing.Size(49, 13);
            this.labJoinDate.TabIndex = 27;
            this.labJoinDate.Text = "JoinDate";
            // 
            // labRating
            // 
            this.labRating.AutoSize = true;
            this.labRating.Location = new System.Drawing.Point(285, 514);
            this.labRating.Name = "labRating";
            this.labRating.Size = new System.Drawing.Size(38, 13);
            this.labRating.TabIndex = 26;
            this.labRating.Text = "Rating";
            // 
            // labMovieID
            // 
            this.labMovieID.AutoSize = true;
            this.labMovieID.Location = new System.Drawing.Point(160, 514);
            this.labMovieID.Name = "labMovieID";
            this.labMovieID.Size = new System.Drawing.Size(47, 13);
            this.labMovieID.TabIndex = 25;
            this.labMovieID.Text = "MovieID";
            // 
            // labPlot
            // 
            this.labPlot.AutoSize = true;
            this.labPlot.Location = new System.Drawing.Point(820, 524);
            this.labPlot.Name = "labPlot";
            this.labPlot.Size = new System.Drawing.Size(25, 13);
            this.labPlot.TabIndex = 32;
            this.labPlot.Text = "Plot";
            // 
            // labRent_Cost
            // 
            this.labRent_Cost.AutoSize = true;
            this.labRent_Cost.Location = new System.Drawing.Point(703, 524);
            this.labRent_Cost.Name = "labRent_Cost";
            this.labRent_Cost.Size = new System.Drawing.Size(54, 13);
            this.labRent_Cost.TabIndex = 31;
            this.labRent_Cost.Text = "Rent Cost";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(567, 524);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(29, 13);
            this.labYear.TabIndex = 30;
            this.labYear.Text = "Year";
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(425, 514);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(27, 13);
            this.labTitle.TabIndex = 29;
            this.labTitle.Text = "Title";
            // 
            // labDateRen
            // 
            this.labDateRen.AutoSize = true;
            this.labDateRen.Location = new System.Drawing.Point(1060, 535);
            this.labDateRen.Name = "labDateRen";
            this.labDateRen.Size = new System.Drawing.Size(68, 13);
            this.labDateRen.TabIndex = 34;
            this.labDateRen.Text = "Date Rented";
            // 
            // labGenre
            // 
            this.labGenre.AutoSize = true;
            this.labGenre.Location = new System.Drawing.Point(925, 524);
            this.labGenre.Name = "labGenre";
            this.labGenre.Size = new System.Drawing.Size(36, 13);
            this.labGenre.TabIndex = 33;
            this.labGenre.Text = "Genre";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCutomer);
            this.tabControl1.Controls.Add(this.tabMovies);
            this.tabControl1.Controls.Add(this.tabRented_Movies);
            this.tabControl1.Location = new System.Drawing.Point(21, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(846, 389);
            this.tabControl1.TabIndex = 35;
            // 
            // tabCutomer
            // 
            this.tabCutomer.Controls.Add(this.DgvCustomers);
            this.tabCutomer.Location = new System.Drawing.Point(4, 22);
            this.tabCutomer.Name = "tabCutomer";
            this.tabCutomer.Padding = new System.Windows.Forms.Padding(3);
            this.tabCutomer.Size = new System.Drawing.Size(838, 363);
            this.tabCutomer.TabIndex = 0;
            this.tabCutomer.Text = "Customer";
            this.tabCutomer.UseVisualStyleBackColor = true;
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvCustomers.Location = new System.Drawing.Point(3, 3);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.Size = new System.Drawing.Size(832, 357);
            this.DgvCustomers.TabIndex = 36;
            this.DgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellContentClick);
            this.DgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellContentClick);
            // 
            // tabMovies
            // 
            this.tabMovies.Controls.Add(this.DgvMovies);
            this.tabMovies.Location = new System.Drawing.Point(4, 22);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovies.Size = new System.Drawing.Size(838, 363);
            this.tabMovies.TabIndex = 1;
            this.tabMovies.Text = "Movies";
            this.tabMovies.UseVisualStyleBackColor = true;
            // 
            // tabRented_Movies
            // 
            this.tabRented_Movies.Controls.Add(this.DgvRented_Movies);
            this.tabRented_Movies.Location = new System.Drawing.Point(4, 22);
            this.tabRented_Movies.Name = "tabRented_Movies";
            this.tabRented_Movies.Size = new System.Drawing.Size(838, 363);
            this.tabRented_Movies.TabIndex = 2;
            this.tabRented_Movies.Text = "Rented Movies";
            this.tabRented_Movies.UseVisualStyleBackColor = true;
            // 
            // DgvRented_Movies
            // 
            this.DgvRented_Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRented_Movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRented_Movies.Location = new System.Drawing.Point(0, 0);
            this.DgvRented_Movies.Name = "DgvRented_Movies";
            this.DgvRented_Movies.Size = new System.Drawing.Size(838, 363);
            this.DgvRented_Movies.TabIndex = 36;
            this.DgvRented_Movies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRented_Movies_CellContentClick);
            // 
            // txtDateRet
            // 
            this.txtDateRet.Location = new System.Drawing.Point(1167, 551);
            this.txtDateRet.Name = "txtDateRet";
            this.txtDateRet.Size = new System.Drawing.Size(100, 20);
            this.txtDateRet.TabIndex = 36;
            // 
            // labDateRet
            // 
            this.labDateRet.AutoSize = true;
            this.labDateRet.Location = new System.Drawing.Point(1165, 524);
            this.labDateRet.Name = "labDateRet";
            this.labDateRet.Size = new System.Drawing.Size(77, 13);
            this.labDateRet.TabIndex = 37;
            this.labDateRet.Text = "Date Returned";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 639);
            this.Controls.Add(this.labDateRet);
            this.Controls.Add(this.txtDateRet);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labDateRen);
            this.Controls.Add(this.labGenre);
            this.Controls.Add(this.labPlot);
            this.Controls.Add(this.labRent_Cost);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labTitle);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.labJoinDate);
            this.Controls.Add(this.labRating);
            this.Controls.Add(this.labMovieID);
            this.Controls.Add(this.labAddress);
            this.Controls.Add(this.labLastName);
            this.Controls.Add(this.labFirstName);
            this.Controls.Add(this.labCustID);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtDateRen);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtRent_Cost);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.txtJdate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnDelRenMov);
            this.Controls.Add(this.btnDelMov);
            this.Controls.Add(this.btnDelCus);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAlmovies);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgvMovies)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabCutomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.tabMovies.ResumeLayout(false);
            this.tabRented_Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRented_Movies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlmovies;
        private System.Windows.Forms.DataGridView DgvMovies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDelCus;
        private System.Windows.Forms.Button btnDelMov;
        private System.Windows.Forms.Button btnDelRenMov;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtJdate;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtRent_Cost;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDateRen;
        private System.Windows.Forms.Label labCustID;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labJoinDate;
        private System.Windows.Forms.Label labRating;
        private System.Windows.Forms.Label labMovieID;
        private System.Windows.Forms.Label labPlot;
        private System.Windows.Forms.Label labRent_Cost;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labDateRen;
        private System.Windows.Forms.Label labGenre;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCutomer;
        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.TabPage tabRented_Movies;
        private System.Windows.Forms.DataGridView DgvRented_Movies;
        private System.Windows.Forms.TextBox txtDateRet;
        private System.Windows.Forms.Label labDateRet;
    }
}

