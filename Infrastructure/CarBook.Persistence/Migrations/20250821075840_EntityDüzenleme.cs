using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EntityDüzenleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Pricings_PricingID",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "TestimonialID",
                table: "Testimoinals",
                newName: "TestimonialId");

            migrationBuilder.RenameColumn(
                name: "SocialMediaID",
                table: "socialMedias",
                newName: "SocialMediaId");

            migrationBuilder.RenameColumn(
                name: "ServiceID",
                table: "Services",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "PricingID",
                table: "Pricings",
                newName: "PricingId");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Locations",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "FooterAddressID",
                table: "FooterAddresses",
                newName: "FooterAddressId");

            migrationBuilder.RenameColumn(
                name: "FeatureID",
                table: "Features",
                newName: "FeatureId");

            migrationBuilder.RenameColumn(
                name: "ContactID",
                table: "Contacts",
                newName: "ContactId");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Cars",
                newName: "BrandId");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "Cars",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "CoverİmageURL",
                table: "Cars",
                newName: "CoverImageURL");

            migrationBuilder.RenameColumn(
                name: "BigİmageURL",
                table: "Cars",
                newName: "BigImageURL");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandID",
                table: "Cars",
                newName: "IX_Cars_BrandId");

            migrationBuilder.RenameColumn(
                name: "PricingID",
                table: "CarPricings",
                newName: "PricingId");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarPricings",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "CarpricingID",
                table: "CarPricings",
                newName: "CarPricingId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_PricingID",
                table: "CarPricings",
                newName: "IX_CarPricings_PricingId");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_CarID",
                table: "CarPricings",
                newName: "IX_CarPricings_CarId");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarFeatures",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "CarFeatureID",
                table: "CarFeatures",
                newName: "CarFeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_CarID",
                table: "CarFeatures",
                newName: "IX_CarFeatures_CarId");

            migrationBuilder.RenameColumn(
                name: "CarID",
                table: "CarDescriptions",
                newName: "CarId");

            migrationBuilder.RenameColumn(
                name: "CarDescriptionID",
                table: "CarDescriptions",
                newName: "CarDescriptionId");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarId");

            migrationBuilder.RenameColumn(
                name: "BrandID",
                table: "Brands",
                newName: "BrandId");

            migrationBuilder.RenameColumn(
                name: "BannerID",
                table: "Banners",
                newName: "BannerId");

            migrationBuilder.RenameColumn(
                name: "AboutID",
                table: "Abouts",
                newName: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarId",
                table: "CarDescriptions",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Cars_CarId",
                table: "CarPricings",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "CarId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Pricings_PricingId",
                table: "CarPricings",
                column: "PricingId",
                principalTable: "Pricings",
                principalColumn: "PricingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars",
                column: "BrandId",
                principalTable: "Brands",
                principalColumn: "BrandId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarId",
                table: "CarDescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_CarFeatures_Cars_CarId",
                table: "CarFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Cars_CarId",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_CarPricings_Pricings_PricingId",
                table: "CarPricings");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "TestimonialId",
                table: "Testimoinals",
                newName: "TestimonialID");

            migrationBuilder.RenameColumn(
                name: "SocialMediaId",
                table: "socialMedias",
                newName: "SocialMediaID");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Services",
                newName: "ServiceID");

            migrationBuilder.RenameColumn(
                name: "PricingId",
                table: "Pricings",
                newName: "PricingID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Locations",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "FooterAddressId",
                table: "FooterAddresses",
                newName: "FooterAddressID");

            migrationBuilder.RenameColumn(
                name: "FeatureId",
                table: "Features",
                newName: "FeatureID");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "Contacts",
                newName: "ContactID");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Cars",
                newName: "BrandID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Cars",
                newName: "CarID");

            migrationBuilder.RenameColumn(
                name: "CoverImageURL",
                table: "Cars",
                newName: "CoverİmageURL");

            migrationBuilder.RenameColumn(
                name: "BigImageURL",
                table: "Cars",
                newName: "BigİmageURL");

            migrationBuilder.RenameIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                newName: "IX_Cars_BrandID");

            migrationBuilder.RenameColumn(
                name: "PricingId",
                table: "CarPricings",
                newName: "PricingID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "CarPricings",
                newName: "CarID");

            migrationBuilder.RenameColumn(
                name: "CarPricingId",
                table: "CarPricings",
                newName: "CarpricingID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_PricingId",
                table: "CarPricings",
                newName: "IX_CarPricings_PricingID");

            migrationBuilder.RenameIndex(
                name: "IX_CarPricings_CarId",
                table: "CarPricings",
                newName: "IX_CarPricings_CarID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "CarFeatures",
                newName: "CarID");

            migrationBuilder.RenameColumn(
                name: "CarFeatureId",
                table: "CarFeatures",
                newName: "CarFeatureID");

            migrationBuilder.RenameIndex(
                name: "IX_CarFeatures_CarId",
                table: "CarFeatures",
                newName: "IX_CarFeatures_CarID");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "CarDescriptions",
                newName: "CarID");

            migrationBuilder.RenameColumn(
                name: "CarDescriptionId",
                table: "CarDescriptions",
                newName: "CarDescriptionID");

            migrationBuilder.RenameIndex(
                name: "IX_CarDescriptions_CarId",
                table: "CarDescriptions",
                newName: "IX_CarDescriptions_CarID");

            migrationBuilder.RenameColumn(
                name: "BrandId",
                table: "Brands",
                newName: "BrandID");

            migrationBuilder.RenameColumn(
                name: "BannerId",
                table: "Banners",
                newName: "BannerID");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "Abouts",
                newName: "AboutID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarFeatures_Cars_CarID",
                table: "CarFeatures",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Cars_CarID",
                table: "CarPricings",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarPricings_Pricings_PricingID",
                table: "CarPricings",
                column: "PricingID",
                principalTable: "Pricings",
                principalColumn: "PricingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Brands_BrandID",
                table: "Cars",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
