using System;
using System.Drawing;
using System.Windows.Forms;

public class ModernTabRenderer : ToolStripProfessionalRenderer
{
    public ModernTabRenderer() : base(new ModernColorTable()) { }
}

public class ModernColorTable : ProfessionalColorTable
{
    public override Color ToolStripBorder => Color.White;
    public override Color ToolStripContentPanelGradientBegin => Color.White;
    public override Color ToolStripContentPanelGradientEnd => Color.White;
    public override Color ToolStripGradientBegin => Color.White;
    public override Color ToolStripGradientEnd => Color.White;
    public override Color ToolStripPanelGradientBegin => Color.White;
    public override Color ToolStripPanelGradientEnd => Color.White;
    public override Color ButtonSelectedGradientBegin => Color.LightBlue;
    public override Color ButtonSelectedGradientEnd => Color.DeepSkyBlue;
}

public class ModernTabControl : TabControl
{
    public ModernTabControl()
    {
        SetStyle(ControlStyles.UserPaint, true);
        ItemSize = new Size(120, 40); // Tab size
        SizeMode = TabSizeMode.Fixed; // Uniform size for tabs
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Background
        e.Graphics.Clear(Color.White);

        for (int i = 0; i < TabCount; i++)
        {
            Rectangle tabRect = GetTabRect(i);

            if (SelectedIndex == i)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.DeepSkyBlue), tabRect);
                TextRenderer.DrawText(e.Graphics, TabPages[i].Text, Font, tabRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), tabRect);
                TextRenderer.DrawText(e.Graphics, TabPages[i].Text, Font, tabRect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }
}
