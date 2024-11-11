using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HarvardUniversity.API.Properties.SwaggerResponseExamples
{
    public class GroupExamples : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            if (operation.OperationId == "GetGroups")
            {
                var responseExample = new OpenApiObject
                {
                    ["groups"] = new OpenApiArray()
                    {
                        new OpenApiObject
                        {
                            ["id"] = new OpenApiInteger(1),
                            ["name"] = new OpenApiString("SX-01"),
                            ["courseId"] = new OpenApiInteger(1),
                            ["courseName"] = new OpenApiString("Perfect course")
                        },
                        new OpenApiObject
                        {
                            ["id"] = new OpenApiInteger(2),
                            ["name"] = new OpenApiString("GX-23"),
                            ["courseId"] = new OpenApiInteger(3),
                            ["courseName"] = new OpenApiString("Wonderful course")
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
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"name\":\"SE-01\",\"courseId\":1}");
            }
            else if (operation.OperationId == "GetDetails")
            {
                operation.Responses["200"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"name\":\"SE-01\",\"courseId\":1,\"courseName\":\"Perfect course\",\"students\":[{\"id\":1,\"firstName\":\"Jhon\",\"lastName\":\"Snow\"},{\"id\":2,\"firstName\":\"Jack\",\"lastName\":\"Black\"}]}");
            }
            else if (operation.OperationId == "Create")
            {
                operation.RequestBody.Content["application/json-patch+json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"name\":\"GR-01\",\"courseId\":1}");
                operation.Responses["201"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":1,\"name\":\"GR-01\",\"courseId\":1}");
            }
            else if (operation.OperationId == "Update")
            {
                operation.RequestBody.Content["application/json-patch+json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"name\":\"GR-02\",\"courseId\":3}");
                operation.Responses["201"].Content["application/json"].Example =
                    OpenApiAnyFactory.CreateFromJson("{\"id\":3,\"name\":\"GR-02\",\"courseId\":3}");
            }
        }
    }
}
