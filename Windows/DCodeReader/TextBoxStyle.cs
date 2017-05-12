using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class ExTextBox : TextBox {
    [DllImport("user32")]
    private static extern IntPtr GetWindowDC(IntPtr hwnd);
    private const int WM_NCPAINT = 0x85;
    protected override void WndProc(ref Message m) {
        base.WndProc(ref m);
        if (m.Msg == WM_NCPAINT && this.Focused) {
            var dc = GetWindowDC(Handle);
            using (Graphics g = Graphics.FromHdc(dc)) {
                g.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
            }
        }
    }
}

public static class ControlStyle {
    public static void setBorder(TextBox tb, Color color, PaintEventArgs e, bool focus) {
        if (focus) {
            tb.BorderStyle = BorderStyle.None;
            Pen p = new Pen(color);
            Graphics g = e.Graphics;
            int variance = 3;
            g.DrawRectangle(p, new Rectangle(tb.Location.X - variance, tb.Location.Y - variance, tb.Width + variance, tb.Height + variance + 2));
        } else {
            tb.BorderStyle = BorderStyle.FixedSingle;
        }
    }

    public static void setBorder(Control control, Color color, PaintEventArgs e, bool focus) {
        if (focus) {
            //control.BorderStyle = BorderStyle.None;
            Pen p = new Pen(color);
            Graphics g = e.Graphics;
            int variance = 3;
            g.DrawRectangle(p, new Rectangle(control.Location.X - variance, control.Location.Y - variance, control.Width + variance, control.Height + variance));
        } else {
            //control.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}