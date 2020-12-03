using WebApplication.Dtos;
using WebApplication.Models;

namespace WebApplication.Mappers.Interfaces
{
    /// <inheritdoc cref="IToDtoBaseModelMapper{TModel,TDto}"/>
    public interface IInternshipOverviewMapper
        : IToDtoBaseModelMapper<Internship, InternshipOverviewDto>
    {
    }
}