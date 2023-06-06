using DataRepository.Repositories.PlanetRepo;
using DTO;
using Microsoft.AspNetCore.Mvc;

namespace SolarSystemApi.Controllers;


[Route("api/[controller]")]
[ApiController]
public class PlanetController : ControllerBase
{
    private readonly IPlanetRepository _planetRepository;
    public PlanetController(IPlanetRepository planetRepo)
    {
        _planetRepository = planetRepo;
    }
    public List<Planet> GetAllPlanets()
    {
        return _planetRepository.GetAllPlanets();
    }
}
