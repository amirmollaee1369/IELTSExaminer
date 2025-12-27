using FluentValidation;

namespace IELTSExaminer.Application.Features.ExamFeature.Commands.UpdateExam;

public class UpdateExamCommandValidator : AbstractValidator<UpdateExamCommand>
{
    public UpdateExamCommandValidator()
    {
        RuleFor(v => v.Title)
            .MaximumLength(200)
            .NotEmpty();
    }
}
