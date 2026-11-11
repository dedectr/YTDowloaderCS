using src.Interfaces;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace src.Infra.Dowloader
{
    public class Dowloaders : ITasksDowloaders
    {
        public async Task DowloaderAudio(String url){
            var yt = new YoutubeClient();
            var video = await yt.Videos.GetAsync(url);
            var streamMetaDados = await yt.Videos.Streams.GetManifestAsync(video.Id);
            var streamAudioDefine = streamMetaDados.GetAudioOnlyStreams().GetWithHighestBitrate();
            if (streamAudioDefine != null)
            {
                // 4. Define o nome do arquivo de saída
                var fileName = $"Music/{video.Title}.{streamAudioDefine.Container.Name}";

                // 5. Faz o download do stream
                await yt.Videos.Streams.DownloadAsync(streamAudioDefine, fileName);
                Console.WriteLine("Download concluído!");
            }
        }
        public async Task DowloaderVideo(String url){
            var yt = new YoutubeClient();
            var video = await yt.Videos.GetAsync(url);
            var streamMetaDados = await yt.Videos.Streams.GetManifestAsync(video.Id);
            var streamAudioDefine = streamMetaDados.GetVideoOnlyStreams().GetWithHighestBitrate();
            if (streamAudioDefine != null)
            {
                // 4. Define o nome do arquivo de saída
                var fileName = $"Video/{video.Title}.{streamAudioDefine.Container.Name}";

                // 5. Faz o download do stream
                await yt.Videos.Streams.DownloadAsync(streamAudioDefine, fileName);
                Console.WriteLine("Download concluído!");
            }
        }
    }
}
