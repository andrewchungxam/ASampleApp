//This is for SQLite

using System;
using SQLite;

namespace ASampleApp.Models
{

    [Table("dog")]
    public class Dog
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(250), Unique]
        public string Name { get; set; }

        [MaxLength(250)]
        public string FurColor { get; set; }

    }
}
