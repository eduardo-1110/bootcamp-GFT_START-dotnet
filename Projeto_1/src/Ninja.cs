namespace Projeto_1.src
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
        }
        public override string Attack(){
            return this.Name + " lançou uma kunai!!";
        }
    }
}