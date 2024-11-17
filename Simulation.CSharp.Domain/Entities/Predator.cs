using Simulation.CSharp.Domain.Abstract;

namespace Simulation.CSharp.Domain.Entities
{
    public class Predator : Creature
    {
        public int AttackPower { get; init; }

        public Predator(int hp, int speed, int attackPower) : base(hp, speed)
        {
            AttackPower = attackPower;
        }

        public override void MakeMove()
        {
            throw new NotImplementedException();
        }
    }
}
