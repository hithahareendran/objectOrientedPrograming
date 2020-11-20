namespace AxeProject
{
    public class Dummy
    {
        private int v1;
        private int v2;
        public int Health { get; set; }
        public int XP  => this.Health == 0 ? 100 : 0;

        public Dummy(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.Health = 10;
        }

        
    }
}