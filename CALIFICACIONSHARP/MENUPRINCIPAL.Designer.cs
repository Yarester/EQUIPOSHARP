/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 28/11/2025
 * Hora: 07:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CALIFICACIONSHARP
{
	partial class MENUPRINCIPAL
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MENUPRINCIPAL));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pROGRAMASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cALIFICACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nUMEROSALERATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dATOSDEALUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sALIRToolStripMenuItem,
									this.pROGRAMASToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 5, 0, 5);
			this.menuStrip1.Size = new System.Drawing.Size(805, 34);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sALIRToolStripMenuItem
			// 
			this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
			this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
			this.sALIRToolStripMenuItem.Text = "&SALIR";
			this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.SALIRToolStripMenuItemClick);
			// 
			// pROGRAMASToolStripMenuItem
			// 
			this.pROGRAMASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cALIFICACIONESToolStripMenuItem,
									this.nUMEROSALERATORIOSToolStripMenuItem,
									this.dATOSDEALUMNOSToolStripMenuItem});
			this.pROGRAMASToolStripMenuItem.Name = "pROGRAMASToolStripMenuItem";
			this.pROGRAMASToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
			this.pROGRAMASToolStripMenuItem.Text = "&PROGRAMAS";
			// 
			// cALIFICACIONESToolStripMenuItem
			// 
			this.cALIFICACIONESToolStripMenuItem.Name = "cALIFICACIONESToolStripMenuItem";
			this.cALIFICACIONESToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
			this.cALIFICACIONESToolStripMenuItem.Text = "CALIFICACIONES";
			// 
			// nUMEROSALERATORIOSToolStripMenuItem
			// 
			this.nUMEROSALERATORIOSToolStripMenuItem.Name = "nUMEROSALERATORIOSToolStripMenuItem";
			this.nUMEROSALERATORIOSToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
			this.nUMEROSALERATORIOSToolStripMenuItem.Text = "NUMEROS ALERATORIOS";
			// 
			// dATOSDEALUMNOSToolStripMenuItem
			// 
			this.dATOSDEALUMNOSToolStripMenuItem.Name = "dATOSDEALUMNOSToolStripMenuItem";
			this.dATOSDEALUMNOSToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
			this.dATOSDEALUMNOSToolStripMenuItem.Text = "DATOS DE ALUMNOS";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(6, 78);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(307, 290);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(362, 185);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(518, 95);
			this.label1.TabIndex = 2;
			this.label1.Text = "BIENVENIDO ";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Location = new System.Drawing.Point(0, 378);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(811, 10);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Maroon;
			this.panel2.Location = new System.Drawing.Point(0, 60);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(811, 19);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Maroon;
			this.panel3.Location = new System.Drawing.Point(0, 394);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(811, 10);
			this.panel3.TabIndex = 4;
			// 
			// MENUPRINCIPAL
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SeaShell;
			this.ClientSize = new System.Drawing.Size(805, 422);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "MENUPRINCIPAL";
			this.Text = "MENUPRINCIPAL";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem dATOSDEALUMNOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nUMEROSALERATORIOSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cALIFICACIONESToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pROGRAMASToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
	}
}
