<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VisualizarCursos.aspx.cs" Inherits="LTP2_ProjetoWeb_001.VisualizarCursos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizar Cursos</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
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
                <a class="navbar-brand active" href="#">Visualizar Cursos</a>
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
            <h3 class="text-center">Cursos</h3>
            <br />
            <asp:GridView CssClass="table table-bordered table-responsive" ID="tabelaCursos" runat="server" AutoGenerateColumns="false" OnRowCommand="tabelaCursos_RowCommand">
                <Columns>
                    <asp:TemplateField HeaderText="Ações">
                        <ItemTemplate>
                            <asp:LinkButton ID="Editar" runat="server" CommandName="editar" CommandArgument='<%# Eval("ID_Curso") %>' ToolTip="Editar Usuário">
                            Editar
                            </asp:LinkButton>
                            &nbsp
                           
                            <asp:LinkButton ID="Excluir" runat="server" CommandName="excluir" CommandArgument='<%# Eval("ID_Curso") %>' ToolTip="Editar Usuário">
                            Excluir
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="Código" DataField="Codigo_Curso" />
                    <asp:BoundField HeaderText="Curso" DataField="Nome_Curso" />
                    <asp:BoundField HeaderText="Período" DataField="Periodo_Curso" />
                    <asp:BoundField HeaderText="Duração" DataField="Duracao_Curso" />
                    <asp:BoundField HeaderText="Enade" DataField="Enade_Curso" />
                </Columns>
            </asp:GridView>
        <a type="button" href="Curso.aspx" target="_self" class="btn btn-success btn-lg center-block" role="button">Cadastrar novo Curso</a>
        </div>
    </form>
</body>
</html>
