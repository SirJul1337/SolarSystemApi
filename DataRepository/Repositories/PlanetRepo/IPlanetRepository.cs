using DTO;

namespace DataRepository.Repositories.PlanetRepo;
public interface IPlanetRepository
{
    public List<Planet> GetAllPlanets();
    public void GetPlanetDescription();
    public void GetPlanetDistanceToSun();
    public void GetPlanetDiameter();
}
