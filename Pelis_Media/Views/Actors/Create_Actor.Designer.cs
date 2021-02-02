namespace Pelis_Media.Views.Actors
{
	partial class Create_Actor
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
			this.btnUpload = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboG = new System.Windows.Forms.ComboBox();
			this.dateBirth = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnClean = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpload
			// 
			this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpload.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpload.Location = new System.Drawing.Point(12, 294);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(222, 55);
			this.btnUpload.TabIndex = 3;
			this.btnUpload.Text = "SUBIR IMAGEN";
			this.btnUpload.UseVisualStyleBackColor = false;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "NOMBRE";
			// 
			// tbxName
			// 
			this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxName.Location = new System.Drawing.Point(390, 53);
			this.tbxName.Multiline = true;
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(310, 38);
			this.tbxName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(256, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "APELLIDO";
			// 
			// textSurname
			// 
			this.textSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textSurname.Location = new System.Drawing.Point(390, 110);
			this.textSurname.Multiline = true;
			this.textSurname.Name = "textSurname";
			this.textSurname.Size = new System.Drawing.Size(310, 38);
			this.textSurname.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(256, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "GENERO";
			// 
			// comboG
			// 
			this.comboG.DisplayMember = "Id";
			this.comboG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
			this.comboG.FormattingEnabled = true;
			this.comboG.Items.AddRange(new object[] {
            "M",
            "F"});
			this.comboG.Location = new System.Drawing.Point(390, 189);
			this.comboG.Name = "comboG";
			this.comboG.Size = new System.Drawing.Size(310, 37);
			this.comboG.TabIndex = 19;
			this.comboG.ValueMember = "Id";
			// 
			// dateBirth
			// 
			this.dateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateBirth.Location = new System.Drawing.Point(252, 315);
			this.dateBirth.Name = "dateBirth";
			this.dateBirth.Size = new System.Drawing.Size(448, 34);
			this.dateBirth.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(256, 270);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 25);
			this.label4.TabIndex = 20;
			this.label4.Text = "FECHA NACIMIENTO";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.Location = new System.Drawing.Point(12, 425);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(688, 55);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "GUARDAR";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnClean
			// 
			this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnClean.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClean.Location = new System.Drawing.Point(12, 499);
			this.btnClean.Name = "btnClean";
			this.btnClean.Size = new System.Drawing.Size(688, 55);
			this.btnClean.TabIndex = 22;
			this.btnClean.Text = "LIMPIAR FORMULARIO";
			this.btnClean.UseVisualStyleBackColor = false;
			this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pelis_Media.Properties.Resources.logo1;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(222, 266);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// Create_Actor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 680);
			this.Controls.Add(this.btnClean);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dateBirth);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboG);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textSurname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Create_Actor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Crear Actor";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboG;
		private System.Windows.Forms.DateTimePicker dateBirth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClean;
	}
}