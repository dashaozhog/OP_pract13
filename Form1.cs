using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Створити застосунок Windows Forms згідно зі своїм варіантом (відповідно
//порядковому номеру у журналі). Кожен застосунок повинен складатися з щонайменше двох
//частин:
//• Клас(и) бізнес - логіки, який інкапсулює дані та операції і містить щонайменше одну
//подію.
//• Клас форми, який містить елементи керування та виступає підписником на події
//логіки, оновлюючи GUI відповідно до них

//Будильник.Логіка: Клас AlarmClock, який використовує Timer і має метод
//SetAlarm(time). Коли поточний час збігається із заданим, ініціюється подія Alarm.
//Інтерфейс: DateTimePicker для встановлення часу, кнопка "Встановити будильник". При
//спрацюванні події Alarm програма має видавати звуковий сигнал та/або показувати
//MessageBox.

namespace OP_pract13
{
    public partial class Form1 : Form
    {
        //System.Timers.Timer timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        
    }
}
