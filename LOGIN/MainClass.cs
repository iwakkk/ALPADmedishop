using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    internal class MainClass
    {
        public static void BlurBackground(Form Model)
        {
            Form background = new Form();
            {
                using (Model)
                {
                    background.StartPosition = FormStartPosition.Manual;
                    background.FormBorderStyle = FormBorderStyle.None;
                    background.Opacity = 0.5d;
                    background.BackColor = Color.Black;
                    background.Size = FormMaster.Instance.Size;
                    background.Location = FormMaster.Instance.Location;
                    background.ShowInTaskbar = false;
                    background.Show();
                    Model.Owner = background;
                    Model.ShowDialog(background);
                    background.Dispose();
                }
            }
        }
    }
}
