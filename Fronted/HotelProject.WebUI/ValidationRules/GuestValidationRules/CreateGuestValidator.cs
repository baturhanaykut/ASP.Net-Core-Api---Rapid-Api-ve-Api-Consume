using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDto;

namespace HotelProject.WebUI.ValidationRules.GuestValidationRules
{
    public class CreateGuestValidator : AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş geçilemez.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 Karekter veri girişi yapınız.");
            RuleFor(x => x.Name).MaximumLength(15).WithMessage("Lütfen en fazla 15 Karekter veri girişi yapınız.");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soy İsim alanı boş geçilemez.");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Lütfen en az 2 Karekter veri girişi yapınız.");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Lütfen en fazla 20 Karekter veri girişi yapınız.");

            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş geçilemez.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Lütfen en az 3 Karekter veri girişi yapınız.");
            RuleFor(x => x.City).MaximumLength(15).WithMessage("Lütfen en fazla 20 Karekter veri girişi yapınız.");
        }
    }
}
