using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    internal class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        //WritePrivateProfileString - копирует строку в указанный раздел файла инициализации (позволяеет читать данные (настройки
        //разных классов, колекций и тд. Все что мы хотим записать в файл) из файла к примеру при закрытии программы, если только
        //такая функция реализована).
        //GetPrivateProfileString - извлекает строку из указанного раздела в файле инициализации (позволяеет читать данные (настройки
        //разных классов, колекций и тд. Все что мы хотим записать в файл) из файла при запуске программы).
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        //Прописывая структуру [DllImport("kernel32.dll")] и далее через static extern void мы прописываем какую функцию
        //мы экспортируем из внутренней kernel.dll библиотеки.
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);
        //Section = название секции в файле записанное в квадратных скобках.
        public IniFile(string IniPath = null)
        {
            this.Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Value, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }
        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}
