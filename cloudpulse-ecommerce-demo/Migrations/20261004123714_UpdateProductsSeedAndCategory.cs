using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cloudpulse_ecommerce_demo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductsSeedAndCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Products",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Volt Flow from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-1/600/600", "Volt Flow", 103.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Summit Runner from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-2/600/600", "Summit Runner", 106.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Pulse React from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-3/600/600", "Pulse React", 173.77m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Zenith Court 90s from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-4/600/600", "Zenith Court 90s", 163.24m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Street Runner from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-5/600/600", "Street Runner", 80.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Summit React from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-6/600/600", "Summit React", 112.58m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Nova Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-7/600/600", "Nova Vibe Low", 69.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Street Edge from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-8/600/600", "Street Edge", 168.2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Aero Horizon from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-9/600/600", "Aero Horizon", 162.52m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 10, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Volt Court 90s from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-10/600/600", "Volt Court 90s", 85.29m },
                    { 11, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Core Loafer from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-11/600/600", "Core Loafer", 131.26m },
                    { 12, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Street Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-12/600/600", "Street Vibe Low", 127.21m },
                    { 13, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Street Horizon from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-13/600/600", "Street Horizon", 65.63m },
                    { 14, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Volt Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-14/600/600", "Volt Vibe Low", 147.94m },
                    { 15, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trail React from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-15/600/600", "Trail React", 117.82m },
                    { 16, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-16/600/600", "Classic Vibe Low", 150.11m },
                    { 17, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Summit Edge from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-17/600/600", "Summit Edge", 116.6m },
                    { 18, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Nova Runner from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-18/600/600", "Nova Runner", 45.08m },
                    { 19, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pulse Street Pro from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-19/600/600", "Pulse Street Pro", 88.76m },
                    { 20, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Volt Street Pro from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-20/600/600", "Volt Street Pro", 47.63m },
                    { 21, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Trail Horizon from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-21/600/600", "Trail Horizon", 170.43m },
                    { 22, "Footwear", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "AirFlex Sneaker from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-22/600/600", "AirFlex Sneaker", 163.63m },
                    { 23, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Premium Jogger Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-23/600/600", "Premium Jogger Pants", 114.67m },
                    { 24, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Relaxed Wool Sweater from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-24/600/600", "Relaxed Wool Sweater", 124.08m },
                    { 25, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Premium Hoodie from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-25/600/600", "Premium Hoodie", 34.2m },
                    { 26, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Relaxed Denim Jacket from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-26/600/600", "Relaxed Denim Jacket", 44.91m },
                    { 27, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Heritage Flannel Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-27/600/600", "Heritage Flannel Shirt", 89.72m },
                    { 28, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tailored Flannel Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-28/600/600", "Tailored Flannel Shirt", 38.22m },
                    { 29, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Wool Sweater from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-29/600/600", "Modern Wool Sweater", 43.85m },
                    { 30, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Wool Sweater from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-30/600/600", "Classic Wool Sweater", 80.14m },
                    { 31, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Bomber Jacket from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-31/600/600", "Classic Bomber Jacket", 133.68m },
                    { 32, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Slim-Fit Crew Tee from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-32/600/600", "Slim-Fit Crew Tee", 29.8m },
                    { 33, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Slim-Fit Oxford Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-33/600/600", "Slim-Fit Oxford Shirt", 125.04m },
                    { 34, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Everyday Crew Tee from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-34/600/600", "Everyday Crew Tee", 131.28m },
                    { 35, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Premium Oxford Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-35/600/600", "Premium Oxford Shirt", 32.73m },
                    { 36, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Relaxed Chino Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-36/600/600", "Relaxed Chino Pants", 104.78m },
                    { 37, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Everyday Jogger Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-37/600/600", "Everyday Jogger Pants", 90.28m },
                    { 38, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Relaxed Hoodie from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-38/600/600", "Relaxed Hoodie", 21.92m },
                    { 39, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Relaxed Flannel Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-39/600/600", "Relaxed Flannel Shirt", 32.12m },
                    { 40, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Everyday Oxford Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-40/600/600", "Everyday Oxford Shirt", 117.96m },
                    { 41, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Everyday Bomber Jacket from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-41/600/600", "Everyday Bomber Jacket", 50.73m },
                    { 42, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Slim-Fit Polo Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-42/600/600", "Slim-Fit Polo Shirt", 72.83m },
                    { 43, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Heritage Chino Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-43/600/600", "Heritage Chino Pants", 82.58m },
                    { 44, "Men's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Slim-Fit Jogger Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-44/600/600", "Slim-Fit Jogger Pants", 132.4m },
                    { 45, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Flowy High-Waist Jeans from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-45/600/600", "Flowy High-Waist Jeans", 121.84m },
                    { 46, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Flowy Blouse from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-46/600/600", "Flowy Blouse", 105.42m },
                    { 47, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-47/600/600", "Minimalist Linen Pants", 160.1m },
                    { 48, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Knit Sweater from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-48/600/600", "Classic Knit Sweater", 40.02m },
                    { 49, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fitted Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-49/600/600", "Fitted Linen Pants", 152.33m },
                    { 50, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Knit Sweater from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-50/600/600", "Minimalist Knit Sweater", 63.35m },
                    { 51, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic High-Waist Jeans from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-51/600/600", "Classic High-Waist Jeans", 154.01m },
                    { 52, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fitted Cardigan from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-52/600/600", "Fitted Cardigan", 132.65m },
                    { 53, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fitted Wrap Top from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-53/600/600", "Fitted Wrap Top", 47.54m },
                    { 54, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Breezy Trench Coat from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-54/600/600", "Breezy Trench Coat", 65.85m },
                    { 55, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Elegant Wrap Top from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-55/600/600", "Elegant Wrap Top", 55.54m },
                    { 56, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Cardigan from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-56/600/600", "Minimalist Cardigan", 74.72m },
                    { 57, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chic Blouse from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-57/600/600", "Chic Blouse", 124.69m },
                    { 58, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Jumpsuit from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-58/600/600", "Minimalist Jumpsuit", 148.67m },
                    { 59, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-59/600/600", "Classic Linen Pants", 98.28m },
                    { 60, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Elegant Jumpsuit from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-60/600/600", "Elegant Jumpsuit", 61.41m },
                    { 61, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Flowy Wrap Top from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-61/600/600", "Flowy Wrap Top", 156.68m },
                    { 62, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Fitted Trench Coat from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-62/600/600", "Fitted Trench Coat", 32.37m },
                    { 63, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Breezy Knit Sweater from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-63/600/600", "Breezy Knit Sweater", 116.97m },
                    { 64, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Cardigan from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-64/600/600", "Classic Cardigan", 145.26m },
                    { 65, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bohemian Jumpsuit from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-65/600/600", "Bohemian Jumpsuit", 31.39m },
                    { 66, "Women's Clothing", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chic Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-66/600/600", "Chic Linen Pants", 73.37m },
                    { 67, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "HD Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-67/600/600", "HD Tablet Stand", 25.87m },
                    { 68, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wireless Power Bank from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-68/600/600", "Wireless Power Bank", 184.43m },
                    { 69, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Noise-Cancelling Bluetooth Speaker from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-69/600/600", "Noise-Cancelling Bluetooth Speaker", 113.18m },
                    { 70, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ultra Bluetooth Earbuds from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-70/600/600", "Ultra Bluetooth Earbuds", 238.35m },
                    { 71, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Portable Phone Charger from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-71/600/600", "Portable Phone Charger", 138.94m },
                    { 72, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Over-Ear Headphones from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-72/600/600", "Compact Over-Ear Headphones", 294.52m },
                    { 73, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Noise-Cancelling Wireless Mouse from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-73/600/600", "Noise-Cancelling Wireless Mouse", 47.84m },
                    { 74, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Portable Webcam from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-74/600/600", "Portable Webcam", 270.46m },
                    { 75, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "HD Smartwatch from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-75/600/600", "HD Smartwatch", 68.98m },
                    { 76, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Smartwatch from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-76/600/600", "Compact Smartwatch", 27.61m },
                    { 77, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Bluetooth Speaker from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-77/600/600", "Compact Bluetooth Speaker", 138.84m },
                    { 78, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ultra Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-78/600/600", "Ultra Tablet Stand", 162.66m },
                    { 79, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Power Bank from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-79/600/600", "Compact Power Bank", 244.05m },
                    { 80, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-80/600/600", "Compact Tablet Stand", 210.07m },
                    { 81, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Mechanical Keyboard from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-81/600/600", "Compact Mechanical Keyboard", 282.03m },
                    { 82, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "HD Over-Ear Headphones from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-82/600/600", "HD Over-Ear Headphones", 224.32m },
                    { 83, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wireless Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-83/600/600", "Wireless Tablet Stand", 70.96m },
                    { 84, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "HD Bluetooth Speaker from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-84/600/600", "HD Bluetooth Speaker", 137.49m },
                    { 85, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Smart Smartwatch from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-85/600/600", "Smart Smartwatch", 284.48m },
                    { 86, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "HD Bluetooth Earbuds from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-86/600/600", "HD Bluetooth Earbuds", 276.5m },
                    { 87, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Wireless Bluetooth Earbuds from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-87/600/600", "Wireless Bluetooth Earbuds", 191.98m },
                    { 88, "Electronics", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ultra Phone Charger from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-88/600/600", "Ultra Phone Charger", 203.4m },
                    { 89, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ceramic Tea Kettle from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-89/600/600", "Ceramic Tea Kettle", 178.69m },
                    { 90, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-90/600/600", "Modern Knife Set", 150.86m },
                    { 91, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-91/600/600", "Compact Dinnerware Set", 217.48m },
                    { 92, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Non-Stick Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-92/600/600", "Non-Stick Dinnerware Set", 135.85m },
                    { 93, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Non-Stick Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-93/600/600", "Non-Stick Knife Set", 209.61m },
                    { 94, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Toaster from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-94/600/600", "Compact Toaster", 197.42m },
                    { 95, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stainless Steel Storage Containers from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-95/600/600", "Stainless Steel Storage Containers", 139.43m },
                    { 96, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bamboo Cutting Board from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-96/600/600", "Bamboo Cutting Board", 161.61m },
                    { 97, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Non-Stick Toaster from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-97/600/600", "Non-Stick Toaster", 116.99m },
                    { 98, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ceramic Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-98/600/600", "Ceramic Knife Set", 184.76m },
                    { 99, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Electric Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-99/600/600", "Electric Dinnerware Set", 125.96m },
                    { 100, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Toaster from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-100/600/600", "Classic Toaster", 198.62m },
                    { 101, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Electric Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-101/600/600", "Electric Knife Set", 166.68m },
                    { 102, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stainless Steel Cutting Board from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-102/600/600", "Stainless Steel Cutting Board", 110.73m },
                    { 103, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-103/600/600", "Classic Dinnerware Set", 65.91m },
                    { 104, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ceramic Blender from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-104/600/600", "Ceramic Blender", 63.43m },
                    { 105, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Storage Containers from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-105/600/600", "Classic Storage Containers", 144.63m },
                    { 106, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bamboo Storage Containers from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-106/600/600", "Bamboo Storage Containers", 171.29m },
                    { 107, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Electric Tea Kettle from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-107/600/600", "Electric Tea Kettle", 120.43m },
                    { 108, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Blender from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-108/600/600", "Modern Blender", 142.36m },
                    { 109, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ceramic Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-109/600/600", "Ceramic Dinnerware Set", 69.12m },
                    { 110, "Home & Kitchen", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Tea Kettle from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-110/600/600", "Compact Tea Kettle", 28.12m },
                    { 111, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Refreshing Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-111/600/600", "Refreshing Facial Cleanser", 74.23m },
                    { 112, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gentle Body Lotion from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-112/600/600", "Gentle Body Lotion", 40.98m },
                    { 113, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Soothing Face Serum from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-113/600/600", "Soothing Face Serum", 73.42m },
                    { 114, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Organic Sunscreen from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-114/600/600", "Organic Sunscreen", 80.38m },
                    { 115, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gentle Face Serum from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-115/600/600", "Gentle Face Serum", 29.95m },
                    { 116, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Soothing Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-116/600/600", "Soothing Perfume", 15.13m },
                    { 117, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Radiant Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-117/600/600", "Radiant Perfume", 9.69m },
                    { 118, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Soothing Makeup Brush Set from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-118/600/600", "Soothing Makeup Brush Set", 54.93m },
                    { 119, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gentle Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-119/600/600", "Gentle Perfume", 94.99m },
                    { 120, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Organic Moisturizer from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-120/600/600", "Organic Moisturizer", 38.45m },
                    { 121, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hydrating Hair Mask from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-121/600/600", "Hydrating Hair Mask", 64.56m },
                    { 122, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hydrating Shampoo from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-122/600/600", "Hydrating Shampoo", 75.97m },
                    { 123, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hydrating Sunscreen from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-123/600/600", "Hydrating Sunscreen", 64.7m },
                    { 124, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gentle Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-124/600/600", "Gentle Facial Cleanser", 73.62m },
                    { 125, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Radiant Body Lotion from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-125/600/600", "Radiant Body Lotion", 90.62m },
                    { 126, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Organic Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-126/600/600", "Organic Perfume", 25.34m },
                    { 127, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Nourishing Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-127/600/600", "Nourishing Perfume", 9.77m },
                    { 128, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gentle Hair Mask from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-128/600/600", "Gentle Hair Mask", 21.26m },
                    { 129, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Refreshing Body Lotion from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-129/600/600", "Refreshing Body Lotion", 18.98m },
                    { 130, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Soothing Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-130/600/600", "Soothing Facial Cleanser", 66.24m },
                    { 131, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Nourishing Shampoo from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-131/600/600", "Nourishing Shampoo", 57.07m },
                    { 132, "Beauty & Personal Care", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hydrating Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-132/600/600", "Hydrating Facial Cleanser", 26.96m },
                    { 133, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pro Hiking Backpack from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-133/600/600", "Pro Hiking Backpack", 209.38m },
                    { 134, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All-Terrain Resistance Bands from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-134/600/600", "All-Terrain Resistance Bands", 30.8m },
                    { 135, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Durable Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-135/600/600", "Durable Cycling Helmet", 221.59m },
                    { 136, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lightweight Sleeping Bag from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-136/600/600", "Lightweight Sleeping Bag", 68.53m },
                    { 137, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pro Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-137/600/600", "Pro Cycling Helmet", 121.53m },
                    { 138, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Performance Yoga Mat from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-138/600/600", "Performance Yoga Mat", 156.48m },
                    { 139, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All-Terrain Dumbbell Set from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-139/600/600", "All-Terrain Dumbbell Set", 100.96m },
                    { 140, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All-Terrain Water Bottle from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-140/600/600", "All-Terrain Water Bottle", 16.89m },
                    { 141, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All-Terrain Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-141/600/600", "All-Terrain Cycling Helmet", 214.23m },
                    { 142, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Performance Resistance Bands from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-142/600/600", "Performance Resistance Bands", 53.64m },
                    { 143, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Durable Fitness Tracker from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-143/600/600", "Durable Fitness Tracker", 60.91m },
                    { 144, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pro Sleeping Bag from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-144/600/600", "Pro Sleeping Bag", 201.48m },
                    { 145, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All-Terrain Yoga Mat from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-145/600/600", "All-Terrain Yoga Mat", 91.68m },
                    { 146, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Adjustable Fitness Tracker from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-146/600/600", "Adjustable Fitness Tracker", 221.28m },
                    { 147, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "All-Terrain Hiking Backpack from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-147/600/600", "All-Terrain Hiking Backpack", 178.28m },
                    { 148, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Durable Water Bottle from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-148/600/600", "Durable Water Bottle", 76.3m },
                    { 149, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lightweight Dumbbell Set from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-149/600/600", "Lightweight Dumbbell Set", 12.44m },
                    { 150, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Adjustable Jump Rope from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-150/600/600", "Adjustable Jump Rope", 237.54m },
                    { 151, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Adjustable Sleeping Bag from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-151/600/600", "Adjustable Sleeping Bag", 30.55m },
                    { 152, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pro Water Bottle from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-152/600/600", "Pro Water Bottle", 182.82m },
                    { 153, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Performance Camping Tent from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-153/600/600", "Performance Camping Tent", 127.26m },
                    { 154, "Sports & Outdoors", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Adjustable Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-154/600/600", "Adjustable Cycling Helmet", 191.96m },
                    { 155, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Complete Photography from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-155/600/600", "Complete Photography", 39.18m },
                    { 156, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Timeless Gardening from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-156/600/600", "Timeless Gardening", 25.71m },
                    { 157, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Practical Travel Writing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-157/600/600", "Practical Travel Writing", 30.32m },
                    { 158, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Practical Coding from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-158/600/600", "Practical Coding", 12.04m },
                    { 159, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Complete Coding from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-159/600/600", "Complete Coding", 35.79m },
                    { 160, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Timeless Productivity from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-160/600/600", "Timeless Productivity", 23.71m },
                    { 161, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Art of Storytelling from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-161/600/600", "The Art of Storytelling", 35.93m },
                    { 162, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Mindfulness from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-162/600/600", "Modern Mindfulness", 26.37m },
                    { 163, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Art of Cooking from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-163/600/600", "The Art of Cooking", 23.02m },
                    { 164, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Complete Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-164/600/600", "Complete Investing", 22.1m },
                    { 165, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Cooking from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-165/600/600", "Modern Cooking", 13.9m },
                    { 166, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Art of Photography from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-166/600/600", "The Art of Photography", 9.64m },
                    { 167, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Essential Photography from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-167/600/600", "Essential Photography", 38.11m },
                    { 168, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Productivity from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-168/600/600", "Modern Productivity", 23.29m },
                    { 169, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Timeless Cooking from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-169/600/600", "Timeless Cooking", 34.31m },
                    { 170, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Art of Coding from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-170/600/600", "The Art of Coding", 20.82m },
                    { 171, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-171/600/600", "Modern Investing", 10.37m },
                    { 172, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Timeless Design from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-172/600/600", "Timeless Design", 28.14m },
                    { 173, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Practical Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-173/600/600", "Practical Investing", 9.72m },
                    { 174, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Essential Storytelling from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-174/600/600", "Essential Storytelling", 12.77m },
                    { 175, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Essential Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-175/600/600", "Essential Investing", 26.01m },
                    { 176, "Books", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Timeless Mindfulness from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-176/600/600", "Timeless Mindfulness", 17.72m },
                    { 177, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mini Art Kit from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-177/600/600", "Mini Art Kit", 14.07m },
                    { 178, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Educational Card Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-178/600/600", "Educational Card Game", 20.78m },
                    { 179, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Card Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-179/600/600", "Classic Card Game", 30.84m },
                    { 180, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mini Board Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-180/600/600", "Mini Board Game", 62.18m },
                    { 181, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Interactive Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-181/600/600", "Interactive Puzzle", 49.41m },
                    { 182, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Educational Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-182/600/600", "Educational Puzzle", 29.49m },
                    { 183, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Deluxe Art Kit from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-183/600/600", "Deluxe Art Kit", 17.83m },
                    { 184, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mini Plush Toy from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-184/600/600", "Mini Plush Toy", 57.9m },
                    { 185, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Educational Board Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-185/600/600", "Educational Board Game", 58.68m },
                    { 186, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Colorful Remote Control Car from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-186/600/600", "Colorful Remote Control Car", 75.93m },
                    { 187, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Interactive Art Kit from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-187/600/600", "Interactive Art Kit", 44.53m },
                    { 188, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Remote Control Car from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-188/600/600", "Classic Remote Control Car", 44.06m },
                    { 189, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Deluxe Plush Toy from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-189/600/600", "Deluxe Plush Toy", 14.71m },
                    { 190, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Colorful Board Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-190/600/600", "Colorful Board Game", 11.83m },
                    { 191, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Interactive Plush Toy from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-191/600/600", "Interactive Plush Toy", 39.67m },
                    { 192, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mini Toy Train Set from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-192/600/600", "Mini Toy Train Set", 31.88m },
                    { 193, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Interactive Play Kitchen from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-193/600/600", "Interactive Play Kitchen", 26.78m },
                    { 194, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Interactive Building Blocks Set from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-194/600/600", "Interactive Building Blocks Set", 15.48m },
                    { 195, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Deluxe Card Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-195/600/600", "Deluxe Card Game", 77.3m },
                    { 196, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-196/600/600", "Classic Puzzle", 68.35m },
                    { 197, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Play Kitchen from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-197/600/600", "Classic Play Kitchen", 49.84m },
                    { 198, "Toys & Games", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Colorful Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-198/600/600", "Colorful Puzzle", 76.51m },
                    { 199, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Baseball Cap from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-199/600/600", "Modern Baseball Cap", 104.27m },
                    { 200, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Belt from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-200/600/600", "Classic Belt", 167.85m },
                    { 201, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Woven Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-201/600/600", "Woven Keychain", 85.6m },
                    { 202, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vintage Crossbody Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-202/600/600", "Vintage Crossbody Bag", 129.31m },
                    { 203, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vintage Watch from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-203/600/600", "Vintage Watch", 32.4m },
                    { 204, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Scarf from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-204/600/600", "Minimalist Scarf", 175.49m },
                    { 205, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Leather Tote Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-205/600/600", "Leather Tote Bag", 114.29m },
                    { 206, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vintage Sunglasses from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-206/600/600", "Vintage Sunglasses", 52.2m },
                    { 207, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Watch from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-207/600/600", "Classic Watch", 38.61m },
                    { 208, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-208/600/600", "Classic Keychain", 104.54m },
                    { 209, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Woven Tote Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-209/600/600", "Woven Tote Bag", 104.78m },
                    { 210, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Leather Crossbody Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-210/600/600", "Leather Crossbody Bag", 27.66m },
                    { 211, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-211/600/600", "Minimalist Keychain", 178.7m },
                    { 212, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Belt from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-212/600/600", "Minimalist Belt", 165.37m },
                    { 213, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Baseball Cap from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-213/600/600", "Minimalist Baseball Cap", 89.52m },
                    { 214, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Leather Wallet from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-214/600/600", "Leather Wallet", 31.73m },
                    { 215, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Crossbody Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-215/600/600", "Modern Crossbody Bag", 151.8m },
                    { 216, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Leather Belt from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-216/600/600", "Leather Belt", 95.73m },
                    { 217, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Woven Watch from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-217/600/600", "Woven Watch", 132.39m },
                    { 218, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Leather Baseball Cap from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-218/600/600", "Leather Baseball Cap", 97.49m },
                    { 219, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vintage Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-219/600/600", "Vintage Keychain", 57.94m },
                    { 220, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Tote Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-220/600/600", "Modern Tote Bag", 152.23m },
                    { 221, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Bedside Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-221/600/600", "Modern Bedside Table", 80.88m },
                    { 222, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-222/600/600", "Minimalist Storage Ottoman", 413.28m },
                    { 223, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Dining Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-223/600/600", "Minimalist Dining Table", 46.29m },
                    { 224, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-224/600/600", "Industrial Storage Ottoman", 99.1m },
                    { 225, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Accent Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-225/600/600", "Modern Accent Chair", 397.08m },
                    { 226, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist TV Stand from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-226/600/600", "Minimalist TV Stand", 437.68m },
                    { 227, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-227/600/600", "Classic Storage Ottoman", 70.68m },
                    { 228, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Bookshelf from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-228/600/600", "Minimalist Bookshelf", 360.43m },
                    { 229, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Office Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-229/600/600", "Minimalist Office Chair", 148.66m },
                    { 230, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Bookshelf from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-230/600/600", "Modern Bookshelf", 295.54m },
                    { 231, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-231/600/600", "Compact Storage Ottoman", 202.97m },
                    { 232, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Bookshelf from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-232/600/600", "Classic Bookshelf", 72.93m },
                    { 233, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic Desk from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-233/600/600", "Classic Desk", 174.71m },
                    { 234, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Scandinavian Office Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-234/600/600", "Scandinavian Office Chair", 316.49m },
                    { 235, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Coffee Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-235/600/600", "Compact Coffee Table", 258.79m },
                    { 236, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Classic TV Stand from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-236/600/600", "Classic TV Stand", 431.2m },
                    { 237, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Scandinavian Accent Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-237/600/600", "Scandinavian Accent Chair", 296.99m },
                    { 238, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Modern Coffee Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-238/600/600", "Modern Coffee Table", 403.85m },
                    { 239, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Compact Bedside Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-239/600/600", "Compact Bedside Table", 240.06m },
                    { 240, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Scandinavian Bedside Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-240/600/600", "Scandinavian Bedside Table", 261.82m },
                    { 241, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Scandinavian Desk from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-241/600/600", "Scandinavian Desk", 293.16m },
                    { 242, "Furniture", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Minimalist Coffee Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-242/600/600", "Minimalist Coffee Table", 136.26m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Products",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Running", "Ultra-responsive cushioning with breathable mesh upper. Designed for all-day urban agility and high performance.", "https://images.unsplash.com/photo-1542291026-7eec264c27ff?auto=format&fit=crop&w=800&q=80", "CloudPulse Apex Runner", 149.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sneakers", "Clean, understated court silhouette crafted from buttery Italian leather with vulcanized gum sole.", "https://images.unsplash.com/photo-1549298916-b41d501d3772?auto=format&fit=crop&w=800&q=80", "Retro Court Minimalist", 129.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Boots", "Hand-stitched premium water-resistant suede with ergonomic elastic side gussets and Goodyear welt.", "https://images.unsplash.com/photo-1608256246200-53e635b5b65f?auto=format&fit=crop&w=800&q=80", "Amber Suede Chelsea Boot", 189.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Running", "Engineered knit mesh upper paired with high-rebound nitrogen-infused foam sole for marathon comfort.", "https://images.unsplash.com/photo-1551107696-a4b0c5a0d9a2?auto=format&fit=crop&w=800&q=80", "Veloce Air Stride 02", 165.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Casual", "Timeless skate-inspired low-top with reinforced canvas, contrast stitching, and memory-foam insole.", "https://images.unsplash.com/photo-1525966222134-fcfa99b8ae77?auto=format&fit=crop&w=800&q=80", "Mono Horizon Low-Top", 115.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Loafers", "Polished calfskin leather with traditional moc-toe stitching and stacked leather heel. Effortlessly elevated.", "https://images.unsplash.com/photo-1533867617858-e7b97e060509?auto=format&fit=crop&w=800&q=80", "Artisan Leather Penny Loafer", 210.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Boots", "Vibram-lugged outsole with waterproof breathable membrane. Built for rugged trails and city winters.", "https://images.unsplash.com/photo-1520639888713-7851133b1ed0?auto=format&fit=crop&w=800&q=80", "TrailMaster All-Weather Hiker", 195.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sneakers", "Weightless slip-on sock sneaker engineered with recycled stretch yarn and shock-absorbing outsole.", "https://images.unsplash.com/photo-1560769629-975ec94e6a86?auto=format&fit=crop&w=800&q=80", "Aero Glide Knit Slip-On", 98.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Casual", "Hand-burnished cognac leather with wingtip perforations. Refined formal footwear built to last decades.", "https://images.unsplash.com/photo-1614252235316-8c857d38b5f4?auto=format&fit=crop&w=800&q=80", "Oxford Heritage Brogue", 225.00m });
        }
    }
}
