using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OP_pract13
{
    //Будильник.Логіка: Клас AlarmClock, який використовує Timer і має метод
    //SetAlarm(time). Коли поточний час збігається із заданим, ініціюється подія Alarm.
    //Інтерфейс: DateTimePicker для встановлення часу, кнопка "Встановити будильник". При
    //спрацюванні події Alarm програма має видавати звуковий сигнал та/або показувати
    //MessageBox.
    public class AlarmClock
    {
        System.Timers.Timer timer;

        public AlarmClock()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker1.Value;
            // Check if current time matches the alarm time
            if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
            {
                timer.Stop();
                UpdateLable upd = UpdateDataLable;
                //Update label control in mutiple thread
                if (lblStatus.InvokeRequired)
                    Invoke(upd, lblStatus, "Stop"); // Ensures thread-safe updates to the label control in a multi-threaded environment.
                                                    // Trigger the alarm (play a sound, show a message, etc.)
                MessageBox.Show("Ring ring ring...", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
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

}
