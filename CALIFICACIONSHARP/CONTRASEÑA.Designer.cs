/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 28/11/2025
 * Hora: 06:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CALIFICACIONSHARP
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtuser = new System.Windows.Forms.TextBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(215, 186);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(218, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuario:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(218, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contraseña:";
			// 
			// txtuser
			// 
			this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtuser.Location = new System.Drawing.Point(218, 34);
			this.txtuser.Name = "txtuser";
			this.txtuser.Size = new System.Drawing.Size(336, 20);
			this.txtuser.TabIndex = 3;
			this.txtuser.Enter += new System.EventHandler(this.TxtuserEnter);
			this.txtuser.Leave += new System.EventHandler(this.TxtuserLeave);
			// 
			// txtpass
			// 
			this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtpass.Location = new System.Drawing.Point(218, 93);
			this.txtpass.Name = "txtpass";
			this.txtpass.Size = new System.Drawing.Size(336, 20);
			this.txtpass.TabIndex = 4;
			this.txtpass.Enter += new System.EventHandler(this.TxtpassEnter);
			this.txtpass.Leave += new System.EventHandler(this.TxtpassLeave);
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
			this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
			this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnCerrar.Location = new System.Drawing.Point(572, 0);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(39, 31);
			this.btnCerrar.TabIndex = 5;
			this.btnCerrar.UseVisualStyleBackColor = true;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// btnAceptar
			// 
			this.btnAceptar.BackColor = System.Drawing.Color.YellowGreen;
			this.btnAceptar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAceptar.Location = new System.Drawing.Point(328, 134);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(168, 38);
			this.btnAceptar.TabIndex = 6;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = false;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(609, 184);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnCerrar);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.txtuser);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "CALIFICACIONSHARP";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtuser;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
