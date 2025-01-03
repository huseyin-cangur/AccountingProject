

using MediatR;

namespace AccountingProject.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public class LoginRequest:IRequest<LoginResponse>
    {
        public string EmailOrUsername { get; set; } 
        public string Password { get; set; }     
    }
}