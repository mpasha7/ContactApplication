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
    public partial class PersonListForm : Form
    {
        public PersonListForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вызывается при загрузке формы PersonListForm.
        /// Заполняет таблицу объектов Person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.Person". При необходимости она может быть перемещена или удалена.
            personTableAdapter.Fill(notebookDataSet.Person);
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Добавить".
        /// Открывает форму PersonEditForm для добавления объекта Person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm();
            form.ShowDialog();
            personTableAdapter.Fill(notebookDataSet.Person);/////////////////
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Изменить".
        /// Открывает форму PersonEditForm для изменения объекта Person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(personBindingSource.Position);
            form.ShowDialog();
            personTableAdapter.Fill(notebookDataSet.Person);////////////////
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Удалить".
        /// Удаляет выбранный объект Person.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
            personTableAdapter.Update(notebookDataSet.Person);
        }
    }
}
