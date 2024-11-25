using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksShop.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038e5319-0910-4cba-bf80-253a10030324",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ed9226b7-d06e-41ec-82a0-68170a75c81d", "AQAAAAEAACcQAAAAEEilTPukzLq2k9dd8K6wEz0yjLlxyuFwLLQhCGfSj/EL0hv57nK2Gp8cetF5jL4tyQ==", new DateTime(2024, 11, 24, 10, 31, 40, 700, DateTimeKind.Local).AddTicks(5373), "b9d94e36-3c2a-4d98-9977-287badf442fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2082b250-410f-432e-9723-05652f3ae7be", "AQAAAAEAACcQAAAAEOHWglxJDYkCvPEu04NYoitHAdZG9wwTQAPhb2K4vcIJ02UXep6WHzoTgLvhCORg+Q==", new DateTime(2024, 11, 24, 10, 31, 40, 677, DateTimeKind.Local).AddTicks(7197), "8863e8b6-f92c-4f99-a8fb-70e9bb64e83e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "30e72795-107c-45ca-8a08-cf5f2ca220ce", "AQAAAAEAACcQAAAAEE1+u9udHoywdsL4oLd1n5CvuazMP4kCv/im+0jfd6Nvl5iAPD+cluLb/wQTDAhkpg==", new DateTime(2024, 11, 24, 10, 31, 40, 688, DateTimeKind.Local).AddTicks(633), "9532bd94-ec46-4c6d-b875-d9f3efbe51a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "03a3c735-bc92-4120-bd7b-10a1a2c03401", "AQAAAAEAACcQAAAAELAdb0XpB4tasZRu8Jh97/GbID+BXH2Vf7UiPX5pz44WZT9bz8Rc5DfWTB1lhVkfGw==", new DateTime(2024, 11, 24, 10, 31, 40, 690, DateTimeKind.Local).AddTicks(1112), "371e8a5f-a462-4291-932e-1d6289183760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "e9f83197-41ac-4545-bf47-1d939ef38c45", "AQAAAAEAACcQAAAAEL9TV5ykQxKFE4zQjwpMuncLb2mkAgZTORjQZcnz7ZQG0SAM+eK18xLHf30TpAOnkQ==", new DateTime(2024, 11, 24, 10, 31, 40, 693, DateTimeKind.Local).AddTicks(2044), "72026014-30c8-443b-b5db-817633e06feb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "43379d4b-2e4c-46fd-8e4c-b897efad08fb", "AQAAAAEAACcQAAAAEH2b4Mi9T1DAvbT3bpNd1+BHeLQVjXxR1iphGHBbfVuy2IxMc37zBiTZa1KFYVlNcQ==", new DateTime(2024, 11, 24, 10, 31, 40, 702, DateTimeKind.Local).AddTicks(5885), "bcab6f30-c8e0-485e-a389-a746ac07b821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "eb253343-d622-4c0d-91af-d8fc152f88df", "AQAAAAEAACcQAAAAEFyfOMYGmywQuqSC8ZbkATEeK1PCHJhexJWTDDBvdr2ys6xmnGQmUkG3SUUFhW4tZw==", new DateTime(2024, 11, 24, 10, 31, 40, 699, DateTimeKind.Local).AddTicks(4871), "8d11e87c-9208-4368-9d7d-ddb29d6398b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3e466cf9-8eb2-4916-89cc-4f82dba7dbe6", "AQAAAAEAACcQAAAAEBuAy70+BraGe+BZn18lssWCLu6rEIfoY8BQHHQiCmEGdQpWczh7tsLPOW8BzmjppA==", new DateTime(2024, 11, 24, 10, 31, 40, 682, DateTimeKind.Local).AddTicks(8751), "55b9b47c-6170-47a5-b8e5-eaa369c916c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "66d65f26-777f-4b85-ab7e-e1659d093c32", "AQAAAAEAACcQAAAAEAIDWd8SJGgjTbvBA3+xPaF0NLvGflGBiF5EGN9PA4JW1DeO+xZjvRjSfRiifVBI5w==", new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2799), "c318904c-8b19-4eb1-ba20-4af24a493e4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "0bd6a037-a2dd-45a8-9bf7-a12e7e7a44a1", "AQAAAAEAACcQAAAAEIckIEeI4XD8sIMQ0DXDJCloz3Za2K/kIlPby79Kpf+yxa62MQi9pA1Tncy9jyJrJg==", new DateTime(2024, 11, 24, 10, 31, 40, 683, DateTimeKind.Local).AddTicks(9034), "04f16f31-d5dd-4347-bf83-3dc88a5724d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "897d7f6f-57d0-40b8-ac85-9ebfa35c2238", "AQAAAAEAACcQAAAAEFb1cL2ornGaKvM4AacM+35Lh6bEcL/Vr1z3voSOLqZuxnNzyVh9eEUNh7FlhnirpQ==", new DateTime(2024, 11, 24, 10, 31, 40, 680, DateTimeKind.Local).AddTicks(8200), "031acd72-8131-4cdf-ab1e-31f2d97ac820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "3dced06f-582e-4ee8-9d03-5f2be98c5cec", "AQAAAAEAACcQAAAAEAuC7DwxetXl7O3hy0aUIV4oQt+tLGXirAeU8eHRoUDo6+2b8NgedH/y4HfXv6PoDQ==", new DateTime(2024, 11, 24, 10, 31, 40, 695, DateTimeKind.Local).AddTicks(3159), "8e77fdfc-39a5-4772-a2af-ba7b3e82a5aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "bade1195-88cf-42c3-88dc-7872e8f84914", "AQAAAAEAACcQAAAAEARyLBxqoPrwtGmPQuO5+ljLjEycjoUgFFn0Pa0z+VnAh8yHbsHkOgULRMunGL0KYQ==", new DateTime(2024, 11, 24, 10, 31, 40, 673, DateTimeKind.Local).AddTicks(3573), "95f60031-75f9-470c-9ac8-39d23640ed06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f9d57d60-e92d-486b-9feb-dc6099756e9d", "AQAAAAEAACcQAAAAEEdeT0aYh7L/R2mH4e0O3dl+7i3MrDta2o/wpY7DoRPXosopKnQLiKFQiJdACa3sfA==", new DateTime(2024, 11, 24, 10, 31, 40, 678, DateTimeKind.Local).AddTicks(7731), "e16dd695-1981-46ca-b300-7db309343e2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "a04e5b37-c2fc-4828-9abb-f1b2f3003a55", "AQAAAAEAACcQAAAAEKH0rtpGyeX24RMGbsZeI/bWmxTM++lOLRH4dXcgpKe3qwF1vzEmntleezR16Ngo8Q==", new DateTime(2024, 11, 24, 10, 31, 40, 676, DateTimeKind.Local).AddTicks(5997), "af62f1fa-7dd4-4f56-ba3e-1b875b29448c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "26293c66-1300-456a-9b2f-52ecd00ce1a2", "AQAAAAEAACcQAAAAEHGJrVD3j3at5mEDL3ol/zhLd6D2M57JV2ZKSAsXutLF/OzigluyhxvzEqb+oF3zNw==", new DateTime(2024, 11, 24, 10, 31, 40, 698, DateTimeKind.Local).AddTicks(4506), "f7c288b2-77ce-44d6-837b-60196e89c0c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "6550feda-52d7-4372-966e-6819beac30e3", "AQAAAAEAACcQAAAAENqUiCWA3VEM4kCp50g6Ju6EsLEsYnmxNtJkPKEB9gFT9lCnobmgenSq83qGkx6z1A==", new DateTime(2024, 11, 24, 10, 31, 40, 681, DateTimeKind.Local).AddTicks(8403), "4b1bef39-f414-47cf-91cf-42629c56359b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2fb0b868-339d-4d26-a3ea-6089372e3b26", "AQAAAAEAACcQAAAAECZVa8Cs3U29D1v4tMinQNbM3r+gNFDDrhbvYa9ZgqFqLahy5Q0+ac1f1vHs9CD9Ig==", new DateTime(2024, 11, 24, 10, 31, 40, 696, DateTimeKind.Local).AddTicks(3657), "5009ba5d-4f2b-4aba-9293-6f9600676288" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2ba3eee1-7b7f-4c90-aece-b472049b6769", "AQAAAAEAACcQAAAAECOELfzVbpPMv6ARt0FPtbpfDwlhh3uU38QQIFGg+fU8fKwEHq3qyO+1kpyCN5sWcQ==", new DateTime(2024, 11, 24, 10, 31, 40, 675, DateTimeKind.Local).AddTicks(4356), "1e6b10b0-2589-4dcd-96d7-f4690c7a49ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "349b8ff4-2cee-4941-9589-b369bf060ea3", "AQAAAAEAACcQAAAAEJOFt7hXqWvRWvQCwFf2t6scgpKIA/hwDZ9Tyfoi8bcFvEqvwEwkjvTkMe7PcAl9wA==", new DateTime(2024, 11, 24, 10, 31, 40, 691, DateTimeKind.Local).AddTicks(1355), "e953ee36-5ffb-48ba-8e9e-3f6aa11dc591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "37a1628d-e7a4-4acf-84ba-d12b8b19244f", "AQAAAAEAACcQAAAAEFu5GcTBggJ+bVBmHsE6LRZ1pyzQxT/Q7+lnsaotmpMoz9jZjb7dxfE1SSw11QPysw==", new DateTime(2024, 11, 24, 10, 31, 40, 689, DateTimeKind.Local).AddTicks(885), "93d595ba-c305-4688-ad17-d29cabfe4311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "340ad663-1e5e-4b67-956d-54e5c980fba4", "AQAAAAEAACcQAAAAEBe2qClfMRrZPNSVTpMxqn0OpvLwjv1+7WLhEhL7tubDVS80A41ijTegOnBBjG4mtw==", new DateTime(2024, 11, 24, 10, 31, 40, 701, DateTimeKind.Local).AddTicks(5701), "680acda4-5b0f-432b-baed-c15fe12b4ac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d257b1a7-7b9d-46da-8c81-eb39fe343a7e", "AQAAAAEAACcQAAAAEJ9xh++hRis9hAg6OP2O1+B6PMuJPx9ramPdKDTeRzIYCT6r5Dv1zgOWhKmUfD7iGQ==", new DateTime(2024, 11, 24, 10, 31, 40, 672, DateTimeKind.Local).AddTicks(3270), "21e5080d-be5b-4598-883c-4d62a98a1043" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d89de82b-65b8-4567-ae4b-44b618afa2d4", "AQAAAAEAACcQAAAAELNv/aE5mlrmt0XfxvdEDxB36WmrnDCh76IUxSI3OKg+o2wPwMRCAh9UwlDuXIJf2A==", new DateTime(2024, 11, 24, 10, 31, 40, 685, DateTimeKind.Local).AddTicks(9462), "3e992d5a-144c-4e10-b7e2-e829cabc8914" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ee305b73-b067-4537-a58c-188278a56614", "AQAAAAEAACcQAAAAEK16wee5oI9IYTY42mMGTADUguI+tTdoC9+jehEnRCkO0pe4dc+j9pOL4RwJmjmd7g==", new DateTime(2024, 11, 24, 10, 31, 40, 697, DateTimeKind.Local).AddTicks(4126), "0999bb73-10e8-4d45-bd4b-cb5e41360c9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "fbcdd9ea-f852-4269-b417-3b0313bacba9", "AQAAAAEAACcQAAAAEATte4AwdGWtW+F/wt1YImko+ZP4ztb8gqmATvZWk7Fk53jDnjF+fGqJ2h+422OQXA==", new DateTime(2024, 11, 24, 10, 31, 40, 674, DateTimeKind.Local).AddTicks(4032), "f773f6d5-f975-4a16-8231-d2629ab42408" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "1cb103a5-b856-4467-b411-5049d32fc7f4", "AQAAAAEAACcQAAAAEFBBlNIAQEafbSUMbBWhj/nd/s9E57AVTP/xXiUTXGBJelpqaie0TylgDm6+xGJCBg==", new DateTime(2024, 11, 24, 10, 31, 40, 684, DateTimeKind.Local).AddTicks(9154), "222fbbd5-2cfd-4fe8-a2bf-49498eb4e817" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "546c2161-b6f5-4a61-9f62-6bb8a02f05cd", "AQAAAAEAACcQAAAAEKwymdh0eSmfQauA8K5iui0oGf11lnHrxS/CScNeJXAzurc8KVNt3VlNK5DpVpmCyw==", new DateTime(2024, 11, 24, 10, 31, 40, 686, DateTimeKind.Local).AddTicks(9998), "3f8b0173-b4b1-4a05-9ab9-9474f2d45309" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "db420711-7269-48df-b03c-47b4d88454ec", "AQAAAAEAACcQAAAAEPVjIt1GyLC2oR3YnvX2VilYRcvzlIHeuYKXW0fl+IZEzLhbCmGwaEIYlO9kYhXaMQ==", new DateTime(2024, 11, 24, 10, 31, 40, 694, DateTimeKind.Local).AddTicks(2581), "b0d49696-17b2-416d-b220-db2cd645dfc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f54a3d20-2c10-4fd7-9b94-c163fa63dbcf", "AQAAAAEAACcQAAAAELdBnrc15zdXB1qc3xc/AsO95iCUkEbQB5Sl3tx4KNVjMpicR8y4VYGqCea4N7qWpA==", new DateTime(2024, 11, 24, 10, 31, 40, 692, DateTimeKind.Local).AddTicks(1592), "3ce669f6-9270-405f-afbf-f5cc07143380" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ebb628ed-79eb-4e94-a680-811a9003a458", "AQAAAAEAACcQAAAAEGR4sfShOIQfHLosxDyMn0pp+ZsMt18DvtmMymeaIvtS12YQBi5Ecd0aeBxjx5dzgg==", new DateTime(2024, 11, 24, 10, 31, 40, 679, DateTimeKind.Local).AddTicks(8071), "880913d4-7529-4ffb-94dc-96c3166bcea5" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2024, 11, 24, 10, 31, 40, 671, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 11, 3, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 11, 6, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 11, 8, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 11, 8, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 11, 11, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 11, 14, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 11, 18, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 11, 18, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2024, 11, 19, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2024, 11, 19, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2024, 11, 20, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2024, 11, 21, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2024, 11, 21, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2024, 11, 21, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2024, 11, 22, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2024, 11, 22, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2024, 11, 22, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2024, 11, 22, 22, 31, 40, 703, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 10, 31, 40, 703, DateTimeKind.Local).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 14, 31, 40, 703, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 16, 31, 40, 703, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 18, 31, 40, 703, DateTimeKind.Local).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 19, 31, 40, 703, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 19, 31, 40, 703, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2024, 11, 23, 21, 31, 40, 703, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2024, 11, 24, 0, 31, 40, 703, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2024, 11, 24, 0, 31, 40, 703, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2024, 11, 24, 2, 31, 40, 703, DateTimeKind.Local).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2024, 11, 24, 5, 31, 40, 703, DateTimeKind.Local).AddTicks(6920));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "038e5319-0910-4cba-bf80-253a10030324",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ea4a71da-50e0-4934-a951-58cd8f4346df", "AQAAAAEAACcQAAAAEMw7tHtYq+BVAMQplj44kA7Z1C6xfpBaFaRgz/e3q9zlRo1JLkYgh7/rycDgD+NPpw==", new DateTime(2023, 9, 17, 17, 50, 52, 334, DateTimeKind.Local).AddTicks(5316), "1ea700b5-17b3-4d73-a77f-7912fffdd0ef" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0908214c-eac6-4029-b303-8d987037c4ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "77671253-ce8c-41a2-a15e-9df6a76f1fb9", "AQAAAAEAACcQAAAAEKYuL+4h4U4vsZd6SZRh5ZF7dbvIC4EZ2KvU4T+qOYNV/KCfQicw1J/X5+139yx/IQ==", new DateTime(2023, 9, 17, 17, 50, 52, 310, DateTimeKind.Local).AddTicks(8068), "2590ba21-efbc-44f5-8a1c-196607f206dd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e6103a7-8dae-4d2e-b438-74fe02768f4f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "7a32f9b5-fb31-4b5a-9ab2-e3473c9f7398", "AQAAAAEAACcQAAAAEJMkGjgTr6tcRSmoAPS/0hfu+fM/8+YwiqUfoNHz3stQIR6caAyuqOejR08e1SlEvQ==", new DateTime(2023, 9, 17, 17, 50, 52, 321, DateTimeKind.Local).AddTicks(7123), "42c80eea-edd4-4305-984d-1f18bf0606ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "109044cd-44fb-470c-b7b9-2724987b08de",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2ed1a3b7-2d3d-4759-a05c-b80fe0c218a4", "AQAAAAEAACcQAAAAELcICNQFnXmCaXpN5d97J71w0MweBhZYnAC1vaUpna4eDOFytF99R68IJ3TqSxoI5A==", new DateTime(2023, 9, 17, 17, 50, 52, 323, DateTimeKind.Local).AddTicks(8462), "f42d809f-f507-4067-b8d3-d37d8be4adfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c1a75f2-63d1-4aaf-b026-b9e13ebb62ca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "c1448fd8-b5bc-44d6-8bcb-fc493ecb4928", "AQAAAAEAACcQAAAAEPMe8lKmOxn2dWNEqMEsuej1RhiIS/pxxA6poHhHuyNuCppNkYGGtir09DcH9d5/Rg==", new DateTime(2023, 9, 17, 17, 50, 52, 327, DateTimeKind.Local).AddTicks(640), "07a96a39-efab-454e-b461-9afeb6546bf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1de2f067-3236-4b27-9fba-8b5d49db06ae",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "78e185a7-8461-46dd-ab04-105a2eefd32f", "AQAAAAEAACcQAAAAEIby/lzNSxrzUrTknlZMf2YSwE31jOdgvXN8QDY3uuQiYNy/7ZWapqmBAPHd7y0pmg==", new DateTime(2023, 9, 17, 17, 50, 52, 336, DateTimeKind.Local).AddTicks(6849), "551778a6-4f91-45d6-add0-334399bd7885" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22657eba-f41a-4bb3-986e-83ef23fedf15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "c0ac3029-6679-4fb9-941c-b0483ddc71a6", "AQAAAAEAACcQAAAAEOdY7Wzl5j0fxysAuBTnXdSh2/Km4lYrcw9BKNiJT2noPga96VKEdeYhjbr6sJs58Q==", new DateTime(2023, 9, 17, 17, 50, 52, 333, DateTimeKind.Local).AddTicks(4594), "240f91ca-aa2d-458b-94f4-cfeb364b5c83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2708e501-67b2-4c5b-aacd-9a044df9de21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "0beb0448-0daf-477b-b528-9d0dc7f8cd7b", "AQAAAAEAACcQAAAAEGn2WZM/3kOEZ+b19AeI300THWla3vowq7KsZxq2TLVU77U91L4xrQO+NKnB5ENVZA==", new DateTime(2023, 9, 17, 17, 50, 52, 316, DateTimeKind.Local).AddTicks(2662), "d88fff2a-9847-4541-97bc-fa7ddb806af2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "283073f1-cc28-485a-ab58-44f4ed128264",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "31f4eff9-0e06-4c94-b158-d41a6d92850a", "AQAAAAEAACcQAAAAEEnHgqAIo+Zw+g0xm1ryX/1ZVZrTzZ/snZk0e+6wwDc41EcHbljTVJZv331ADOp3+A==", new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2810), "c1e7e8e8-092c-4ea4-9e54-d417bdb31cb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b760fe4-01b3-4794-9d1a-a63002dc3ccd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b04956d4-70d1-43be-85fb-d55ac05df194", "AQAAAAEAACcQAAAAEMUlJkqccU6oFR6BOuPmnvBV12q+gaTt6HogZjUGekmlpTdw5W8AXiNT6QcZQavE/A==", new DateTime(2023, 9, 17, 17, 50, 52, 317, DateTimeKind.Local).AddTicks(3624), "661d86b7-1875-4d33-94a7-9437ef3402d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c2467dc-c396-46ce-af79-da3e48398f4a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "6298ad51-6623-4013-ba55-ffb07d290a98", "AQAAAAEAACcQAAAAEE3/wXh/3tPnGDLsXo6d2qbwIpg2l4k2D7AsV74BbdeET4yHu1kjw3FWA3fE730h9g==", new DateTime(2023, 9, 17, 17, 50, 52, 314, DateTimeKind.Local).AddTicks(826), "8de391b2-140e-4e2e-9a16-7b8c4dbcdfa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33008499-b5d6-4dc4-8b90-81eb4c5da11e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "10cf2ede-680f-4a90-940c-b90dbd7c63dd", "AQAAAAEAACcQAAAAEJTPDd5LEJRvPQkWYmGjrbb13ImEj3YieyuFJmUj02MGs6wFrIbTKabq4GrSX9PVfw==", new DateTime(2023, 9, 17, 17, 50, 52, 329, DateTimeKind.Local).AddTicks(1816), "8c2b8350-f5e8-4b3e-a2e5-2ff6ede34416" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45538c3e-df96-4b79-86dc-e190def35cf4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "9cacf843-5a30-4711-bb77-91746df4b1cf", "AQAAAAEAACcQAAAAEAe3IAxonEoo4JaflC+2UqBojQj4KW1ZtL5bEEEaGoItnB2HGV/lQY6Hvx8D3boGCA==", new DateTime(2023, 9, 17, 17, 50, 52, 306, DateTimeKind.Local).AddTicks(4800), "1370f3fe-55d8-4156-907a-2a7bef0baa18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77eb1836-14d0-414d-85ad-3413afd9e2d9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "44b540e2-e376-4554-8eff-51a07636491a", "AQAAAAEAACcQAAAAEGIrF4WWXWT2ATYpnMLuz9aaxfTur7eTf3/Cx7VTc1ZeV8TBQQzc6N4OgW27hA45nw==", new DateTime(2023, 9, 17, 17, 50, 52, 311, DateTimeKind.Local).AddTicks(8948), "986fa6e0-9ac1-4d71-bca4-345fb04a31a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a09fc16-8d35-48e4-bf98-532a876423f2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "fee64f03-2442-48c0-865d-d90ae2668700", "AQAAAAEAACcQAAAAENsOCkyiDyETWr7qDAO1A/ODHOQMtC45cB9B9PMRHr/LmHHDeSaRq4ZQqF1vOoNUBw==", new DateTime(2023, 9, 17, 17, 50, 52, 309, DateTimeKind.Local).AddTicks(7056), "543be11d-2a84-4da5-9386-371668400003" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "838db25f-ef7e-4cda-aa56-dfe1691d298d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "26d4e7a5-3c03-4fa0-a17d-bf7368caaeb0", "AQAAAAEAACcQAAAAEHfExfRwxprUyiOnP5kYz25fG+g3fGN2ZUrr8nSYW/c+IQTGH9wA43V29Qlh5x960g==", new DateTime(2023, 9, 17, 17, 50, 52, 332, DateTimeKind.Local).AddTicks(3820), "da264025-b834-4eb5-a01a-a82c278df940" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87582ce2-32f8-48ac-a429-cdb22d49bd45",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "0e3dd1ba-40fb-4b14-9409-2220c893fb55", "AQAAAAEAACcQAAAAEOXuLTxOOZ77+d9fFmPB9gR01+KWAbvVXCYMJ8S2i8gzzf3SywUIJ+d3C6TROvB8PA==", new DateTime(2023, 9, 17, 17, 50, 52, 315, DateTimeKind.Local).AddTicks(1772), "73620668-211f-4c3b-99dd-a7873fd14687" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a702a88-26b5-4e9d-bd3e-6b088b350db5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "d4aa3996-5fd5-40c1-8a61-a926ee261453", "AQAAAAEAACcQAAAAEF5ka5s3ftP6Yu+TiJeoPnVqaFGFlQfiqtno9v4OXX2XKS3RqLAaDWksfFQ8RWjpjg==", new DateTime(2023, 9, 17, 17, 50, 52, 330, DateTimeKind.Local).AddTicks(2495), "3c5a88c1-c9ef-436d-9c67-50212d1244e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d307bd3-3290-43c2-b9b3-eb2daf715cb4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "f6a8dd68-0919-425d-8de4-f4f3cc7f10ea", "AQAAAAEAACcQAAAAEGbrpcD3mzBeish9dz9tZDF0JU79j+L3vE/MrSG10wkDabVgwLyYdMKdrjYW3rY9bg==", new DateTime(2023, 9, 17, 17, 50, 52, 308, DateTimeKind.Local).AddTicks(6409), "a96a31f9-7027-4c9a-ba0d-8576da55fa4a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93a879f7-64a2-4a8c-b821-a1304bd7c8fb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "133ebc52-7c45-4879-9765-b2c3eb00cf97", "AQAAAAEAACcQAAAAEGq3Tr9TCfQkfREoR1wo96uUtkQ5V727/oa7Jwz+1ew37bUBDWKoXyZvDbnSe/DmOQ==", new DateTime(2023, 9, 17, 17, 50, 52, 324, DateTimeKind.Local).AddTicks(9138), "3ae35f76-1a86-4565-b6fa-a0ad2740a454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94280b80-6076-4025-9bf7-ae251fb7bcee",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "251aeb66-438b-4504-b6fd-f0bb974361b8", "AQAAAAEAACcQAAAAEBW+qbybBeVZ4903izADMojZ86wcBGi3YtUN9f+ymuozCScO7c3DUyoAMXwR/ZO99g==", new DateTime(2023, 9, 17, 17, 50, 52, 322, DateTimeKind.Local).AddTicks(7883), "cc62de01-becf-4f0e-9d5d-80b34fabf8d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "978959e9-4ec5-49a0-a703-77884cc8d109",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "ff3f3d56-85aa-4e4f-b3e5-8ef332dc73b9", "AQAAAAEAACcQAAAAECwJ5plRkeP2cwl84NGlGAcloK+21tB9Cf17ev1oyzPvplQ1AbXhang+ab7ZLILxZQ==", new DateTime(2023, 9, 17, 17, 50, 52, 335, DateTimeKind.Local).AddTicks(6064), "c2662870-3b15-476a-ab97-3a1d69c8bd14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a9b36f7-4a83-48c8-91d3-9136426dbee9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "2a6f0953-5da5-4aff-b835-ceac75cc9065", "AQAAAAEAACcQAAAAEBA/f5kc8Re+eWuoatRvfNgzR2mjy6pjh6IxGx91bL1TbXU3O+h8QZAHh8vaapTkIA==", new DateTime(2023, 9, 17, 17, 50, 52, 305, DateTimeKind.Local).AddTicks(3767), "e619b375-cf60-4e9a-90e7-75659bdf8a82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6424f60-c8e2-495d-bf48-bfb3e9457516",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "84968972-c421-434b-a499-2b31a8df037c", "AQAAAAEAACcQAAAAEMSeoBbv5K0ESZLrQRcFKhSWPYB1ehAytWCl1Gc4PXNYttZJ4fKK6pSiwq2ZcnHmlg==", new DateTime(2023, 9, 17, 17, 50, 52, 319, DateTimeKind.Local).AddTicks(5710), "9ed62bbe-9f1b-4263-9962-c7028de6c9b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6dc0238-4999-49e9-93c1-dfd243e36781",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4c00e051-79d6-4910-ae94-cfc4e6876ca4", "AQAAAAEAACcQAAAAEN5N85vX9v4Og06CNBb8qRbWzK9GMfwEhg4dJoJC+Okpk7SCjtPhiV13FNiST+/WXw==", new DateTime(2023, 9, 17, 17, 50, 52, 331, DateTimeKind.Local).AddTicks(3124), "186fff25-f1b8-406d-91bd-4b994e780cfd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9e4a9d6-96f3-40dd-8968-a30baa02ce9b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "4ca2b8d1-09ec-4eef-b714-f750cb32a884", "AQAAAAEAACcQAAAAEJNUcy8DsK0Hnr9qkVjZeMH1gtLA6sjtOcFFN0/WozmxoFkLLuPHxrhV3wnZV+aA9w==", new DateTime(2023, 9, 17, 17, 50, 52, 307, DateTimeKind.Local).AddTicks(5493), "22af121d-2597-4cec-8467-6d9b354d7f9a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acb6d047-97c5-4553-82cf-d6042362af1e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "8fe0fda9-de3b-426d-91c7-65af6a6c9f50", "AQAAAAEAACcQAAAAEFnGfoIuyXPXrs5SHUS8ch+vqUKBTxW78tI8t0dZv2wh1L7DISuDJrQ+sWWusy3MRQ==", new DateTime(2023, 9, 17, 17, 50, 52, 318, DateTimeKind.Local).AddTicks(4668), "3dd8036b-18d0-47f6-840d-b07b1159790a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2a83ec0-3fd0-4500-93b6-9fd1804db4fc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "e9678ace-c3b6-438b-9097-551ab243e96d", "AQAAAAEAACcQAAAAECBpjAHXrhWplHk6q07GHu2Kq0L9+roHQVM8yVxlqRwxpa825wiTleyrbx68Ge+itQ==", new DateTime(2023, 9, 17, 17, 50, 52, 320, DateTimeKind.Local).AddTicks(6410), "586c5eae-c15b-4014-a0d6-16b27f8846ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b87fc486-a805-4fad-89bd-c836281ce8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "b07be17a-6810-47f5-b3da-09c1dacedd6d", "AQAAAAEAACcQAAAAEIUkEV0JY713tdBQjd5S8kcfCGhZbsjY2Kh6AJY0habTZxRXP8kCVgjgY6NljaZllw==", new DateTime(2023, 9, 17, 17, 50, 52, 328, DateTimeKind.Local).AddTicks(1057), "40b772f5-a9aa-48ea-83b5-eba49d984421" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d966a121-573e-49ed-bf9b-5f677d0a4aa8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "32919525-8f41-4683-9830-11eb99c755a9", "AQAAAAEAACcQAAAAEPTgZzIE5Etfwsa7/SzzkBL3CC7r6GNwXVKuM/bO7Zlta0rFQTB8Eq09YzpB4Wqo3w==", new DateTime(2023, 9, 17, 17, 50, 52, 325, DateTimeKind.Local).AddTicks(9880), "a70b84bc-6b08-4caa-9040-249525a653c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f18ff312-2889-46df-a392-264b865a2c72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredOn", "SecurityStamp" },
                values: new object[] { "330faba3-2b5c-4305-9000-c08a8a0a513b", "AQAAAAEAACcQAAAAELVYGu7kxdcx8prj1paGWYG6ziDRPyl/GiItQz/EVnLFe2TH2R1oWkbOBA7ZBI30sg==", new DateTime(2023, 9, 17, 17, 50, 52, 312, DateTimeKind.Local).AddTicks(9971), "724b0ad4-6bca-4d04-9d1f-3ca383b11414" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2317));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedOn",
                value: new DateTime(2023, 9, 17, 17, 50, 52, 304, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 8, 27, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 8, 30, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2023, 9, 1, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2023, 9, 1, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2023, 9, 4, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2023, 9, 7, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2023, 9, 11, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2023, 9, 11, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                column: "OrderDate",
                value: new DateTime(2023, 9, 12, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                column: "OrderDate",
                value: new DateTime(2023, 9, 12, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                column: "OrderDate",
                value: new DateTime(2023, 9, 13, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                column: "OrderDate",
                value: new DateTime(2023, 9, 14, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                column: "OrderDate",
                value: new DateTime(2023, 9, 14, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                column: "OrderDate",
                value: new DateTime(2023, 9, 14, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                column: "OrderDate",
                value: new DateTime(2023, 9, 15, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 16,
                column: "OrderDate",
                value: new DateTime(2023, 9, 15, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 17,
                column: "OrderDate",
                value: new DateTime(2023, 9, 15, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 18,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 5, 50, 52, 337, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 19,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 21,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 17, 50, 52, 337, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 22,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 21, 50, 52, 337, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 23,
                column: "OrderDate",
                value: new DateTime(2023, 9, 16, 23, 50, 52, 337, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 24,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 1, 50, 52, 337, DateTimeKind.Local).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 25,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 2, 50, 52, 337, DateTimeKind.Local).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 26,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 2, 50, 52, 337, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 27,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 4, 50, 52, 337, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 28,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 7, 50, 52, 337, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 29,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 7, 50, 52, 337, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 9, 50, 52, 337, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 31,
                column: "OrderDate",
                value: new DateTime(2023, 9, 17, 12, 50, 52, 337, DateTimeKind.Local).AddTicks(8142));
        }
    }
}
