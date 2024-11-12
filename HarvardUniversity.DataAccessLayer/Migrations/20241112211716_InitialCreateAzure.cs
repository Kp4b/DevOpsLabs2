using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HarvardUniversity.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateAzure : Migration
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
                    { 1, "Kirk", 1, "Messy" },
                    { 2, "Sheva", 5, "Endy" },
                    { 3, "Smith", 9, "Luke" },
                    { 4, "Marko", 11, "Kirk" },
                    { 5, "Snow", 11, "Sterling" },
                    { 6, "Jon", 1, "Kirk" },
                    { 7, "Alex", 10, "Rick" },
                    { 8, "Luke", 11, "Kane" },
                    { 9, "Alex", 2, "Marge" },
                    { 10, "Jon", 11, "Some" },
                    { 11, "Snow", 3, "Messy" },
                    { 12, "Leo", 6, "Rodrigez" },
                    { 13, "Leo", 8, "Rick" },
                    { 14, "Andrue", 7, "Snow" },
                    { 15, "Messy", 5, "Snow" },
                    { 16, "Kane", 3, "Some" },
                    { 17, "Sterling", 1, "Sanchez" },
                    { 18, "Snow", 9, "Jon" },
                    { 19, "Kane", 1, "Mark" },
                    { 20, "Leo", 7, "Alex" },
                    { 21, "Endy", 1, "Snow" },
                    { 22, "Mark", 5, "Andrue" },
                    { 23, "Roberto", 9, "Joy" },
                    { 24, "Kail", 2, "Alex" },
                    { 25, "Sanchez", 8, "Endy" },
                    { 26, "Smith", 1, "Piter" },
                    { 27, "Homer", 5, "Smith" },
                    { 28, "Endy", 5, "Kail" },
                    { 29, "Joy", 4, "Sterling" },
                    { 30, "Mark", 3, "Rodrigez" },
                    { 31, "Marko", 11, "Snow" },
                    { 32, "Mark", 6, "Some" },
                    { 33, "Snow", 3, "Leo" },
                    { 34, "Leo", 9, "Endy" },
                    { 35, "Sanchez", 8, "Marge" },
                    { 36, "Kirk", 9, "Alex" },
                    { 37, "Marge", 11, "Mark" },
                    { 38, "Rick", 5, "Marge" },
                    { 39, "Rick", 1, "Kane" },
                    { 40, "Joy", 1, "Piter" },
                    { 41, "Roberto", 11, "Roberto" },
                    { 42, "Kail", 3, "Mark" },
                    { 43, "Andrue", 8, "Snow" },
                    { 44, "Jane", 2, "Roberto" },
                    { 45, "Alex", 6, "Marge" },
                    { 46, "Mark", 10, "Luke" },
                    { 47, "Sterling", 3, "Andrue" },
                    { 48, "Sterling", 2, "Jane" },
                    { 49, "Jon", 8, "Roberto" },
                    { 50, "Kirk", 10, "Alex" },
                    { 51, "Luke", 10, "Roberto" },
                    { 52, "Snow", 1, "Jon" },
                    { 53, "Marge", 9, "Jane" },
                    { 54, "Kail", 7, "Sheva" },
                    { 55, "Sterling", 4, "Sanchez" },
                    { 56, "Sanchez", 7, "Kirk" },
                    { 57, "Sterling", 1, "Andrue" },
                    { 58, "Alex", 2, "Andrue" },
                    { 59, "Marge", 11, "Joy" },
                    { 60, "Rodrigez", 4, "Alex" },
                    { 61, "Roberto", 11, "Mark" },
                    { 62, "Kail", 1, "Andrue" },
                    { 63, "Andrue", 5, "Jon" },
                    { 64, "Some", 2, "Jon" },
                    { 65, "Snow", 3, "Sterling" },
                    { 66, "Jane", 9, "Rodrigez" },
                    { 67, "Luke", 10, "Piter" },
                    { 68, "Kail", 1, "Messy" },
                    { 69, "Kane", 8, "Some" },
                    { 70, "Marge", 7, "Roberto" },
                    { 71, "Alex", 9, "Messy" },
                    { 72, "Sheva", 6, "Andrue" },
                    { 73, "Marko", 9, "Sterling" },
                    { 74, "Alex", 3, "Leo" },
                    { 75, "Kirk", 11, "Sterling" },
                    { 76, "Joy", 5, "Kail" },
                    { 77, "Jon", 8, "Kail" },
                    { 78, "Marge", 9, "Smith" },
                    { 79, "Endy", 10, "Endy" },
                    { 80, "Smith", 10, "Alex" },
                    { 81, "Sanchez", 11, "Alex" },
                    { 82, "Homer", 6, "Joy" },
                    { 83, "Jane", 2, "Gary" },
                    { 84, "Jane", 8, "Mark" },
                    { 85, "Sanchez", 6, "Rodrigez" },
                    { 86, "Andrue", 10, "Sheva" },
                    { 87, "Snow", 10, "Marge" },
                    { 88, "Sanchez", 7, "Rodrigez" },
                    { 89, "Mark", 5, "Homer" },
                    { 90, "Rick", 4, "Sheva" },
                    { 91, "Leo", 10, "Sterling" },
                    { 92, "Some", 3, "Kirk" },
                    { 93, "Messy", 9, "Sterling" },
                    { 94, "Marge", 1, "Snow" },
                    { 95, "Gary", 8, "Gary" },
                    { 96, "Andrue", 9, "Mark" },
                    { 97, "Rodrigez", 3, "Kail" },
                    { 98, "Joy", 6, "Kirk" },
                    { 99, "Snow", 2, "Roberto" },
                    { 100, "Luke", 1, "Rick" },
                    { 101, "Rodrigez", 1, "Luke" },
                    { 102, "Messy", 1, "Mark" },
                    { 103, "Kane", 6, "Mark" },
                    { 104, "Rick", 7, "Rick" },
                    { 105, "Jane", 3, "Mark" },
                    { 106, "Kail", 1, "Sanchez" },
                    { 107, "Kail", 2, "Marge" },
                    { 108, "Andrue", 1, "Leo" },
                    { 109, "Jon", 4, "Smith" },
                    { 110, "Sterling", 1, "Mark" },
                    { 111, "Kane", 7, "Endy" },
                    { 112, "Kirk", 9, "Roberto" },
                    { 113, "Jane", 8, "Smith" },
                    { 114, "Luke", 9, "Kirk" },
                    { 115, "Roberto", 6, "Kirk" },
                    { 116, "Rick", 2, "Snow" },
                    { 117, "Andrue", 7, "Rodrigez" },
                    { 118, "Piter", 10, "Kail" },
                    { 119, "Alex", 11, "Alex" },
                    { 120, "Kail", 11, "Messy" },
                    { 121, "Marge", 11, "Joy" },
                    { 122, "Kirk", 4, "Alex" },
                    { 123, "Rodrigez", 1, "Marge" },
                    { 124, "Marko", 6, "Andrue" },
                    { 125, "Piter", 1, "Sheva" },
                    { 126, "Jon", 7, "Andrue" },
                    { 127, "Marge", 7, "Kail" },
                    { 128, "Alex", 10, "Gary" },
                    { 129, "Snow", 11, "Messy" },
                    { 130, "Messy", 11, "Mark" },
                    { 131, "Smith", 4, "Alex" },
                    { 132, "Snow", 5, "Rodrigez" },
                    { 133, "Endy", 10, "Marge" },
                    { 134, "Piter", 2, "Joy" },
                    { 135, "Jane", 6, "Rodrigez" },
                    { 136, "Rick", 10, "Rick" },
                    { 137, "Some", 10, "Piter" },
                    { 138, "Sterling", 3, "Some" },
                    { 139, "Messy", 8, "Endy" },
                    { 140, "Messy", 9, "Homer" },
                    { 141, "Sterling", 5, "Snow" },
                    { 142, "Kane", 10, "Luke" },
                    { 143, "Gary", 11, "Snow" },
                    { 144, "Messy", 9, "Roberto" },
                    { 145, "Jane", 10, "Messy" },
                    { 146, "Leo", 1, "Alex" },
                    { 147, "Mark", 9, "Homer" },
                    { 148, "Gary", 2, "Joy" },
                    { 149, "Rick", 7, "Jane" },
                    { 150, "Kane", 3, "Gary" },
                    { 151, "Messy", 3, "Piter" },
                    { 152, "Jon", 1, "Marge" },
                    { 153, "Rodrigez", 2, "Kail" },
                    { 154, "Sanchez", 4, "Jane" },
                    { 155, "Sterling", 3, "Endy" },
                    { 156, "Andrue", 4, "Sheva" },
                    { 157, "Smith", 4, "Messy" },
                    { 158, "Andrue", 6, "Marko" },
                    { 159, "Mark", 10, "Rick" },
                    { 160, "Leo", 11, "Alex" },
                    { 161, "Jon", 2, "Rick" },
                    { 162, "Kane", 11, "Marko" },
                    { 163, "Andrue", 4, "Luke" },
                    { 164, "Homer", 11, "Endy" },
                    { 165, "Homer", 1, "Smith" },
                    { 166, "Marko", 4, "Piter" },
                    { 167, "Endy", 10, "Gary" },
                    { 168, "Endy", 9, "Rodrigez" },
                    { 169, "Some", 11, "Sterling" },
                    { 170, "Alex", 3, "Sheva" },
                    { 171, "Some", 6, "Homer" },
                    { 172, "Marge", 1, "Homer" },
                    { 173, "Leo", 10, "Leo" },
                    { 174, "Gary", 2, "Jon" },
                    { 175, "Sheva", 11, "Sanchez" },
                    { 176, "Roberto", 9, "Homer" },
                    { 177, "Jon", 2, "Rick" },
                    { 178, "Messy", 4, "Homer" },
                    { 179, "Snow", 9, "Marge" },
                    { 180, "Jane", 11, "Rick" },
                    { 181, "Sheva", 1, "Marge" },
                    { 182, "Mark", 6, "Kail" },
                    { 183, "Gary", 5, "Piter" },
                    { 184, "Sanchez", 2, "Some" },
                    { 185, "Kail", 8, "Jon" },
                    { 186, "Piter", 10, "Rodrigez" },
                    { 187, "Endy", 8, "Leo" },
                    { 188, "Luke", 10, "Kail" },
                    { 189, "Sheva", 6, "Smith" },
                    { 190, "Sheva", 4, "Joy" },
                    { 191, "Smith", 6, "Marge" },
                    { 192, "Marge", 11, "Sterling" },
                    { 193, "Gary", 1, "Jon" },
                    { 194, "Piter", 2, "Kirk" },
                    { 195, "Rodrigez", 7, "Jane" },
                    { 196, "Marge", 4, "Sterling" },
                    { 197, "Kail", 10, "Rodrigez" },
                    { 198, "Rick", 3, "Sanchez" },
                    { 199, "Endy", 8, "Messy" },
                    { 200, "Sterling", 10, "Endy" }
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
