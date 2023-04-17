namespace adv_csharp_animals
{
    public class Dog: Talkable
    {
        public override string Name { get; set; }
        public bool Friendly { get; set; }
        
        public override string Talk()
        {
            return "Bark";
        }

        public override string GetName()
        {
            return $"Dog: Name={Name} Friendly={Friendly}";
        }
    }
}