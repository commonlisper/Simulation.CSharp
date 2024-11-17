using Simulation.CSharp.Domain.Abstract;

namespace Simulation.CSharp.Domain.Entities
{
    public class Herbivore : Creature
    {
        public Herbivore(int hp, int speed) : base(hp, speed)
        {
        }

        public override void MakeMove()
        {
            throw new NotImplementedException();
        }
    }
}
