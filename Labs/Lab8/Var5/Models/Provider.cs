﻿

namespace Var5.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();
    }
}
