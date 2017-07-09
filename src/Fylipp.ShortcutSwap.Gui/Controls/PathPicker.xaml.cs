using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fylipp.ShortcutSwap.Gui.Controls {

    /// <summary>
    /// Interaction logic for PathPicker.xaml
    /// </summary>
    public partial class PathPicker : UserControl {

        public bool IsFolderPicker { get; set; } = false;

        public PathPicker() {
            InitializeComponent();

            button.Click += (sender, args) => {
                BrowsePath();
            };
        }

        public void BrowsePath() {
            var dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = IsFolderPicker;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                textBox.Text = dialog.FileName;
            }
        }
    }

}
