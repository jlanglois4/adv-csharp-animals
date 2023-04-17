namespace adv_csharp_animals
{
    public class Teacher: Talkable
    {
        public override string Name { get; set; }
        public int Age { get; set; }
        public override string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }

        public override string GetName()
        {
            return $"Teacher: Name={Name} Age={Age}";
        }
    }
}