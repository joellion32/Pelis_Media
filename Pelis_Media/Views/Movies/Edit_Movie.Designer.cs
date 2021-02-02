namespace Pelis_Media.Views.Movies
{
	partial class Edit_Movie
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
			this.btnReset = new System.Windows.Forms.Button();
			this.comboG = new System.Windows.Forms.ComboBox();
			this.comboGenre = new System.Windows.Forms.Label();
			this.comboPremiere = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateDate = new System.Windows.Forms.DateTimePicker();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.tbxDescription = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxQualification = new System.Windows.Forms.TextBox();
			this.tbxTitle = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnActors = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnReset.Location = new System.Drawing.Point(96, 573);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(524, 55);
			this.btnReset.TabIndex = 35;
			this.btnReset.Text = "RESETEAR FORMULARIO";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// comboG
			// 
			this.comboG.DisplayMember = "Id";
			this.comboG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.comboG.FormattingEnabled = true;
			this.comboG.Location = new System.Drawing.Point(676, 216);
			this.comboG.Name = "comboG";
			this.comboG.Size = new System.Drawing.Size(532, 37);
			this.comboG.TabIndex = 34;
			this.comboG.ValueMember = "Id";
			// 
			// comboGenre
			// 
			this.comboGenre.AutoSize = true;
			this.comboGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboGenre.Location = new System.Drawing.Point(476, 228);
			this.comboGenre.Name = "comboGenre";
			this.comboGenre.Size = new System.Drawing.Size(96, 25);
			this.comboGenre.TabIndex = 33;
			this.comboGenre.Text = "GENERO";
			// 
			// comboPremiere
			// 
			this.comboPremiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboPremiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.comboPremiere.FormattingEnabled = true;
			this.comboPremiere.Items.AddRange(new object[] {
            "SI",
            "NO"});
			this.comboPremiere.Location = new System.Drawing.Point(677, 277);
			this.comboPremiere.Name = "comboPremiere";
			this.comboPremiere.Size = new System.Drawing.Size(532, 37);
			this.comboPremiere.TabIndex = 32;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(477, 289);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 25);
			this.label7.TabIndex = 31;
			this.label7.Text = "EN ESTRENO";
			// 
			// dateDate
			// 
			this.dateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateDate.Location = new System.Drawing.Point(678, 158);
			this.dateDate.Name = "dateDate";
			this.dateDate.Size = new System.Drawing.Size(532, 34);
			this.dateDate.TabIndex = 30;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.Location = new System.Drawing.Point(97, 672);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(1103, 55);
			this.btnUpdate.TabIndex = 29;
			this.btnUpdate.Text = "ACTUALIZAR";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// tbxDescription
			// 
			this.tbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxDescription.Location = new System.Drawing.Point(677, 350);
			this.tbxDescription.Multiline = true;
			this.tbxDescription.Name = "tbxDescription";
			this.tbxDescription.Size = new System.Drawing.Size(532, 167);
			this.tbxDescription.TabIndex = 28;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(476, 350);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(141, 25);
			this.label4.TabIndex = 27;
			this.label4.Text = "ARGUMENTO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(477, 166);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 25);
			this.label3.TabIndex = 24;
			this.label3.Text = "FECHA ESTRENO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(476, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 25);
			this.label2.TabIndex = 25;
			this.label2.Text = "CALIFICACION";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(477, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 25);
			this.label1.TabIndex = 26;
			this.label1.Text = "TITULO";
			// 
			// tbxQualification
			// 
			this.tbxQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxQualification.Location = new System.Drawing.Point(677, 99);
			this.tbxQualification.Multiline = true;
			this.tbxQualification.Name = "tbxQualification";
			this.tbxQualification.Size = new System.Drawing.Size(532, 38);
			this.tbxQualification.TabIndex = 22;
			// 
			// tbxTitle
			// 
			this.tbxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxTitle.Location = new System.Drawing.Point(677, 38);
			this.tbxTitle.Multiline = true;
			this.tbxTitle.Name = "tbxTitle";
			this.tbxTitle.Size = new System.Drawing.Size(532, 38);
			this.tbxTitle.TabIndex = 23;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pelis_Media.Properties.Resources.logo1;
			this.pictureBox1.Location = new System.Drawing.Point(105, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(296, 362);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// btnActors
			// 
			this.btnActors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnActors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnActors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnActors.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnActors.Location = new System.Drawing.Point(676, 573);
			this.btnActors.Name = "btnActors";
			this.btnActors.Size = new System.Drawing.Size(524, 55);
			this.btnActors.TabIndex = 36;
			this.btnActors.Text = "AGREGAR ACTORES";
			this.btnActors.UseVisualStyleBackColor = false;
			this.btnActors.Click += new System.EventHandler(this.btnActors_Click);
			// 
			// Edit_Movie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 755);
			this.Controls.Add(this.btnActors);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.comboG);
			this.Controls.Add(this.comboGenre);
			this.Controls.Add(this.comboPremiere);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateDate);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.tbxDescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxQualification);
			this.Controls.Add(this.tbxTitle);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Edit_Movie";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editar Pelicula";
			this.Load += new System.EventHandler(this.Edit_Movie_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ComboBox comboG;
		private System.Windows.Forms.Label comboGenre;
		private System.Windows.Forms.ComboBox comboPremiere;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dateDate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.TextBox tbxDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxQualification;
		private System.Windows.Forms.TextBox tbxTitle;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnActors;
	}
}