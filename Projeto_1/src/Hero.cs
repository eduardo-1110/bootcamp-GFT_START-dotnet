namespace Projeto_1.src
{
    public abstract class Hero
    {
        public Hero(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
        }

        public Hero(){

        }
        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack(){
            return this.Name + " atacou com a sua espada!!";
        }
    }
}