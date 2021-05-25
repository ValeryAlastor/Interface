using System;

namespace Interface.DAL
{
    internal class User
    {
        public int Id { get; internal set; }
        public string UserName { get; internal set; }
        public string Name { get; internal set; }
        public DateTime Date { get; internal set; }
    }
}