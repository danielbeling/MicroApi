﻿using MicroApi.Enums;

namespace MicroApi.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UserId { get; set; }
        public virtual UserModel? Usuario { get; set; }

    }
}
