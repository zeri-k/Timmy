using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Cloud.Speech.V1;
using System.Runtime.InteropServices;

namespace Timmy
{
    class STT
    {
        public static string resultText = null;
        public static bool writeMore;
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int n, int m);

        public static async Task<object> StreamingMicRecognizeAsync(int seconds)
        {
            if (NAudio.Wave.WaveIn.DeviceCount < 1)
            {
                Console.WriteLine("No microphone!");
                return -1;
            }
            var speech = SpeechClient.Create();
            var streamingCall = speech.StreamingRecognize();
            // config로 초기 요청을 작성하십시오.
            await streamingCall.WriteAsync(
                new StreamingRecognizeRequest()
                {
                    StreamingConfig = new StreamingRecognitionConfig()
                    {
                        Config = new RecognitionConfig()
                        {
                            Encoding = RecognitionConfig.Types.AudioEncoding.Linear16,
                            SampleRateHertz = 16000,
                            LanguageCode = "ko-KR",
                            Model = "command_and_search",
                            UseEnhanced = true,
                            SpeechContexts = { new SpeechContext() { Phrases = { "티미야","인터넷", "켜", "꺼", "구글" } } }
                        },
                        InterimResults = true
                    }
                });
            // 응답이 도착하면 인쇄하십시오.
            Task printResponses = Task.Run(async () =>
            {
                while (await streamingCall.ResponseStream.MoveNext(
                    default(CancellationToken)))
                {
                    foreach (var result in streamingCall.ResponseStream
                        .Current.Results)
                    {
                        foreach (var alternative in result.Alternatives)
                        {
                            resultText = alternative.Transcript;
                            
                            //Console.WriteLine(resultText);
                        }
                    }
                }
            });
            // 마이크에서 읽고 API로 스트리밍합니다.
            object writeLock = new object();
            writeMore = true;
            var waveIn = new NAudio.Wave.WaveInEvent();
            waveIn.DeviceNumber = 0;
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);
            waveIn.DataAvailable +=
                (object sender, NAudio.Wave.WaveInEventArgs args) =>
                {
                    lock (writeLock)
                    {
                        if (!writeMore) return;
                        streamingCall.WriteAsync(
                            new StreamingRecognizeRequest()
                            {
                                AudioContent = Google.Protobuf.ByteString
                                    .CopyFrom(args.Buffer, 0, args.BytesRecorded)
                            }).Wait();
                    }
                };
            waveIn.StartRecording();
            Beep(512, 50);
            Beep(640, 50);
            Console.WriteLine("Speak now.");
            await Task.Delay(TimeSpan.FromSeconds(seconds));
            // 녹음을 중지하고 종료하십시오.
            waveIn.StopRecording();
            lock (writeLock) writeMore = false;
            await streamingCall.WriteCompleteAsync();
            await printResponses;
            return 0;
        }
    }
}
