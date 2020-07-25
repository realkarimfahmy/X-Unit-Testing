using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitProject.Mocking
{
    public class VideoService
    {
        private IFileReader _fileReader;
        public VideoService(IFileReader fileReader = null)
        {
            _fileReader = fileReader ?? new FileReader();
        }
        public string ReadVideoTitle()
        {
            var str = _fileReader.Read("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error Passing the video";
            return video.Title;
        }
    }
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }


    }
}
