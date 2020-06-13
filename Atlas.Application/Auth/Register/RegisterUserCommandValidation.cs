using FluentValidation;
namespace Application.Auth.Register
{
    public class RegisterUserCommandValidation : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidation()
        {
            RuleFor(r => r.Username)
                .NotEmpty()
                .Matches("^[a-zA-Z0-9]*$").WithMessage("No special characters");

            RuleFor(r => r.Password)
                .NotEmpty()
                .MinimumLength(8);

            RuleFor(r => r.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}
