using EsemkaBakery.DTOs.Request;
using Swashbuckle.AspNetCore.Filters;

namespace EsemkaBakery.Examples
{
    public class RegisterRequestExample : IExamplesProvider<RegisterRequestDTO>
    {
        public RegisterRequestDTO GetExamples()
        {
            return new RegisterRequestDTO
            {
                Email = "emma@example.com",
                FirstName = "Emma",
                LastName = "Brown",
                Password = "emma123",
                PasswordConfirmation = "emma123",
                Username = "emmabrownie"
            };
        }
    }
}
