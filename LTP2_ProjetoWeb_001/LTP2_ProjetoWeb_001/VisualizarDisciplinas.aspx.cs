using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTP2_ProjetoWeb_001
{
    public partial class VisualizarDisciplinas : System.Web.UI.Page
    {
        public static int ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = 0;
            preencher_dados();
        }

        private void preencher_dados()
        {
            conectDisciplina D = new conectDisciplina();
            D.configurarConexao();

            tabelaDisciplina.DataSource = D.visualizarDisciplinas();
            tabelaDisciplina.DataBind();
        }

        protected void tabelaDisciplina_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ID = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "editar")
            {
                Response.Redirect("Disciplina.aspx");
            }
            if (e.CommandName == "excluir")
            {
                conectDisciplina D = new conectDisciplina();
                D.ID_Disciplina = ID;
                D.configurarConexao();
                D.excluirItem();


                Response.Redirect("VisualizarDisciplinas.aspx");
            }
        }
    }
}