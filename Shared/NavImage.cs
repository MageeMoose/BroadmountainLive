using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BroadmountainLive.Shared
{
    public class NavImage
    {
        public int Id { get; set; }
        public string ImgUrl { get; set; } = string.Empty;
        public string PathName { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public bool IsExt { get; set; }
        public bool IsSign { get; set; }
        public bool IsTopNav { get; set; }
        public int Delay { get; set; }
    }
}
