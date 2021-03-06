﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTinTuc.Models.Entities;

namespace WebTinTuc.Migrations
{
    [DbContext(typeof(TinTucContext))]
    [Migration("20190714042320_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("WebTinTuc.Models.Entities.BaiBao", b =>
                {
                    b.Property<long>("IdBaiBao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<long?>("IdDanhMuc")
                        .IsRequired()
                        .HasColumnType("bigint(20)");

                    b.Property<int?>("LuotXem")
                        .HasColumnType("int(11)");

                    b.Property<string>("NoiDung")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Tags")
                        .IsUnicode(false);

                    b.Property<DateTime>("ThoiGianTao");

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("TomTat")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("IdBaiBao");

                    b.HasIndex("IdDanhMuc")
                        .HasName("BaiBao___DanhMuc");

                    b.HasIndex("Username")
                        .HasName("BaiBao___QuanTriVien");

                    b.ToTable("BaiBao","TinTuc");
                });

            modelBuilder.Entity("WebTinTuc.Models.Entities.BinhLuan", b =>
                {
                    b.Property<long>("IdBinhLuan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<long>("IdBaiBao")
                        .HasColumnType("bigint(20)");

                    b.Property<long?>("IdBlcha")
                        .HasColumnName("IdBLCha")
                        .HasColumnType("bigint(20)");

                    b.Property<string>("NoiDung")
                        .IsUnicode(false);

                    b.Property<string>("TenNguoiBl")
                        .HasColumnName("TenNguoiBL")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<DateTime>("ThoiGian");

                    b.HasKey("IdBinhLuan");

                    b.HasIndex("IdBaiBao")
                        .HasName("BinhLuan___BaiBao");

                    b.HasIndex("IdBlcha")
                        .HasName("BinhLuan___BinhLuan");

                    b.ToTable("BinhLuan","TinTuc");
                });

            modelBuilder.Entity("WebTinTuc.Models.Entities.DanhMuc", b =>
                {
                    b.Property<long>("IdDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint(20)");

                    b.Property<string>("TenDanhMuc")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("IdDanhMuc");

                    b.ToTable("DanhMuc","TinTuc");
                });

            modelBuilder.Entity("WebTinTuc.Models.Entities.QuanTriVien", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("Bio");

                    b.Property<string>("ChucVu")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("GioiTinh")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("HinhDaiDien");

                    b.Property<string>("HoTen")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("MatKhau")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.HasKey("Username");

                    b.ToTable("QuanTriVien","TinTuc");
                });

            modelBuilder.Entity("WebTinTuc.Models.Entities.BaiBao", b =>
                {
                    b.HasOne("WebTinTuc.Models.Entities.DanhMuc", "IdDanhMucNavigation")
                        .WithMany("BaiBao")
                        .HasForeignKey("IdDanhMuc")
                        .HasConstraintName("BaiBao___DanhMuc")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebTinTuc.Models.Entities.QuanTriVien", "UsernameNavigation")
                        .WithMany("BaiBao")
                        .HasForeignKey("Username")
                        .HasConstraintName("BaiBao___QuanTriVien");
                });

            modelBuilder.Entity("WebTinTuc.Models.Entities.BinhLuan", b =>
                {
                    b.HasOne("WebTinTuc.Models.Entities.BaiBao", "IdBaiBaoNavigation")
                        .WithMany("BinhLuan")
                        .HasForeignKey("IdBaiBao")
                        .HasConstraintName("BinhLuan___BaiBao");

                    b.HasOne("WebTinTuc.Models.Entities.BinhLuan", "IdBlchaNavigation")
                        .WithMany("InverseIdBlchaNavigation")
                        .HasForeignKey("IdBlcha")
                        .HasConstraintName("BinhLuan___BinhLuan");
                });
#pragma warning restore 612, 618
        }
    }
}
