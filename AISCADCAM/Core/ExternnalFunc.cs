using System.Collections.Generic;
using System.Linq;
using AISCADCAM.Models;

namespace AISCADCAM.Core
{
    /// <summary> Класс функций расширений </summary>
    public static class _Externnal_Func
    {
        public static Model To(this List<Model> list, string name) => list.FirstOrDefault(l => l.Name == name);
        public static Color To(this List<Color> list, string name) => list.FirstOrDefault(l => l.Name == name);
        public static Size To(this List<Size> list, string name) => list.FirstOrDefault(l => l.Value == name);
        public static Material To(this List<Material> list, string name) => list.FirstOrDefault(l => l.Name == name);
        public static Block To(this List<Block> list, string name) => list.FirstOrDefault(l => l.Name == name);
    }
}
