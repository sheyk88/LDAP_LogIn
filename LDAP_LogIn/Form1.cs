using System;
using System.DirectoryServices;
using System.Drawing;
using System.Windows.Forms;

namespace LDAP_LogIn
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"LDAP://Nombre_del_servidor";       //CAMBIAR POR VUESTRO PATH (URL DEL SERVICIO DE DIRECTORIO LDAP)
                                                               //Por ejemplo: 'LDAP://ejemplo.lan.es'
            string dominio = @"Nombre_del_dominio";             //CAMBIAR POR VUESTRO DOMINIO
            string usu = txtb_user.Text.Trim();                 //USUARIO DEL DOMINIO
            string pass = txtb_pass.Text.Trim();                //PASSWORD DEL USUARIO
            string domUsu = dominio + @"\" + usu;               //CADENA DE DOMINIO + USUARIO A COMPROBAR

            bool permiso = AutenticaUsuario(path, domUsu, pass);

            if (permiso)
            {
                lbl_check.BackColor = Color.Green;
            }
            else
            {
                lbl_check.BackColor = Color.Red;
            }


        }

        private bool AutenticaUsuario(string path, string domUsu, string pass)
        {
            //Los datos que hemos pasado los 'convertimos' en una entrada de Active Directory para hacer la consulta
            DirectoryEntry de = new DirectoryEntry(path, domUsu, pass, AuthenticationTypes.Secure);
            try
            {
                //Inicia el chequeo con las credenciales que le hemos pasado
                //Si devuelve algo significa que ha autenticado las credenciales
                DirectorySearcher ds = new DirectorySearcher(de);
                ds.FindOne();
                return true;
            }
            catch
            {
                //Si no devuelve nada es que no ha podido autenticar las credenciales
                //ya sea porque no existe el usuario o por que no son correctas
                return false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtb_user_TextChanged(object sender, EventArgs e)
        {
            if (txtb_user.Text == "Username")
            {
                txtb_user.Text = "";

                txtb_user.ForeColor = Color.Black;
            }
        }

        private void txtb_pass_TextChanged(object sender, EventArgs e)
        {
            if (txtb_pass.Text == "Password")
            {
                txtb_pass.Text = "";

                txtb_pass.ForeColor = Color.Black;
            }
        }

        private void lbl_check_Click(object sender, EventArgs e)
        {

        }
    }
}
