using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace tscui.Service
{
   
    class CFtp
    {
        public static bool UploadFile(string localFile, string FtpAddress, string passwd)
        {
            FileInfo fi = new FileInfo(localFile);
            FileStream fs = fi.OpenRead();
            long length = fs.Length;
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create("ftp://" + FtpAddress + "/" + fi.Name);
            req.Credentials = new NetworkCredential("root", passwd.Trim());
            req.Method = WebRequestMethods.Ftp.UploadFile;
            req.UseBinary = true;
            req.ContentLength = length;
            req.Timeout = 10 * 1000;
            try
            {
                Stream stream = req.GetRequestStream();

                int BufferLength = 2048; //2K   
                byte[] b = new byte[BufferLength];
                int i;
                while ((i = fs.Read(b, 0, BufferLength)) > 0)
                {
                    stream.Write(b, 0, i);
                }
                fs.Close();
                stream.Close();
                stream.Dispose();

                return true;
            }
            catch (WebException ex)
            {
                return false;
            }

        }

        public static List<String> GetFileList(string FtpAddress, string passwd)
        {

            List<string> list = new List<string>();
            try
            {

                FtpWebRequest req = (FtpWebRequest)WebRequest.Create(new Uri("ftp://" + FtpAddress + "/"));
                req.Credentials = new NetworkCredential("root", passwd.Trim());
                req.Method = WebRequestMethods.Ftp.ListDirectory;
                req.UseBinary = true;
                req.UsePassive = true;

                req.Timeout = 5000;

                using (FtpWebResponse res = (FtpWebResponse)req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.Default))
                    {
                        string s;
                        while ((s = sr.ReadLine()) != null)
                        {
                            if(s.IndexOf(".aiton")>-1|| s.IndexOf(".db")>-1)
                             list.Add(s);
                        }
                        sr.Close();
                        res.Close();
                    }
                }
            }
            catch (WebException ex)
            {
             //   MessageBox.Show("异常错误:" + ex.ToString());
                return null;
            }
            return list;

        }

        public static bool DownLoadFile(string filename, string destfile,string FtpAddress, string passwd)
        {
            string tmp = "ftp://" + FtpAddress + "/" + Uri.EscapeUriString(filename); ;
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(tmp);
            req.Method = WebRequestMethods.Ftp.DownloadFile;
            req.UseBinary = true;
            req.UsePassive = true;
            req.Credentials = new NetworkCredential("root", passwd.Trim());
            try
            {
                using (FtpWebResponse res = (FtpWebResponse)req.GetResponse())
                {
                   // string localfile = Path.Combine("C:\\", filename);
                    FileStream fs = new FileStream(destfile, FileMode.Create, FileAccess.Write);
                    int buffer = 1024 * 1024;  //1K缓冲   
                    byte[] b = new byte[buffer];
                    int i = 0;
                    Stream stream = res.GetResponseStream();
                    while ((i = stream.Read(b, 0, buffer)) > 0)
                    {
                        fs.Write(b, 0, i);

                    }
                    fs.Close();
                    res.Close();

                }
               return true;

            }
            catch (WebException ex)
            {
              //  MessageBox.Show("异常错误:" + ex.ToString());
                return false;
            }

        }

        public static bool Delete(string fileName, string FtpAddress, string passwd)
        {
            try
            {
                string uri = "ftp://" + FtpAddress + "/" + fileName;
                FtpWebRequest reqFTP;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));
                reqFTP.Credentials = new NetworkCredential("root", passwd.Trim());
                reqFTP.KeepAlive = false;
                reqFTP.Method = WebRequestMethods.Ftp.DeleteFile;
                string result = String.Empty;
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                long size = response.ContentLength;
                Stream datastream = response.GetResponseStream();
                StreamReader sr = new StreamReader(datastream);
                result = sr.ReadToEnd();
                sr.Close();
                datastream.Close();
                response.Close();
                return true;
            }
            catch (WebException ex)
            {
                return false;
            }
        }
        public static string UrlEncode(string str)  //中文FTP URL编码
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }
    }

}
