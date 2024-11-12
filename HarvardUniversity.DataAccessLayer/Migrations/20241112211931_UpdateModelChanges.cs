using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarvardUniversity.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Alex", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 10, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 4, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 1, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 4, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 11, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 9, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 5, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 10, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 8, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 7, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Kail", 11 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 2, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 4, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 3, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 1, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 10, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 4, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 9, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 1, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 10, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 1, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Joy", 5, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 8, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 10, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 2, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 7, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 9, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marge", "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 11, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 4, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 3, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 8, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rick", "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 5, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 2, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 7, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 9, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 5, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 11, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 2, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 7, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 3, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 4, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 8, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 8, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 9, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 4, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 7, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 9, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 9, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 2, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 7, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 11, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 2, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 8, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 2, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 6, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 3, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 8, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 2, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 7, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 3, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 5, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 7, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Luke", "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 5, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 11, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 9, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 5, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 8, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 1, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 2, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 6, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 9, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Leo", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 2, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 2, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 9, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 2, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Rodrigez", 10 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 11, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 11, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 2, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 4, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 11, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 2, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 9, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 4, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 3, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Joy", 6, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 9, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 5, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 2, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 10, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rodrigez", "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 10, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 1, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 6, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 7, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 9, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 9, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Endy", "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 105,
                column: "GroupId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 10, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 7, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 8, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 5, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 5, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Luke", "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marge", "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 2, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 10, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 4, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 5, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 6, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Joy", 1, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 10, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 7, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 6, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 7, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 11, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rick", "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 5, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 6, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 9, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 10, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 9, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 3, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 9, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rick", "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 8, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 1, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 8, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 4, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 1, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 10, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Sterling", 3 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 2, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Roberto", "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 9, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Gary", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 8, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 11, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 8, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Andrue", "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 1, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 1, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 5, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Messy", "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 8, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 5, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marge", "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 3, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 1, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 10, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 11, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 9, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 7, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 7, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Messy", "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 7, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 9, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 11, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 7, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 10, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 10, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 1, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 5, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 3, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 4, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rick", "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 7, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 3, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 11, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 5, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 8, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 4, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 2, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Kane", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 10, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 9, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 1, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 9, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 6, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 1, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 1, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 2, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 3, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Joy", 8, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 5, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 1, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 9, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 3, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 6, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 4, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 5, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 1, "Some" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Kirk", 1 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 5, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 9, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 11, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 11, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 1, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 10, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 11, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 2, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 11, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 3, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Leo", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 8, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 7, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 5, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 3, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 1, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 9, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 1, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 7, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 1, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 5, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 9, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 2, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 8, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 1, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 5, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 5, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Joy", "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 3, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 11, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 6, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 3, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Leo", "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 8, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 9, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 11, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 5, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 1, "Kane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Joy", 1, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 11, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 3, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 8, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 2, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 6, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 10, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 3, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 2, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 8, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 10, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 10, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 1, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 9, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 7, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 4, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 7, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 1, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 2, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 11, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 4, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 11, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 1, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 5, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 2, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 3, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 10, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 1, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 8, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 7, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 9, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 6, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 9, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 3, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 11, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Joy", 5 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 8, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 9, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 10, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 10, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Sanchez", 11 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 6, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 2, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 8, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 6, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 10, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 10, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 7, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 5, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 4, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 10, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 3, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 9, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 1, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 8, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Andrue", "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 3, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Joy", 6, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 2, "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 1, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 1, "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Messy", "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 6, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rick", "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 105,
                column: "GroupId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kail", "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 2, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 1, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 4, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 1, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 7, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kirk", "Roberto" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jane", "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 9, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 6, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 2, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 7, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 10, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 11, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 11, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 11, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kirk", 4, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 1, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 6, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Piter", "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 7, "Andrue" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 7, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 10, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 11, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 11, "Mark" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 4, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 5, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Endy", "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 2, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 6, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 10, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 10, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 3, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 8, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Messy", 9 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 5, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kane", "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 11, "Snow" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Messy", 9 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 10, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 1, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 9, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gary", "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 7, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 3, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 3, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jon", "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 2, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 4, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sterling", "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 4, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 4, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Andrue", 6, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Mark", 10, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 11, "Alex" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 2, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kane", 11, "Marko" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Andrue", "Luke" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 11, "Endy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Homer", 1, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marko", 4, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 10, "Gary" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 9, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 11, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Alex", 3, "Sheva" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Some", 6, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 1, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Leo", 10, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gary", "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 11, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Roberto", 9, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jon", 2, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Messy", 4, "Homer" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Snow", 9, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Jane", 11, "Rick" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 1, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "FirstName", "GroupId" },
                values: new object[] { "Mark", 6 });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 5, "Piter" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sanchez", 2, "Some" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 8, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 10, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 8, "Leo" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Luke", 10, "Kail" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "GroupId", "LastName" },
                values: new object[] { 6, "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sheva", 4, "Joy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Smith", 6, "Marge" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 11, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Gary", 1, "Jon" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Piter", 2, "Kirk" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rodrigez", 7, "Jane" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Marge", 4, "Sterling" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Kail", 10, "Rodrigez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Rick", 3, "Sanchez" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Endy", 8, "Messy" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "FirstName", "GroupId", "LastName" },
                values: new object[] { "Sterling", 10, "Endy" });
        }
    }
}
