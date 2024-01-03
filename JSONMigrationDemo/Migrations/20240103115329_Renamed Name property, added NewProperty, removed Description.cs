using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JSONMigrationDemo.Migrations
{
    /// <inheritdoc />
    public partial class RenamedNamepropertyaddedNewPropertyremovedDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // expectation:
            // automatically generated migration detects changes of type saved as JSON column
            // what I found for manual appraoch: https://stackoverflow.com/questions/53433285/mysql-update-or-rename-a-key-in-json
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // same for reverting a migration
        }
    }
}
