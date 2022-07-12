

namespace Adapter
{
    interface IAudioFile
    {
        void Play();
    }

    class MP3 : IAudioFile
    {
        public void Play()
        {
            Console.WriteLine("Dunya senin, dunya menim. dunya hech kiminnnnn....");
        }
    }

    class Wav : IAudioFile
    {
        public void Play()
        {
            Console.WriteLine("Bu tin senindi, o tin de menim. tinler bizimdi. biz de tinleriiinn!!!!");
        }
    }

    class OGG // from another dll
    {
        public void PlayMusic()
        {
            Console.WriteLine("zehlem gedir senden. maraqlanmadin menle");
        }
    }

    class OGGToAudioFileAdapter : IAudioFile
    {
        private OGG OGGFile { get; set; }

        public OGGToAudioFileAdapter(OGG oGGFile)
        {
            OGGFile = oGGFile;
        }

        public void Play()
        {
            // some amazing converting code
            OGGFile.PlayMusic();
        }
    }

    class Adapter
    {
        static void Main1(string[] args)
        {
            List<IAudioFile> audios = new();

            audios.Add(new Wav());
            audios.Add(new Wav());
            audios.Add(new MP3());
            audios.Add(new MP3());
            audios.Add(new Wav());
            audios.Add(new MP3());
            audios.Add(new Wav());
            audios.Add(new OGGToAudioFileAdapter(new OGG()));

            foreach (var audio in audios)
            {
                audio.Play();
            }
        }
    }
}