using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OP_pract13;
//Будильник.Логіка: Клас AlarmClock, який використовує Timer і має метод
//SetAlarm(time). Коли поточний час збігається із заданим, ініціюється подія Alarm.
//Інтерфейс: DateTimePicker для встановлення часу, кнопка "Встановити будильник". При
//спрацюванні події Alarm програма має видавати звуковий сигнал та/або показувати
//MessageBox.
public class AlarmClock {

}



    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

