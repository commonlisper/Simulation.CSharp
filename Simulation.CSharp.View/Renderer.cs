using Simulation.CSharp.Domain.Field;

namespace Simulation.CSharp.View
{
    public abstract class Renderer(Map map)
    {
        private readonly Map _map = map;
    }
}
