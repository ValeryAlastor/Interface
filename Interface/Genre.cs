using System;

using Interface.DAL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interface
{
    
        public partial class Genre : Form
        {
            private List<Genres> _list;

            public Genre()
            {
                InitializeComponent();

                _list = new List<Genres>();
                bsGenre.DataSource = _list;
                dataGridView1.AutoGenerateColumns = true;
            
            }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Form f = new Start();
            f.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _list.Clear();//необходимо чтобы новые строчки не накладывались друг на друга

            List<Genres> list = SQLiteHelper.GetGenre();//получаем список из гетфилмс
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);//Добавляет элементы указанной коллекции в конец списка
                bsGenre.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
        }
    }
}
