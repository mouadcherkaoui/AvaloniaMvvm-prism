using System.Windows.Input;

namespace AvaloniaMvvm.Main.Models
{
    public class MenuItem
    {
        public string MenuName { get; set; } = "";
        public string Label { get; set; } = "";
        public string Icon { get; set; } = "";
        public string ParentName { get; set; } = "";
        public ICommand Command { get; set; }
    }
}