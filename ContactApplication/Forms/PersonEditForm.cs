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
    public partial class PersonEditForm : Form
    {
        public PersonEditForm()
        {
            InitializeComponent();
            contactTableAdapter.Fill(notebookDataSet.Contact);
            contactTypeTableAdapter.Fill(notebookDataSet.ContactType);
            personBindingSource.AddNew();
        }

        public PersonEditForm(int index)
        {
            InitializeComponent();
            personTableAdapter.Fill(notebookDataSet.Person);
            contactTableAdapter.Fill(notebookDataSet.Contact);
            contactTypeTableAdapter.Fill(notebookDataSet.ContactType);
            personBindingSource.Position = index;
            contactTypeBindingSource.Position = index;
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Сохранить".
        /// Сохраняет введенные данные и закрывает форму PersonEditForm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            personBindingSource.EndEdit();
            personTableAdapter.Update(notebookDataSet.Person);
            contactTableAdapter.Update(notebookDataSet.Contact);
            Close();
        }

        /// <summary>
        /// Вызывается при нажатии на кнопку "Отмена".
        /// Закрывает форму PersonEditForm без сохранения введенных данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //  ???????
        //private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    Validate();
        //    personBindingSource.EndEdit();
        //    tableAdapterManager.UpdateAll(notebookDataSet);
        //}

        //private void PersonEditForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.ContactType". При необходимости она может быть перемещена или удалена.
        //    this.contactTypeTableAdapter.Fill(this.notebookDataSet.ContactType);
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.Contact". При необходимости она может быть перемещена или удалена.
        //    this.contactTableAdapter.Fill(this.notebookDataSet.Contact);
        //    // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.Person". При необходимости она может быть перемещена или удалена.
        //    this.personTableAdapter.Fill(this.notebookDataSet.Person);
        //}
    }
}
