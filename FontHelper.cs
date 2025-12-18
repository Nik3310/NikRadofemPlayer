using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Reflection;

namespace NikRadofemPlayerWindows
{
    public static class FontHelper
    {
        private static PrivateFontCollection _pfc = new PrivateFontCollection();

        public static void LoadFont(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Загружаем поток ресурса
            using (Stream? stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new Exception($"Не найден ресурс: {resourceName}. Проверь написание и Свойства файла.");
                }

                byte[] fontData = new byte[stream.Length];
                stream.Read(fontData, 0, (int)stream.Length);

                IntPtr data = Marshal.AllocCoTaskMem((int)stream.Length);

                try
                {
                    Marshal.Copy(fontData, 0, data, (int)stream.Length);
                    _pfc.AddMemoryFont(data, (int)stream.Length);
                }
                finally
                {
                    Marshal.FreeCoTaskMem(data);
                }
            }
        }

        public static Font GetFont(float size, FontStyle style = FontStyle.Regular)
        {
            if (_pfc.Families.Length > 0)
            {
                return new Font(_pfc.Families[0], size, style);
            }
            return SystemFonts.DefaultFont;
        }
    }
}