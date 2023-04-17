namespace adv_csharp_animals
{
    public class Animal : Talkable
    {
        public override string Name { get; set; }
        public string Speech { get; set; }
        public string UniqueAbility { get; set; }

        public override string Talk()
        {
            return Speech;
        }

        public override string GetName()
        {
            return $"Animal: Name={Name} UniqueAbility={UniqueAbility}";
        }
        
    }
}