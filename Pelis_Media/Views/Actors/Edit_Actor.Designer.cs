namespace Pelis_Media.Views.Actors
{
	partial class Edit_Actor
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dateBirth = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxSurname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxName = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnUpdate.Location = new System.Drawing.Point(12, 537);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(688, 55);
			this.btnUpdate.TabIndex = 34;
			this.btnUpdate.Text = "ACTUALIZAR";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dateBirth
			// 
			this.dateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateBirth.Location = new System.Drawing.Point(252, 259);
			this.dateBirth.Name = "dateBirth";
			this.dateBirth.Size = new System.Drawing.Size(448, 34);
			this.dateBirth.TabIndex = 32;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(256, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 25);
			this.label4.TabIndex = 31;
			this.label4.Text = "FECHA NACIMIENTO";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(256, 137);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 25);
			this.label2.TabIndex = 28;
			this.label2.Text = "APELLIDO";
			// 
			// tbxSurname
			// 
			this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxSurname.Location = new System.Drawing.Point(390, 131);
			this.tbxSurname.Multiline = true;
			this.tbxSurname.Name = "tbxSurname";
			this.tbxSurname.Size = new System.Drawing.Size(310, 38);
			this.tbxSurname.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(256, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 25);
			this.label1.TabIndex = 26;
			this.label1.Text = "NOMBRE";
			// 
			// tbxName
			// 
			this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxName.Location = new System.Drawing.Point(390, 74);
			this.tbxName.Multiline = true;
			this.tbxName.Name = "tbxName";
			this.tbxName.Size = new System.Drawing.Size(310, 38);
			this.tbxName.TabIndex = 25;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pelis_Media.Properties.Resources.logo1;
			this.pictureBox1.Location = new System.Drawing.Point(12, 33);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(222, 266);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 23;
			this.pictureBox1.TabStop = false;
			// 
			// Edit_Actor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 680);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.dateBirth);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbxSurname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxName);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Edit_Actor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Editar Actor";
			this.Load += new System.EventHandler(this.Edit_Actor_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.DateTimePicker dateBirth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxSurname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxName;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}