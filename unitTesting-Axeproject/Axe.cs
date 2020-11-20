using System;

namespace AxeProject
{
    public class Axe
    {
        private int v1;
        private int v2;
        public int DurabilityPoints { get; set; }
        

        public Axe(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.DurabilityPoints = 10;
        }


        public void Attack(Dummy dummy)
        {
            if (this.DurabilityPoints == 0)
                throw new InvalidOperationException("Broken Weapon");
            if(dummy.Health == 0)
                throw new InvalidOperationException("Dummy already dead");
            this.DurabilityPoints--;
            dummy.Health--;
        }
    }
}