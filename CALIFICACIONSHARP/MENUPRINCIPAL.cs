/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 28/11/2025
 * Hora: 07:16 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CALIFICACIONSHARP
{
	/// <summary>
	/// Description of MENUPRINCIPAL.
	/// </summary>
	public partial class MENUPRINCIPAL : Form
	{
		public MENUPRINCIPAL()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SALIRToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿DESEA SALIR?","Confirmar Salir",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
			Application.Exit();

			}
		}
	}
}
