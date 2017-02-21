using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCodeReader {
    class Theme {
        private Color background, foreground, menuBack, menuFore;
        private HighLight_Char [] highLight;
        public Theme(Color background, Color foreground, Color menuBack, Color menuFore, HighLight_Char [] highLight) {
            this.background = background; this.foreground = foreground;
            this.menuBack = menuBack; this.menuFore = menuFore;
            this.highLight = highLight;
        }

        // Getters

        public Color getBackGround() {
            return background;
        }
        public Color getForeGround() {
            return foreground;
        }
        public Color getMenuBack() {
            return menuBack;
        }
        public Color getMenuFore() {
            return menuFore;
        }

        public Color getHighLightColor(char character) {
            for (int i = 0; i < highLight.Length; i++)
                if (highLight [i].getCharacter().Equals(character))
                    return highLight [i].getColor();
            return foreground;
        }

    }

    class HighLight_Char {
        private char character;
        private Color color;
        public HighLight_Char(char character, Color color) {
            this.character = character;
            this.color = color;
        }

        // Getters

        public char getCharacter() {
            return character;
        }

        public Color getColor(){
            return color;
        }
    }
}
