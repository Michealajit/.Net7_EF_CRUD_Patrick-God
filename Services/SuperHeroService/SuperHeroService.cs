namespace FormulaApi.Services.SuperHeroService;


using FormulaApi.Models;
using FormulaApi.Data;



public class SuperHeroService : ISuperHeroService
{

 private readonly DataContext _context;
public SuperHeroService(DataContext context)
{
    _context =  context;
}
 
    public async Task<List<Driver>> Get(){
        var hello = await _context.Drivers.ToListAsync();
        Console.WriteLine(hello);
        return hello;
    }

    public async Task<Driver?> GetSingle(int id){
         var hero = await _context.Drivers.FindAsync(id);
        if( hero is null){
            return null;
        }
            return hero;
    }

    public async Task<List<Driver>> post(Driver request){

        _context.Drivers.Add(request);
        await _context.SaveChangesAsync();
        return await _context.Drivers.ToListAsync();
    }


    public async Task<List<Driver>?> update(Driver request,int id){
         var hello = _context.Drivers.Find(id);
            if(hello is null){
                return null;
            }
            hello.Name = request.Name;
            hello.DriverNumber = request.DriverNumber;
            hello.Team = request.Team;
            await _context.SaveChangesAsync();
            return await _context.Drivers.ToListAsync();
    }

    public  async Task<List<Driver>?> delete(int id){
        var hello = _context.Drivers.Find(id);
        if( hello is null){
            return null;}
         _context.Drivers.Remove(hello);
            await _context.SaveChangesAsync();
        return await _context.Drivers.ToListAsync();
    }
}




