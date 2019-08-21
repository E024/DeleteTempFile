using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DeleteTempFile
{
    class Program
    {
        static void Main(string[] args)
        {

            var files = Directory.GetFiles(System.Environment.GetEnvironmentVariable("TEMP"));
            foreach (var item in files)
            {
                try
                {
                    File.Delete(item);
                    Console.WriteLine(DateTime.Now + " 删除文件：" + item);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(DateTime.Now + " 删除文件失败：" + item + "ex:" + ex.Message);
                }
            }
            var dirs = Directory.GetDirectories(System.Environment.GetEnvironmentVariable("TEMP"));
            if (dirs != null && dirs.Length != 0)
            {
                foreach (var item in dirs)
                {
                    try
                    {
                        Directory.Delete(item, true);
                        Console.WriteLine(DateTime.Now + " 删除文件夹：" + item);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(DateTime.Now + " 删除文件夹失败：" + item + "ex:" + ex.Message);
                    }
                }
            }

            Console.WriteLine("完成");
        }
    }
}
