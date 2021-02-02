namespace Pelis_Media.Views.Movies
{
	partial class Detail_Movie
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_Movie));
			this.lbtitle = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbxdescription = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dataGactors = new System.Windows.Forms.DataGridView();
			this.lbyear = new System.Windows.Forms.Label();
			this.lbqualification = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbgenre = new System.Windows.Forms.Label();
			this.btnEdit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGactors)).BeginInit();
			this.SuspendLayout();
			// 
			// lbtitle
			// 
			this.lbtitle.AutoSize = true;
			this.lbtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbtitle.Location = new System.Drawing.Point(344, 59);
			this.lbtitle.Name = "lbtitle";
			this.lbtitle.Size = new System.Drawing.Size(145, 32);
			this.lbtitle.TabIndex = 1;
			this.lbtitle.Text = "John Wick";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(346, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Año:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(346, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(101, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Calificación:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(346, 244);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Argumento:";
			// 
			// tbxdescription
			// 
			this.tbxdescription.BackColor = System.Drawing.SystemColors.Control;
			this.tbxdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbxdescription.Enabled = false;
			this.tbxdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxdescription.Location = new System.Drawing.Point(447, 244);
			this.tbxdescription.Multiline = true;
			this.tbxdescription.Name = "tbxdescription";
			this.tbxdescription.Size = new System.Drawing.Size(637, 201);
			this.tbxdescription.TabIndex = 6;
			this.tbxdescription.Text = resources.GetString("tbxdescription.Text");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pelis_Media.Properties.Resources.logo1;
			this.pictureBox1.Location = new System.Drawing.Point(33, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(289, 395);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 450);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Reparto";
			// 
			// dataGactors
			// 
			this.dataGactors.AllowUserToAddRows = false;
			this.dataGactors.AllowUserToDeleteRows = false;
			this.dataGactors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGactors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGactors.Location = new System.Drawing.Point(33, 494);
			this.dataGactors.Name = "dataGactors";
			this.dataGactors.ReadOnly = true;
			this.dataGactors.RowHeadersWidth = 51;
			this.dataGactors.RowTemplate.Height = 24;
			this.dataGactors.Size = new System.Drawing.Size(1212, 217);
			this.dataGactors.TabIndex = 8;
			// 
			// lbyear
			// 
			this.lbyear.AutoSize = true;
			this.lbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.lbyear.Location = new System.Drawing.Point(395, 120);
			this.lbyear.Name = "lbyear";
			this.lbyear.Size = new System.Drawing.Size(45, 20);
			this.lbyear.TabIndex = 9;
			this.lbyear.Text = "2000";
			// 
			// lbqualification
			// 
			this.lbqualification.AutoSize = true;
			this.lbqualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.lbqualification.Location = new System.Drawing.Point(453, 157);
			this.lbqualification.Name = "lbqualification";
			this.lbqualification.Size = new System.Drawing.Size(31, 20);
			this.lbqualification.TabIndex = 10;
			this.lbqualification.Text = "5.5";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(346, 195);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "Género:";
			// 
			// lbgenre
			// 
			this.lbgenre.AutoSize = true;
			this.lbgenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
			this.lbgenre.Location = new System.Drawing.Point(421, 195);
			this.lbgenre.Name = "lbgenre";
			this.lbgenre.Size = new System.Drawing.Size(58, 20);
			this.lbgenre.TabIndex = 12;
			this.lbgenre.Text = "accion";
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnEdit.Location = new System.Drawing.Point(811, 36);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(434, 55);
			this.btnEdit.TabIndex = 13;
			this.btnEdit.Text = "EDITAR PELICULA";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// Detail_Movie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1314, 755);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.lbgenre);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbqualification);
			this.Controls.Add(this.lbyear);
			this.Controls.Add(this.dataGactors);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbxdescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbtitle);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Detail_Movie";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Película Detalle";
			this.Load += new System.EventHandler(this.Detail_Movie_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGactors)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbtitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbxdescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGactors;
		private System.Windows.Forms.Label lbyear;
		private System.Windows.Forms.Label lbqualification;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbgenre;
		private System.Windows.Forms.Button btnEdit;
	}
}