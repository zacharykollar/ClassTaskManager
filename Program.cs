using System.Windows.Forms;
namespace ClassManagerApp
{
    internal class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        public static Tuple<DialogResult, string, DateTime> InputBox(string title, string message)
        {
            InputBox inputBox = new InputBox(title, message);
            inputBox.ShowDialog();
            return new Tuple<DialogResult, string, DateTime>(inputBox.DialogResult, inputBox.Output, inputBox.Time);
        }
    }
}