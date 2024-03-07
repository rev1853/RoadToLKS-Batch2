using EsemkaBakery.DTOs.Request;
using Swashbuckle.AspNetCore.Filters;

namespace EsemkaBakery.Examples
{
    public class LoginRequestExample : IMultipleExamplesProvider<LoginRequestDTO>
    {
        public IEnumerable<SwaggerExample<LoginRequestDTO>> GetExamples()
        {
            yield return SwaggerExample.Create("John Doe", new LoginRequestDTO
            {
                UsernameOrEmail = "john_doe",
                Password = "password"
            });

            yield return SwaggerExample.Create("Jane Doe", new LoginRequestDTO
            {
                UsernameOrEmail = "jane_doe",
                Password = "password"
            });
        }
    }
}
