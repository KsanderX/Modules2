﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1_Demo.Models
{
    public enum Status
    {
        Instock, //в налии
        Issued,  //выдана
        UnderMaintenance  // на обслуживании
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } // Название книги
        public DateTime DateOfIssue { get; set; } = DateTime.Now; // Дата выдачи
        public DateTime DateOfDelivery { get; set; } // Дата сдачи
        public string Genre { get; set; } // жанр
        public string Description { get; set; } // описание книги
        public Status BookStatus { get; set; } = Status.Issued; // наличие книги

        public int UserId { get; set; }
        public User User { get; set; }
    }

}
