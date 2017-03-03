using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCodeReader {
    static class Utility {
        public static void HighlightText(this RichTextBox myRtb, string word, Color color) {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1) {
                myRtb.Select(index, word.Length -1);
                myRtb.SelectionColor = color;
                //myRtb.SelectionBackColor = Styles.getTheme().getBackGround();
                myRtb.SelectionFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            //myRtb.SelectionColor = Color.Black;
            myRtb.SelectionColor = Styles.getTheme().getForeGround();
        }

        public static void HighlightText(this RichTextBox myRtb, char word, Color color) {

            //if (word == null)
                //return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1) {
                //MessageBox.Show("" + index + " - " + myRtb.Text.Length);
                myRtb.Select(index, 1);
                myRtb.SelectionColor = color;

                //myRtb.SelectionFont = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));

                startIndex = index + 1;

                if (index == myRtb.Text.Length - 1) break;
            }

            myRtb.SelectionStart = s_start;
            myRtb.SelectionLength = 0;
            //myRtb.SelectionColor = Color.Black;
            myRtb.SelectionColor = Styles.getTheme().getForeGround();
        }
    }
}
