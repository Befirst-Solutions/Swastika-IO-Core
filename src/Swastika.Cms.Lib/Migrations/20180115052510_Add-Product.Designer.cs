﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Swastika.Cms.Lib.Models.Cms;
using System;

namespace Swastika.Cms.Lib.Migrations
{
    [DbContext(typeof(SiocCmsContext))]
    [Migration("20180115052510_Add-Product")]
    partial class AddProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocArticle", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50);

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("Content");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Excerpt");

                    b.Property<string>("Icon");

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVisible");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(250);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(4000);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(4000);

                    b.Property<string>("SeoName")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("SeoTitle")
                        .HasMaxLength(4000);

                    b.Property<string>("Source")
                        .HasMaxLength(250);

                    b.Property<string>("Tags")
                        .HasMaxLength(500);

                    b.Property<string>("Template")
                        .HasMaxLength(250);

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .HasMaxLength(4000);

                    b.Property<int>("Type");

                    b.Property<int?>("Views");

                    b.HasKey("Id", "Specificulture");

                    b.HasIndex("Specificulture");

                    b.ToTable("sioc_article");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocArticleModule", b =>
                {
                    b.Property<int>("ModuleId");

                    b.Property<string>("ArticleId")
                        .HasMaxLength(50);

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<int>("Position");

                    b.Property<int>("Priority");

                    b.HasKey("ModuleId", "ArticleId", "Specificulture");

                    b.HasIndex("ArticleId", "Specificulture");

                    b.HasIndex("ModuleId", "Specificulture");

                    b.ToTable("sioc_article_module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategory", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("Content");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("CssClass")
                        .HasMaxLength(50);

                    b.Property<string>("Excerpt");

                    b.Property<string>("Icon")
                        .HasMaxLength(50);

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool?>("IsVisible");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<int?>("Level");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(250);

                    b.Property<int>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(4000);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(4000);

                    b.Property<string>("SeoName")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("SeoTitle")
                        .HasMaxLength(4000);

                    b.Property<string>("StaticUrl")
                        .HasMaxLength(250);

                    b.Property<string>("Tags")
                        .HasMaxLength(500);

                    b.Property<string>("Template")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .HasMaxLength(4000);

                    b.Property<int>("Type");

                    b.Property<int?>("Views");

                    b.HasKey("Id", "Specificulture");

                    b.HasIndex("Specificulture");

                    b.ToTable("sioc_category");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryArticle", b =>
                {
                    b.Property<string>("ArticleId")
                        .HasMaxLength(50);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.HasKey("ArticleId", "CategoryId", "Specificulture");

                    b.HasIndex("ArticleId", "Specificulture");

                    b.HasIndex("CategoryId", "Specificulture");

                    b.ToTable("sioc_category_article");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryCategory", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("ParentId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.HasKey("Id", "ParentId", "Specificulture");

                    b.HasIndex("Id", "Specificulture");

                    b.HasIndex("ParentId", "Specificulture");

                    b.ToTable("sioc_category_category");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryModule", b =>
                {
                    b.Property<int>("ModuleId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<int>("Position");

                    b.Property<int>("Priority");

                    b.HasKey("ModuleId", "CategoryId", "Specificulture");

                    b.HasIndex("CategoryId", "Specificulture");

                    b.HasIndex("ModuleId", "Specificulture");

                    b.ToTable("sioc_category_module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryPosition", b =>
                {
                    b.Property<int>("PositionId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.HasKey("PositionId", "CategoryId", "Specificulture");

                    b.HasIndex("CategoryId", "Specificulture");

                    b.ToTable("sioc_category_position");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryProduct", b =>
                {
                    b.Property<string>("ProductId")
                        .HasMaxLength(50);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.HasKey("ProductId", "CategoryId", "Specificulture");

                    b.HasIndex("CategoryId", "Specificulture");

                    b.HasIndex("ProductId", "Specificulture");

                    b.ToTable("sioc_category_product");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocComment", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Content");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("FullName")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool?>("IsReviewed");

                    b.Property<bool?>("IsVisible");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("sioc_comment");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocConfiguration", b =>
                {
                    b.Property<string>("Keyword")
                        .HasMaxLength(250);

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("Category")
                        .HasMaxLength(250);

                    b.Property<int>("DataType");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Value");

                    b.HasKey("Keyword", "Specificulture");

                    b.HasIndex("Specificulture");

                    b.ToTable("sioc_configuration");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCopy", b =>
                {
                    b.Property<string>("Culture")
                        .HasMaxLength(10);

                    b.Property<string>("Keyword")
                        .HasMaxLength(250);

                    b.Property<string>("Note")
                        .HasMaxLength(250);

                    b.Property<string>("Value");

                    b.HasKey("Culture", "Keyword");

                    b.ToTable("sioc_copy");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCulture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alias")
                        .HasMaxLength(150);

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("FullName")
                        .HasMaxLength(150);

                    b.Property<string>("Icon")
                        .HasMaxLength(50);

                    b.Property<string>("Lcid")
                        .HasColumnName("LCID")
                        .HasMaxLength(50);

                    b.Property<string>("Specificulture")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("Specificulture")
                        .IsUnique()
                        .HasName("IX_TTS_Culture");

                    b.ToTable("sioc_culture");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FileFolder")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("FolderType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(250);

                    b.Property<int>("Priority");

                    b.Property<int?>("ThemeId");

                    b.Property<string>("ThemeName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("ThemeId");

                    b.ToTable("sioc_file");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModule", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Fields")
                        .HasMaxLength(4000);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Template")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .HasMaxLength(250);

                    b.Property<int>("Type")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("('0')");

                    b.HasKey("Id", "Specificulture");

                    b.HasIndex("Specificulture");

                    b.ToTable("sioc_module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleArticle", b =>
                {
                    b.Property<string>("ArticleId")
                        .HasMaxLength(50);

                    b.Property<int>("ModuleId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.HasKey("ArticleId", "ModuleId", "Specificulture");

                    b.HasIndex("ArticleId", "Specificulture");

                    b.HasIndex("ModuleId", "Specificulture");

                    b.ToTable("sioc_module_article");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleAttributeSet", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<int>("ModuleId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("ArticleId")
                        .HasMaxLength(50);

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Fields")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<int>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Value");

                    b.HasKey("Id", "ModuleId", "Specificulture");

                    b.HasIndex("ModuleId", "Specificulture");

                    b.HasIndex("ModuleId", "ArticleId", "Specificulture");

                    b.HasIndex("ModuleId", "CategoryId", "Specificulture");

                    b.ToTable("sioc_module_attribute_set");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleAttributeValue", b =>
                {
                    b.Property<Guid>("Id");

                    b.Property<Guid>("AttributeSetId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<int>("DataType");

                    b.Property<string>("DefaultValue")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<int>("ModuleId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .HasMaxLength(250);

                    b.Property<int>("Width")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id", "AttributeSetId", "Specificulture");

                    b.HasIndex("AttributeSetId", "ModuleId", "Specificulture");

                    b.ToTable("sioc_module_attribute_value");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleData", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50);

                    b.Property<int>("ModuleId");

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("ArticleId")
                        .HasMaxLength(50);

                    b.Property<int?>("CategoryId");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Fields")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<int>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Value");

                    b.HasKey("Id", "ModuleId", "Specificulture");

                    b.HasIndex("ModuleId", "Specificulture");

                    b.HasIndex("ModuleId", "ArticleId", "Specificulture");

                    b.HasIndex("ModuleId", "CategoryId", "Specificulture");

                    b.ToTable("sioc_module_data");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocParameter", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("Description");

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Name");

                    b.ToTable("sioc_parameter");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("sioc_position");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocProduct", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50);

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<string>("Content");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Excerpt");

                    b.Property<string>("Icon");

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVisible");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(250);

                    b.Property<double>("Price")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("PriceUnit")
                        .HasMaxLength(10);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(4000);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(4000);

                    b.Property<string>("SeoName")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("SeoTitle")
                        .HasMaxLength(4000);

                    b.Property<string>("Source")
                        .HasMaxLength(250);

                    b.Property<string>("Tags")
                        .HasMaxLength(500);

                    b.Property<string>("Template")
                        .HasMaxLength(250);

                    b.Property<string>("Thumbnail")
                        .HasMaxLength(250);

                    b.Property<string>("Title")
                        .HasMaxLength(4000);

                    b.Property<int>("Type");

                    b.Property<int?>("Views");

                    b.HasKey("Id", "Specificulture");

                    b.HasIndex("Specificulture");

                    b.ToTable("sioc_product");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocProductModule", b =>
                {
                    b.Property<int>("ModuleId");

                    b.Property<string>("ProductId")
                        .HasMaxLength(50);

                    b.Property<string>("Specificulture")
                        .HasMaxLength(10);

                    b.Property<int>("Position");

                    b.Property<int>("Priority");

                    b.HasKey("ModuleId", "ProductId", "Specificulture");

                    b.HasIndex("ModuleId", "Specificulture");

                    b.HasIndex("ProductId", "Specificulture");

                    b.ToTable("sioc_product_module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("ntext");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FileFolder")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("FolderType")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(250);

                    b.Property<int>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Scripts")
                        .HasColumnType("ntext");

                    b.Property<string>("Styles")
                        .HasColumnType("ntext");

                    b.Property<int>("TemplateId");

                    b.Property<string>("TemplateName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("TemplateId")
                        .HasName("IX_sioc_template_file_TemplateId");

                    b.ToTable("sioc_template");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocTheme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Priority")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("((0))");

                    b.HasKey("Id");

                    b.ToTable("sioc_theme");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocArticle", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCulture", "SpecificultureNavigation")
                        .WithMany("SiocArticle")
                        .HasForeignKey("Specificulture")
                        .HasConstraintName("FK_TTS_Article_TTS_Culture")
                        .HasPrincipalKey("Specificulture");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocArticleModule", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocArticle", "SiocArticle")
                        .WithMany("SiocArticleModule")
                        .HasForeignKey("ArticleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Article_Module_TTS_Article");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModule", "SiocModule")
                        .WithMany("SiocArticleModule")
                        .HasForeignKey("ModuleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Article_Module_TTS_Module1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategory", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCulture", "SpecificultureNavigation")
                        .WithMany("SiocCategory")
                        .HasForeignKey("Specificulture")
                        .HasConstraintName("FK_TTS_Category_TTS_Culture")
                        .HasPrincipalKey("Specificulture");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryArticle", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocArticle", "SiocArticle")
                        .WithMany("SiocCategoryArticle")
                        .HasForeignKey("ArticleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Article_TTS_Article");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategory", "SiocCategory")
                        .WithMany("SiocCategoryArticle")
                        .HasForeignKey("CategoryId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Article_TTS_Category");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryCategory", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategory", "SiocCategory")
                        .WithMany("SiocCategoryCategorySiocCategory")
                        .HasForeignKey("Id", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Category_TTS_Category");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategory", "SiocCategoryNavigation")
                        .WithMany("SiocCategoryCategorySiocCategoryNavigation")
                        .HasForeignKey("ParentId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Category_TTS_Category1");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryModule", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategory", "SiocCategory")
                        .WithMany("SiocCategoryModule")
                        .HasForeignKey("CategoryId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Module_TTS_Category");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModule", "SiocModule")
                        .WithMany("SiocCategoryModule")
                        .HasForeignKey("ModuleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Menu_Module_TTS_Module1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryPosition", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocPosition", "Position")
                        .WithMany("SiocCategoryPosition")
                        .HasForeignKey("PositionId")
                        .HasConstraintName("FK_TTS_Category_Position_TTS_Position")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategory", "SiocCategory")
                        .WithMany("SiocCategoryPosition")
                        .HasForeignKey("CategoryId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Position_TTS_Category");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocCategoryProduct", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategory", "SiocCategory")
                        .WithMany("SiocCategoryProduct")
                        .HasForeignKey("CategoryId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Product_TTS_Category");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocProduct", "SiocProduct")
                        .WithMany("SiocCategoryProduct")
                        .HasForeignKey("ProductId", "Specificulture")
                        .HasConstraintName("FK_TTS_Category_Product_TTS_Product");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocConfiguration", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCulture", "SpecificultureNavigation")
                        .WithMany("SiocConfiguration")
                        .HasForeignKey("Specificulture")
                        .HasConstraintName("FK_Sioc_Configuration_Sioc_Culture")
                        .HasPrincipalKey("Specificulture")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocFile", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocTheme", "Theme")
                        .WithMany("SiocFile")
                        .HasForeignKey("ThemeId")
                        .HasConstraintName("FK_sioc_file_sioc_template");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModule", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCulture", "SpecificultureNavigation")
                        .WithMany("SiocModule")
                        .HasForeignKey("Specificulture")
                        .HasConstraintName("FK_TTS_Module_TTS_Culture")
                        .HasPrincipalKey("Specificulture")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleArticle", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocArticle", "SiocArticle")
                        .WithMany("SiocModuleArticle")
                        .HasForeignKey("ArticleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Article_TTS_Article");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModule", "SiocModule")
                        .WithMany("SiocModuleArticle")
                        .HasForeignKey("ModuleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Article_TTS_Module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleAttributeSet", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModule", "SiocModule")
                        .WithMany("SiocModuleAttributeSet")
                        .HasForeignKey("ModuleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Attribute_set_TTS_Module")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocArticleModule", "SiocArticleModule")
                        .WithMany("SiocModuleAttributeSet")
                        .HasForeignKey("ModuleId", "ArticleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Attribute_set_TTS_Article_Module");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategoryModule", "SiocCategoryModule")
                        .WithMany("SiocModuleAttributeSet")
                        .HasForeignKey("ModuleId", "CategoryId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Attribute_set_TTS_Category_Module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleAttributeValue", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModuleAttributeSet", "SiocModuleAttributeSet")
                        .WithMany("SiocModuleAttributeValue")
                        .HasForeignKey("AttributeSetId", "ModuleId", "Specificulture")
                        .HasConstraintName("FK_sioc_module_attribute_value_sioc_module_attribute_set")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocModuleData", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModule", "SiocModule")
                        .WithMany("SiocModuleData")
                        .HasForeignKey("ModuleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Data_TTS_Module")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocArticleModule", "SiocArticleModule")
                        .WithMany("SiocModuleData")
                        .HasForeignKey("ModuleId", "ArticleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Data_TTS_Article_Module");

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCategoryModule", "SiocCategoryModule")
                        .WithMany("SiocModuleData")
                        .HasForeignKey("ModuleId", "CategoryId", "Specificulture")
                        .HasConstraintName("FK_TTS_Module_Data_TTS_Category_Module");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocProduct", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocCulture", "SpecificultureNavigation")
                        .WithMany("SiocProduct")
                        .HasForeignKey("Specificulture")
                        .HasConstraintName("FK_TTS_Product_TTS_Culture")
                        .HasPrincipalKey("Specificulture");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocProductModule", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocModule", "SiocModule")
                        .WithMany("SiocProductModule")
                        .HasForeignKey("ModuleId", "Specificulture")
                        .HasConstraintName("FK_TTS_Product_Module_TTS_Module1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocProduct", "SiocProduct")
                        .WithMany("SiocProductModule")
                        .HasForeignKey("ProductId", "Specificulture")
                        .HasConstraintName("FK_TTS_Product_Module_TTS_Product");
                });

            modelBuilder.Entity("Swastika.Cms.Lib.Models.Cms.SiocTemplate", b =>
                {
                    b.HasOne("Swastika.Cms.Lib.Models.Cms.SiocTheme", "Template")
                        .WithMany("SiocTemplate")
                        .HasForeignKey("TemplateId")
                        .HasConstraintName("FK_sioc_template_file_sioc_template");
                });
#pragma warning restore 612, 618
        }
    }
}
