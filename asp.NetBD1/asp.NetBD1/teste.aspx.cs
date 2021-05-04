using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.NetBD1
{
    public partial class teste : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                //em caso de erro ele vai para o catch e não trava a aplicação
                cmd.Connection = conexao.Connection;
                conexao.Conectar();
                lblResultado.CssClass = "text text-success";
                lblResultado.Text = "Conectado com Sucesso!";
            }
            catch (Exception ex)
            {
                //vita o travamento
                lblResultado.CssClass = "text text-danger";
                lblResultado.Text = $"Atenção: {ex.Message}";
            }
            finally
            {
                //não obrigatório, havendo o finally independente do try e catch ele vem para o finally
                conexao.Desconectar();
            }
        }
    }
}