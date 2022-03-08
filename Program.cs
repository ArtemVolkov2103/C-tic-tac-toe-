using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practik_4
{
    static class Program
    {
        public static ApplicationContext Context;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Startbutton1_Click(Object sender, EventArgs e)
        {
            //Form2 frm2 = new Form2();
            // var newForm1 = new Form1();
            //var newForm = new Form2();
            //newForm1.Hide();
            //newForm.Show();
            Form2 mainWin = new Form2();
            Form1 StartWin = new Form1();
            StartWin.Hide();
            mainWin.Show();

        }
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new Form1()); // Form1 - название класса вашей первой формы
            Application.Run(new Form1());
            var newForm1 = new Form1();
            var newForm = new Form2();          // Создаем новую форму. Form2 - название класса вашей второй формы
            newForm.player1.Text = newForm1.textBox1.Text;        // playerName1 - строковое свойство для хранения имени первого игрока
            newForm.player2.Text = newForm1.textBox2.Text;         // playerName2 - строковое свойство для хранения имени второго игрока
            newForm.Show();                     // Отображаем вторую форму
            Program.Context.MainForm = newForm; // Делаем вторую форму основной
           // newForm1.Close();                            // Закрываем первую форму
        }
    }
}
