using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HarvardUniversity.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "This mission is achieved through research to identify the social and behavioral determinants of health,\r\n                                        development and evaluation of interventions and policies leading to the improvement of population health,\r\n                                        and the preparation of professionals and researchers who will fill leadership positions in advocacy \r\n                                        and public service.", "Society, Human Development and Health" },
                    { 2, "Science and engineering technology enterprises have a great demand for managers \r\n                                        who are not only skilled at business, but who also understand the principles underlying the science, technology, \r\n                                        and engineering ventures they must manage.", "Science, Technology and Management" },
                    { 3, "Through the Graduate School of Arts and Sciences, prospective students apply for \r\n                                        doctoral and master’s degree study at the Harvard John A. Paulson School of Engineering \r\n                                        and Applied Sciences (SEAS). These programs lie at the interfaces of engineering, \r\n                                        the applied sciences (from biology to physics), and technology.", "Engineering and Applied Sciences" },
                    { 4, "Bioengineering is inherently interdisciplinary and combines faculty and research centers from across \r\n                                        our campuses and Harvard teaching hospitals.", "Bioengineering" },
                    { 5, "Applied Mathematics is an interdisciplinary field that focuses on the creation and imaginative \r\n                                        use of mathematical concepts to pose and solve problems over the entire gamut of the physical \r\n                                        and biomedical sciences and engineering, and increasingly, the social sciences and humanities.", "Applied Mathematics" },
                    { 6, "Prospective students apply through GSAS; in the online application, select “Engineering and \r\n                                        Applied Sciences” as your program choice and select 'PhD Computer Science' in the Area of Study menu.", "Computer Science" },
                    { 7, "Data Science lies at the intersection of statistical methodology, computational science, and a wide range \r\n                                        of application domains. The program offers strong preparation in statistical modeling, machine learning, \r\n                                        optimization, management and analysis of massive data sets, and data acquisition.", "Data Science" },
                    { 8, "Electrical Engineering (EE) studies systems that sense, analyze, and interact with the world.\r\n                                        Electrical engineers invent devices for sensing and actuation, design physical substrates for \r\n                                        computation, create algorithms for analysis and control, and expand the theory of information \r\n                                        processing.", "Electrical Engineering" },
                    { 9, "The Department of Near Eastern Languages and Civilizations (NELC) encompasses\r\n                                        the study of ancient and modern peoples, languages, literatures, cultures, \r\n                                        and societies of the Near and Middle East.", "Near Eastern Languages and Civilizations" },
                    { 10, "The PhD program in quantum science and engineering (QSE) lies at the interface of physics,\r\n                                        chemistry, and engineering, providing students with exciting opportunities to explore the fundamentals, realizations, \r\n                                        and applications of QSE.", "Quantum Science and Engineering" }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "SE-01" },
                    { 2, 3, "SE-02" },
                    { 3, 8, "SE-08" },
                    { 4, 2, "JB-01" },
                    { 5, 6, "DC-23" },
                    { 6, 7, "DE-15" },
                    { 7, 5, "SX-02" },
                    { 8, 9, "SX-02" },
                    { 9, 3, "FQ-14" },
                    { 10, 4, "SR-01" },
                    { 11, 6, "SM-03" }
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "Id", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1, "Smith", 8, "Sheva" },
                    { 2, "Luke", 2, "Marko" },
                    { 3, "Mark", 5, "Mark" },
                    { 4, "Homer", 11, "Jane" },
                    { 5, "Smith", 4, "Kail" },
                    { 6, "Luke", 2, "Sheva" },
                    { 7, "Marko", 9, "Leo" },
                    { 8, "Some", 11, "Marge" },
                    { 9, "Homer", 9, "Smith" },
                    { 10, "Kail", 6, "Jane" },
                    { 11, "Kirk", 2, "Snow" },
                    { 12, "Jon", 11, "Marko" },
                    { 13, "Smith", 7, "Kirk" },
                    { 14, "Leo", 9, "Luke" },
                    { 15, "Endy", 6, "Marge" },
                    { 16, "Joy", 5, "Roberto" },
                    { 17, "Rick", 11, "Kane" },
                    { 18, "Mark", 5, "Kail" },
                    { 19, "Kane", 11, "Messy" },
                    { 20, "Jon", 5, "Rick" },
                    { 21, "Messy", 1, "Jane" },
                    { 22, "Andrue", 2, "Gary" },
                    { 23, "Marge", 3, "Snow" },
                    { 24, "Endy", 10, "Piter" },
                    { 25, "Homer", 4, "Snow" },
                    { 26, "Messy", 9, "Kail" },
                    { 27, "Homer", 8, "Alex" },
                    { 28, "Jane", 9, "Mark" },
                    { 29, "Sanchez", 7, "Jane" },
                    { 30, "Homer", 4, "Jane" },
                    { 31, "Smith", 9, "Sheva" },
                    { 32, "Joy", 6, "Sterling" },
                    { 33, "Homer", 3, "Sterling" },
                    { 34, "Smith", 2, "Marge" },
                    { 35, "Gary", 4, "Sheva" },
                    { 36, "Luke", 11, "Sanchez" },
                    { 37, "Roberto", 1, "Roberto" },
                    { 38, "Marko", 3, "Jon" },
                    { 39, "Marge", 1, "Leo" },
                    { 40, "Gary", 7, "Snow" },
                    { 41, "Kail", 4, "Homer" },
                    { 42, "Marge", 10, "Smith" },
                    { 43, "Gary", 1, "Sanchez" },
                    { 44, "Leo", 5, "Kail" },
                    { 45, "Joy", 8, "Kail" },
                    { 46, "Kane", 1, "Endy" },
                    { 47, "Leo", 3, "Homer" },
                    { 48, "Jon", 2, "Roberto" },
                    { 49, "Jane", 1, "Mark" },
                    { 50, "Gary", 6, "Roberto" },
                    { 51, "Snow", 9, "Kirk" },
                    { 52, "Snow", 9, "Kane" },
                    { 53, "Leo", 9, "Roberto" },
                    { 54, "Marge", 11, "Gary" },
                    { 55, "Sterling", 6, "Luke" },
                    { 56, "Andrue", 3, "Andrue" },
                    { 57, "Homer", 5, "Sanchez" },
                    { 58, "Marge", 2, "Snow" },
                    { 59, "Smith", 4, "Gary" },
                    { 60, "Alex", 1, "Rick" },
                    { 61, "Some", 9, "Sheva" },
                    { 62, "Homer", 5, "Joy" },
                    { 63, "Marko", 2, "Rodrigez" },
                    { 64, "Endy", 10, "Rick" },
                    { 65, "Jane", 9, "Endy" },
                    { 66, "Kail", 4, "Rick" },
                    { 67, "Piter", 7, "Gary" },
                    { 68, "Snow", 7, "Joy" },
                    { 69, "Homer", 11, "Kail" },
                    { 70, "Mark", 1, "Joy" },
                    { 71, "Marko", 10, "Snow" },
                    { 72, "Mark", 5, "Luke" },
                    { 73, "Sterling", 11, "Sterling" },
                    { 74, "Sheva", 3, "Endy" },
                    { 75, "Kirk", 10, "Roberto" },
                    { 76, "Gary", 2, "Sanchez" },
                    { 77, "Roberto", 4, "Alex" },
                    { 78, "Some", 10, "Rick" },
                    { 79, "Jon", 4, "Roberto" },
                    { 80, "Sheva", 9, "Kane" },
                    { 81, "Rodrigez", 9, "Kane" },
                    { 82, "Gary", 1, "Snow" },
                    { 83, "Roberto", 8, "Leo" },
                    { 84, "Sterling", 9, "Marge" },
                    { 85, "Sterling", 5, "Alex" },
                    { 86, "Jon", 4, "Piter" },
                    { 87, "Jane", 7, "Sheva" },
                    { 88, "Snow", 9, "Piter" },
                    { 89, "Marge", 8, "Marko" },
                    { 90, "Jane", 5, "Homer" },
                    { 91, "Mark", 5, "Alex" },
                    { 92, "Marge", 11, "Alex" },
                    { 93, "Andrue", 9, "Some" },
                    { 94, "Leo", 10, "Some" },
                    { 95, "Some", 8, "Marko" },
                    { 96, "Kail", 10, "Marko" },
                    { 97, "Sheva", 6, "Jane" },
                    { 98, "Kirk", 9, "Sterling" },
                    { 99, "Kirk", 6, "Snow" },
                    { 100, "Snow", 5, "Snow" },
                    { 101, "Sanchez", 2, "Roberto" },
                    { 102, "Sanchez", 1, "Leo" },
                    { 103, "Rick", 2, "Smith" },
                    { 104, "Roberto", 5, "Homer" },
                    { 105, "Jane", 1, "Endy" },
                    { 106, "Rick", 9, "Snow" },
                    { 107, "Some", 5, "Rodrigez" },
                    { 108, "Kail", 5, "Roberto" },
                    { 109, "Snow", 9, "Alex" },
                    { 110, "Sanchez", 5, "Rodrigez" },
                    { 111, "Snow", 4, "Marko" },
                    { 112, "Jon", 11, "Sheva" },
                    { 113, "Messy", 9, "Some" },
                    { 114, "Luke", 2, "Snow" },
                    { 115, "Endy", 10, "Mark" },
                    { 116, "Sanchez", 6, "Gary" },
                    { 117, "Marko", 9, "Kane" },
                    { 118, "Gary", 5, "Endy" },
                    { 119, "Messy", 1, "Gary" },
                    { 120, "Piter", 5, "Endy" },
                    { 121, "Andrue", 1, "Marko" },
                    { 122, "Andrue", 1, "Smith" },
                    { 123, "Rick", 10, "Alex" },
                    { 124, "Piter", 4, "Messy" },
                    { 125, "Messy", 11, "Jane" },
                    { 126, "Some", 1, "Snow" },
                    { 127, "Luke", 4, "Luke" },
                    { 128, "Gary", 9, "Marko" },
                    { 129, "Joy", 1, "Marge" },
                    { 130, "Marko", 7, "Kail" },
                    { 131, "Kane", 4, "Marko" },
                    { 132, "Piter", 5, "Luke" },
                    { 133, "Sheva", 2, "Jane" },
                    { 134, "Sanchez", 7, "Smith" },
                    { 135, "Kirk", 4, "Marko" },
                    { 136, "Luke", 4, "Leo" },
                    { 137, "Gary", 4, "Snow" },
                    { 138, "Mark", 2, "Jane" },
                    { 139, "Alex", 10, "Some" },
                    { 140, "Snow", 2, "Marko" },
                    { 141, "Joy", 2, "Joy" },
                    { 142, "Alex", 11, "Smith" },
                    { 143, "Marge", 2, "Mark" },
                    { 144, "Snow", 8, "Marge" },
                    { 145, "Kirk", 11, "Snow" },
                    { 146, "Endy", 8, "Andrue" },
                    { 147, "Snow", 7, "Homer" },
                    { 148, "Endy", 4, "Leo" },
                    { 149, "Kail", 6, "Kail" },
                    { 150, "Andrue", 2, "Joy" },
                    { 151, "Kirk", 7, "Marge" },
                    { 152, "Jane", 9, "Jane" },
                    { 153, "Sterling", 5, "Roberto" },
                    { 154, "Rodrigez", 4, "Smith" },
                    { 155, "Mark", 7, "Alex" },
                    { 156, "Messy", 2, "Andrue" },
                    { 157, "Endy", 3, "Homer" },
                    { 158, "Some", 6, "Marge" },
                    { 159, "Endy", 10, "Sterling" },
                    { 160, "Sterling", 11, "Messy" },
                    { 161, "Andrue", 5, "Kail" },
                    { 162, "Gary", 10, "Jon" },
                    { 163, "Marko", 11, "Snow" },
                    { 164, "Joy", 10, "Jon" },
                    { 165, "Endy", 2, "Roberto" },
                    { 166, "Andrue", 5, "Roberto" },
                    { 167, "Smith", 10, "Jane" },
                    { 168, "Jane", 7, "Snow" },
                    { 169, "Alex", 4, "Endy" },
                    { 170, "Smith", 2, "Jon" },
                    { 171, "Some", 10, "Endy" },
                    { 172, "Rick", 8, "Snow" },
                    { 173, "Homer", 8, "Kail" },
                    { 174, "Jane", 3, "Snow" },
                    { 175, "Rodrigez", 11, "Kirk" },
                    { 176, "Jane", 5, "Piter" },
                    { 177, "Jon", 8, "Andrue" },
                    { 178, "Snow", 10, "Sterling" },
                    { 179, "Piter", 3, "Leo" },
                    { 180, "Sanchez", 9, "Gary" },
                    { 181, "Rodrigez", 8, "Rodrigez" },
                    { 182, "Joy", 7, "Smith" },
                    { 183, "Mark", 9, "Messy" },
                    { 184, "Marge", 10, "Rodrigez" },
                    { 185, "Andrue", 9, "Mark" },
                    { 186, "Marko", 5, "Sterling" },
                    { 187, "Sheva", 10, "Jon" },
                    { 188, "Alex", 2, "Jon" },
                    { 189, "Messy", 7, "Smith" },
                    { 190, "Mark", 1, "Leo" },
                    { 191, "Homer", 9, "Messy" },
                    { 192, "Homer", 6, "Messy" },
                    { 193, "Jon", 7, "Some" },
                    { 194, "Jon", 3, "Marge" },
                    { 195, "Rodrigez", 9, "Sterling" },
                    { 196, "Kail", 4, "Homer" },
                    { 197, "Smith", 5, "Messy" },
                    { 198, "Marko", 9, "Marko" },
                    { 199, "Endy", 11, "Mark" },
                    { 200, "Joy", 11, "Homer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Group_CourseId",
                table: "Group",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "Course");
        }
    }
}
