using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBeauty.Dados.Migrations
{
    public partial class PrimeiroBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logradouro = table.Column<string>(type: "varchar(150)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(15)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(100)", nullable: true),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "date", nullable: false),
                    ContatosID = table.Column<int>(type: "int", nullable: false),
                    ClientesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegimeContratual",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegimeContratual", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoContato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoContato", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    PessoaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Pessoa_PessoaID",
                        column: x => x.PessoaID,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NomeSocial = table.Column<string>(type: "varchar(100)", nullable: true),
                    GeneroID = table.Column<int>(type: "int", nullable: false),
                    EnderecosID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colaborador_Endereco_EnderecosID",
                        column: x => x.EnderecosID,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Genero_GeneroID",
                        column: x => x.GeneroID,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colaborador_Pessoa_Id",
                        column: x => x.Id,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<string>(type: "varchar(50)", nullable: false),
                    TipoContatosID = table.Column<int>(type: "int", nullable: false),
                    PessoaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contato_Pessoa_PessoaID",
                        column: x => x.PessoaID,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contato_TipoContato_TipoContatosID",
                        column: x => x.TipoContatosID,
                        principalTable: "TipoContato",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrecoTotal = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DuracaoTotal = table.Column<int>(type: "int", nullable: false),
                    ClienteID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContratoTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataEntrada = table.Column<DateTime>(type: "date", nullable: false),
                    DataDesligamento = table.Column<DateTime>(type: "date", nullable: false),
                    CnpjCTPS = table.Column<string>(type: "varchar(14)", nullable: false),
                    RegimeContratualID = table.Column<int>(type: "int", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: true),
                    ContratoTrabalhoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContratoTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_ContratoTrabalho_ContratoTrabalhoId",
                        column: x => x.ContratoTrabalhoId,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContratoTrabalho_RegimeContratual_RegimeContratualID",
                        column: x => x.RegimeContratualID,
                        principalTable: "RegimeContratual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Escala",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataHoraEntrada = table.Column<DateTime>(type: "date", nullable: false),
                    DataHoraSaida = table.Column<DateTime>(type: "date", nullable: false),
                    ColadoradoresID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Escala", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Escala_Colaborador_ColadoradoresID",
                        column: x => x.ColadoradoresID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(50)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150)", nullable: false),
                    DuracaoEmMin = table.Column<int>(type: "int", nullable: false),
                    ColaboradorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servico_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cargo_ContratoTrabalho",
                columns: table => new
                {
                    CargoID = table.Column<int>(type: "int", nullable: false),
                    ContratoTrabalhoID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo_ContratoTrabalho", x => new { x.CargoID, x.ContratoTrabalhoID });
                    table.ForeignKey(
                        name: "FK_Cargo_ContratoTrabalho_Cargo_CargoID",
                        column: x => x.CargoID,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cargo_ContratoTrabalho_ContratoTrabalho_ContratoTrabalhoID",
                        column: x => x.ContratoTrabalhoID,
                        principalTable: "ContratoTrabalho",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicoID = table.Column<int>(type: "int", nullable: false),
                    ColaboradorID = table.Column<int>(type: "int", nullable: false),
                    PessoaAtendida = table.Column<string>(type: "varchar(30)", nullable: true),
                    DataHoraCriacao = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    OrdemServicoID = table.Column<int>(type: "int", nullable: false),
                    DataHoraInicio = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    DataHoraTermino = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    LogAgendamentosID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agendamento_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_OrdemServico_OrdemServicoID",
                        column: x => x.OrdemServicoID,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamento_Servico_ServicoID",
                        column: x => x.ServicoID,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicoColaborador",
                columns: table => new
                {
                    ColaboradorID = table.Column<int>(type: "int", nullable: false),
                    ServicoID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoColaborador", x => new { x.ServicoID, x.ColaboradorID });
                    table.ForeignKey(
                        name: "FK_ServicoColaborador_Colaborador_ColaboradorID",
                        column: x => x.ColaboradorID,
                        principalTable: "Colaborador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoColaborador_Servico_ServicoID",
                        column: x => x.ServicoID,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogAgendamento",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataCriacao = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdAgendamento = table.Column<int>(type: "int", nullable: false),
                    AgendamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAgendamento", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LogAgendamento_Agendamento_AgendamentoID",
                        column: x => x.AgendamentoID,
                        principalTable: "Agendamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ColaboradorID",
                table: "Agendamento",
                column: "ColaboradorID");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_OrdemServicoID",
                table: "Agendamento",
                column: "OrdemServicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamento_ServicoID",
                table: "Agendamento",
                column: "ServicoID");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_ContratoTrabalho_ContratoTrabalhoID",
                table: "Cargo_ContratoTrabalho",
                column: "ContratoTrabalhoID");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_PessoaID",
                table: "Cliente",
                column: "PessoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_EnderecosID",
                table: "Colaborador",
                column: "EnderecosID");

            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_GeneroID",
                table: "Colaborador",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_PessoaID",
                table: "Contato",
                column: "PessoaID");

            migrationBuilder.CreateIndex(
                name: "IX_Contato_TipoContatosID",
                table: "Contato",
                column: "TipoContatosID");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_ColaboradorId",
                table: "ContratoTrabalho",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_ContratoTrabalhoId",
                table: "ContratoTrabalho",
                column: "ContratoTrabalhoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContratoTrabalho_RegimeContratualID",
                table: "ContratoTrabalho",
                column: "RegimeContratualID");

            migrationBuilder.CreateIndex(
                name: "IX_Escala_ColadoradoresID",
                table: "Escala",
                column: "ColadoradoresID");

            migrationBuilder.CreateIndex(
                name: "IX_LogAgendamento_AgendamentoID",
                table: "LogAgendamento",
                column: "AgendamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_ClienteID",
                table: "OrdemServico",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_ColaboradorId",
                table: "Servico",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoColaborador_ColaboradorID",
                table: "ServicoColaborador",
                column: "ColaboradorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargo_ContratoTrabalho");

            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Escala");

            migrationBuilder.DropTable(
                name: "LogAgendamento");

            migrationBuilder.DropTable(
                name: "ServicoColaborador");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "ContratoTrabalho");

            migrationBuilder.DropTable(
                name: "TipoContato");

            migrationBuilder.DropTable(
                name: "Agendamento");

            migrationBuilder.DropTable(
                name: "RegimeContratual");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
