namespace CatanBoardGame.Core
{
    public class Limit
    {
        public Path Path { get; private set; }
        public void AddPath(Path path) =>
            Path = path;

        public bool HasPath() =>
            Path != null;
    }
}