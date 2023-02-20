using System.Net;
using System.Text;

namespace fuckhook
{
    internal class GET2
    {
        public static string Download(string adress)
        {
            string result;
            using (var wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                result = wc.DownloadString(adress);
            }
            return result;
        }
    }
}
