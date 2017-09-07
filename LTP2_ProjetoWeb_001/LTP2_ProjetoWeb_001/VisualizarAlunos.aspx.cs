using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LTP2_ProjetoWeb_001
{
    public partial class VisualizarAlunos : System.Web.UI.Page
    {
        public static int ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            ID = 0;
            preencher_dados();
        }

        private void preencher_dados()
        {
            conectAluno A = new conectAluno();
            A.configurarConexao();

            tabelaAlunos.DataSource = A.visualizarAlunos();
            tabelaAlunos.DataBind();
        }

        protected void tabelaAlunos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ID = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "editar")
            {
                Response.Redirect("Aluno.aspx");
            }
            if (e.CommandName == "excluir")
            {
                conectAluno A = new conectAluno();
                A.ID_Aluno = ID;
                A.configurarConexao();
                A.excluirItem();


                Response.Redirect("VisualizarAlunos.aspx");
            }
        }
    }
}