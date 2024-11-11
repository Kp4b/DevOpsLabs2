using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HarvardUniversity.API.Properties.SwaggerResponseExamples
{
    public class StudentExamples : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId == "GetStudents")
            {
                var responseExample = new OpenApiObject
                {
                    ["students"] = new OpenApiArray()
                    {
                        new OpenApiObject
                        {
                            ["id"] = new OpenApiInteger(1),
                            ["firstName"] = new OpenApiString("Jhon"),
                            ["lastName"] = new OpenApiString("Snow"),
                            ["groupId"] = new OpenApiInteger(1),
                            ["groupName"] = new OpenApiString("GX-1")
                        },
                        new OpenApiObject
                        {
                            ["id"] = new OpenApiInteger(2),
                            ["firstName"] = new OpenApiString("Jack"),
                            ["lastName"] = new OpenApiString("Sparrow"),
                            ["groupId"] = new OpenApiInteger(3),
                            ["groupName"] = new OpenApiString("GX-3")
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
                    new OpenApiObject
                    {
                        ["id"] = new OpenApiInteger(3),
                        ["firstName"] = new OpenApiString("John"),
                        ["lastName"] = new OpenApiString("Snow"),
                        ["groupId"] = new OpenApiInteger(1)
                    };
            }
            else if (operation.OperationId == "GetDetails")
            {
                operation.Responses["200"].Content["application/json"].Example =
                    new OpenApiObject
                    {
                        ["id"] = new OpenApiInteger(1),
                        ["firstName"] = new OpenApiString("John"),
                        ["lastName"] = new OpenApiString("Snow"),
                        ["groupId"] = new OpenApiInteger(1),
                        ["groupName"] = new OpenApiString("GX-1"),
                        ["courseId"] = new OpenApiInteger(1),
                        ["courseName"] = new OpenApiString("Excelent Course")
                    };
            }
            else if (operation.OperationId == "Create")
            {
                operation.RequestBody.Content["application/json-patch+json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"firstName\":\"Jhon\",\"lastName\":\"Snow\",\"groupId\":1}");
                operation.Responses["201"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"firstName\":\"Jhon\",\"lastName\":\"Snow\",\"groupId\":1}");
            }
            else if (operation.OperationId == "Update")
            {
                operation.RequestBody.Content["application/json-patch+json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"firstName\":\"Jhon\",\"lastName\":\"Snow\",\"groupId\":1}");
                operation.Responses["201"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":3,\"firstName\":\"Jhon\",\"lastName\":\"Snow\",\"groupId\":1}");
            }
        }
    }
}
