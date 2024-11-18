using Simulation.CSharp.Domain.Field;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulation.CSharp.View
{
    public class ConsoleRenderer(Map map) : Renderer(map)
    {
    }
}
