using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZoomSniper
{
    public static class LinkUtils
    {
        //Opens link
        public static void openLink(string link)
        {
            //if ((!link.StartsWith("http://", StringComparison.OrdinalIgnoreCase)) || (!link.StartsWith("https://"))) link = "http://" + link;
            //System.Windows.Forms.MessageBox.Show(link);

            if (!link.StartsWith("http://") && !link.StartsWith("https://"))
            {
                link = "http://" + link;
            }

            //Process.Start("explorer", link);
            System.Diagnostics.Process.Start(link);
        }
    }
}
