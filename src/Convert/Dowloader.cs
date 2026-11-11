using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace src.Convert
{

    public class Dowloader
    {

        public async Task FazerDowload(String url) {
            var yt = new YoutubeClient();
            var video = await yt.Videos.GetAsync(url);
            var streamMetaDados = await yt.Videos.Streams.GetManifestAsync(video.Id);
            var streamAudioDefine = streamMetaDados.GetAudioOnlyStreams().GetWithHighestBitrate();
            if (streamAudioDefine != null)
            {
                // 4. Define o nome do arquivo de saída
                var fileName = $"{video.Title}.{streamAudioDefine.Container.Name}";

                // 5. Faz o download do stream
                await yt.Videos.Streams.DownloadAsync(streamAudioDefine, fileName);
                Console.WriteLine("Download concluído!");
            }
        }
    }
}
