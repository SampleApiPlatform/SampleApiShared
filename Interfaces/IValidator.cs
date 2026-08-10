using NuGet.SampleSharedModels.Results;

namespace NuGet.SampleSharedModels.MovieInterfaces;
public interface IValidator<T>
{
    ValidationResult Validate(T entity);
}
