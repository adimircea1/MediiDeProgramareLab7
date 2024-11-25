using SQLite;

namespace CremeneMirceaAdrianLab7.Models;

public class ShopList
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    
    [System.ComponentModel.DataAnnotations.MaxLength(250), Unique]
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
}
