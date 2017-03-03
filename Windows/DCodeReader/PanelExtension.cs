using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCodeReader {
     static class PanelExtension {
        public static void ScrollDown(this Panel p, int pos) {
            //pos passed in should be positive
            using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos }) {
                //if ((-p.AutoScrollPosition.Y + 32) >= p.Height) return;
                    p.ScrollControlIntoView(c);
            }
        }
        public static void ScrollUp(this Panel p, int pos) {
            //pos passed in should be negative
            using (Control c = new Control() { Parent = p, Height = 1, Top = pos - 1 }) {
                p.ScrollControlIntoView(c);
            }
        }

        public static void ScrollToBottom(this Panel p) {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom }) {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }

        public static void ScrollToTop(this Panel p) {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Top }) {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }
    }

     /*static class RichTextBoxExtension {
         public static void ScrollDown(this RichTextBox p, int pos) {
             //pos passed in should be positive
             using (Control c = new Control() { Parent = p, Height = 1, Top = p.ClientSize.Height + pos }) {
                 //if ((-p.AutoScrollPosition.Y + 32) >= p.Height) return;
                 p.ScrollControlIntoView(c);
             }
         }
         public static void ScrollUp(this RichTextBox p, int pos) {
             //pos passed in should be negative
             using (Control c = new Control() { Parent = p, Height = 1, Top = pos - 1 }) {
                 p.ScrollControlIntoView(c);
             }
         }

         public static void ScrollToBottom(this RichTextBox p) {
             using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom }) {
                 p.ScrollControlIntoView(c);
                 c.Parent = null;
             }
         }

         public static void ScrollToTop(this RichTextBox p) {
             using (Control c = new Control() { Parent = p, Dock = DockStyle.Top }) {
                 p.ScrollControlIntoView(c);
                 c.Parent = null;
             }
         }
     }*/
}
