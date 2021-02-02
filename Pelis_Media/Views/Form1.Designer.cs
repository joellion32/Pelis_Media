namespace Pelis_Media
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnExit = new FontAwesome.Sharp.IconButton();
			this.btnActors = new FontAwesome.Sharp.IconButton();
			this.btnMovies = new FontAwesome.Sharp.IconButton();
			this.btnHome = new FontAwesome.Sharp.IconButton();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelBar = new System.Windows.Forms.Panel();
			this.lbNavigation = new System.Windows.Forms.Label();
			this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			this.primaryPanel = new System.Windows.Forms.Panel();
			this.panelMenu.SuspendLayout();
			this.panelLogo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.panelMenu.Controls.Add(this.btnExit);
			this.panelMenu.Controls.Add(this.btnActors);
			this.panelMenu.Controls.Add(this.btnMovies);
			this.panelMenu.Controls.Add(this.btnHome);
			this.panelMenu.Controls.Add(this.panelLogo);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(220, 877);
			this.panelMenu.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnExit.FlatAppearance.BorderSize = 0;
			this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExit.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
			this.btnExit.IconColor = System.Drawing.Color.White;
			this.btnExit.IconSize = 32;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(0, 320);
			this.btnExit.Margin = new System.Windows.Forms.Padding(20);
			this.btnExit.Name = "btnExit";
			this.btnExit.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
			this.btnExit.Rotation = 0D;
			this.btnExit.Size = new System.Drawing.Size(220, 60);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Salir";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnActors
			// 
			this.btnActors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActors.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnActors.FlatAppearance.BorderSize = 0;
			this.btnActors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActors.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnActors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnActors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnActors.IconChar = FontAwesome.Sharp.IconChar.Users;
			this.btnActors.IconColor = System.Drawing.Color.White;
			this.btnActors.IconSize = 32;
			this.btnActors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActors.Location = new System.Drawing.Point(0, 260);
			this.btnActors.Margin = new System.Windows.Forms.Padding(20);
			this.btnActors.Name = "btnActors";
			this.btnActors.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
			this.btnActors.Rotation = 0D;
			this.btnActors.Size = new System.Drawing.Size(220, 60);
			this.btnActors.TabIndex = 3;
			this.btnActors.Text = "Actores";
			this.btnActors.UseVisualStyleBackColor = true;
			this.btnActors.Click += new System.EventHandler(this.btnActors_Click);
			// 
			// btnMovies
			// 
			this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMovies.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnMovies.FlatAppearance.BorderSize = 0;
			this.btnMovies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMovies.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMovies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnMovies.IconChar = FontAwesome.Sharp.IconChar.Tv;
			this.btnMovies.IconColor = System.Drawing.Color.White;
			this.btnMovies.IconSize = 32;
			this.btnMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMovies.Location = new System.Drawing.Point(0, 200);
			this.btnMovies.Margin = new System.Windows.Forms.Padding(20);
			this.btnMovies.Name = "btnMovies";
			this.btnMovies.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
			this.btnMovies.Rotation = 0D;
			this.btnMovies.Size = new System.Drawing.Size(220, 60);
			this.btnMovies.TabIndex = 2;
			this.btnMovies.Text = "Películas";
			this.btnMovies.UseVisualStyleBackColor = true;
			this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
			// 
			// btnHome
			// 
			this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
			this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
			this.btnHome.IconColor = System.Drawing.Color.White;
			this.btnHome.IconSize = 32;
			this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHome.Location = new System.Drawing.Point(0, 140);
			this.btnHome.Margin = new System.Windows.Forms.Padding(20);
			this.btnHome.Name = "btnHome";
			this.btnHome.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
			this.btnHome.Rotation = 0D;
			this.btnHome.Size = new System.Drawing.Size(220, 60);
			this.btnHome.TabIndex = 1;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelLogo
			// 
			this.panelLogo.Controls.Add(this.label1);
			this.panelLogo.Controls.Add(this.pictureBox1);
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Size = new System.Drawing.Size(220, 140);
			this.panelLogo.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(51, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Pelis Media";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pelis_Media.Properties.Resources.youtube;
			this.pictureBox1.Location = new System.Drawing.Point(72, 25);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 44);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panelBar
			// 
			this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.panelBar.Controls.Add(this.lbNavigation);
			this.panelBar.Controls.Add(this.iconPictureBox1);
			this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBar.Location = new System.Drawing.Point(220, 0);
			this.panelBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panelBar.Name = "panelBar";
			this.panelBar.Size = new System.Drawing.Size(1538, 75);
			this.panelBar.TabIndex = 1;
			// 
			// lbNavigation
			// 
			this.lbNavigation.AutoSize = true;
			this.lbNavigation.ForeColor = System.Drawing.Color.Lavender;
			this.lbNavigation.Location = new System.Drawing.Point(55, 32);
			this.lbNavigation.Name = "lbNavigation";
			this.lbNavigation.Size = new System.Drawing.Size(45, 17);
			this.lbNavigation.TabIndex = 1;
			this.lbNavigation.Text = "Home";
			// 
			// iconPictureBox1
			// 
			this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkOrchid;
			this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.YoutubeSquare;
			this.iconPictureBox1.IconColor = System.Drawing.Color.DarkOrchid;
			this.iconPictureBox1.Location = new System.Drawing.Point(17, 25);
			this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.iconPictureBox1.Name = "iconPictureBox1";
			this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
			this.iconPictureBox1.TabIndex = 0;
			this.iconPictureBox1.TabStop = false;
			// 
			// primaryPanel
			// 
			this.primaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.primaryPanel.Location = new System.Drawing.Point(220, 75);
			this.primaryPanel.Margin = new System.Windows.Forms.Padding(5);
			this.primaryPanel.Name = "primaryPanel";
			this.primaryPanel.Size = new System.Drawing.Size(1538, 802);
			this.primaryPanel.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1758, 877);
			this.Controls.Add(this.primaryPanel);
			this.Controls.Add(this.panelBar);
			this.Controls.Add(this.panelMenu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pelis Media";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panelMenu.ResumeLayout(false);
			this.panelLogo.ResumeLayout(false);
			this.panelLogo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelBar.ResumeLayout(false);
			this.panelBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private FontAwesome.Sharp.IconButton btnHome;
		private System.Windows.Forms.Panel panelLogo;
		private FontAwesome.Sharp.IconButton btnExit;
		private FontAwesome.Sharp.IconButton btnActors;
		private FontAwesome.Sharp.IconButton btnMovies;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelBar;
		private System.Windows.Forms.Label lbNavigation;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
		private System.Windows.Forms.Panel primaryPanel;
	}
}

