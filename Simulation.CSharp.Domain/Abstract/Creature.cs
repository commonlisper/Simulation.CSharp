namespace Simulation.CSharp.Domain.Abstract
{
    public abstract class Creature : Entity
    {
        protected int Hp { get; private set; }
        protected int Speed { get; private set; }

        public Creature(int hp, int speed)
        {
            Hp = hp;
            Speed = speed;
        }

        public abstract void MakeMove();
    }
}
