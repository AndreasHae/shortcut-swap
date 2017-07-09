using System;
using System.Windows.Controls;

namespace Fylipp.ShortcutSwap.Gui.Controls {
    class NumberTextBox : TextBox {

        public long Number {
            get {
                return long.Parse(Text);
            }
            set {
                var text = value.ToString();

                if (text.Length > MaxLength) {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }

                Text = value.ToString();
            }
        }

        public NumberTextBox(): base() {
            PreviewTextInput += OnTextInput;
        }

        private void OnTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e) {
            if (!char.IsDigit(e.Text, e.Text.Length - 1)) {
                e.Handled = true;
            }
        }
    }
}
