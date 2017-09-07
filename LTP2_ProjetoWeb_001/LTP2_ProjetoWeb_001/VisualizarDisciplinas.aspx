<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarDisciplinas.aspx.cs" Inherits="LTP2_ProjetoWeb_001.VisualizarDisciplinas" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizar Disciplinas</title>
        <meta name="viewport" content="width=device-width, initial-scale=1"/>
        <link rel="stylesheet" href="Content/bootstrap.min.css"/>
        <script src="Scripts/jquery-1.9.1.min.js"></script>
        <script src="Scripts/bootstrap.min.js"></script>
</head>
<body>
    <!-- Navbar -->
    <nav class="navbar navbar-inverse">
        <div class="container-fluid">
            <!-- Header -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand active" href="#">Visualizar Disciplinas</a>
            </div>
            <!-- Navbar links -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li><a href="index.html">Home</a></li>
                    <li><a href="Aluno.aspx">Cadastrar Alunos</a></li>
                    <li><a href="VisualizarAlunos.aspx">Visualizar Alunos</a></li>
                    <li><a href="Disciplina.aspx">Cadastrar Disciplinas</a></li>
                    <li><a href="VisualizarDisciplinas.aspx">Visualizar Disciplinas</a></li>
                    <li><a href="Curso.aspx">Cadastrar Cursos</a></li>
                    <li><a href="VisualizarCursos.aspx">Visualizar Cursos</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- Tabela Dados -->
    <form id="form1" runat="server">
        <div>
            <h3 class="text-center">Disciplinas</h3>
            <br />
            <asp:GridView CssClass="table table-bordered table-responsive" ID="tabelaDisciplina" runat="server" AutoGenerateColumns="false" OnRowCommand="tabelaDisciplina_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <asp:LinkButton ID="Editar" runat="server" CommandName="editar" CommandArgument='<%# Eval("ID_Disciplina") %>' ToolTip="Editar Usuário">
                            Editar
                            </asp:LinkButton>
                            &nbsp
                            <asp:LinkButton ID="Excluir" runat="server" CommandName="excluir" CommandArgument='<%# Eval("ID_Disciplina") %>' ToolTip="Editar Usuário">
                            Excluir
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Codigo" DataField="Codigo_Disciplina" />
                    <asp:BoundField HeaderText="Nome" DataField="Nome_Disciplina" />
                    <asp:BoundField HeaderText="Ementa" DataField="Ementa_Disciplina" />
                    <asp:BoundField HeaderText="Semestre" DataField="Semestre_Disciplina" />
                    <asp:BoundField HeaderText="Carga Horária" DataField="CargaHoraria_Disciplina" />
                </Columns>
            </asp:GridView>
            <a type="button" href="Disciplina.aspx" target="_self" class="btn btn-success btn-lg center-block" role="button">Cadastrar nova Disciplina</a>
        </div>
    </form>
</body>
</html>
