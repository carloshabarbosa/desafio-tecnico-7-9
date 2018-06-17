using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioTecnico.Infraestructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Cnpj = table.Column<string>(maxLength: 20, nullable: false),
                    Address = table.Column<string>(maxLength: 70, nullable: false),
                    Phone = table.Column<string>(maxLength: 18, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 60, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobOpportunities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpportunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOpportunities_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyTecnologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CompanyId = table.Column<Guid>(nullable: true),
                    TecnologyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyTecnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyTecnologies_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyTecnologies_Tecnologies_TecnologyId",
                        column: x => x.TecnologyId,
                        principalTable: "Tecnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 70, nullable: false),
                    Cpf = table.Column<string>(maxLength: 15, nullable: false),
                    Address = table.Column<string>(maxLength: 70, nullable: false),
                    Phone = table.Column<string>(maxLength: 15, nullable: false),
                    JobOpportunityId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidates_JobOpportunities_JobOpportunityId",
                        column: x => x.JobOpportunityId,
                        principalTable: "JobOpportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JobOpportunityTecnologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    JobOpportunityId = table.Column<Guid>(nullable: true),
                    TecnologyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobOpportunityTecnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobOpportunityTecnologies_JobOpportunities_JobOpportunityId",
                        column: x => x.JobOpportunityId,
                        principalTable: "JobOpportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_JobOpportunityTecnologies_Tecnologies_TecnologyId",
                        column: x => x.TecnologyId,
                        principalTable: "Tecnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CandidateTecnologies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CandidateId = table.Column<Guid>(nullable: true),
                    TecnologyId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateTecnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateTecnologies_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CandidateTecnologies_Tecnologies_TecnologyId",
                        column: x => x.TecnologyId,
                        principalTable: "Tecnologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_JobOpportunityId",
                table: "Candidates",
                column: "JobOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateTecnologies_CandidateId",
                table: "CandidateTecnologies",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateTecnologies_TecnologyId",
                table: "CandidateTecnologies",
                column: "TecnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTecnologies_CompanyId",
                table: "CompanyTecnologies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyTecnologies_TecnologyId",
                table: "CompanyTecnologies",
                column: "TecnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpportunities_CompanyId",
                table: "JobOpportunities",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpportunityTecnologies_JobOpportunityId",
                table: "JobOpportunityTecnologies",
                column: "JobOpportunityId");

            migrationBuilder.CreateIndex(
                name: "IX_JobOpportunityTecnologies_TecnologyId",
                table: "JobOpportunityTecnologies",
                column: "TecnologyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateTecnologies");

            migrationBuilder.DropTable(
                name: "CompanyTecnologies");

            migrationBuilder.DropTable(
                name: "JobOpportunityTecnologies");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Tecnologies");

            migrationBuilder.DropTable(
                name: "JobOpportunities");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
