namespace Snake
{
    public class SnakeSegment
    {
        public int Xpos {  get; set; }
        public int Ypos { get; set; }



        public SnakeSegment(int xpos, int ypos)
        {
            Xpos = xpos;
            Ypos = ypos;
        }
    }
}