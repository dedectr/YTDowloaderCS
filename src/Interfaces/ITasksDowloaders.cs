namespace src.Interfaces {
    public interface ITasksDowloaders {
        Task DowloaderVideo(String url);
        Task DowloaderAudio(String url);
    }
}
