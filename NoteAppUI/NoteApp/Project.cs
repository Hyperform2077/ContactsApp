﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    public class Project //класс для добавления всех контактов в проект
    {
        public List<Contact> Contacts { get; }

        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }
    }
}