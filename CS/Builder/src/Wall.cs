namespace Builder.src
{
    public class Wall
    {
        private string material;
        private string position;

        public Wall(string material, string position)
        {
            this.Material = material;
            this.Position = position;
        }

        public string Material { get => material; set => material = value; }
        public string Position { get => position; set => position = value; }
    }
}