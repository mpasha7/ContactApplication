using ContactApplication.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Выход".
        /// Закрывает приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "О программе".
        /// Открывает форму AboutForm со сведениями о программе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Контакты".
        /// Открывает форму PersonListForm для редактирования данных об объектах Person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonListForm persons = new PersonListForm();
            persons.MdiParent = this;
            persons.Show();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Типы контактов".
        /// Открывает форму ContactTypeForm для редактирования данных об объектах ContactType.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void типыКонтактовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContactTypeForm contactTypes = new ContactTypeForm();
            contactTypes.MdiParent = this;
            contactTypes.Show();
        }
    }
}
