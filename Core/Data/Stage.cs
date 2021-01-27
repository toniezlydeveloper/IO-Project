namespace IO_Project.StageInteraction
{
    public class Stage
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; }

        public Stage(string stageName, string description, string iconPath)
        {
            Name = stageName;
            Description = description;
            IconPath = iconPath;
        }
    }
}
