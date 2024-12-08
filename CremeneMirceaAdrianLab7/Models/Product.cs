using SQLite;
using SQLiteNetExtensions.Attributes;

namespace CremeneMirceaAdrianLab7.Models;

public class Product
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Description { get; set; }
    [OneToMany]
    public List<ListProduct> ListProducts { get; set; }
}