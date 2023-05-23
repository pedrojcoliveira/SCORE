﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCORE.Data;

#nullable disable

namespace SCORE.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230516091643_List_Alunos")]
    partial class List_Alunos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("SCORE.Models.Aluno", b =>
                {
                    b.Property<int>("NmecanograficoAluno")
                        .HasColumnType("int")
                        .HasColumnName("NMecanograficoAluno");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TurmaIdTurma")
                        .HasColumnType("int");

                    b.HasKey("NmecanograficoAluno")
                        .HasName("PK__Aluno__7C8A234AEFB222B4");

                    b.HasIndex("TurmaIdTurma");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("SCORE.Models.AlunoCampeonato", b =>
                {
                    b.Property<int>("IdAlunoCampeonato")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Aluno_Campeonato");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlunoCampeonato"));

                    b.Property<int>("Creditos")
                        .HasColumnType("int");

                    b.Property<int>("IdCampeonato")
                        .HasColumnType("int")
                        .HasColumnName("Id_campeonato");

                    b.Property<int>("NmecanograficoAluno")
                        .HasColumnType("int")
                        .HasColumnName("NMecanograficoAluno");

                    b.Property<int>("NumEntradas")
                        .HasColumnType("int")
                        .HasColumnName("Num_Entradas");

                    b.Property<int>("NumSubmissoes")
                        .HasColumnType("int")
                        .HasColumnName("Num_Submissoes");

                    b.Property<int>("TempoMin")
                        .HasColumnType("int")
                        .HasColumnName("Tempo_Min");

                    b.HasKey("IdAlunoCampeonato")
                        .HasName("PK__Aluno_Ca__83E4D97D2B0DD820");

                    b.HasIndex("IdCampeonato");

                    b.HasIndex("NmecanograficoAluno");

                    b.ToTable("Aluno_Campeonato");
                });

            modelBuilder.Entity("SCORE.Models.AlunoEquipa", b =>
                {
                    b.Property<int>("IdAlunoEquipa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Aluno_Equipa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAlunoEquipa"));

                    b.Property<int>("IdEquipa")
                        .HasColumnType("int")
                        .HasColumnName("Id_Equipa");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma");

                    b.Property<int>("NmecanograficoAluno")
                        .HasColumnType("int")
                        .HasColumnName("NMecanograficoAluno");

                    b.HasKey("IdAlunoEquipa")
                        .HasName("PK__Aluno_Eq__9B02E1C300D9DD40");

                    b.HasIndex("IdEquipa");

                    b.HasIndex("NmecanograficoAluno");

                    b.ToTable("Aluno_Equipa");
                });

            modelBuilder.Entity("SCORE.Models.Campeonato", b =>
                {
                    b.Property<int>("IdCampeonato")
                        .HasColumnType("int")
                        .HasColumnName("Id_Campeonato");

                    b.Property<int>("IdTurma")
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma");

                    b.Property<int>("IdUC")
                        .HasColumnType("int")
                        .HasColumnName("Id_UC");

                    b.Property<bool>("Terminado")
                        .HasColumnType("bit");

                    b.HasKey("IdCampeonato")
                        .HasName("PK__Campeona__A8849C34EDC06937");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUC");

                    b.ToTable("Campeonato");
                });

            modelBuilder.Entity("SCORE.Models.CampeonatoEquipa", b =>
                {
                    b.Property<int>("IdCampeonatoEquipa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Campeonato_Equipa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCampeonatoEquipa"));

                    b.Property<int>("IdCampeonato")
                        .HasColumnType("int")
                        .HasColumnName("Id_Campeonato");

                    b.Property<int>("IdEquipa")
                        .HasColumnType("int")
                        .HasColumnName("Id_Equipa");

                    b.Property<int>("Pontuacao")
                        .HasColumnType("int");

                    b.Property<int>("Posicao")
                        .HasColumnType("int");

                    b.HasKey("IdCampeonatoEquipa")
                        .HasName("PK__Campeona__20443250C98E5302");

                    b.HasIndex("IdCampeonato");

                    b.HasIndex("IdEquipa");

                    b.ToTable("Campeonato_Equipa");
                });

            modelBuilder.Entity("SCORE.Models.CampeonatoJogo", b =>
                {
                    b.Property<int>("IdCampeonatoJogo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Campeonato_Jogo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCampeonatoJogo"));

                    b.Property<int>("IdCampeonato")
                        .HasColumnType("int")
                        .HasColumnName("Id_Campeonato");

                    b.Property<int>("IdJogo")
                        .HasColumnType("int")
                        .HasColumnName("Id_Jogo");

                    b.HasKey("IdCampeonatoJogo")
                        .HasName("PK__Campeona__870298C0FC284ADB");

                    b.HasIndex("IdCampeonato");

                    b.HasIndex("IdJogo");

                    b.ToTable("Campeonato_Jogo");
                });

            modelBuilder.Entity("SCORE.Models.Docente", b =>
                {
                    b.Property<int>("NmecanograficoDocente")
                        .HasColumnType("int")
                        .HasColumnName("NMecanograficoDocente");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NmecanograficoDocente")
                        .HasName("PK__Docente__BAA1BFEF0BE3947F");

                    b.ToTable("Docente");
                });

            modelBuilder.Entity("SCORE.Models.DocenteUc", b =>
                {
                    b.Property<int>("IdDocenteUc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Docente_UC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDocenteUc"));

                    b.Property<int>("IdUc")
                        .HasColumnType("int")
                        .HasColumnName("id_UC");

                    b.Property<int>("NmecanograficoDocente")
                        .HasColumnType("int")
                        .HasColumnName("NMecanograficoDocente");

                    b.HasKey("IdDocenteUc")
                        .HasName("PK__Docente___2E47949A93F1E34E");

                    b.HasIndex("IdUc");

                    b.HasIndex("NmecanograficoDocente");

                    b.ToTable("Docente_UC");
                });

            modelBuilder.Entity("SCORE.Models.Equipa", b =>
                {
                    b.Property<int>("IdEquipa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Equipa");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipa"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OverallRating")
                        .HasColumnType("int")
                        .HasColumnName("Overall_Rating");

                    b.HasKey("IdEquipa")
                        .HasName("PK__Equipa__4B9119CE57613823");

                    b.ToTable("Equipa");
                });

            modelBuilder.Entity("SCORE.Models.EquipaJogador", b =>
                {
                    b.Property<int>("IdEquipaJogador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Equipa_Jogador");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipaJogador"));

                    b.Property<int>("IdEquipa")
                        .HasColumnType("int")
                        .HasColumnName("Id_Equipa");

                    b.Property<int>("IdJogador")
                        .HasColumnType("int")
                        .HasColumnName("Id_Jogador");

                    b.HasKey("IdEquipaJogador")
                        .HasName("PK__Equipa_J__65683B32B2C79ABC");

                    b.HasIndex("IdEquipa");

                    b.HasIndex("IdJogador");

                    b.ToTable("Equipa_Jogador");
                });

            modelBuilder.Entity("SCORE.Models.Exercicio", b =>
                {
                    b.Property<int>("IdExercicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Exercicio");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExercicio"));

                    b.Property<DateTime?>("DataEntrega")
                        .HasColumnType("datetime");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Nota")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdExercicio")
                        .HasName("PK__Exercici__8BAE3646C5C2B738");

                    b.ToTable("Exercicio");
                });

            modelBuilder.Entity("SCORE.Models.ExercicioUc", b =>
                {
                    b.Property<int>("IdExercicioUc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Exercicio_UC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExercicioUc"));

                    b.Property<int>("IdExercicio")
                        .HasColumnType("int")
                        .HasColumnName("Id_Exercicio");

                    b.Property<int>("IdUc")
                        .HasColumnType("int")
                        .HasColumnName("Id_UC");

                    b.HasKey("IdExercicioUc")
                        .HasName("PK__Exercici__D473139A0A7D01D9");

                    b.HasIndex("IdExercicio");

                    b.HasIndex("IdUc");

                    b.ToTable("Exercicio_UC");
                });

            modelBuilder.Entity("SCORE.Models.Jogador", b =>
                {
                    b.Property<int>("IdJogador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Jogador");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJogador"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("IdJogador")
                        .HasName("PK__Jogador__5720AAD9471CC4B6");

                    b.ToTable("Jogador");
                });

            modelBuilder.Entity("SCORE.Models.Jogo", b =>
                {
                    b.Property<int>("IdJogo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Jogo");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdJogo"));

                    b.Property<DateTime?>("DataJogo")
                        .HasColumnType("datetime");

                    b.HasKey("IdJogo")
                        .HasName("PK__Jogo__FECD839810E75792");

                    b.ToTable("Jogo");
                });

            modelBuilder.Entity("SCORE.Models.Turma", b =>
                {
                    b.Property<int>("IdTurma")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTurma"));

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("IdTurma")
                        .HasName("PK__Turma__5CF918CE321987AE");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("SCORE.Models.TurmaAluno", b =>
                {
                    b.Property<int>("IdTurmaAluno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma_Aluno");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTurmaAluno"));

                    b.Property<int>("IdTurma")
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma");

                    b.Property<int>("NmecanograficoAluno")
                        .HasColumnType("int")
                        .HasColumnName("NMecanograficoAluno");

                    b.HasKey("IdTurmaAluno")
                        .HasName("PK__Turma_Al__AAF950D028AD7F30");

                    b.HasIndex("IdTurma");

                    b.HasIndex("NmecanograficoAluno");

                    b.ToTable("Turma_Aluno");
                });

            modelBuilder.Entity("SCORE.Models.TurmaUc", b =>
                {
                    b.Property<int>("IdTurmaUc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma_UC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTurmaUc"));

                    b.Property<int>("IdTurma")
                        .HasColumnType("int")
                        .HasColumnName("Id_Turma");

                    b.Property<int>("IdUc")
                        .HasColumnType("int")
                        .HasColumnName("Id_UC");

                    b.Property<int?>("TurmaIdTurma")
                        .HasColumnType("int");

                    b.Property<int?>("UcIdUc")
                        .HasColumnType("int");

                    b.HasKey("IdTurmaUc")
                        .HasName("PK__Turma_UC__CA3EC711F7FA34F5");

                    b.HasIndex("IdTurma");

                    b.HasIndex("IdUc");

                    b.HasIndex("TurmaIdTurma");

                    b.HasIndex("UcIdUc");

                    b.ToTable("Turma_UC");
                });

            modelBuilder.Entity("SCORE.Models.Uc", b =>
                {
                    b.Property<int>("IdUc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id_UC");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUc"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUc")
                        .HasName("PK__UC__16EC21A836FAADA2");

                    b.ToTable("UC");
                });

            modelBuilder.Entity("SCORE.Models.Aluno", b =>
                {
                    b.HasOne("SCORE.Models.Turma", null)
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaIdTurma");
                });

            modelBuilder.Entity("SCORE.Models.AlunoCampeonato", b =>
                {
                    b.HasOne("SCORE.Models.Campeonato", "IdCampeonatoNavigation")
                        .WithMany("AlunoCampeonatos")
                        .HasForeignKey("IdCampeonato")
                        .IsRequired()
                        .HasConstraintName("FK__Aluno_Cam__Id_ca__46E78A0C");

                    b.HasOne("SCORE.Models.Aluno", "NmecanograficoAlunoNavigation")
                        .WithMany("AlunoCampeonatos")
                        .HasForeignKey("NmecanograficoAluno")
                        .IsRequired()
                        .HasConstraintName("FK__Aluno_Cam__NMeca__45F365D3");

                    b.Navigation("IdCampeonatoNavigation");

                    b.Navigation("NmecanograficoAlunoNavigation");
                });

            modelBuilder.Entity("SCORE.Models.AlunoEquipa", b =>
                {
                    b.HasOne("SCORE.Models.Equipa", "IdEquipaNavigation")
                        .WithMany("AlunoEquipas")
                        .HasForeignKey("IdEquipa")
                        .IsRequired()
                        .HasConstraintName("FK__Aluno_Equ__Id_Eq__4E88ABD4");

                    b.HasOne("SCORE.Models.Aluno", "NmecanograficoAlunoNavigation")
                        .WithMany("AlunoEquipas")
                        .HasForeignKey("NmecanograficoAluno")
                        .IsRequired()
                        .HasConstraintName("FK__Aluno_Equ__NMeca__4D94879B");

                    b.Navigation("IdEquipaNavigation");

                    b.Navigation("NmecanograficoAlunoNavigation");
                });

            modelBuilder.Entity("SCORE.Models.Campeonato", b =>
                {
                    b.HasOne("SCORE.Models.Turma", "IdTurmaNavigation")
                        .WithMany("Campeonatos")
                        .HasForeignKey("IdTurma")
                        .IsRequired()
                        .HasConstraintName("FK__Campeonat__Id_Tu__33D4B598");

                    b.HasOne("SCORE.Models.Uc", "IdUcNavigation")
                        .WithMany("Campeonatos")
                        .HasForeignKey("IdUC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdTurmaNavigation");

                    b.Navigation("IdUcNavigation");
                });

            modelBuilder.Entity("SCORE.Models.CampeonatoEquipa", b =>
                {
                    b.HasOne("SCORE.Models.Campeonato", "IdCampeonatoNavigation")
                        .WithMany("CampeonatoEquipas")
                        .HasForeignKey("IdCampeonato")
                        .IsRequired()
                        .HasConstraintName("FK__Campeonat__Id_Ca__3B75D760");

                    b.HasOne("SCORE.Models.Equipa", "IdEquipaNavigation")
                        .WithMany("CampeonatoEquipas")
                        .HasForeignKey("IdEquipa")
                        .IsRequired()
                        .HasConstraintName("FK__Campeonat__Id_Eq__3A81B327");

                    b.Navigation("IdCampeonatoNavigation");

                    b.Navigation("IdEquipaNavigation");
                });

            modelBuilder.Entity("SCORE.Models.CampeonatoJogo", b =>
                {
                    b.HasOne("SCORE.Models.Campeonato", "IdCampeonatoNavigation")
                        .WithMany("CampeonatoJogos")
                        .HasForeignKey("IdCampeonato")
                        .IsRequired()
                        .HasConstraintName("FK__Campeonat__Id_Ca__5535A963");

                    b.HasOne("SCORE.Models.Jogo", "IdJogoNavigation")
                        .WithMany("CampeonatoJogos")
                        .HasForeignKey("IdJogo")
                        .IsRequired()
                        .HasConstraintName("FK__Campeonat__Id_Jo__5629CD9C");

                    b.Navigation("IdCampeonatoNavigation");

                    b.Navigation("IdJogoNavigation");
                });

            modelBuilder.Entity("SCORE.Models.DocenteUc", b =>
                {
                    b.HasOne("SCORE.Models.Uc", "IdUcNavigation")
                        .WithMany("DocenteUcs")
                        .HasForeignKey("IdUc")
                        .IsRequired()
                        .HasConstraintName("FK__Docente_U__id_UC__3F466844");

                    b.HasOne("SCORE.Models.Docente", "NmecanograficoDocenteNavigation")
                        .WithMany("DocenteUcs")
                        .HasForeignKey("NmecanograficoDocente")
                        .IsRequired()
                        .HasConstraintName("FK__Docente_U__NMeca__3E52440B");

                    b.Navigation("IdUcNavigation");

                    b.Navigation("NmecanograficoDocenteNavigation");
                });

            modelBuilder.Entity("SCORE.Models.EquipaJogador", b =>
                {
                    b.HasOne("SCORE.Models.Equipa", "IdEquipaNavigation")
                        .WithMany("EquipaJogadors")
                        .HasForeignKey("IdEquipa")
                        .IsRequired()
                        .HasConstraintName("FK__Equipa_Jo__Id_Eq__49C3F6B7");

                    b.HasOne("SCORE.Models.Jogador", "IdJogadorNavigation")
                        .WithMany("EquipaJogadors")
                        .HasForeignKey("IdJogador")
                        .IsRequired()
                        .HasConstraintName("FK__Equipa_Jo__Id_Jo__4AB81AF0");

                    b.Navigation("IdEquipaNavigation");

                    b.Navigation("IdJogadorNavigation");
                });

            modelBuilder.Entity("SCORE.Models.ExercicioUc", b =>
                {
                    b.HasOne("SCORE.Models.Exercicio", "IdExercicioNavigation")
                        .WithMany("ExercicioUcs")
                        .HasForeignKey("IdExercicio")
                        .IsRequired()
                        .HasConstraintName("FK__Exercicio__Id_Ex__4222D4EF");

                    b.HasOne("SCORE.Models.Uc", "IdUcNavigation")
                        .WithMany("ExercicioUcs")
                        .HasForeignKey("IdUc")
                        .IsRequired()
                        .HasConstraintName("FK__Exercicio__Id_UC__4316F928");

                    b.Navigation("IdExercicioNavigation");

                    b.Navigation("IdUcNavigation");
                });

            modelBuilder.Entity("SCORE.Models.TurmaAluno", b =>
                {
                    b.HasOne("SCORE.Models.Turma", "IdTurmaNavigation")
                        .WithMany("TurmaAlunos")
                        .HasForeignKey("IdTurma")
                        .IsRequired()
                        .HasConstraintName("FK__Turma_Alu__Id_Tu__5165187F");

                    b.HasOne("SCORE.Models.Aluno", "NmecanograficoAlunoNavigation")
                        .WithMany("TurmaAlunos")
                        .HasForeignKey("NmecanograficoAluno")
                        .IsRequired()
                        .HasConstraintName("FK__Turma_Alu__NMeca__52593CB8");

                    b.Navigation("IdTurmaNavigation");

                    b.Navigation("NmecanograficoAlunoNavigation");
                });

            modelBuilder.Entity("SCORE.Models.TurmaUc", b =>
                {
                    b.HasOne("SCORE.Models.Turma", "IdTurmaNavigation")
                        .WithMany("TurmaUcs")
                        .HasForeignKey("IdTurma")
                        .IsRequired()
                        .HasConstraintName("FK__Turma_UC__Id_Tur__36B12243");

                    b.HasOne("SCORE.Models.Uc", "IdUcNavigation")
                        .WithMany("TurmaUcs")
                        .HasForeignKey("IdUc")
                        .IsRequired()
                        .HasConstraintName("FK__Turma_UC__Id_UC__37A5467C");

                    b.HasOne("SCORE.Models.Turma", "Turma")
                        .WithMany()
                        .HasForeignKey("TurmaIdTurma");

                    b.HasOne("SCORE.Models.Uc", "Uc")
                        .WithMany()
                        .HasForeignKey("UcIdUc");

                    b.Navigation("IdTurmaNavigation");

                    b.Navigation("IdUcNavigation");

                    b.Navigation("Turma");

                    b.Navigation("Uc");
                });

            modelBuilder.Entity("SCORE.Models.Aluno", b =>
                {
                    b.Navigation("AlunoCampeonatos");

                    b.Navigation("AlunoEquipas");

                    b.Navigation("TurmaAlunos");
                });

            modelBuilder.Entity("SCORE.Models.Campeonato", b =>
                {
                    b.Navigation("AlunoCampeonatos");

                    b.Navigation("CampeonatoEquipas");

                    b.Navigation("CampeonatoJogos");
                });

            modelBuilder.Entity("SCORE.Models.Docente", b =>
                {
                    b.Navigation("DocenteUcs");
                });

            modelBuilder.Entity("SCORE.Models.Equipa", b =>
                {
                    b.Navigation("AlunoEquipas");

                    b.Navigation("CampeonatoEquipas");

                    b.Navigation("EquipaJogadors");
                });

            modelBuilder.Entity("SCORE.Models.Exercicio", b =>
                {
                    b.Navigation("ExercicioUcs");
                });

            modelBuilder.Entity("SCORE.Models.Jogador", b =>
                {
                    b.Navigation("EquipaJogadors");
                });

            modelBuilder.Entity("SCORE.Models.Jogo", b =>
                {
                    b.Navigation("CampeonatoJogos");
                });

            modelBuilder.Entity("SCORE.Models.Turma", b =>
                {
                    b.Navigation("Alunos");

                    b.Navigation("Campeonatos");

                    b.Navigation("TurmaAlunos");

                    b.Navigation("TurmaUcs");
                });

            modelBuilder.Entity("SCORE.Models.Uc", b =>
                {
                    b.Navigation("Campeonatos");

                    b.Navigation("DocenteUcs");

                    b.Navigation("ExercicioUcs");

                    b.Navigation("TurmaUcs");
                });
#pragma warning restore 612, 618
        }
    }
}
