using System;

namespace ConsoleApp3
{
    class StrategySamurai
    {
        static void Main(string[] args)
        {
            string currentMap = "Kyoto";
            Warrior war = new Warrior();

            if(currentMap == "Kyoto")
            {
                war.SetAttacker(new Samurai());
            }
            else
            {
                war.SetAttacker(new Berserk());
            }

            war.Attack();
        }
    }

    public class Warrior
    {
        private IAttack _attacker;

        public Warrior() { }

        public Warrior(IAttack attacker) 
        {
            _attacker = attacker;
        }

        public void SetAttacker(IAttack attacker)
        {
            _attacker = attacker;
        }

        public void Attack()
        {
            if(_attacker != null)
            {
                _attacker.PerformAttack();
            }
        }
    }

    public interface IAttack
    {
        void PerformAttack();
    }

    class Berserk : IAttack
    {
        public void PerformAttack()
        {
            Console.WriteLine("Beau Beau Beau");
        }
    }

    class Samurai : IAttack
    {
        public void PerformAttack()
        {
            Console.WriteLine("ボー ボー ボー");
        }
    }
}
