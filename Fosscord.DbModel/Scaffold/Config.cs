﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Fosscord.DbModel.Scaffold
{
    [Table("config")]
    public partial class Config
    {
        [Key]
        [Column("key", TypeName = "character varying")]
        public string Key { get; set; } = null!;
        [Column("value")]
        public string? Value { get; set; }
    }
}
