using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assets.BaseObject
{
    public class QuestionResourcePath
    {
        private readonly string _path;

        public QuestionResourcePath(string resourcePathDirectory)
        {
            // ディレクトリ以外は禁止にしとく（とりあえず）
            if (File.GetAttributes(resourcePathDirectory) != FileAttributes.Directory)
            {
                throw new IOException("指定はディレクトリにしてください。");
            }

            // 末尾は鬱陶しいから先に着けとく
            if (!resourcePathDirectory.EndsWith("/"))
            {
                resourcePathDirectory += "/";
            }
            _path = resourcePathDirectory;
        }

        /// <summary>
        /// 回答を取得する
        /// </summary>
        /// <returns></returns>
        public string AnswerName
        {
            get
            {
                // 1つ上の階層が回答。末尾の/を削って無理やりファイル名っぽくすることで取得する
                string dummy = _path.TrimEnd('/') + "dummy.dummy";
                return GetLastDirectoryName(dummy);
            }
        }

        public string AnswerFullName
        {
            get
            {
                return GetLastDirectoryName(_path);
            }
        }

        public string SpritePath
        {
            get
            {
                return _path + "main.png";
            }
        }

        private string GetLastDirectoryName(string path)
        {
            return Path.GetFileName(Path.GetDirectoryName(path));
        }
    }
}
