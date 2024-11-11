using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HarvardUniversity.API.Properties.SwaggerResponseExamples
{
    public class CourseExamples : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId == "GetCourses")
            {
                var responseExample = new OpenApiObject
                {
                    ["courses"] = new OpenApiArray()
                    {
                        new OpenApiObject
                        {
                            ["id"] = new OpenApiInteger(1),
                            ["name"] = new OpenApiString("Bioengineering"),
                            ["description"] = new OpenApiString("Perfect course")
                        },
                        new OpenApiObject
                        {
                            ["id"] = new OpenApiInteger(2),
                            ["name"] = new OpenApiString("Computer science"),
                            ["description"] = new OpenApiString("Wonderful course")
                        }
                    },
                    ["totalCount"] = new OpenApiInteger(2)
                };
                var response = operation.Responses["200"];
                response.Content["application/json"].Example = responseExample;
            }
            else if (operation.OperationId == "GetByIdAsync")
            {
                operation.Responses["200"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"name\":\"Bioengineering\",\"description\":\"Wonderful course\"}");
            }
            else if (operation.OperationId == "GetDetails")
            {
                operation.Responses["200"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"name\":\"Bioengineering\",\"description\":\"Perfect course\",\"groups\":[{\"id\":1,\"name\":\"SX-01\"},{\"id\":2,\"name\":\"GR-02\"}]}");
            }
            else if (operation.OperationId == "Create")
            {
                operation.RequestBody.Content["application/json-patch+json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"name\":\"New Course\",\"description\":\"New perfect course.\"}");
                operation.Responses["201"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"name\":\"New Course\",\"description\":\"New perfect course.\"}");
            }
            else if (operation.OperationId == "Update")
            {
                operation.RequestBody.Content["application/json-patch+json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"name\":\"Changed Course\",\"description\":\"New changed course.\"}");
                operation.Responses["201"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":3,\"name\":\"Changed Course\",\"description\":\"New changed course.\"}");
            }
        }
    }
}
