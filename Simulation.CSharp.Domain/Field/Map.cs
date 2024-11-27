using Simulation.CSharp.Domain.Abstract;

namespace Simulation.CSharp.Domain.Field
{
    public class Map
    {
        private readonly Dictionary<Coordinates, Entity> _map = new();
    }
}