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
            private List<Directors> _listD;
            private List<Composers> _listC; 

        public Genre()
            {
                InitializeComponent();

                GenresOpen();
                ActorsOpen();
                DirectorsOpen();
                ComposersOpen();

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
            Form f = new Start();
            f.Visible = true;
        }

        private void GenresOpen()
        {
            dataGridView1.AutoGenerateColumns = true;
            _list = new List<Genres>();
            bsGenre.DataSource = _list;
            List<Genres> list = SQLiteHelper.GetGenre();//получаем список из гетфилмс
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);//Добавляет элементы указанной коллекции в конец списка
                bsGenre.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
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

        private void DirectorsOpen()
        {
            dataGridView3.AutoGenerateColumns = true;
            _listD = new List<Directors>();
            bsDirector.DataSource = _listD;
            List<Directors> listD = SQLiteHelper.GetDirectors();
            if (listD != null && listD.Count > 0)
            {
                _listD.AddRange(listD);//Добавляет элементы указанной коллекции в конец списка
                bsDirector.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
        }
        private void ComposersOpen()
        {
            dataGridView4.AutoGenerateColumns = true;
            _listC = new List<Composers>();
            bsComposer.DataSource = _listC;
            List<Composers> listC = SQLiteHelper.GetComposers();//получаем список из гетфилмс
            if (listC != null && listC.Count > 0)
            {
                _listC.AddRange(listC);//Добавляет элементы указанной коллекции в конец списка
                bsComposer.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }
        }

      ]
    }
}
