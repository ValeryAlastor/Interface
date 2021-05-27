using Interface.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Film : Form
    {
        private List<DAL.Film> _list;

        public Film()
        {
            InitializeComponent();

            _list = new List<DAL.Film>();
            bsUser.DataSource = _list;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _list.Clear();//необходимо чтобы новые строчки не накладывались друг на друга

            List<DAL.Film> list = SQLiteHelper.GetFilms();//получаем список из гетфилмс
            if(list != null && list.Count>0)
            {
                _list.AddRange(list);//Добавляет элементы указанной коллекции в конец списка
                bsUser.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form frm = new Start();
            frm.Show();
            this.Hide();
        }
    }
}

