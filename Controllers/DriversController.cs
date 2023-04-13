namespace FormulaApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using FormulaApi.Models;
using FormulaApi.Services.SuperHeroService;

[ApiController]
[Route("[controller]")]
public class DriverController : ControllerBase
{
    private readonly ISuperHeroService _superHeroService ;
    public DriverController(ISuperHeroService superHeroService) 
    {
        _superHeroService = superHeroService;
    }
   

    [HttpGet]
    public async Task<ActionResult<Driver>> Get()
    {
        var hello = await _superHeroService.Get();
            return Ok(hello);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<Driver>> GetSingle(int id)
    {
       var hello = await _superHeroService.GetSingle(id);
       if(hello is null){
        return NotFound("Not Found");
       }
       return Ok(hello);
    }
    

     [HttpPost]
    public async Task<ActionResult<Driver>> post(Driver request)
    {
        
           var hello = await _superHeroService.post(request);
           return Ok(hello);

    }

        [HttpPut("{id}")]
        public async  Task<ActionResult<Driver>> update(Driver request,int id)
        {   
          var hello = await _superHeroService.update(request,id);
           if (hello is null ){
            return NotFound("not found");
           }
           return Ok(hello);

        }

          [HttpDelete("{id}")]
    public async  Task<ActionResult<Driver>> delete(int id)
    {   
        var hello =await _superHeroService.delete(id);

        if(hello is null)
            return NotFound("not found");

        return Ok(hello);

    }

}
