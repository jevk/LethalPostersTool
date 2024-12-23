namespace LethalPostersCreator
{
    internal class ImageData
    {
        public Image image { get; set; }
        public int xOffsetPercentage { get; set; }
        public int yOffsetPercentage { get; set; }

        public ImageData(Image image)
        {
            this.image = image;
            this.xOffsetPercentage = 50;
            this.yOffsetPercentage = 50;
        }
    }
}
