namespace Projeto_1.src
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string herotype)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = herotype;
        }
        public override string Attack(){
            return this.Name + " lançou uma magia!!";
        }
        public string Attack(int bonus){

            if(bonus > 10){
                return this.Name + " lançou uma super magia com um bonus de " + bonus + "!";
            }else{
                return this.Name + " lançou uma magia com um bonus de " + bonus + "!";
            }
            
        }
    }
}