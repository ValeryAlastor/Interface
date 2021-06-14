using System;

using Interface.DAL;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interface
{
    
        public partial class Genre : Form
        {
            private List<Genres> _list;
            private List<Actors> _listA;

        public Genre()
            {
                InitializeComponent();

                _list = new List<Genres>();
               

                bsGenre.DataSource = _list;
                

            dataGridView1.AutoGenerateColumns = true;
            dataGridView2.AutoGenerateColumns = true;

            List<Genres> list = SQLiteHelper.GetGenre();//получаем список из гетфилмс
            

            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);//Добавляет элементы указанной коллекции в конец списка
                bsGenre.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
            ActorsOpen();

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Form f = new Start();
            f.Visible = true;
        }

        private void ActorsOpen()
        {
             dataGridView2.AutoGenerateColumns = true;
            _listA = new List<Actors>();
            bsActor.DataSource = _listA;
            List<Actors> listA = SQLiteHelper.GetActors();
            if (listA != null && listA.Count > 0)
            {
                _listA.AddRange(listA);//Добавляет элементы указанной коллекции в конец списка
                bsActor.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
        }
    }
}
