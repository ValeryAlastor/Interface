using System;
using System.ComponentModel;

namespace Interface.DAL
{
    internal class Films
    {
        [DisplayName("ID")]
        [Browsable(false)]
        public int Id { get; internal set; }
        [DisplayName("Название")]
        public string Title { get; internal set; }
        [DisplayName("Описание")]
        public string Description { get; internal set; }
        [DisplayName("Дата выпуска")]
        public DateTime Date { get; internal set; }
        [DisplayName("Возрастное ограничение")]
        public int Age { get; internal set; }
        [DisplayName("Время(мин)")]
        public int Time { get; internal set; }
        [DisplayName("Страна")]
        public string Country { get; internal set; }
        
    }
}