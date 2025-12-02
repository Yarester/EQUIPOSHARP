/*
 * Creado por SharpDevelop.
 * Usuario: juant
 * Fecha: 28/11/2025
 * Hora: 06:48 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CALIFICACIONSHARP
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TxtuserEnter(object sender, EventArgs e)
		{
			if( txtuser.Text == "USUARIO" )
			{
				txtuser.Text = "";
				txtuser.ForeColor=Color.Black;
			}
		}
		
		void TxtuserLeave(object sender, EventArgs e)
		{
			if( txtuser.Text == "" )
			{
				txtuser.Text = "USUARIO";
				txtuser.ForeColor=Color.Black;
			}
		}
		
		void TxtpassEnter(object sender, EventArgs e)
		{
			if( txtpass.Text == "CONTRASEÑA" )
			{
				txtpass.Text = "";
				txtpass.ForeColor=Color.Black;
				txtpass.UseSystemPasswordChar=true;
			}
		}
		
		void TxtpassLeave(object sender, EventArgs e)
		{
			if( txtpass.Text == "" )
			{
				txtpass.Text = "CONTRASEÑA";
				txtpass.ForeColor=Color.Black;
				txtpass.UseSystemPasswordChar=true;
			}
		}
		
		void BtnCerrarClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void BtnAceptarClick(object sender, EventArgs e)
		{
			if(txtpass.Text=="12345" && txtuser.Text=="Admin")
			{
				MENUPRINCIPAL f = new MENUPRINCIPAL();
				f.Show();
				this.Hide();
			}
		}
	}
}
