namespace Pelis_Media.Views
{
	partial class Movies_s
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnall = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cmGenero = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGMovies = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxSearch = new System.Windows.Forms.TextBox();
			this.buttonS = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.comboGenres = new System.Windows.Forms.ComboBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGMovies)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(653, -90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 25);
			this.label2.TabIndex = 17;
			this.label2.Text = "GENERO";
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(1161, -95);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(354, 41);
			this.button2.TabIndex = 15;
			this.button2.Text = "CREAR NUEVA PELICULA";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// btnall
			// 
			this.btnall.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnall.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnall.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnall.Location = new System.Drawing.Point(1142, 740);
			this.btnall.Name = "btnall";
			this.btnall.Size = new System.Drawing.Size(354, 41);
			this.btnall.TabIndex = 16;
			this.btnall.Text = "MOSTRAR TODO";
			this.btnall.UseVisualStyleBackColor = false;
			this.btnall.Click += new System.EventHandler(this.btnall_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSearch.Location = new System.Drawing.Point(506, -95);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(94, 41);
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "BUSCAR";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// cmGenero
			// 
			this.cmGenero.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmGenero.FormattingEnabled = true;
			this.cmGenero.Location = new System.Drawing.Point(767, -95);
			this.cmGenero.Name = "cmGenero";
			this.cmGenero.Size = new System.Drawing.Size(267, 37);
			this.cmGenero.TabIndex = 13;
			this.cmGenero.UseWaitCursor = true;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(103, -95);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(397, 41);
			this.textBox1.TabIndex = 11;
			// 
			// dataGMovies
			// 
			this.dataGMovies.AllowUserToAddRows = false;
			this.dataGMovies.AllowUserToDeleteRows = false;
			this.dataGMovies.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dataGMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGMovies.EnableHeadersVisualStyles = false;
			this.dataGMovies.Location = new System.Drawing.Point(32, 219);
			this.dataGMovies.Name = "dataGMovies";
			this.dataGMovies.ReadOnly = true;
			this.dataGMovies.RowHeadersWidth = 51;
			this.dataGMovies.RowTemplate.Height = 24;
			this.dataGMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGMovies.Size = new System.Drawing.Size(1464, 503);
			this.dataGMovies.TabIndex = 10;
			this.dataGMovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGMovies_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(-345, -158);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 29);
			this.label1.TabIndex = 9;
			this.label1.Text = "Todas las Películas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(27, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 29);
			this.label3.TabIndex = 18;
			this.label3.Text = "Todas las Películas";
			// 
			// tbxSearch
			// 
			this.tbxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSearch.Location = new System.Drawing.Point(89, 158);
			this.tbxSearch.Multiline = true;
			this.tbxSearch.Name = "tbxSearch";
			this.tbxSearch.Size = new System.Drawing.Size(524, 43);
			this.tbxSearch.TabIndex = 19;
			// 
			// buttonS
			// 
			this.buttonS.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.buttonS.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttonS.Location = new System.Drawing.Point(619, 156);
			this.buttonS.Name = "buttonS";
			this.buttonS.Size = new System.Drawing.Size(132, 45);
			this.buttonS.TabIndex = 21;
			this.buttonS.Text = "BUSCAR";
			this.buttonS.UseVisualStyleBackColor = false;
			this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(792, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 25);
			this.label4.TabIndex = 22;
			this.label4.Text = "GENERO";
			// 
			// comboGenres
			// 
			this.comboGenres.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboGenres.DisplayMember = "Id";
			this.comboGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboGenres.FormattingEnabled = true;
			this.comboGenres.Location = new System.Drawing.Point(894, 158);
			this.comboGenres.Name = "comboGenres";
			this.comboGenres.Size = new System.Drawing.Size(202, 37);
			this.comboGenres.TabIndex = 23;
			this.comboGenres.ValueMember = "Id";
			this.comboGenres.SelectionChangeCommitted += new System.EventHandler(this.comboGenres_SelectionChangeCommitted);
			this.comboGenres.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboGenres_MouseClick);
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCreate.Location = new System.Drawing.Point(1142, 156);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(354, 41);
			this.btnCreate.TabIndex = 24;
			this.btnCreate.Text = "CREAR PELICULA";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// iconPictureBox2
			// 
			this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox2.IconSize = 43;
			this.iconPictureBox2.Location = new System.Drawing.Point(32, 158);
			this.iconPictureBox2.Name = "iconPictureBox2";
			this.iconPictureBox2.Size = new System.Drawing.Size(51, 43);
			this.iconPictureBox2.TabIndex = 20;
			this.iconPictureBox2.TabStop = false;
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
			this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
			this.iconPictureBox1.IconSize = 41;
			this.iconPictureBox1.Location = new System.Drawing.Point(51, -95);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(46, 41);
			this.iconPictureBox1.TabIndex = 12;
			this.iconPictureBox1.TabStop = false;
			// 
			// Movies_s
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1538, 802);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.comboGenres);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonS);
			this.Controls.Add(this.iconPictureBox2);
			this.Controls.Add(this.tbxSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnall);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.cmGenero);
			this.Controls.Add(this.iconPictureBox1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGMovies);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Movies_s";
			this.Text = "Películas";
			this.Load += new System.EventHandler(this.Movie_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGMovies)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnall;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cmGenero;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGMovies;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxSearch;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
		private System.Windows.Forms.Button buttonS;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboGenres;
		private System.Windows.Forms.Button btnCreate;
	}
}