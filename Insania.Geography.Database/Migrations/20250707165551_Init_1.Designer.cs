﻿// <auto-generated />
using System;
using Insania.Geography.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Insania.Geography.Database.Migrations
{
    [DbContext(typeof(GeographyContext))]
    [Migration("20250707165551_Init_1")]
    partial class Init_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("insania_geography")
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "postgis");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Insania.Geography.Entities.GeographyObject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint")
                        .HasColumnName("parent_id")
                        .HasComment("Идентификатор родителя");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("type_id")
                        .HasComment("Идентификатор типа");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.HasIndex("ParentId");

                    b.HasIndex("TypeId");

                    b.ToTable("c_geography_objects", "insania_geography", t =>
                        {
                            t.HasComment("Географические объекты");
                        });
                });

            modelBuilder.Entity("Insania.Geography.Entities.GeographyObjectCoordinate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id"), 4L, null, null, null, null, null);

                    b.Property<double>("Area")
                        .HasColumnType("double precision")
                        .HasColumnName("area")
                        .HasComment("Площадь сущности");

                    b.Property<Point>("Center")
                        .IsRequired()
                        .HasColumnType("geometry")
                        .HasColumnName("center")
                        .HasComment("Координаты точки центра сущности");

                    b.Property<long?>("CoordinateId")
                        .HasColumnType("bigint")
                        .HasColumnName("coordinate_id")
                        .HasComment("Идентификатор координаты");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<long>("GeographyObjectId")
                        .HasColumnType("bigint")
                        .HasColumnName("geography_object_id")
                        .HasComment("Идентификатор географического объекта");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.Property<int>("Zoom")
                        .HasColumnType("integer")
                        .HasColumnName("zoom")
                        .HasComment("Коэффициент масштаба отображения сущности");

                    b.HasKey("Id");

                    b.HasIndex("GeographyObjectId");

                    b.HasIndex("CoordinateId", "GeographyObjectId", "DateDeleted")
                        .IsUnique();

                    b.ToTable("u_geography_objects_coordinates", "insania_geography", t =>
                        {
                            t.HasComment("Координаты географических объектов");
                        });
                });

            modelBuilder.Entity("Insania.Geography.Entities.GeographyObjectType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_geography_objects_types", "insania_geography", t =>
                        {
                            t.HasComment("Типы географических объектов");
                        });
                });

            modelBuilder.Entity("Insania.Shared.Entities.Coordinate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));
                    NpgsqlPropertyBuilderExtensions.HasIdentityOptions(b.Property<long>("Id"), 4L, null, null, null, null, null);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<bool>("IsSystem")
                        .HasColumnType("boolean")
                        .HasColumnName("is_system")
                        .HasComment("Признак системной записи");

                    b.Property<Polygon>("PolygonEntity")
                        .IsRequired()
                        .HasColumnType("geometry")
                        .HasColumnName("polygon")
                        .HasComment("Полигон (массив координат)");

                    b.Property<string>("TypeDiscriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<long?>("TypeId")
                        .HasColumnType("bigint")
                        .HasColumnName("type_id")
                        .HasComment("Идентификатор типа координаты");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("r_coordinates", "insania_geography");

                    b.HasDiscriminator<string>("TypeDiscriminator").HasValue("Coordinate");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Insania.Shared.Entities.CoordinateType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id")
                        .HasComment("Первичный ключ таблицы");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("alias")
                        .HasComment("Псевдоним");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_create")
                        .HasComment("Дата создания");

                    b.Property<DateTime?>("DateDeleted")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_deleted")
                        .HasComment("Дата удаления");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date_update")
                        .HasComment("Дата обновления");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasComment("Наименование");

                    b.Property<string>("TypeDiscriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("UsernameCreate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_create")
                        .HasComment("Логин пользователя, создавшего");

                    b.Property<string>("UsernameUpdate")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username_update")
                        .HasComment("Логин пользователя, обновившего");

                    b.HasKey("Id");

                    b.HasAlternateKey("Alias");

                    b.ToTable("c_coordinates_types", "insania_geography");

                    b.HasDiscriminator<string>("TypeDiscriminator").HasValue("CoordinateType");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Insania.Geography.Entities.CoordinateGeography", b =>
                {
                    b.HasBaseType("Insania.Shared.Entities.Coordinate");

                    b.HasIndex("PolygonEntity");

                    NpgsqlIndexBuilderExtensions.HasMethod(b.HasIndex("PolygonEntity"), "gist");

                    b.ToTable("r_coordinates", "insania_geography", t =>
                        {
                            t.HasComment("Координаты географии");
                        });

                    b.HasDiscriminator().HasValue("Geography");
                });

            modelBuilder.Entity("Insania.Geography.Entities.CoordinateTypeGeography", b =>
                {
                    b.HasBaseType("Insania.Shared.Entities.CoordinateType");

                    b.ToTable("c_coordinates_types", "insania_geography", t =>
                        {
                            t.HasComment("Типы координат географии");
                        });

                    b.HasDiscriminator().HasValue("Geography");
                });

            modelBuilder.Entity("Insania.Geography.Entities.GeographyObject", b =>
                {
                    b.HasOne("Insania.Geography.Entities.GeographyObject", "ParentEntity")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("Insania.Geography.Entities.GeographyObjectType", "TypeEntity")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentEntity");

                    b.Navigation("TypeEntity");
                });

            modelBuilder.Entity("Insania.Geography.Entities.GeographyObjectCoordinate", b =>
                {
                    b.HasOne("Insania.Shared.Entities.Coordinate", "CoordinateEntity")
                        .WithMany()
                        .HasForeignKey("CoordinateId");

                    b.HasOne("Insania.Geography.Entities.GeographyObject", "GeographyObjectEntity")
                        .WithMany()
                        .HasForeignKey("GeographyObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CoordinateEntity");

                    b.Navigation("GeographyObjectEntity");
                });

            modelBuilder.Entity("Insania.Shared.Entities.Coordinate", b =>
                {
                    b.HasOne("Insania.Shared.Entities.CoordinateType", "TypeEntity")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("TypeEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
