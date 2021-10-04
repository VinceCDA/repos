using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EnqueteAFPANA_API.Models
{
    public partial class EnquetesContext : DbContext
    {
        public EnquetesContext()
        {
        }

        public EnquetesContext(DbContextOptions<EnquetesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppellationRome> AppellationRomes { get; set; }
        public virtual DbSet<Beneficiaire> Beneficiaires { get; set; }
        public virtual DbSet<BeneficiaireOffreFormation> BeneficiaireOffreFormations { get; set; }
        public virtual DbSet<DomaineMetierRome> DomaineMetierRomes { get; set; }
        public virtual DbSet<DureeContrat> DureeContrats { get; set; }
        public virtual DbSet<Etablissement> Etablissements { get; set; }
        public virtual DbSet<ExercerFonction> ExercerFonctions { get; set; }
        public virtual DbSet<ExtraitCodeRomeM1805> ExtraitCodeRomeM1805s { get; set; }
        public virtual DbSet<FamilleMetierRome> FamilleMetierRomes { get; set; }
        public virtual DbSet<OffreFormation> OffreFormations { get; set; }
        public virtual DbSet<ProduitFormation> ProduitFormations { get; set; }
        public virtual DbSet<ProduitFormationRome> ProduitFormationRomes { get; set; }
        public virtual DbSet<Questionnaire> Questionnaires { get; set; }
        public virtual DbSet<Rome> Romes { get; set; }
        public virtual DbSet<Soumissionnaire> Soumissionnaires { get; set; }
        public virtual DbSet<TitreCivilite> TitreCivilites { get; set; }
        public virtual DbSet<TypeContrat> TypeContrats { get; set; }
        public virtual DbSet<VueSoumissionnaire> VueSoumissionnaires { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Enquetes;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "French_CI_AS");

            modelBuilder.Entity<AppellationRome>(entity =>
            {
                entity.HasKey(e => e.CodeAppellationRome)
                    .HasName("PK_AppelationRome");

                entity.ToTable("AppellationRome");

                entity.Property(e => e.CodeAppellationRome).ValueGeneratedNever();

                entity.Property(e => e.CodeRome)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LibelleAppellationRome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeRomeNavigation)
                    .WithMany(p => p.AppellationRomes)
                    .HasForeignKey(d => d.CodeRome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppelationRome_CodeRome");
            });

            modelBuilder.Entity<Beneficiaire>(entity =>
            {
                entity.HasKey(e => e.MatriculeBeneficiaire);

                entity.ToTable("Beneficiaire");

                entity.Property(e => e.MatriculeBeneficiaire)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodePostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateNaissanceBeneficiaire).HasColumnType("date");

                entity.Property(e => e.IdPays2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ligne1Adresse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ligne2Adresse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ligne3Adresse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailBeneficiaire)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.NomBeneficiaire)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PathPhoto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomBeneficiaire)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelBeneficiaire)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(128)
                    .HasColumnName("UserID");

                entity.Property(e => e.Ville)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeTitreCiviliteNavigation)
                    .WithMany(p => p.Beneficiaires)
                    .HasForeignKey(d => d.CodeTitreCivilite)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaire_TitreCivilite");
            });

            modelBuilder.Entity<BeneficiaireOffreFormation>(entity =>
            {
                entity.HasKey(e => new { e.MatriculeBeneficiaire, e.IdOffreFormation, e.Idetablissement });

                entity.ToTable("Beneficiaire_OffreFormation");

                entity.Property(e => e.MatriculeBeneficiaire)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Idetablissement)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IDEtablissement")
                    .IsFixedLength(true);

                entity.Property(e => e.DateEntreeBeneficiaire).HasColumnType("date");

                entity.Property(e => e.DateSortieBeneficiaire).HasColumnType("date");

                entity.HasOne(d => d.MatriculeBeneficiaireNavigation)
                    .WithMany(p => p.BeneficiaireOffreFormations)
                    .HasForeignKey(d => d.MatriculeBeneficiaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaire_OffreFormation_Beneficiaire");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.BeneficiaireOffreFormations)
                    .HasForeignKey(d => new { d.IdOffreFormation, d.Idetablissement })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Beneficiaire_OffreFormation_OffreFormation");
            });

            modelBuilder.Entity<DomaineMetierRome>(entity =>
            {
                entity.HasKey(e => e.CodeDomaineRome);

                entity.ToTable("DomaineMetierRome");

                entity.Property(e => e.CodeDomaineRome)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodeFamilleRome)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntituleDomaineRome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeFamilleRomeNavigation)
                    .WithMany(p => p.DomaineMetierRomes)
                    .HasForeignKey(d => d.CodeFamilleRome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomaineMetierRome_FamilleMetierRome");
            });

            modelBuilder.Entity<DureeContrat>(entity =>
            {
                entity.HasKey(e => e.IdDureeContrat);

                entity.ToTable("DureeContrat");

                entity.Property(e => e.IdDureeContrat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LibelleDureeContrat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Etablissement>(entity =>
            {
                entity.HasKey(e => e.IdEtablissement);

                entity.ToTable("Etablissement");

                entity.Property(e => e.IdEtablissement)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodePostal)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IdEtablissementRattachement)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ligne1Adresse)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ligne2Adresse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ligne3Adresse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MailEtablissement)
                    .HasMaxLength(254)
                    .IsUnicode(false);

                entity.Property(e => e.NomEtablissement)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelEtablissement)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEtablissementRattachementNavigation)
                    .WithMany(p => p.InverseIdEtablissementRattachementNavigation)
                    .HasForeignKey(d => d.IdEtablissementRattachement)
                    .HasConstraintName("FK_Etablissement_Etablissement");
            });

            modelBuilder.Entity<ExercerFonction>(entity =>
            {
                entity.HasKey(e => e.IdExercerFonction)
                    .HasName("PK_Exercer Fonction");

                entity.ToTable("ExercerFonction");

                entity.Property(e => e.DateEntreeFonction).HasColumnType("date");

                entity.Property(e => e.DateReponse)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateSortieFonction).HasColumnType("date");

                entity.Property(e => e.DureeContrat)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IdtypeContrat).HasColumnName("IDTypeContrat");

                entity.HasOne(d => d.CodeAppellationRomeNavigation)
                    .WithMany(p => p.ExercerFonctions)
                    .HasForeignKey(d => d.CodeAppellationRome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExercerFonction_AppellationRome");

                entity.HasOne(d => d.DureeContratNavigation)
                    .WithMany(p => p.ExercerFonctions)
                    .HasForeignKey(d => d.DureeContrat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExercerFonction_DureeContrat");

                entity.HasOne(d => d.IdentifiantMailingNavigation)
                    .WithMany(p => p.ExercerFonctions)
                    .HasForeignKey(d => d.IdentifiantMailing)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExercerFonction_Soumissionnaires");

                entity.HasOne(d => d.IdtypeContratNavigation)
                    .WithMany(p => p.ExercerFonctions)
                    .HasForeignKey(d => d.IdtypeContrat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExercerFonction_TypeContrat");
            });

            modelBuilder.Entity<ExtraitCodeRomeM1805>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ExtraitCodeRomeM1805");

                entity.Property(e => e.CodeDomaineRome)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodeFamilleMetierRome)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodeRome)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntituleCodeRome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IntituleDomaineRome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IntituleFamilleMetierRome)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LibelleAppellationRome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FamilleMetierRome>(entity =>
            {
                entity.HasKey(e => e.CodeFamilleMetierRome);

                entity.ToTable("FamilleMetierRome");

                entity.Property(e => e.CodeFamilleMetierRome)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntituleFamilleMetierRome)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OffreFormation>(entity =>
            {
                entity.HasKey(e => new { e.IdOffreFormation, e.IdEtablissement });

                entity.ToTable("OffreFormation");

                entity.Property(e => e.IdEtablissement)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DateDebutOffreFormation).HasColumnType("date");

                entity.Property(e => e.DateFinOffreFormation).HasColumnType("date");

                entity.Property(e => e.IdLotAo).HasColumnName("IdLotAO");

                entity.Property(e => e.LibelleOffreFormation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleReduitOffreFormation)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculeCollaborateurAfpa)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodeProduitFormationNavigation)
                    .WithMany(p => p.OffreFormations)
                    .HasForeignKey(d => d.CodeProduitFormation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreFormation_ProduitFormation");

                entity.HasOne(d => d.IdEtablissementNavigation)
                    .WithMany(p => p.OffreFormations)
                    .HasForeignKey(d => d.IdEtablissement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffreFormation_Etablissement");
            });

            modelBuilder.Entity<ProduitFormation>(entity =>
            {
                entity.HasKey(e => e.CodeProduitFormation);

                entity.ToTable("ProduitFormation");

                entity.Property(e => e.CodeProduitFormation).ValueGeneratedNever();

                entity.Property(e => e.LibelleCourtFormation)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleProduitFormation)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NiveauFormation)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ProduitFormationRome>(entity =>
            {
                entity.HasKey(e => new { e.CodeProduitFormation, e.CodeRome })
                    .HasName("PK_ProduitFormation_AppellationRome");

                entity.ToTable("ProduitFormation_Rome");

                entity.Property(e => e.CodeRome)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CodeProduitFormationNavigation)
                    .WithMany(p => p.ProduitFormationRomes)
                    .HasForeignKey(d => d.CodeProduitFormation)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProduitFormation_AppellationRome_ProduitFormation");

                entity.HasOne(d => d.CodeRomeNavigation)
                    .WithMany(p => p.ProduitFormationRomes)
                    .HasForeignKey(d => d.CodeRome)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProduitFormation_AppellationRome_Rome");
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.HasKey(e => e.IdQuestionnaire);

                entity.ToTable("Questionnaire");

                entity.Property(e => e.IdQuestionnaire).ValueGeneratedNever();

                entity.Property(e => e.Commentaires).HasColumnType("text");

                entity.Property(e => e.DateEnquete).HasColumnType("date");

                entity.Property(e => e.DesignationProduit)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdEtablissement)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("idEtablissement")
                    .IsFixedLength(true);

                entity.Property(e => e.IdProduit).HasColumnName("idProduit");

                entity.Property(e => e.LibelleQuestionnaire)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rome>(entity =>
            {
                entity.HasKey(e => e.CodeRome)
                    .HasName("PK_CodeRome");

                entity.ToTable("Rome");

                entity.Property(e => e.CodeRome)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CodeDomaineRome)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntituleCodeRome)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodeDomaineRomeNavigation)
                    .WithMany(p => p.Romes)
                    .HasForeignKey(d => d.CodeDomaineRome)
                    .HasConstraintName("FK_Rome_DomaineMetierRome");
            });

            modelBuilder.Entity<Soumissionnaire>(entity =>
            {
                entity.HasKey(e => e.IdentifiantMailing)
                    .HasName("PK_Soumissionnaires");

                entity.ToTable("Soumissionnaire");

                entity.Property(e => e.IdentifiantMailing).HasDefaultValueSql("(newid())");

                entity.Property(e => e.DateEnregistrementReponse).HasColumnType("date");

                entity.Property(e => e.MatriculeBeneficiaire)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdQuestionnaireNavigation)
                    .WithMany(p => p.Soumissionnaires)
                    .HasForeignKey(d => d.IdQuestionnaire)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Soumissionnaire_Questionnaire");
            });

            modelBuilder.Entity<TitreCivilite>(entity =>
            {
                entity.HasKey(e => e.CodeTitreCivilite);

                entity.ToTable("TitreCivilite");

                entity.Property(e => e.CodeTitreCivilite).ValueGeneratedNever();

                entity.Property(e => e.TitreCiviliteAbrege)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TitreCiviliteComplet)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeContrat>(entity =>
            {
                entity.HasKey(e => e.IdtypeContrat);

                entity.ToTable("TypeContrat");

                entity.Property(e => e.IdtypeContrat)
                    .ValueGeneratedNever()
                    .HasColumnName("IDTypeContrat");

                entity.Property(e => e.LibelleTypeContrat)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VueSoumissionnaire>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vue_Soumissionnaire");

                entity.Property(e => e.DateEntreeBeneficiaire).HasColumnType("date");

                entity.Property(e => e.DateSortieBeneficiaire).HasColumnType("date");

                entity.Property(e => e.LibelleOffreFormation)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LibelleQuestionnaire)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculeBeneficiaire)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.NomBeneficiaire)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomEtablissement)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PrenomBeneficiaire)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TitreCiviliteComplet)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
