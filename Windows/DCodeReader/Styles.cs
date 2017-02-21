using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCodeReader {
    abstract class Styles {
        public static int currentTheme = 0;
        public static Theme Light = new Theme(SystemColors.Control, Color.Black, Color.MediumAquamarine, Color.White, new HighLight_Char [] {
            new HighLight_Char('{', Color.Blue)
        });

        public static Theme Dark = new Theme(System.Drawing.ColorTranslator.FromHtml("#103933"), Color.FromArgb(0xffffff), Color.MediumAquamarine, Color.White, new HighLight_Char [] {
            new HighLight_Char('{', Color.Blue)
        });

        public static Theme getThemeById(int id){
            switch (id) {
                case 0:
                    return Light;
                case 1:
                    return Dark;
            }

            return null;
        }

        public static Theme getTheme(){
            return getThemeById(currentTheme);
        }
    }
}
