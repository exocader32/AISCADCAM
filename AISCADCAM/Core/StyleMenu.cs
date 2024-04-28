using System.Drawing;
using System.Windows.Forms;

namespace AISCADCAM.Core
{
    public class StyleMenu : ProfessionalColorTable
    {
        private static Color back = Color.FromArgb(255, 64, 74, 75);
        private static Color lightback = Color.FromArgb(255, 84, 94, 95);
        private static Color fore = Color.AliceBlue; 
        public override Color ToolStripDropDownBackground => back;
        public override Color ImageMarginGradientBegin => back;
        public override Color ImageMarginGradientMiddle => back;
        public override Color ImageMarginGradientEnd => back;
        public override Color MenuBorder => fore;
        public override Color MenuItemBorder => lightback;
        public override Color MenuItemSelected => lightback;
        public override Color MenuStripGradientBegin => back;
        public override Color MenuStripGradientEnd => back;
        public override Color MenuItemSelectedGradientBegin => lightback;
        public override Color MenuItemSelectedGradientEnd => lightback;
        public override Color MenuItemPressedGradientBegin => back;
        public override Color MenuItemPressedGradientEnd => back;
    }
}
