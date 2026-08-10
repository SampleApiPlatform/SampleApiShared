using NuGet.SampleSharedModels.Results;

namespace NuGet.SampleSharedModels.Interfaces;
public interface IValidator<T>
{
    ValidationResult Validate(T entity);
}
