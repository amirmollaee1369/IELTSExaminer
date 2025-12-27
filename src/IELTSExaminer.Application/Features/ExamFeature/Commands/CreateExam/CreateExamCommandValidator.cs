using FluentValidation;

namespace IELTSExaminer.Application.Features.ExamFeature.Commands.CreateExam;

public class CreateExamCommandValidator : AbstractValidator<CreateExamCommand>
{
    public CreateExamCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }
}
