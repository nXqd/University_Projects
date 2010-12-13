using System;
using System.Windows.Forms;

namespace QLNS {
    internal static class Program {
        // Press ESC to close windows

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        #region Nested type: CloseWindowBehavior

        public class CloseWindowBehavior : IMessageFilter {
            private const int WM_KEYDOWN = 0x100;
            private const int VK_ESCAPE = 0x1B;

            #region IMessageFilter Members

            bool IMessageFilter.PreFilterMessage(ref Message m) {
                if (m.Msg == WM_KEYDOWN && (int) m.WParam == VK_ESCAPE) {
                    if (Form.ActiveForm != null) {
                        Form.ActiveForm.Close();
                    }
                    return true;
                }
                return false;
            }

            #endregion
        }

        #endregion
    }
}