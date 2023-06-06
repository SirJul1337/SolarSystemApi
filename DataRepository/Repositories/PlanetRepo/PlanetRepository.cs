

using DTO;

namespace DataRepository.Repositories.PlanetRepo;

public class PlanetRepository : IPlanetRepository
{
    public List<Planet> GetAllPlanets()
    {
        return new List<Planet>();
    }

    public void GetPlanetDescription()
    {
        
    }

    public void GetPlanetDiameter()
    {
        throw new NotImplementedException();
    }

    public void GetPlanetDistanceToSun()
    {
        throw new NotImplementedException();
    }
}
