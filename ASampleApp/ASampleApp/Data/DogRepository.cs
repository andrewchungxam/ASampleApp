﻿using System;
using System.Collections.Generic;
using SQLite;

using ASampleApp.Models;
using System.Linq;

namespace ASampleApp.Data
{
    public class DogRepository
    {

        private SQLiteConnection sqliteConnection;

        public DogRepository(string dbPath)
        {
            sqliteConnection = new SQLiteConnection(dbPath);
            sqliteConnection.CreateTable<Dog>();

        }

        public void AddNewDog(string name, string furColor)
        {
            sqliteConnection.Insert(new Dog { Name = name, FurColor = furColor });

        }

        public List<Dog> GetAllDogs()
        {
            return sqliteConnection.Table<Dog>().ToList();
        }

        public Dog GetFirstDog()
        {
            return sqliteConnection.Table<Dog>().FirstOrDefault();

        }


    }
}
