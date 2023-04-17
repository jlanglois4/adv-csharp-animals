namespace adv_csharp_animals
{
    public class Cat: Talkable
    {
        public override string Name { get; set; }
        public int MiceKilled { get; set; }

        public void AddMouse()
        {
            MiceKilled++;
        }

        public override string Talk()
        {
            return "Meow";
        }

        public override string GetName()
        {
            return $"Cat: Name={Name} MiceKilled={MiceKilled}";
        }
    }
}