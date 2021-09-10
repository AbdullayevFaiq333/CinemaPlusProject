using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminPanel.Utils;

namespace Common
{
    public static class CommonFolder
    {
        public static List<string> FolderList(string folderPath)
        {
            var folderList = new List<string>
            {
                Constants.MovieImageFolderPath,
                @"D:\Programming\CodeAcademy\FrontEnd\FinalProject\limak-az--front-end\public\images"
            };

            return folderList;
        }
    }
}
