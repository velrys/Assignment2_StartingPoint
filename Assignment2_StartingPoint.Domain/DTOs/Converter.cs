using Assignment2_StartingPoint.Domain.Entity;

namespace Assignment2_StartingPoint.Domain.DTOs
{
    public interface Converter<D, E> where D : IDto where E : IEntity
    {
        E ConvertDtoToEntity(D dto);
        D ConvertEntityToDto(E entity);
    }
}