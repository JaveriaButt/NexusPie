using MaterialDesignThemes.Wpf;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NPIE.Controls
{
    public class ItemMenu
    {
        public ItemMenu(string header, List<SubItem> subItems, PackIconKind icon, ScreenType screen = ScreenType.None)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
            SCREEN = screen;
        }

        public ItemMenu(string header,  PackIconKind icon, ScreenType screen = ScreenType.None)
        {
            Header = header;
            SCREEN = screen;
            Icon = icon;
        }

        public string Header { get; private set; }
        public PackIconKind Icon { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public ScreenType SCREEN { get; private set; }
       
    }

    public class SubItem
    {
        public SubItem(string name , ScreenType screen = ScreenType.None)
        {
            NAME = name;
            SCREEN = screen;
        }
        public string NAME { get; private set; }
        public ScreenType SCREEN { get; private set; }
    }
}
