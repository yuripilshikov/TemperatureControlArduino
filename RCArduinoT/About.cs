using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCArduinoT
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void txtAbout_TextChanged(object sender, EventArgs e)
        {

        }

        private void About_Load(object sender, EventArgs e)
        {
            txtAbout.AppendText("Перед началом работы подключить Arduino к компьютеру" + Environment.NewLine);
            txtAbout.AppendText("1 - нажать для получения списка COM-портов" + Environment.NewLine);
            txtAbout.AppendText("2 - выбрать COM, к которому подключен Arduino" + Environment.NewLine);
            txtAbout.AppendText("3 - нажать для подключения к Arduino" + Environment.NewLine);
            txtAbout.AppendText("4 - ввести время таймера в секундах" + Environment.NewLine);
            txtAbout.AppendText("5 - запуск таймера" + Environment.NewLine);
            txtAbout.AppendText("6 - если птица отмечена, то таймер автоматически перезапустится" + Environment.NewLine);
            txtAbout.AppendText("7 - разные полезные сообщения" + Environment.NewLine);
            txtAbout.AppendText("8 - нажатие на эту кнопку привело к отображению текущего окна" + Environment.NewLine);
            txtAbout.AppendText("По окончании таймера включает светодиод, нажимает первую кнопку, ждёт 2 секунды и нажимает вторую кнопку" + Environment.NewLine);
        }
    }
}
