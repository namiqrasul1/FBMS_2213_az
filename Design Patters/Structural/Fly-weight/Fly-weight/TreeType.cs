namespace Fly_weight
{
    public class TreeType
    {
        public TreeType(string name, string color, string texture)
        {
            Name = name;
            Color = color;
            Texture = texture;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public string Texture { get; set; }
    }
}