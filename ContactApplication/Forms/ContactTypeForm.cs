using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApplication.Forms
{
    public partial class ContactTypeForm : Form
    {
        public ContactTypeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при загрузке формы ContactTypeForm.
        /// Заполняет таблицу объектов ContactType.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.ContactType". При необходимости она может быть перемещена или удалена.
            contactTypeTableAdapter.Fill(notebookDataSet.ContactType);

        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Сохранить".
        /// Сохраняет изменения в таблице объектов ContactType и закрывает форму ContactTypeForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            contactTypeTableAdapter.Update(notebookDataSet.ContactType);
            Close();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Отмена".
        /// Закрывает форму ContactTypeForm без сохранения изменений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
