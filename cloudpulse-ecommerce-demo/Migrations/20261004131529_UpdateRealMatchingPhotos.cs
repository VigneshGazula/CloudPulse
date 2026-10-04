using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace cloudpulse_ecommerce_demo.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRealMatchingPhotos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "The Essence Mascara Lash Princess is a popular mascara known for its volumizing and lengthening effects. Achieve dramatic lashes with this long-lasting and cruelty-free formula.", "https://cdn.dummyjson.com/product-images/beauty/essence-mascara-lash-princess/1.webp", "Essence Mascara Lash Princess", 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "The Eyeshadow Palette with Mirror offers a versatile range of eyeshadow shades for creating stunning eye looks. With a built-in mirror, it's convenient for on-the-go makeup application.", "https://cdn.dummyjson.com/product-images/beauty/eyeshadow-palette-with-mirror/1.webp", "Eyeshadow Palette with Mirror", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "The Powder Canister is a finely milled setting powder designed to set makeup and control shine. With a lightweight and translucent formula, it provides a smooth and matte finish.", "https://cdn.dummyjson.com/product-images/beauty/powder-canister/1.webp", "Powder Canister", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "The Red Lipstick is a classic and bold choice for adding a pop of color to your lips. With a creamy and pigmented formula, it provides a vibrant and long-lasting finish.", "https://cdn.dummyjson.com/product-images/beauty/red-lipstick/1.webp", "Red Lipstick", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "The Red Nail Polish offers a rich and glossy red hue for vibrant and polished nails. With a quick-drying formula, it provides a salon-quality finish at home.", "https://cdn.dummyjson.com/product-images/beauty/red-nail-polish/1.webp", "Red Nail Polish", 8.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "CK One by Calvin Klein is a classic unisex fragrance, known for its fresh and clean scent. It's a versatile fragrance suitable for everyday wear.", "https://cdn.dummyjson.com/product-images/fragrances/calvin-klein-ck-one/1.webp", "Calvin Klein CK One", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Coco Noir by Chanel is an elegant and mysterious fragrance, featuring notes of grapefruit, rose, and sandalwood. Perfect for evening occasions.", "https://cdn.dummyjson.com/product-images/fragrances/chanel-coco-noir-eau-de/1.webp", "Chanel Coco Noir Eau De", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "J'adore by Dior is a luxurious and floral fragrance, known for its blend of ylang-ylang, rose, and jasmine. It embodies femininity and sophistication.", "https://cdn.dummyjson.com/product-images/fragrances/dior-j'adore/1.webp", "Dior J'adore", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Dolce Shine by Dolce & Gabbana is a vibrant and fruity fragrance, featuring notes of mango, jasmine, and blonde woods. It's a joyful and youthful scent.", "https://cdn.dummyjson.com/product-images/fragrances/dolce-shine-eau-de/1.webp", "Dolce Shine Eau de", 69.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Gucci Bloom by Gucci is a floral and captivating fragrance, with notes of tuberose, jasmine, and Rangoon creeper. It's a modern and romantic scent.", "https://cdn.dummyjson.com/product-images/fragrances/gucci-bloom-eau-de/1.webp", "Gucci Bloom Eau de", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "The Annibale Colombo Bed is a luxurious and elegant bed frame, crafted with high-quality materials for a comfortable and stylish bedroom.", "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-bed/1.webp", "Annibale Colombo Bed", 1899.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "The Annibale Colombo Sofa is a sophisticated and comfortable seating option, featuring exquisite design and premium upholstery for your living room.", "https://cdn.dummyjson.com/product-images/furniture/annibale-colombo-sofa/1.webp", "Annibale Colombo Sofa", 2499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "The Bedside Table in African Cherry is a stylish and functional addition to your bedroom, providing convenient storage space and a touch of elegance.", "https://cdn.dummyjson.com/product-images/furniture/bedside-table-african-cherry/1.webp", "Bedside Table African Cherry", 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "The Knoll Saarinen Executive Conference Chair is a modern and ergonomic chair, perfect for your office or conference room with its timeless design.", "https://cdn.dummyjson.com/product-images/furniture/knoll-saarinen-executive-conference-chair/1.webp", "Knoll Saarinen Executive Conference Chair", 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "The Wooden Bathroom Sink with Mirror is a unique and stylish addition to your bathroom, featuring a wooden sink countertop and a matching mirror.", "https://cdn.dummyjson.com/product-images/furniture/wooden-bathroom-sink-with-mirror/1.webp", "Wooden Bathroom Sink With Mirror", 799.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Fresh and crisp apples, perfect for snacking or incorporating into various recipes.", "https://cdn.dummyjson.com/product-images/groceries/apple/1.webp", "Apple", 1.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "High-quality beef steak, great for grilling or cooking to your preferred level of doneness.", "https://cdn.dummyjson.com/product-images/groceries/beef-steak/1.webp", "Beef Steak", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Nutritious cat food formulated to meet the dietary needs of your feline friend.", "https://cdn.dummyjson.com/product-images/groceries/cat-food/1.webp", "Cat Food", 8.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Fresh and tender chicken meat, suitable for various culinary preparations.", "https://cdn.dummyjson.com/product-images/groceries/chicken-meat/1.webp", "Chicken Meat", 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Versatile cooking oil suitable for frying, sautéing, and various culinary applications.", "https://cdn.dummyjson.com/product-images/groceries/cooking-oil/1.webp", "Cooking Oil", 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Crisp and hydrating cucumbers, ideal for salads, snacks, or as a refreshing side.", "https://cdn.dummyjson.com/product-images/groceries/cucumber/1.webp", "Cucumber", 1.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Specially formulated dog food designed to provide essential nutrients for your canine companion.", "https://cdn.dummyjson.com/product-images/groceries/dog-food/1.webp", "Dog Food", 10.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Fresh eggs, a versatile ingredient for baking, cooking, or breakfast.", "https://cdn.dummyjson.com/product-images/groceries/eggs/1.webp", "Eggs", 2.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Quality fish steak, suitable for grilling, baking, or pan-searing.", "https://cdn.dummyjson.com/product-images/groceries/fish-steak/1.webp", "Fish Steak", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Fresh and vibrant green bell pepper, perfect for adding color and flavor to your dishes.", "https://cdn.dummyjson.com/product-images/groceries/green-bell-pepper/1.webp", "Green Bell Pepper", 1.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Spicy green chili pepper, ideal for adding heat to your favorite recipes.", "https://cdn.dummyjson.com/product-images/groceries/green-chili-pepper/1.webp", "Green Chili Pepper", 0.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Pure and natural honey in a convenient jar, perfect for sweetening beverages or drizzling over food.", "https://cdn.dummyjson.com/product-images/groceries/honey-jar/1.webp", "Honey Jar", 6.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Creamy and delicious ice cream, available in various flavors for a delightful treat.", "https://cdn.dummyjson.com/product-images/groceries/ice-cream/1.webp", "Ice Cream", 5.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Refreshing fruit juice, packed with vitamins and great for staying hydrated.", "https://cdn.dummyjson.com/product-images/groceries/juice/1.webp", "Juice", 3.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Nutrient-rich kiwi, perfect for snacking or adding a tropical twist to your dishes.", "https://cdn.dummyjson.com/product-images/groceries/kiwi/1.webp", "Kiwi", 2.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Zesty and tangy lemons, versatile for cooking, baking, or making refreshing beverages.", "https://cdn.dummyjson.com/product-images/groceries/lemon/1.webp", "Lemon", 0.79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Fresh and nutritious milk, a staple for various recipes and daily consumption.", "https://cdn.dummyjson.com/product-images/groceries/milk/1.webp", "Milk", 3.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Sweet and juicy mulberries, perfect for snacking or adding to desserts and cereals.", "https://cdn.dummyjson.com/product-images/groceries/mulberry/1.webp", "Mulberry", 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Quality coffee from Nescafe, available in various blends for a rich and satisfying cup.", "https://cdn.dummyjson.com/product-images/groceries/nescafe-coffee/1.webp", "Nescafe Coffee", 7.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Versatile and starchy potatoes, great for roasting, mashing, or as a side dish.", "https://cdn.dummyjson.com/product-images/groceries/potatoes/1.webp", "Potatoes", 2.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Nutrient-packed protein powder, ideal for supplementing your diet with essential proteins.", "https://cdn.dummyjson.com/product-images/groceries/protein-powder/1.webp", "Protein Powder", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Flavorful and aromatic red onions, perfect for adding depth to your savory dishes.", "https://cdn.dummyjson.com/product-images/groceries/red-onions/1.webp", "Red Onions", 1.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "High-quality rice, a staple for various cuisines and a versatile base for many dishes.", "https://cdn.dummyjson.com/product-images/groceries/rice/1.webp", "Rice", 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Assorted soft drinks in various flavors, perfect for refreshing beverages.", "https://cdn.dummyjson.com/product-images/groceries/soft-drinks/1.webp", "Soft Drinks", 1.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Sweet and succulent strawberries, great for snacking, desserts, or blending into smoothies.", "https://cdn.dummyjson.com/product-images/groceries/strawberry/1.webp", "Strawberry", 3.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Convenient tissue paper box for everyday use, providing soft and absorbent tissues.", "https://cdn.dummyjson.com/product-images/groceries/tissue-paper-box/1.webp", "Tissue Paper Box", 2.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "Pure and refreshing bottled water, essential for staying hydrated throughout the day.", "https://cdn.dummyjson.com/product-images/groceries/water/1.webp", "Water", 0.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Decoration Swing is a charming addition to your home decor. Crafted with intricate details, it adds a touch of elegance and whimsy to any room.", "https://cdn.dummyjson.com/product-images/home-decoration/decoration-swing/1.webp", "Decoration Swing", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Family Tree Photo Frame is a sentimental and stylish way to display your cherished family memories. With multiple photo slots, it tells the story of your loved ones.", "https://cdn.dummyjson.com/product-images/home-decoration/family-tree-photo-frame/1.webp", "Family Tree Photo Frame", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The House Showpiece Plant is an artificial plant that brings a touch of nature to your home without the need for maintenance. It adds greenery and style to any space.", "https://cdn.dummyjson.com/product-images/home-decoration/house-showpiece-plant/1.webp", "House Showpiece Plant", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Plant Pot is a stylish container for your favorite plants. With a sleek design, it complements your indoor or outdoor garden, adding a modern touch to your plant display.", "https://cdn.dummyjson.com/product-images/home-decoration/plant-pot/1.webp", "Plant Pot", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Table Lamp is a functional and decorative lighting solution for your living space. With a modern design, it provides both ambient and task lighting, enhancing the atmosphere.", "https://cdn.dummyjson.com/product-images/home-decoration/table-lamp/1.webp", "Table Lamp", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Bamboo Spatula is a versatile kitchen tool made from eco-friendly bamboo. Ideal for flipping, stirring, and serving various dishes.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/bamboo-spatula/1.webp", "Bamboo Spatula", 7.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Black Aluminium Cup is a stylish and durable cup suitable for both hot and cold beverages. Its sleek black design adds a modern touch to your drinkware collection.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/black-aluminium-cup/1.webp", "Black Aluminium Cup", 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Black Whisk is a kitchen essential for whisking and beating ingredients. Its ergonomic handle and sleek design make it a practical and stylish tool.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/black-whisk/1.webp", "Black Whisk", 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Boxed Blender is a powerful and compact blender perfect for smoothies, shakes, and more. Its convenient design and multiple functions make it a versatile kitchen appliance.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/boxed-blender/1.webp", "Boxed Blender", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Carbon Steel Wok is a versatile cooking pan suitable for stir-frying, sautéing, and deep frying. Its sturdy construction ensures even heat distribution for delicious meals.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/carbon-steel-wok/1.webp", "Carbon Steel Wok", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Chopping Board is an essential kitchen accessory for food preparation. Made from durable material, it provides a safe and hygienic surface for cutting and chopping.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/chopping-board/1.webp", "Chopping Board", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Citrus Squeezer in Yellow is a handy tool for extracting juice from citrus fruits. Its vibrant color adds a cheerful touch to your kitchen gadgets.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/citrus-squeezer-yellow/1.webp", "Citrus Squeezer Yellow", 8.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Egg Slicer is a convenient tool for slicing boiled eggs evenly. It's perfect for salads, sandwiches, and other dishes where sliced eggs are desired.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/egg-slicer/1.webp", "Egg Slicer", 6.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Electric Stove provides a portable and efficient cooking solution. Ideal for small kitchens or as an additional cooking surface for various culinary needs.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/electric-stove/1.webp", "Electric Stove", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Fine Mesh Strainer is a versatile tool for straining liquids and sifting dry ingredients. Its fine mesh ensures efficient filtering for smooth cooking and baking.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/fine-mesh-strainer/1.webp", "Fine Mesh Strainer", 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Fork is a classic utensil for various dining and serving purposes. Its durable and ergonomic design makes it a reliable choice for everyday use.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/fork/1.webp", "Fork", 3.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Glass is a versatile and elegant drinking vessel suitable for a variety of beverages. Its clear design allows you to enjoy the colors and textures of your drinks.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/glass/1.webp", "Glass", 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Grater in Black is a handy kitchen tool for grating cheese, vegetables, and more. Its sleek design and sharp blades make food preparation efficient and easy.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/grater-black/1.webp", "Grater Black", 10.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Hand Blender is a versatile kitchen appliance for blending, pureeing, and mixing. Its compact design and powerful motor make it a convenient tool for various recipes.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/hand-blender/1.webp", "Hand Blender", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Ice Cube Tray is a practical accessory for making ice cubes in various shapes. Perfect for keeping your drinks cool and adding a fun element to your beverages.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/ice-cube-tray/1.webp", "Ice Cube Tray", 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Kitchen Sieve is a versatile tool for sifting and straining dry and wet ingredients. Its fine mesh design ensures smooth results in your cooking and baking.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/kitchen-sieve/1.webp", "Kitchen Sieve", 7.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Knife is an essential kitchen tool for chopping, slicing, and dicing. Its sharp blade and ergonomic handle make it a reliable choice for food preparation.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/knife/1.webp", "Knife", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Lunch Box is a convenient and portable container for packing and carrying your meals. With compartments for different foods, it's perfect for on-the-go dining.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/lunch-box/1.webp", "Lunch Box", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Microwave Oven is a versatile kitchen appliance for quick and efficient cooking, reheating, and defrosting. Its compact size makes it suitable for various kitchen setups.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/microwave-oven/1.webp", "Microwave Oven", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Mug Tree Stand is a stylish and space-saving solution for organizing your mugs. Keep your favorite mugs easily accessible and neatly displayed in your kitchen.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/mug-tree-stand/1.webp", "Mug Tree Stand", 15.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Pan is a versatile and essential cookware item for frying, sautéing, and cooking various dishes. Its non-stick coating ensures easy food release and cleanup.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/pan/1.webp", "Pan", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Plate is a classic and essential dishware item for serving meals. Its durable and stylish design makes it suitable for everyday use or special occasions.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/plate/1.webp", "Plate", 3.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Red Tongs are versatile kitchen tongs suitable for various cooking and serving tasks. Their vibrant color adds a pop of excitement to your kitchen utensils.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/red-tongs/1.webp", "Red Tongs", 6.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Silver Pot with Glass Cap is a stylish and functional cookware item for boiling, simmering, and preparing delicious meals. Its glass cap allows you to monitor cooking progress.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/silver-pot-with-glass-cap/1.webp", "Silver Pot With Glass Cap", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Slotted Turner is a kitchen utensil designed for flipping and turning food items. Its slotted design allows excess liquid to drain, making it ideal for frying and sautéing.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/slotted-turner/1.webp", "Slotted Turner", 8.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Spice Rack is a convenient organizer for your spices and seasonings. Keep your kitchen essentials within reach and neatly arranged with this stylish spice rack.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/spice-rack/1.webp", "Spice Rack", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Spoon is a versatile kitchen utensil for stirring, serving, and tasting. Its ergonomic design and durable construction make it an essential tool for every kitchen.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/spoon/1.webp", "Spoon", 4.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Tray is a functional and decorative item for serving snacks, appetizers, or drinks. Its stylish design makes it a versatile accessory for entertaining guests.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/tray/1.webp", "Tray", 16.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Wooden Rolling Pin is a classic kitchen tool for rolling out dough for baking. Its smooth surface and sturdy handles make it easy to achieve uniform thickness.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/wooden-rolling-pin/1.webp", "Wooden Rolling Pin", 11.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "The Yellow Peeler is a handy tool for peeling fruits and vegetables with ease. Its bright yellow color adds a cheerful touch to your kitchen gadgets.", "https://cdn.dummyjson.com/product-images/kitchen-accessories/yellow-peeler/1.webp", "Yellow Peeler", 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The MacBook Pro 14 Inch in Space Grey is a powerful and sleek laptop, featuring Apple's M1 Pro chip for exceptional performance and a stunning Retina display.", "https://cdn.dummyjson.com/product-images/laptops/apple-macbook-pro-14-inch-space-grey/1.webp", "Apple MacBook Pro 14 Inch Space Grey", 1999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Asus Zenbook Pro Dual Screen Laptop is a high-performance device with dual screens, providing productivity and versatility for creative professionals.", "https://cdn.dummyjson.com/product-images/laptops/asus-zenbook-pro-dual-screen-laptop/1.webp", "Asus Zenbook Pro Dual Screen Laptop", 1799.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Huawei Matebook X Pro is a slim and stylish laptop with a high-resolution touchscreen display, offering a premium experience for users on the go.", "https://cdn.dummyjson.com/product-images/laptops/huawei-matebook-x-pro/1.webp", "Huawei Matebook X Pro", 1399.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Lenovo Yoga 920 is a 2-in-1 convertible laptop with a flexible hinge, allowing you to use it as a laptop or tablet, offering versatility and portability.", "https://cdn.dummyjson.com/product-images/laptops/lenovo-yoga-920/1.webp", "Lenovo Yoga 920", 1099.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The New DELL XPS 13 9300 Laptop is a compact and powerful device, featuring a virtually borderless InfinityEdge display and high-end performance for various tasks.", "https://cdn.dummyjson.com/product-images/laptops/new-dell-xps-13-9300-laptop/1.webp", "New DELL XPS 13 9300 Laptop", 1499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Blue & Black Check Shirt is a stylish and comfortable men's shirt featuring a classic check pattern. Made from high-quality fabric, it's suitable for both casual and semi-formal occasions.", "https://cdn.dummyjson.com/product-images/mens-shirts/blue-&-black-check-shirt/1.webp", "Blue & Black Check Shirt", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Gigabyte Aorus Men Tshirt is a cool and casual shirt for gaming enthusiasts. With the Aorus logo and sleek design, it's perfect for expressing your gaming style.", "https://cdn.dummyjson.com/product-images/mens-shirts/gigabyte-aorus-men-tshirt/1.webp", "Gigabyte Aorus Men Tshirt", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Man Plaid Shirt is a timeless and versatile men's shirt with a classic plaid pattern. Its comfortable fit and casual style make it a wardrobe essential for various occasions.", "https://cdn.dummyjson.com/product-images/mens-shirts/man-plaid-shirt/1.webp", "Man Plaid Shirt", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Man Short Sleeve Shirt is a breezy and stylish option for warm days. With a comfortable fit and short sleeves, it's perfect for a laid-back yet polished look.", "https://cdn.dummyjson.com/product-images/mens-shirts/man-short-sleeve-shirt/1.webp", "Man Short Sleeve Shirt", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Men Check Shirt is a classic and versatile shirt featuring a stylish check pattern. Suitable for various occasions, it adds a smart and polished touch to your wardrobe.", "https://cdn.dummyjson.com/product-images/mens-shirts/men-check-shirt/1.webp", "Men Check Shirt", 27.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "The Nike Air Jordan 1 in Red and Black is an iconic basketball sneaker known for its stylish design and high-performance features, making it a favorite among sneaker enthusiasts and athletes.", "https://cdn.dummyjson.com/product-images/mens-shoes/nike-air-jordan-1-red-and-black/1.webp", "Nike Air Jordan 1 Red And Black", 149.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Nike Baseball Cleats are designed for maximum traction and performance on the baseball field. They provide stability and support for players during games and practices.", "https://cdn.dummyjson.com/product-images/mens-shoes/nike-baseball-cleats/1.webp", "Nike Baseball Cleats", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "The Puma Future Rider Trainers offer a blend of retro style and modern comfort. Perfect for casual wear, these trainers provide a fashionable and comfortable option for everyday use.", "https://cdn.dummyjson.com/product-images/mens-shoes/puma-future-rider-trainers/1.webp", "Puma Future Rider Trainers", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "The Sports Sneakers in Off White and Red combine style and functionality, making them a fashionable choice for sports enthusiasts. The red and off-white color combination adds a bold and energetic touch.", "https://cdn.dummyjson.com/product-images/mens-shoes/sports-sneakers-off-white-&-red/1.webp", "Sports Sneakers Off White & Red", 119.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Another variant of the Sports Sneakers in Off White Red, featuring a unique design. These sneakers offer style and comfort for casual occasions.", "https://cdn.dummyjson.com/product-images/mens-shoes/sports-sneakers-off-white-red/1.webp", "Sports Sneakers Off White Red", 109.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Brown Leather Belt Watch is a stylish timepiece with a classic design. Featuring a genuine leather strap and a sleek dial, it adds a touch of sophistication to your look.", "https://cdn.dummyjson.com/product-images/mens-watches/brown-leather-belt-watch/1.webp", "Brown Leather Belt Watch", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Longines Master Collection is an elegant and refined watch known for its precision and craftsmanship. With a timeless design, it's a symbol of luxury and sophistication.", "https://cdn.dummyjson.com/product-images/mens-watches/longines-master-collection/1.webp", "Longines Master Collection", 1499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Rolex Cellini Date with Black Dial is a classic and prestigious watch. With a black dial and date complication, it exudes sophistication and is a symbol of Rolex's heritage.", "https://cdn.dummyjson.com/product-images/mens-watches/rolex-cellini-date-black-dial/1.webp", "Rolex Cellini Date Black Dial", 8999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Rolex Cellini Moonphase is a masterpiece of horology, featuring a moon phase complication and exquisite design. It reflects Rolex's commitment to precision and elegance.", "https://cdn.dummyjson.com/product-images/mens-watches/rolex-cellini-moonphase/1.webp", "Rolex Cellini Moonphase", 12999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Rolex Datejust is an iconic and versatile timepiece with a date window. Known for its timeless design and reliability, it's a symbol of Rolex's watchmaking excellence.", "https://cdn.dummyjson.com/product-images/mens-watches/rolex-datejust/1.webp", "Rolex Datejust", 10999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Rolex Submariner is a legendary dive watch with a rich history. Known for its durability and water resistance, it's a symbol of adventure and exploration.", "https://cdn.dummyjson.com/product-images/mens-watches/rolex-submariner-watch/1.webp", "Rolex Submariner Watch", 13999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Amazon Echo Plus is a smart speaker with built-in Alexa voice control. It features premium sound quality and serves as a hub for controlling smart home devices.", "https://cdn.dummyjson.com/product-images/mobile-accessories/amazon-echo-plus/1.webp", "Amazon Echo Plus", 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple Airpods offer a seamless wireless audio experience. With easy pairing, high-quality sound, and Siri integration, they are perfect for on-the-go listening.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods/1.webp", "Apple Airpods", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple AirPods Max in Silver are premium over-ear headphones with high-fidelity audio, adaptive EQ, and active noise cancellation. Experience immersive sound in style.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpods-max-silver/1.webp", "Apple AirPods Max Silver", 549.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple AirPower Wireless Charger provides a convenient way to charge your compatible Apple devices wirelessly. Simply place your devices on the charging mat for effortless charging.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-airpower-wireless-charger/1.webp", "Apple Airpower Wireless Charger", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple HomePod Mini in Cosmic Grey is a compact smart speaker that delivers impressive audio and integrates seamlessly with the Apple ecosystem for a smart home experience.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-homepod-mini-cosmic-grey/1.webp", "Apple HomePod Mini Cosmic Grey", 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple iPhone Charger is a high-quality charger designed for fast and efficient charging of your iPhone. Ensure your device stays powered up and ready to go.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-iphone-charger/1.webp", "Apple iPhone Charger", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple MagSafe Battery Pack is a portable and convenient way to add extra battery life to your MagSafe-compatible iPhone. Attach it magnetically for a secure connection.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-magsafe-battery-pack/1.webp", "Apple MagSafe Battery Pack", 99.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Apple Watch Series 4 in Gold is a stylish and advanced smartwatch with features like heart rate monitoring, fitness tracking, and a beautiful Retina display.", "https://cdn.dummyjson.com/product-images/mobile-accessories/apple-watch-series-4-gold/1.webp", "Apple Watch Series 4 Gold", 349.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Beats Flex Wireless Earphones offer a comfortable and versatile audio experience. With magnetic earbuds and up to 12 hours of battery life, they are ideal for everyday use.", "https://cdn.dummyjson.com/product-images/mobile-accessories/beats-flex-wireless-earphones/1.webp", "Beats Flex Wireless Earphones", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The iPhone 12 Silicone Case with MagSafe in Plum is a stylish and protective case designed for the iPhone 12. It features MagSafe technology for easy attachment of accessories.", "https://cdn.dummyjson.com/product-images/mobile-accessories/iphone-12-silicone-case-with-magsafe-plum/1.webp", "iPhone 12 Silicone Case with MagSafe Plum", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Monopod is a versatile camera accessory for stable and adjustable shooting. Perfect for capturing selfies, group photos, and videos with ease.", "https://cdn.dummyjson.com/product-images/mobile-accessories/monopod/1.webp", "Monopod", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Selfie Lamp with iPhone is a portable and adjustable LED light designed to enhance your selfies and video calls. Attach it to your iPhone for well-lit photos.", "https://cdn.dummyjson.com/product-images/mobile-accessories/selfie-lamp-with-iphone/1.webp", "Selfie Lamp with iPhone", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Selfie Stick Monopod is a extendable and foldable device for capturing the perfect selfie or group photo. Compatible with smartphones and cameras.", "https://cdn.dummyjson.com/product-images/mobile-accessories/selfie-stick-monopod/1.webp", "Selfie Stick Monopod", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The TV Studio Camera Pedestal is a professional-grade camera support system for smooth and precise camera movements in a studio setting. Ideal for broadcast and production.", "https://cdn.dummyjson.com/product-images/mobile-accessories/tv-studio-camera-pedestal/1.webp", "TV Studio Camera Pedestal", 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Generic Motorcycle is a versatile and reliable bike suitable for various riding preferences. With a balanced design, it provides a comfortable and efficient riding experience.", "https://cdn.dummyjson.com/product-images/motorcycle/generic-motorcycle/1.webp", "Generic Motorcycle", 3999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Kawasaki Z800 is a powerful and agile sportbike known for its striking design and performance. It's equipped with advanced features, making it a favorite among motorcycle enthusiasts.", "https://cdn.dummyjson.com/product-images/motorcycle/kawasaki-z800/1.webp", "Kawasaki Z800", 8999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The MotoGP CI.H1 is a high-performance motorcycle inspired by MotoGP racing technology. It offers cutting-edge features and precision engineering for an exhilarating riding experience.", "https://cdn.dummyjson.com/product-images/motorcycle/motogp-ci.h1/1.webp", "MotoGP CI.H1", 14999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Scooter Motorcycle is a practical and fuel-efficient bike ideal for urban commuting. It features a step-through design and user-friendly controls for easy maneuverability.", "https://cdn.dummyjson.com/product-images/motorcycle/scooter-motorcycle/1.webp", "Scooter Motorcycle", 2999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Sportbike Motorcycle is designed for speed and agility, with a sleek and aerodynamic profile. It's suitable for riders looking for a dynamic and thrilling riding experience.", "https://cdn.dummyjson.com/product-images/motorcycle/sportbike-motorcycle/1.webp", "Sportbike Motorcycle", 7499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Attitude Super Leaves Hand Soap is a natural and nourishing hand soap enriched with the goodness of super leaves. It cleanses and moisturizes your hands, leaving them feeling fresh and soft.", "https://cdn.dummyjson.com/product-images/skin-care/attitude-super-leaves-hand-soap/1.webp", "Attitude Super Leaves Hand Soap", 8.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Olay Ultra Moisture Shea Butter Body Wash is a luxurious body wash that hydrates and nourishes your skin with the moisturizing power of shea butter. Enjoy a rich lather and silky-smooth skin.", "https://cdn.dummyjson.com/product-images/skin-care/olay-ultra-moisture-shea-butter-body-wash/1.webp", "Olay Ultra Moisture Shea Butter Body Wash", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Vaseline Men Body and Face Lotion is a specially formulated lotion designed to provide long-lasting moisture to men's skin. It absorbs quickly and helps keep the skin hydrated and healthy.", "https://cdn.dummyjson.com/product-images/skin-care/vaseline-men-body-and-face-lotion/1.webp", "Vaseline Men Body and Face Lotion", 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The iPhone 5s is a classic smartphone known for its compact design and advanced features during its release. While it's an older model, it still provides a reliable user experience.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-5s/1.webp", "iPhone 5s", 199.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The iPhone 6 is a stylish and capable smartphone with a larger display and improved performance. It introduced new features and design elements, making it a popular choice in its time.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-6/1.webp", "iPhone 6", 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The iPhone 13 Pro is a cutting-edge smartphone with a powerful camera system, high-performance chip, and stunning display. It offers advanced features for users who demand top-notch technology.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-13-pro/1.webp", "iPhone 13 Pro", 1099.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The iPhone X is a flagship smartphone featuring a bezel-less OLED display, facial recognition technology (Face ID), and impressive performance. It represents a milestone in iPhone design and innovation.", "https://cdn.dummyjson.com/product-images/smartphones/iphone-x/1.webp", "iPhone X", 899.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Oppo A57 is a mid-range smartphone known for its sleek design and capable features. It offers a balance of performance and affordability, making it a popular choice.", "https://cdn.dummyjson.com/product-images/smartphones/oppo-a57/1.webp", "Oppo A57", 249.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Oppo F19 Pro Plus is a feature-rich smartphone with a focus on camera capabilities. It boasts advanced photography features and a powerful performance for a premium user experience.", "https://cdn.dummyjson.com/product-images/smartphones/oppo-f19-pro-plus/1.webp", "Oppo F19 Pro Plus", 399.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Oppo K1 series offers a range of smartphones with various features and specifications. Known for their stylish design and reliable performance, the Oppo K1 series caters to diverse user preferences.", "https://cdn.dummyjson.com/product-images/smartphones/oppo-k1/1.webp", "Oppo K1", 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Realme C35 is a budget-friendly smartphone with a focus on providing essential features for everyday use. It offers a reliable performance and user-friendly experience.", "https://cdn.dummyjson.com/product-images/smartphones/realme-c35/1.webp", "Realme C35", 149.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Realme X is a mid-range smartphone known for its sleek design and impressive display. It offers a good balance of performance and camera capabilities for users seeking a quality device.", "https://cdn.dummyjson.com/product-images/smartphones/realme-x/1.webp", "Realme X", 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Realme XT is a feature-rich smartphone with a focus on camera technology. It comes equipped with advanced camera sensors, delivering high-quality photos and videos for photography enthusiasts.", "https://cdn.dummyjson.com/product-images/smartphones/realme-xt/1.webp", "Realme XT", 349.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Samsung Galaxy S7 is a flagship smartphone known for its sleek design and advanced features. It features a high-resolution display, powerful camera, and robust performance.", "https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s7/1.webp", "Samsung Galaxy S7", 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Samsung Galaxy S8 is a premium smartphone with an Infinity Display, offering a stunning visual experience. It boasts advanced camera capabilities and cutting-edge technology.", "https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s8/1.webp", "Samsung Galaxy S8", 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Samsung Galaxy S10 is a flagship device featuring a dynamic AMOLED display, versatile camera system, and powerful performance. It represents innovation and excellence in smartphone technology.", "https://cdn.dummyjson.com/product-images/smartphones/samsung-galaxy-s10/1.webp", "Samsung Galaxy S10", 699.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Vivo S1 is a stylish and mid-range smartphone offering a blend of design and performance. It features a vibrant display, capable camera system, and reliable functionality.", "https://cdn.dummyjson.com/product-images/smartphones/vivo-s1/1.webp", "Vivo S1", 249.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Vivo V9 is a smartphone known for its sleek design and emphasis on capturing high-quality selfies. It features a notch display, dual-camera setup, and a modern design.", "https://cdn.dummyjson.com/product-images/smartphones/vivo-v9/1.webp", "Vivo V9", 299.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Vivo X21 is a premium smartphone with a focus on cutting-edge technology. It features an in-display fingerprint sensor, a high-resolution display, and advanced camera capabilities.", "https://cdn.dummyjson.com/product-images/smartphones/vivo-x21/1.webp", "Vivo X21", 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The American Football is a classic ball used in American football games. It is designed for throwing and catching, making it an essential piece of equipment for the sport.", "https://cdn.dummyjson.com/product-images/sports-accessories/american-football/1.webp", "American Football", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Baseball Ball is a standard baseball used in baseball games. It features a durable leather cover and is designed for pitching, hitting, and fielding in the game of baseball.", "https://cdn.dummyjson.com/product-images/sports-accessories/baseball-ball/1.webp", "Baseball Ball", 8.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Baseball Glove is a protective glove worn by baseball players. It is designed to catch and field the baseball, providing players with comfort and control during the game.", "https://cdn.dummyjson.com/product-images/sports-accessories/baseball-glove/1.webp", "Baseball Glove", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Basketball is a standard ball used in basketball games. It is designed for dribbling, shooting, and passing in the game of basketball, suitable for both indoor and outdoor play.", "https://cdn.dummyjson.com/product-images/sports-accessories/basketball/1.webp", "Basketball", 14.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Basketball Rim is a sturdy hoop and net assembly mounted on a basketball backboard. It provides a target for shooting and scoring in the game of basketball.", "https://cdn.dummyjson.com/product-images/sports-accessories/basketball-rim/1.webp", "Basketball Rim", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Cricket Ball is a hard leather ball used in the sport of cricket. It is bowled and batted in the game, and its hardness and seam contribute to the dynamics of cricket play.", "https://cdn.dummyjson.com/product-images/sports-accessories/cricket-ball/1.webp", "Cricket Ball", 12.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Cricket Bat is an essential piece of cricket equipment used by batsmen to hit the cricket ball. It is made of wood and comes in various sizes and designs.", "https://cdn.dummyjson.com/product-images/sports-accessories/cricket-bat/1.webp", "Cricket Bat", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Cricket Helmet is a protective headgear worn by cricket players, especially batsmen and wicketkeepers. It provides protection against fast bowling and bouncers.", "https://cdn.dummyjson.com/product-images/sports-accessories/cricket-helmet/1.webp", "Cricket Helmet", 44.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Cricket Wicket is a set of three stumps and two bails, forming a wicket used in the sport of cricket. Batsmen aim to protect the wicket while scoring runs.", "https://cdn.dummyjson.com/product-images/sports-accessories/cricket-wicket/1.webp", "Cricket Wicket", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Feather Shuttlecock is used in the sport of badminton. It features natural feathers and is designed for high-speed play, providing stability and accuracy during matches.", "https://cdn.dummyjson.com/product-images/sports-accessories/feather-shuttlecock/1.webp", "Feather Shuttlecock", 5.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Football, also known as a soccer ball, is the standard ball used in the sport of football (soccer). It is designed for kicking and passing in the game.", "https://cdn.dummyjson.com/product-images/sports-accessories/football/1.webp", "Football", 17.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Golf Ball is a small ball used in the sport of golf. It features dimples on its surface, providing aerodynamic lift and distance when struck by a golf club.", "https://cdn.dummyjson.com/product-images/sports-accessories/golf-ball/1.webp", "Golf Ball", 9.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Iron Golf is a type of golf club designed for various golf shots. It features a solid metal head and is used for approach shots, chipping, and other golfing techniques.", "https://cdn.dummyjson.com/product-images/sports-accessories/iron-golf/1.webp", "Iron Golf", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Metal Baseball Bat is a durable and lightweight baseball bat made from metal alloys. It is commonly used in baseball games for hitting and batting practice.", "https://cdn.dummyjson.com/product-images/sports-accessories/metal-baseball-bat/1.webp", "Metal Baseball Bat", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Tennis Ball is a standard ball used in the sport of tennis. It is designed for bouncing and hitting with tennis rackets during matches or practice sessions.", "https://cdn.dummyjson.com/product-images/sports-accessories/tennis-ball/1.webp", "Tennis Ball", 6.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Tennis Racket is an essential piece of equipment used in the sport of tennis. It features a frame with strings and a grip, allowing players to hit the tennis ball.", "https://cdn.dummyjson.com/product-images/sports-accessories/tennis-racket/1.webp", "Tennis Racket", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "The Volleyball is a standard ball used in the sport of volleyball. It is designed for passing, setting, and spiking over the net during volleyball matches.", "https://cdn.dummyjson.com/product-images/sports-accessories/volleyball/1.webp", "Volleyball", 11.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Black Sun Glasses are a classic and stylish choice, featuring a sleek black frame and tinted lenses. They provide both UV protection and a fashionable look.", "https://cdn.dummyjson.com/product-images/sunglasses/black-sun-glasses/1.webp", "Black Sun Glasses", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Classic Sun Glasses offer a timeless design with a neutral frame and UV-protected lenses. These sunglasses are versatile and suitable for various occasions.", "https://cdn.dummyjson.com/product-images/sunglasses/classic-sun-glasses/1.webp", "Classic Sun Glasses", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Green and Black Glasses feature a bold combination of green and black colors, adding a touch of vibrancy to your eyewear collection. They are both stylish and eye-catching.", "https://cdn.dummyjson.com/product-images/sunglasses/green-and-black-glasses/1.webp", "Green and Black Glasses", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Party Glasses are designed to add flair to your party outfit. With unique shapes or colorful frames, they're perfect for adding a playful touch to your look during celebrations.", "https://cdn.dummyjson.com/product-images/sunglasses/party-glasses/1.webp", "Party Glasses", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Sunglasses offer a classic and simple design with a focus on functionality. These sunglasses provide essential UV protection while maintaining a timeless look.", "https://cdn.dummyjson.com/product-images/sunglasses/sunglasses/1.webp", "Sunglasses", 22.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The iPad Mini 2021 in Starlight is a compact and powerful tablet from Apple. Featuring a stunning Retina display, powerful A-series chip, and a sleek design, it offers a premium tablet experience.", "https://cdn.dummyjson.com/product-images/tablets/ipad-mini-2021-starlight/1.webp", "iPad Mini 2021 Starlight", 499.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Samsung Galaxy Tab S8 Plus in Grey is a high-performance Android tablet by Samsung. With a large AMOLED display, powerful processor, and S Pen support, it's ideal for productivity and entertainment.", "https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-s8-plus-grey/1.webp", "Samsung Galaxy Tab S8 Plus Grey", 599.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "The Samsung Galaxy Tab in White is a sleek and versatile Android tablet. With a vibrant display, long-lasting battery, and a range of features, it offers a great user experience for various tasks.", "https://cdn.dummyjson.com/product-images/tablets/samsung-galaxy-tab-white/1.webp", "Samsung Galaxy Tab White", 349.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Blue Frock is a charming and stylish dress for various occasions. With a vibrant blue color and a comfortable design, it adds a touch of elegance to your wardrobe.", "https://cdn.dummyjson.com/product-images/tops/blue-frock/1.webp", "Blue Frock", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Girl Summer Dress is a cute and breezy dress designed for warm weather. With playful patterns and lightweight fabric, it's perfect for keeping cool and stylish during the summer.", "https://cdn.dummyjson.com/product-images/tops/girl-summer-dress/1.webp", "Girl Summer Dress", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Gray Dress is a versatile and chic option for various occasions. With a neutral gray color, it can be dressed up or down, making it a wardrobe staple for any fashion-forward individual.", "https://cdn.dummyjson.com/product-images/tops/gray-dress/1.webp", "Gray Dress", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Short Frock is a playful and trendy dress with a shorter length. Ideal for casual outings or special occasions, it combines style and comfort for a fashionable look.", "https://cdn.dummyjson.com/product-images/tops/short-frock/1.webp", "Short Frock", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "The Tartan Dress features a classic tartan pattern, bringing a timeless and sophisticated touch to your wardrobe. Perfect for fall and winter, it adds a hint of traditional charm.", "https://cdn.dummyjson.com/product-images/tops/tartan-dress/1.webp", "Tartan Dress", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The 300 Touring is a stylish and comfortable sedan, known for its luxurious features and smooth performance.", "https://cdn.dummyjson.com/product-images/vehicle/300-touring/1.webp", "300 Touring", 28999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Charger SXT RWD is a powerful and sporty rear-wheel-drive sedan, offering a blend of performance and practicality.", "https://cdn.dummyjson.com/product-images/vehicle/charger-sxt-rwd/1.webp", "Charger SXT RWD", 32999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Dodge Hornet GT Plus is a compact and agile hatchback, perfect for urban driving with a touch of sportiness.", "https://cdn.dummyjson.com/product-images/vehicle/dodge-hornet-gt-plus/1.webp", "Dodge Hornet GT Plus", 24999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Durango SXT RWD is a spacious and versatile SUV, known for its strong performance and family-friendly features.", "https://cdn.dummyjson.com/product-images/vehicle/durango-sxt-rwd/1.webp", "Durango SXT RWD", 36999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Automotive", "The Pacifica Touring is a stylish and well-equipped minivan, offering comfort and convenience for family journeys.", "https://cdn.dummyjson.com/product-images/vehicle/pacifica-touring/1.webp", "Pacifica Touring", 31999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Blue Women's Handbag is a stylish and spacious accessory for everyday use. With a vibrant blue color and multiple compartments, it combines fashion and functionality.", "https://cdn.dummyjson.com/product-images/womens-bags/blue-women's-handbag/1.webp", "Blue Women's Handbag", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Heshe Women's Leather Bag is a luxurious and high-quality leather bag for the sophisticated woman. With a timeless design and durable craftsmanship, it's a versatile accessory.", "https://cdn.dummyjson.com/product-images/womens-bags/heshe-women's-leather-bag/1.webp", "Heshe Women's Leather Bag", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Prada Women Bag is an iconic designer bag that exudes elegance and luxury. Crafted with precision and featuring the Prada logo, it's a statement piece for fashion enthusiasts.", "https://cdn.dummyjson.com/product-images/womens-bags/prada-women-bag/1.webp", "Prada Women Bag", 599.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The White Faux Leather Backpack is a trendy and practical backpack for the modern woman. With a sleek white design and ample storage space, it's perfect for both casual and on-the-go styles.", "https://cdn.dummyjson.com/product-images/womens-bags/white-faux-leather-backpack/1.webp", "White Faux Leather Backpack", 39.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Women Handbag in Black is a classic and versatile accessory that complements various outfits. With a timeless black color and functional design, it's a must-have in every woman's wardrobe.", "https://cdn.dummyjson.com/product-images/womens-bags/women-handbag-black/1.webp", "Women Handbag Black", 59.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "The Black Women's Gown is an elegant and timeless evening gown. With a sleek black design, it's perfect for formal events and special occasions, exuding sophistication and style.", "https://cdn.dummyjson.com/product-images/womens-dresses/black-women's-gown/1.webp", "Black Women's Gown", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "The Corset Leather With Skirt is a bold and edgy ensemble that combines a stylish corset with a matching skirt. Ideal for fashion-forward individuals, it makes a statement at any event.", "https://cdn.dummyjson.com/product-images/womens-dresses/corset-leather-with-skirt/1.webp", "Corset Leather With Skirt", 89.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "The Corset With Black Skirt is a chic and versatile outfit that pairs a fashionable corset with a classic black skirt. It offers a trendy and coordinated look for various occasions.", "https://cdn.dummyjson.com/product-images/womens-dresses/corset-with-black-skirt/1.webp", "Corset With Black Skirt", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "The Dress Pea is a stylish and comfortable dress with a pea pattern. Perfect for casual outings, it adds a playful and fun element to your wardrobe, making it a great choice for day-to-day wear.", "https://cdn.dummyjson.com/product-images/womens-dresses/dress-pea/1.webp", "Dress Pea", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "The Marni Red & Black Suit is a sophisticated and fashion-forward suit ensemble. With a combination of red and black tones, it showcases a modern design for a bold and confident look.", "https://cdn.dummyjson.com/product-images/womens-dresses/marni-red-&-black-suit/1.webp", "Marni Red & Black Suit", 179.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Green Crystal Earring is a dazzling accessory that features a vibrant green crystal. With a classic design, it adds a touch of elegance to your ensemble, perfect for formal or special occasions.", "https://cdn.dummyjson.com/product-images/womens-jewellery/green-crystal-earring/1.webp", "Green Crystal Earring", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Green Oval Earring is a stylish and versatile accessory with a unique oval shape. Whether for casual or dressy occasions, its green hue and contemporary design make it a standout piece.", "https://cdn.dummyjson.com/product-images/womens-jewellery/green-oval-earring/1.webp", "Green Oval Earring", 24.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Tropical Earring is a fun and playful accessory inspired by tropical elements. Featuring vibrant colors and a lively design, it's perfect for adding a touch of summer to your look.", "https://cdn.dummyjson.com/product-images/womens-jewellery/tropical-earring/1.webp", "Tropical Earring", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "The Black & Brown Slipper is a comfortable and stylish choice for casual wear. Featuring a blend of black and brown colors, it adds a touch of sophistication to your relaxation.", "https://cdn.dummyjson.com/product-images/womens-shoes/black-&-brown-slipper/1.webp", "Black & Brown Slipper", 19.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Calvin Klein Heel Shoes are elegant and sophisticated, designed for formal occasions. With a classic design and high-quality materials, they complement your stylish ensemble.", "https://cdn.dummyjson.com/product-images/womens-shoes/calvin-klein-heel-shoes/1.webp", "Calvin Klein Heel Shoes", 79.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "The Golden Shoes for Women are a glamorous choice for special occasions. Featuring a golden hue and stylish design, they add a touch of luxury to your outfit.", "https://cdn.dummyjson.com/product-images/womens-shoes/golden-shoes-woman/1.webp", "Golden Shoes Woman", 49.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Pampi Shoes offer a blend of comfort and style for everyday use. With a versatile design, they are suitable for various casual occasions, providing a trendy and relaxed look.", "https://cdn.dummyjson.com/product-images/womens-shoes/pampi-shoes/1.webp", "Pampi Shoes", 29.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "The Red Shoes make a bold statement with their vibrant red color. Whether for a party or a casual outing, these shoes add a pop of color and style to your wardrobe.", "https://cdn.dummyjson.com/product-images/womens-shoes/red-shoes/1.webp", "Red Shoes", 34.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The IWC Ingenieur Automatic Steel watch is a durable and sophisticated timepiece. With a stainless steel case and automatic movement, it combines precision and style for watch enthusiasts.", "https://cdn.dummyjson.com/product-images/womens-watches/iwc-ingenieur-automatic-steel/1.webp", "IWC Ingenieur Automatic Steel", 4999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Rolex Cellini Moonphase watch is a masterpiece of horology. Featuring a moon phase complication, it showcases the craftsmanship and elegance that Rolex is renowned for.", "https://cdn.dummyjson.com/product-images/womens-watches/rolex-cellini-moonphase/1.webp", "Rolex Cellini Moonphase", 15999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Rolex Datejust Women's watch is an iconic timepiece designed for women. With a timeless design and a date complication, it offers both elegance and functionality.", "https://cdn.dummyjson.com/product-images/womens-watches/rolex-datejust-women/1.webp", "Rolex Datejust Women", 10999.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Gold Women's Watch is a stunning accessory that combines luxury and style. Featuring a gold-plated case and a chic design, it adds a touch of glamour to any outfit.", "https://cdn.dummyjson.com/product-images/womens-watches/watch-gold-for-women/1.webp", "Watch Gold for Women", 799.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "The Women's Wrist Watch is a versatile and fashionable timepiece for everyday wear. With a comfortable strap and a simple yet elegant design, it complements various styles.", "https://cdn.dummyjson.com/product-images/womens-watches/women's-wrist-watch/1.webp", "Women's Wrist Watch", 129.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your wardrobe with this stylish black t-shirt featuring a striking monochrome mountain range graphic. Perfect for those who love the outdoors or want to add a touch of nature-inspired design to their look, this tee is crafted from soft, breathable fabric ensuring all-day comfort. Ideal for casual outings or as a unique gift, this t-shirt is a versatile addition to any collection.", "https://i.imgur.com/QkIa5tT.jpeg", "Majestic Mountain Graphic T-Shirt", 44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your casual wardrobe with our Classic Red Pullover Hoodie. Crafted with a soft cotton blend for ultimate comfort, this vibrant red hoodie features a kangaroo pocket, adjustable drawstring hood, and ribbed cuffs for a snug fit. The timeless design ensures easy pairing with jeans or joggers for a relaxed yet stylish look, making it a versatile addition to your everyday attire.", "https://i.imgur.com/1twoaDy.jpeg", "Classic Red Pullover Hoodie", 10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your casual wear with our Classic Grey Hooded Sweatshirt. Made from a soft cotton blend, this hoodie features a front kangaroo pocket, an adjustable drawstring hood, and ribbed cuffs for a snug fit. Perfect for those chilly evenings or lazy weekends, it pairs effortlessly with your favorite jeans or joggers.", "https://i.imgur.com/R2PN9Wq.jpeg", "Classic Grey Hooded Sweatshirt", 90m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your casual wardrobe with our Classic Black Hooded Sweatshirt. Made from high-quality, soft fabric that ensures comfort and durability, this hoodie features a spacious kangaroo pocket and an adjustable drawstring hood. Its versatile design makes it perfect for a relaxed day at home or a casual outing.", "https://i.imgur.com/cSytoSD.jpeg", "Classic Black Hooded Sweatshirt", 79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Discover the perfect blend of style and comfort with our Classic Comfort Fit Joggers. These versatile black joggers feature a soft elastic waistband with an adjustable drawstring, two side pockets, and ribbed ankle cuffs for a secure fit. Made from a lightweight and durable fabric, they are ideal for both active days and relaxed lounging.", "https://i.imgur.com/ZKGofuB.jpeg", "Classic Comfort Fit Joggers", 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Experience the perfect blend of comfort and style with our Classic Comfort Drawstring Joggers. Designed for a relaxed fit, these joggers feature a soft, stretchable fabric, convenient side pockets, and an adjustable drawstring waist with elegant gold-tipped detailing. Ideal for lounging or running errands, these pants will quickly become your go-to for effortless, casual wear.", "https://i.imgur.com/mp3rUty.jpeg", "Classic Comfort Drawstring Joggers", 79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Experience ultimate comfort with our red jogger sweatpants, perfect for both workout sessions and lounging around the house. Made with soft, durable fabric, these joggers feature a snug waistband, adjustable drawstring, and practical side pockets for functionality. Their tapered design and elastic cuffs offer a modern fit that keeps you looking stylish on the go.", "https://i.imgur.com/9LFjwpI.jpeg", "Classic Red Jogger Sweatpants", 98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Step out in style with this sleek navy blue baseball cap. Crafted from durable material, it features a smooth, structured design and an adjustable strap for the perfect fit. Protect your eyes from the sun and complement your casual looks with this versatile and timeless accessory.", "https://i.imgur.com/R3iobJA.jpeg", "Classic Navy Blue Baseball Cap", 61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Top off your casual look with our Classic Blue Baseball Cap, made from high-quality materials for lasting comfort. Featuring a timeless six-panel design with a pre-curved visor, this adjustable cap offers both style and practicality for everyday wear.", "https://i.imgur.com/wXuQ7bm.jpeg", "Classic Blue Baseball Cap", 86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your casual wardrobe with this timeless red baseball cap. Crafted from durable fabric, it features a comfortable fit with an adjustable strap at the back, ensuring one size fits all. Perfect for sunny days or adding a sporty touch to your outfit.", "https://i.imgur.com/cBuLvBi.jpeg", "Classic Red Baseball Cap", 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your casual wear with this timeless black baseball cap. Made with high-quality, breathable fabric, it features an adjustable strap for the perfect fit. Whether you’re out for a jog or just running errands, this cap adds a touch of style to any outfit.", "https://i.imgur.com/KeqG6r4.jpeg", "Classic Black Baseball Cap", 58m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your casual wardrobe with these classic olive chino shorts. Designed for comfort and versatility, they feature a smooth waistband, practical pockets, and a tailored fit that makes them perfect for both relaxed weekends and smart-casual occasions. The durable fabric ensures they hold up throughout your daily activities while maintaining a stylish look.", "https://i.imgur.com/UsFIvYs.jpeg", "Classic Olive Chino Shorts", 84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Stay comfortable and stylish with our Classic High-Waisted Athletic Shorts. Designed for optimal movement and versatility, these shorts are a must-have for your workout wardrobe. Featuring a figure-flattering high waist, breathable fabric, and a secure fit that ensures they stay in place during any activity, these shorts are perfect for the gym, running, or even just casual wear.", "https://i.imgur.com/eGOUveI.jpeg", "Classic High-Waisted Athletic Shorts", 43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your basics with this versatile white crew neck tee. Made from a soft, breathable cotton blend, it offers both comfort and durability. Its sleek, timeless design ensures it pairs well with virtually any outfit. Ideal for layering or wearing on its own, this t-shirt is a must-have staple for every wardrobe.", "https://i.imgur.com/axsyGpD.jpeg", "Classic White Crew Neck T-Shirt", 39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your everyday wardrobe with our Classic White Tee. Crafted from premium soft cotton material, this versatile t-shirt combines comfort with durability, perfect for daily wear. Featuring a relaxed, unisex fit that flatters every body type, it's a staple piece for any casual ensemble. Easy to care for and machine washable, this white tee retains its shape and softness wash after wash. Pair it with your favorite jeans or layer it under a jacket for a smart look.", "https://i.imgur.com/Y54Bt8J.jpeg", "Classic White Tee - Timeless Style and Comfort", 73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Elevate your everyday style with our Classic Black T-Shirt. This staple piece is crafted from soft, breathable cotton for all-day comfort. Its versatile design features a classic crew neck and short sleeves, making it perfect for layering or wearing on its own. Durable and easy to care for, it's sure to become a favorite in your wardrobe.", "https://i.imgur.com/9DqEOV5.jpeg", "Classic Black T-Shirt", 35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Elevate your gaming experience with this state-of-the-art wireless controller, featuring a crisp white base with vibrant orange accents. Designed for precision play, the ergonomic shape and responsive buttons provide maximum comfort and control for endless hours of gameplay. Compatible with multiple gaming platforms, this controller is a must-have for any serious gamer looking to enhance their setup.", "https://i.imgur.com/ZANVnHE.jpeg", "Sleek White & Orange Wireless Gaming Controller", 69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Experience the fusion of style and sound with this sophisticated audio set featuring a pair of sleek, white wireless headphones offering crystal-clear sound quality and over-ear comfort. The set also includes a set of durable earbuds, perfect for an on-the-go lifestyle. Elevate your music enjoyment with this versatile duo, designed to cater to all your listening needs.", "https://i.imgur.com/yVeIeDa.jpeg", "Sleek Wireless Headphone & Inked Earbud Set", 44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Experience superior sound quality with our Sleek Comfort-Fit Over-Ear Headphones, designed for prolonged use with cushioned ear cups and an adjustable, padded headband. Ideal for immersive listening, whether you're at home, in the office, or on the move. Their durable construction and timeless design provide both aesthetically pleasing looks and long-lasting performance.", "https://i.imgur.com/SolkFEB.jpeg", "Sleek Comfort-Fit Over-Ear Headphones", 28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Enhance your morning routine with our sleek 2-slice toaster, featuring adjustable browning controls and a removable crumb tray for easy cleaning. This compact and stylish appliance is perfect for any kitchen, ensuring your toast is always golden brown and delicious.", "https://i.imgur.com/keVCVIa.jpeg", "Efficient 2-Slice Toaster", 48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Experience smooth and precise navigation with this modern wireless mouse, featuring a glossy finish and a comfortable ergonomic design. Its responsive tracking and easy-to-use interface make it the perfect accessory for any desktop or laptop setup. The stylish blue hue adds a splash of color to your workspace, while its compact size ensures it fits neatly in your bag for on-the-go productivity.", "https://i.imgur.com/w3Y8NwQ.jpeg", "Sleek Wireless Computer Mouse", 10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Experience next-level computing with our ultra-slim laptop, featuring a stunning display illuminated by ambient lighting. This high-performance machine is perfect for both work and play, delivering powerful processing in a sleek, portable design. The vibrant colors add a touch of personality to your tech collection, making it as stylish as it is functional.", "https://i.imgur.com/OKn1KFI.jpeg", "Sleek Modern Laptop with Ambient Lighting", 43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Experience cutting-edge technology and elegant design with our latest laptop model. Perfect for professionals on-the-go, this high-performance laptop boasts a powerful processor, ample storage, and a long-lasting battery life, all encased in a lightweight, slim frame for ultimate portability. Shop now to elevate your work and play.", "https://i.imgur.com/ItHcq7o.jpeg", "Sleek Modern Laptop for Professionals", 97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Immerse yourself in superior sound quality with these sleek red and silver over-ear headphones. Designed for comfort and style, the headphones feature cushioned ear cups, an adjustable padded headband, and a detachable red cable for easy storage and portability. Perfect for music lovers and audiophiles who value both appearance and audio fidelity.", "https://i.imgur.com/YaSqa06.jpeg", "Stylish Red & Silver Over-Ear Headphones", 39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Enhance your smartphone's look with this ultra-sleek mirror finish phone case. Designed to offer style with protection, the case features a reflective surface that adds a touch of elegance while keeping your device safe from scratches and impacts. Perfect for those who love a minimalist and modern aesthetic.", "https://i.imgur.com/yb9UQKL.jpeg", "Sleek Mirror Finish Phone Case", 27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Experience modern timekeeping with our high-tech smartwatch, featuring a vivid touch screen display, customizable watch faces, and a comfortable blue silicone strap. This smartwatch keeps you connected with notifications and fitness tracking while showcasing exceptional style and versatility.", "https://i.imgur.com/LGk9Jn2.jpeg", "Sleek Smartwatch with Vibrant Display", 16m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Enhance the elegance of your living space with our Sleek Modern Leather Sofa. Designed with a minimalist aesthetic, it features clean lines and a luxurious leather finish. The robust metal legs provide stability and support, while the plush cushions ensure comfort. Perfect for contemporary homes or office waiting areas, this sofa is a statement piece that combines style with practicality.", "https://i.imgur.com/Qphac99.jpeg", "Sleek Modern Leather Sofa", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Elevate your dining room with this sleek Mid-Century Modern dining table, featuring an elegant walnut finish and tapered legs for a timeless aesthetic. Its sturdy wood construction and minimalist design make it a versatile piece that fits with a variety of decor styles. Perfect for intimate dinners or as a stylish spot for your morning coffee.", "https://i.imgur.com/DMQHGA0.jpeg", "Mid-Century Modern Wooden Dining Table", 24m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Elevate your dining space with this luxurious table, featuring a sturdy golden metal base with an intricate rod design that provides both stability and chic elegance. The smooth stone top in a sleek round shape offers a robust surface for your dining pleasure. Perfect for both everyday meals and special occasions, this table easily complements any modern or glam decor.", "https://i.imgur.com/NWIJKUj.jpeg", "Elegant Golden-Base Stone Top Dining Table", 66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Elevate your living space with this beautifully crafted armchair, featuring a sleek wooden frame that complements its vibrant teal upholstery. Ideal for adding a pop of color and contemporary style to any room, this chair provides both superb comfort and sophisticated design. Perfect for reading, relaxing, or creating a cozy conversation nook.", "https://i.imgur.com/6wkyyIN.jpeg", "Modern Elegance Teal Armchair", 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Enhance your dining space with this sleek, contemporary dining table, crafted from high-quality solid wood with a warm finish. Its sturdy construction and minimalist design make it a perfect addition for any home looking for a touch of elegance. Accommodates up to six guests comfortably and includes a striking fruit bowl centerpiece. The overhead lighting is not included.", "https://i.imgur.com/4lTaHfF.jpeg", "Elegant Solid Wood Dining Table", 67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Elevate your home office with our Modern Minimalist Workstation Setup, featuring a sleek wooden desk topped with an elegant computer, stylish adjustable wooden desk lamp, and complimentary accessories for a clean, productive workspace. This setup is perfect for professionals seeking a contemporary look that combines functionality with design.", "https://i.imgur.com/3oXNBst.jpeg", "Modern Minimalist Workstation Setup", 49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Elevate your office space with this sleek and comfortable Modern Ergonomic Office Chair. Designed to provide optimal support throughout the workday, it features an adjustable height mechanism, smooth-rolling casters for easy mobility, and a cushioned seat for extended comfort. The clean lines and minimalist white design make it a versatile addition to any contemporary workspace.", "https://i.imgur.com/3dU0m72.jpeg", "Modern Ergonomic Office Chair", 71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step onto the field and stand out from the crowd with these eye-catching holographic soccer cleats. Designed for the modern player, these cleats feature a sleek silhouette, lightweight construction for maximum agility, and durable studs for optimal traction. The shimmering holographic finish reflects a rainbow of colors as you move, ensuring that you'll be noticed for both your skills and style. Perfect for the fashion-forward athlete who wants to make a statement.", "https://i.imgur.com/qNOjJje.jpeg", "Futuristic Holographic Soccer Cleats", 39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into the spotlight with these eye-catching rainbow glitter high heels. Designed to dazzle, each shoe boasts a kaleidoscope of shimmering colors that catch and reflect light with every step. Perfect for special occasions or a night out, these stunners are sure to turn heads and elevate any ensemble.", "https://i.imgur.com/62gGzeF.jpeg", "Rainbow Glitter High Heels", 39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into summer with style in our denim espadrille sandals. Featuring a braided jute sole for a classic touch and adjustable denim straps for a snug fit, these sandals offer both comfort and a fashionable edge. The easy slip-on design ensures convenience for beach days or casual outings.", "https://i.imgur.com/9qrmE1b.jpeg", "Chic Summer Denim Espadrille Sandals", 33m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into style with these eye-catching sneakers featuring a striking combination of orange and blue hues. Designed for both comfort and fashion, these shoes come with flexible soles and cushioned insoles, perfect for active individuals who don't compromise on style. The reflective silver accents add a touch of modernity, making them a standout accessory for your workout or casual wear.", "https://i.imgur.com/hKcMNJs.jpeg", "Vibrant Runners: Bold Orange & Blue Sneakers", 27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into style with our Vibrant Pink Classic Sneakers! These eye-catching shoes feature a bold pink hue with iconic white detailing, offering a sleek, timeless design. Constructed with durable materials and a comfortable fit, they are perfect for those seeking a pop of color in their everyday footwear. Grab a pair today and add some vibrancy to your step!", "https://i.imgur.com/mcW42Gi.jpeg", "Vibrant Pink Classic Sneakers", 84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into the future with this eye-catching high-top sneaker, designed for those who dare to stand out. The sneaker features a sleek silver body with striking gold accents, offering a modern twist on classic footwear. Its high-top design provides support and style, making it the perfect addition to any avant-garde fashion collection. Grab a pair today and elevate your shoe game!", "https://i.imgur.com/npLfCGq.jpeg", "Futuristic Silver and Gold High-Top Sneaker", 68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Elevate your style with our cutting-edge high-heel boots that blend bold design with avant-garde aesthetics. These boots feature a unique color-block heel, a sleek silhouette, and a versatile light grey finish that pairs easily with any cutting-edge outfit. Crafted for the fashion-forward individual, these boots are sure to make a statement.", "https://i.imgur.com/HqYqLnW.jpeg", "Futuristic Chic High-Heel Boots", 36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into sophistication with these chic peep-toe pumps, showcasing a lustrous patent leather finish and an eye-catching gold-tone block heel. The ornate buckle detail adds a touch of glamour, perfect for elevating your evening attire or complementing a polished daytime look.", "https://i.imgur.com/AzAY4Ed.jpeg", "Elegant Patent Leather Peep-Toe Pumps with Gold-Tone Heel", 53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into sophistication with our Elegant Purple Leather Loafers, perfect for making a bold statement. Crafted from high-quality leather with a vibrant purple finish, these shoes feature a classic loafer silhouette that's been updated with a contemporary twist. The comfortable slip-on design and durable soles ensure both style and functionality for the modern man.", "https://i.imgur.com/Au8J9sX.jpeg", "Elegant Purple Leather Loafers", 17m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Step into comfort with our Classic Blue Suede Casual Shoes, perfect for everyday wear. These shoes feature a stylish blue suede upper, durable rubber soles for superior traction, and classic lace-up fronts for a snug fit. The sleek design pairs well with both jeans and chinos, making them a versatile addition to any wardrobe.", "https://i.imgur.com/sC0ztOB.jpeg", "Classic Blue Suede Casual Shoes", 39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "This modern electric bicycle combines style and efficiency with its unique design and top-notch performance features. Equipped with a durable frame, enhanced battery life, and integrated tech capabilities, it's perfect for the eco-conscious commuter looking to navigate the city with ease.", "https://i.imgur.com/BG8J0Fj.jpg", "Sleek Futuristic Electric Bicycle", 22m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Experience the thrill of outdoor adventures with our Sleek All-Terrain Go-Kart, featuring a durable frame, comfortable racing seat, and robust, large-tread tires perfect for handling a variety of terrains. Designed for fun-seekers of all ages, this go-kart is an ideal choice for backyard racing or exploring local trails.", "https://i.imgur.com/Ex5x3IU.jpg", "Sleek All-Terrain Go-Kart", 37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Indulge in the essence of summer with this vibrant citrus-scented Eau de Parfum. Encased in a sleek glass bottle with a bold orange cap, this fragrance embodies freshness and elegance. Perfect for daily wear, it's an olfactory delight that leaves a lasting, zesty impression.", "https://i.imgur.com/xPDwUb3.jpg", "Radiant Citrus Eau de Parfum", 73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Travel in style with our durable hardshell carry-on, perfect for weekend getaways and business trips. This sleek olive green suitcase features smooth gliding wheels for easy airport navigation, a sturdy telescopic handle, and a secure zippered compartment to keep your belongings safe. Its compact size meets most airline overhead bin requirements, ensuring a hassle-free flying experience.", "https://i.imgur.com/jVfoZnP.jpg", "Sleek Olive Green Hardshell Carry-On Luggage", 48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Elevate your style with our Chic Transparent Fashion Handbag, perfect for showcasing your essentials with a clear, modern edge. This trendy accessory features durable acrylic construction, luxe gold-tone hardware, and an elegant chain strap. Its compact size ensures you can carry your day-to-day items with ease and sophistication.", "https://i.imgur.com/Lqaqz59.jpg", "Chic Transparent Fashion Handbag", 61m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatedAt", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 243, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Step up your style game with these fashionable black-framed, pink-tinted sunglasses. Perfect for making a statement while protecting your eyes from the glare. Their bold color and contemporary design make these shades a must-have accessory for any trendsetter looking to add a pop of color to their ensemble.", "https://i.imgur.com/0qQBkxX.jpg", "Trendy Pink-Tinted Sunglasses", 38m },
                    { 244, "Accessories", new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Enhance your drinkware collection with our sophisticated set of glass tumblers, perfect for serving your favorite beverages. This versatile set includes both clear and subtly tinted glasses, lending a modern touch to any table setting. Crafted with quality materials, these durable tumblers are designed to withstand daily use while maintaining their elegant appeal.", "https://i.imgur.com/TF0pXdL.jpg", "Elegant Glass Tumbler Set", 50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 244);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Volt Court 90s from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-10/600/600", "Volt Court 90s", 85.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Core Loafer from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-11/600/600", "Core Loafer", 131.26m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Street Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-12/600/600", "Street Vibe Low", 127.21m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Street Horizon from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-13/600/600", "Street Horizon", 65.63m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Volt Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-14/600/600", "Volt Vibe Low", 147.94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Trail React from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-15/600/600", "Trail React", 117.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Classic Vibe Low from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-16/600/600", "Classic Vibe Low", 150.11m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Summit Edge from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-17/600/600", "Summit Edge", 116.6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Nova Runner from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-18/600/600", "Nova Runner", 45.08m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Pulse Street Pro from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-19/600/600", "Pulse Street Pro", 88.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Volt Street Pro from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-20/600/600", "Volt Street Pro", 47.63m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "Trail Horizon from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-21/600/600", "Trail Horizon", 170.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Footwear", "AirFlex Sneaker from our Footwear collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Footwear-22/600/600", "AirFlex Sneaker", 163.63m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Premium Jogger Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-23/600/600", "Premium Jogger Pants", 114.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Relaxed Wool Sweater from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-24/600/600", "Relaxed Wool Sweater", 124.08m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Premium Hoodie from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-25/600/600", "Premium Hoodie", 34.2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Relaxed Denim Jacket from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-26/600/600", "Relaxed Denim Jacket", 44.91m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Heritage Flannel Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-27/600/600", "Heritage Flannel Shirt", 89.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Tailored Flannel Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-28/600/600", "Tailored Flannel Shirt", 38.22m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Modern Wool Sweater from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-29/600/600", "Modern Wool Sweater", 43.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Classic Wool Sweater from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-30/600/600", "Classic Wool Sweater", 80.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Classic Bomber Jacket from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-31/600/600", "Classic Bomber Jacket", 133.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Slim-Fit Crew Tee from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-32/600/600", "Slim-Fit Crew Tee", 29.8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Slim-Fit Oxford Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-33/600/600", "Slim-Fit Oxford Shirt", 125.04m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Everyday Crew Tee from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-34/600/600", "Everyday Crew Tee", 131.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Premium Oxford Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-35/600/600", "Premium Oxford Shirt", 32.73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Relaxed Chino Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-36/600/600", "Relaxed Chino Pants", 104.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Everyday Jogger Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-37/600/600", "Everyday Jogger Pants", 90.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Relaxed Hoodie from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-38/600/600", "Relaxed Hoodie", 21.92m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Relaxed Flannel Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-39/600/600", "Relaxed Flannel Shirt", 32.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Everyday Oxford Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-40/600/600", "Everyday Oxford Shirt", 117.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Everyday Bomber Jacket from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-41/600/600", "Everyday Bomber Jacket", 50.73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Slim-Fit Polo Shirt from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-42/600/600", "Slim-Fit Polo Shirt", 72.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Heritage Chino Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-43/600/600", "Heritage Chino Pants", 82.58m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Men's Clothing", "Slim-Fit Jogger Pants from our Men's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Men'sClothing-44/600/600", "Slim-Fit Jogger Pants", 132.4m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Flowy High-Waist Jeans from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-45/600/600", "Flowy High-Waist Jeans", 121.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Flowy Blouse from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-46/600/600", "Flowy Blouse", 105.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Minimalist Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-47/600/600", "Minimalist Linen Pants", 160.1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Classic Knit Sweater from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-48/600/600", "Classic Knit Sweater", 40.02m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Fitted Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-49/600/600", "Fitted Linen Pants", 152.33m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Minimalist Knit Sweater from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-50/600/600", "Minimalist Knit Sweater", 63.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Classic High-Waist Jeans from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-51/600/600", "Classic High-Waist Jeans", 154.01m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Fitted Cardigan from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-52/600/600", "Fitted Cardigan", 132.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Fitted Wrap Top from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-53/600/600", "Fitted Wrap Top", 47.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Breezy Trench Coat from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-54/600/600", "Breezy Trench Coat", 65.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Elegant Wrap Top from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-55/600/600", "Elegant Wrap Top", 55.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Minimalist Cardigan from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-56/600/600", "Minimalist Cardigan", 74.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Chic Blouse from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-57/600/600", "Chic Blouse", 124.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Minimalist Jumpsuit from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-58/600/600", "Minimalist Jumpsuit", 148.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Classic Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-59/600/600", "Classic Linen Pants", 98.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Elegant Jumpsuit from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-60/600/600", "Elegant Jumpsuit", 61.41m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Flowy Wrap Top from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-61/600/600", "Flowy Wrap Top", 156.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Fitted Trench Coat from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-62/600/600", "Fitted Trench Coat", 32.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Breezy Knit Sweater from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-63/600/600", "Breezy Knit Sweater", 116.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Classic Cardigan from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-64/600/600", "Classic Cardigan", 145.26m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Bohemian Jumpsuit from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-65/600/600", "Bohemian Jumpsuit", 31.39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Women's Clothing", "Chic Linen Pants from our Women's Clothing collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Women'sClothing-66/600/600", "Chic Linen Pants", 73.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "HD Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-67/600/600", "HD Tablet Stand", 25.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Wireless Power Bank from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-68/600/600", "Wireless Power Bank", 184.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Noise-Cancelling Bluetooth Speaker from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-69/600/600", "Noise-Cancelling Bluetooth Speaker", 113.18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Ultra Bluetooth Earbuds from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-70/600/600", "Ultra Bluetooth Earbuds", 238.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Portable Phone Charger from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-71/600/600", "Portable Phone Charger", 138.94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Compact Over-Ear Headphones from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-72/600/600", "Compact Over-Ear Headphones", 294.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Noise-Cancelling Wireless Mouse from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-73/600/600", "Noise-Cancelling Wireless Mouse", 47.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Portable Webcam from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-74/600/600", "Portable Webcam", 270.46m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "HD Smartwatch from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-75/600/600", "HD Smartwatch", 68.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Compact Smartwatch from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-76/600/600", "Compact Smartwatch", 27.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Compact Bluetooth Speaker from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-77/600/600", "Compact Bluetooth Speaker", 138.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Ultra Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-78/600/600", "Ultra Tablet Stand", 162.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Compact Power Bank from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-79/600/600", "Compact Power Bank", 244.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Compact Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-80/600/600", "Compact Tablet Stand", 210.07m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Compact Mechanical Keyboard from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-81/600/600", "Compact Mechanical Keyboard", 282.03m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "HD Over-Ear Headphones from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-82/600/600", "HD Over-Ear Headphones", 224.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Wireless Tablet Stand from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-83/600/600", "Wireless Tablet Stand", 70.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "HD Bluetooth Speaker from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-84/600/600", "HD Bluetooth Speaker", 137.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Smart Smartwatch from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-85/600/600", "Smart Smartwatch", 284.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "HD Bluetooth Earbuds from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-86/600/600", "HD Bluetooth Earbuds", 276.5m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Wireless Bluetooth Earbuds from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-87/600/600", "Wireless Bluetooth Earbuds", 191.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Electronics", "Ultra Phone Charger from our Electronics collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Electronics-88/600/600", "Ultra Phone Charger", 203.4m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Ceramic Tea Kettle from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-89/600/600", "Ceramic Tea Kettle", 178.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Modern Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-90/600/600", "Modern Knife Set", 150.86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Compact Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-91/600/600", "Compact Dinnerware Set", 217.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Non-Stick Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-92/600/600", "Non-Stick Dinnerware Set", 135.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Non-Stick Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-93/600/600", "Non-Stick Knife Set", 209.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Compact Toaster from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-94/600/600", "Compact Toaster", 197.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Stainless Steel Storage Containers from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-95/600/600", "Stainless Steel Storage Containers", 139.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Bamboo Cutting Board from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-96/600/600", "Bamboo Cutting Board", 161.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Non-Stick Toaster from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-97/600/600", "Non-Stick Toaster", 116.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Ceramic Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-98/600/600", "Ceramic Knife Set", 184.76m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Electric Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-99/600/600", "Electric Dinnerware Set", 125.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Classic Toaster from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-100/600/600", "Classic Toaster", 198.62m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Electric Knife Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-101/600/600", "Electric Knife Set", 166.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Stainless Steel Cutting Board from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-102/600/600", "Stainless Steel Cutting Board", 110.73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Classic Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-103/600/600", "Classic Dinnerware Set", 65.91m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Ceramic Blender from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-104/600/600", "Ceramic Blender", 63.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Classic Storage Containers from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-105/600/600", "Classic Storage Containers", 144.63m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Bamboo Storage Containers from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-106/600/600", "Bamboo Storage Containers", 171.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Electric Tea Kettle from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-107/600/600", "Electric Tea Kettle", 120.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Modern Blender from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-108/600/600", "Modern Blender", 142.36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Ceramic Dinnerware Set from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-109/600/600", "Ceramic Dinnerware Set", 69.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Home & Kitchen", "Compact Tea Kettle from our Home & Kitchen collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/HomeKitchen-110/600/600", "Compact Tea Kettle", 28.12m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Refreshing Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-111/600/600", "Refreshing Facial Cleanser", 74.23m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Gentle Body Lotion from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-112/600/600", "Gentle Body Lotion", 40.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Soothing Face Serum from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-113/600/600", "Soothing Face Serum", 73.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Organic Sunscreen from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-114/600/600", "Organic Sunscreen", 80.38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Gentle Face Serum from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-115/600/600", "Gentle Face Serum", 29.95m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Soothing Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-116/600/600", "Soothing Perfume", 15.13m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Radiant Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-117/600/600", "Radiant Perfume", 9.69m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Soothing Makeup Brush Set from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-118/600/600", "Soothing Makeup Brush Set", 54.93m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Gentle Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-119/600/600", "Gentle Perfume", 94.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Organic Moisturizer from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-120/600/600", "Organic Moisturizer", 38.45m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Hydrating Hair Mask from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-121/600/600", "Hydrating Hair Mask", 64.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Hydrating Shampoo from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-122/600/600", "Hydrating Shampoo", 75.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Hydrating Sunscreen from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-123/600/600", "Hydrating Sunscreen", 64.7m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Gentle Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-124/600/600", "Gentle Facial Cleanser", 73.62m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Radiant Body Lotion from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-125/600/600", "Radiant Body Lotion", 90.62m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Organic Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-126/600/600", "Organic Perfume", 25.34m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Nourishing Perfume from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-127/600/600", "Nourishing Perfume", 9.77m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Gentle Hair Mask from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-128/600/600", "Gentle Hair Mask", 21.26m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Refreshing Body Lotion from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-129/600/600", "Refreshing Body Lotion", 18.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Soothing Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-130/600/600", "Soothing Facial Cleanser", 66.24m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Nourishing Shampoo from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-131/600/600", "Nourishing Shampoo", 57.07m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Beauty & Personal Care", "Hydrating Facial Cleanser from our Beauty & Personal Care collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/BeautyPersonalCare-132/600/600", "Hydrating Facial Cleanser", 26.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sports & Outdoors", "Pro Hiking Backpack from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-133/600/600", "Pro Hiking Backpack", 209.38m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sports & Outdoors", "All-Terrain Resistance Bands from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-134/600/600", "All-Terrain Resistance Bands", 30.8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sports & Outdoors", "Durable Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-135/600/600", "Durable Cycling Helmet", 221.59m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sports & Outdoors", "Lightweight Sleeping Bag from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-136/600/600", "Lightweight Sleeping Bag", 68.53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Pro Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-137/600/600", "Pro Cycling Helmet", 121.53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Performance Yoga Mat from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-138/600/600", "Performance Yoga Mat", 156.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "All-Terrain Dumbbell Set from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-139/600/600", "All-Terrain Dumbbell Set", 100.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "All-Terrain Water Bottle from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-140/600/600", "All-Terrain Water Bottle", 16.89m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "All-Terrain Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-141/600/600", "All-Terrain Cycling Helmet", 214.23m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Performance Resistance Bands from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-142/600/600", "Performance Resistance Bands", 53.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Durable Fitness Tracker from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-143/600/600", "Durable Fitness Tracker", 60.91m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Pro Sleeping Bag from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-144/600/600", "Pro Sleeping Bag", 201.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "All-Terrain Yoga Mat from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-145/600/600", "All-Terrain Yoga Mat", 91.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Adjustable Fitness Tracker from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-146/600/600", "Adjustable Fitness Tracker", 221.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "All-Terrain Hiking Backpack from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-147/600/600", "All-Terrain Hiking Backpack", 178.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Durable Water Bottle from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-148/600/600", "Durable Water Bottle", 76.3m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Lightweight Dumbbell Set from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-149/600/600", "Lightweight Dumbbell Set", 12.44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Adjustable Jump Rope from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-150/600/600", "Adjustable Jump Rope", 237.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Adjustable Sleeping Bag from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-151/600/600", "Adjustable Sleeping Bag", 30.55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Pro Water Bottle from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-152/600/600", "Pro Water Bottle", 182.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Performance Camping Tent from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-153/600/600", "Performance Camping Tent", 127.26m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Sports & Outdoors", "Adjustable Cycling Helmet from our Sports & Outdoors collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/SportsOutdoors-154/600/600", "Adjustable Cycling Helmet", 191.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Complete Photography from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-155/600/600", "Complete Photography", 39.18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Timeless Gardening from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-156/600/600", "Timeless Gardening", 25.71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Practical Travel Writing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-157/600/600", "Practical Travel Writing", 30.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Practical Coding from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-158/600/600", "Practical Coding", 12.04m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Complete Coding from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-159/600/600", "Complete Coding", 35.79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Timeless Productivity from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-160/600/600", "Timeless Productivity", 23.71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "The Art of Storytelling from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-161/600/600", "The Art of Storytelling", 35.93m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Modern Mindfulness from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-162/600/600", "Modern Mindfulness", 26.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "The Art of Cooking from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-163/600/600", "The Art of Cooking", 23.02m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Complete Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-164/600/600", "Complete Investing", 22.1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Modern Cooking from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-165/600/600", "Modern Cooking", 13.9m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "The Art of Photography from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-166/600/600", "The Art of Photography", 9.64m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Essential Photography from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-167/600/600", "Essential Photography", 38.11m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Modern Productivity from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-168/600/600", "Modern Productivity", 23.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Timeless Cooking from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-169/600/600", "Timeless Cooking", 34.31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "The Art of Coding from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-170/600/600", "The Art of Coding", 20.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Modern Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-171/600/600", "Modern Investing", 10.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Timeless Design from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-172/600/600", "Timeless Design", 28.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Practical Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-173/600/600", "Practical Investing", 9.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Essential Storytelling from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-174/600/600", "Essential Storytelling", 12.77m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Essential Investing from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-175/600/600", "Essential Investing", 26.01m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "Timeless Mindfulness from our Books collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Books-176/600/600", "Timeless Mindfulness", 17.72m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Mini Art Kit from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-177/600/600", "Mini Art Kit", 14.07m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Educational Card Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-178/600/600", "Educational Card Game", 20.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Classic Card Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-179/600/600", "Classic Card Game", 30.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Mini Board Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-180/600/600", "Mini Board Game", 62.18m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Interactive Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-181/600/600", "Interactive Puzzle", 49.41m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Educational Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-182/600/600", "Educational Puzzle", 29.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Deluxe Art Kit from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-183/600/600", "Deluxe Art Kit", 17.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Mini Plush Toy from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-184/600/600", "Mini Plush Toy", 57.9m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Educational Board Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-185/600/600", "Educational Board Game", 58.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Colorful Remote Control Car from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-186/600/600", "Colorful Remote Control Car", 75.93m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Interactive Art Kit from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-187/600/600", "Interactive Art Kit", 44.53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Classic Remote Control Car from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-188/600/600", "Classic Remote Control Car", 44.06m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Deluxe Plush Toy from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-189/600/600", "Deluxe Plush Toy", 14.71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Colorful Board Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-190/600/600", "Colorful Board Game", 11.83m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Interactive Plush Toy from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-191/600/600", "Interactive Plush Toy", 39.67m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Mini Toy Train Set from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-192/600/600", "Mini Toy Train Set", 31.88m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Interactive Play Kitchen from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-193/600/600", "Interactive Play Kitchen", 26.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Interactive Building Blocks Set from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-194/600/600", "Interactive Building Blocks Set", 15.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Deluxe Card Game from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-195/600/600", "Deluxe Card Game", 77.3m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Classic Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-196/600/600", "Classic Puzzle", 68.35m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Classic Play Kitchen from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-197/600/600", "Classic Play Kitchen", 49.84m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Toys & Games", "Colorful Puzzle from our Toys & Games collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/ToysGames-198/600/600", "Colorful Puzzle", 76.51m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Modern Baseball Cap from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-199/600/600", "Modern Baseball Cap", 104.27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Classic Belt from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-200/600/600", "Classic Belt", 167.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Woven Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-201/600/600", "Woven Keychain", 85.6m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Vintage Crossbody Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-202/600/600", "Vintage Crossbody Bag", 129.31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Vintage Watch from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-203/600/600", "Vintage Watch", 32.4m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Minimalist Scarf from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-204/600/600", "Minimalist Scarf", 175.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Leather Tote Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-205/600/600", "Leather Tote Bag", 114.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Vintage Sunglasses from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-206/600/600", "Vintage Sunglasses", 52.2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Classic Watch from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-207/600/600", "Classic Watch", 38.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Classic Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-208/600/600", "Classic Keychain", 104.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Woven Tote Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-209/600/600", "Woven Tote Bag", 104.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Leather Crossbody Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-210/600/600", "Leather Crossbody Bag", 27.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Minimalist Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-211/600/600", "Minimalist Keychain", 178.7m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Minimalist Belt from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-212/600/600", "Minimalist Belt", 165.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Minimalist Baseball Cap from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-213/600/600", "Minimalist Baseball Cap", 89.52m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Leather Wallet from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-214/600/600", "Leather Wallet", 31.73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Modern Crossbody Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-215/600/600", "Modern Crossbody Bag", 151.8m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Leather Belt from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-216/600/600", "Leather Belt", 95.73m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Woven Watch from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-217/600/600", "Woven Watch", 132.39m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Leather Baseball Cap from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-218/600/600", "Leather Baseball Cap", 97.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Vintage Keychain from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-219/600/600", "Vintage Keychain", 57.94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Accessories", "Modern Tote Bag from our Accessories collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Accessories-220/600/600", "Modern Tote Bag", 152.23m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Modern Bedside Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-221/600/600", "Modern Bedside Table", 80.88m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Minimalist Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-222/600/600", "Minimalist Storage Ottoman", 413.28m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Minimalist Dining Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-223/600/600", "Minimalist Dining Table", 46.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Industrial Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-224/600/600", "Industrial Storage Ottoman", 99.1m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Modern Accent Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-225/600/600", "Modern Accent Chair", 397.08m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Minimalist TV Stand from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-226/600/600", "Minimalist TV Stand", 437.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Classic Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-227/600/600", "Classic Storage Ottoman", 70.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Minimalist Bookshelf from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-228/600/600", "Minimalist Bookshelf", 360.43m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Minimalist Office Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-229/600/600", "Minimalist Office Chair", 148.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Modern Bookshelf from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-230/600/600", "Modern Bookshelf", 295.54m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Compact Storage Ottoman from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-231/600/600", "Compact Storage Ottoman", 202.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Classic Bookshelf from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-232/600/600", "Classic Bookshelf", 72.93m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Classic Desk from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-233/600/600", "Classic Desk", 174.71m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Scandinavian Office Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-234/600/600", "Scandinavian Office Chair", 316.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Compact Coffee Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-235/600/600", "Compact Coffee Table", 258.79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Classic TV Stand from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-236/600/600", "Classic TV Stand", 431.2m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Scandinavian Accent Chair from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-237/600/600", "Scandinavian Accent Chair", 296.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Modern Coffee Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-238/600/600", "Modern Coffee Table", 403.85m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Compact Bedside Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-239/600/600", "Compact Bedside Table", 240.06m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Scandinavian Bedside Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-240/600/600", "Scandinavian Bedside Table", 261.82m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Scandinavian Desk from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-241/600/600", "Scandinavian Desk", 293.16m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { "Furniture", "Minimalist Coffee Table from our Furniture collection — quality materials and thoughtful design for everyday use.", "https://picsum.photos/seed/Furniture-242/600/600", "Minimalist Coffee Table", 136.26m });
        }
    }
}
