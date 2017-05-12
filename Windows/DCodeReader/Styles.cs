using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCodeReader {
    abstract class Styles {
        public static int currentTheme = 0;
        public static Theme Light = new Theme(SystemColors.Control, Color.Black, Color.MediumAquamarine, Color.White, new HighLight_Char [] {
            new HighLight_Char('{', Color.Blue)
        }, SystemColors.ControlDarkDark);

        public static Theme Dark = new Theme(System.Drawing.ColorTranslator.FromHtml(/*"#103933""#334444"*/"#444444"), Color.FromArgb(0xffffff), Color.MediumAquamarine, Color.White, new HighLight_Char [] {
            new HighLight_Char('{', Color.Blue)
        }, Color.MediumAquamarine);

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
            if (currentTheme < 0) {
                int hours = new Horas().getHours();
                if (hours >= 18 || hours <= 6){
                    //MessageBox.Show("Noite");
                    return getThemeById(1);
                }else{
                    //MessageBox.Show("Dia");
                    return getThemeById(0);
                }
            }

            return getThemeById(currentTheme);
        }
    }
}
