using Ej1.accesoAdatos;
using Ej1.Entidades;
using System.Data;

namespace Ej1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("Ingrese usuario y contraseña");
            }
            else
            {
                string nombreDeUsu = txtUsuario.Text;
                string pass = txtPass.Text;
                bool resultado = false;
                try
                {
                   
                    resultado = UsuarioDAO.ValidarUsuario(nombreDeUsu, pass);

                    if (resultado ==true)
                    {
                        //Usuario usu = new Usuario(nombreDeUsu, pass);
                        Principal ventana = new Principal();
                        MessageBox.Show("Ingresaste al sistema");
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario inexistente");
                    }

                    
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error al consultar"+ex.Message);
                }

                
                
            }
            
        }
    }
}
