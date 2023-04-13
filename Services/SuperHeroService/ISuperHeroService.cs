namespace FormulaApi.Services.SuperHeroService;

using FormulaApi.Models;


public interface ISuperHeroService
{
    Task<List<Driver>> Get();

    Task<Driver?> GetSingle(int id);

    Task<List<Driver>> post(Driver request);


    Task<List<Driver>?> update(Driver request,int id);

    Task<List<Driver>?> delete(int id);
}