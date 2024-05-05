using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace TextAppMaui.Models
{
    [Table("Notes")]
    public class Note
    {
        [PrimaryKey, Column("id"), AutoIncrement]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; } = "";
        [Column("detail")]
        public string Detail { get; set; } = "";
        [Column("is_completed")]
        public bool IsCompleted { get; set; } = false;
    }
}
