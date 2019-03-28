using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Class_pharmacy
    /// <summary>
    /// Класс Аптека
    /// Name название аптеки
    /// Adress адресс 
    /// Medicine список медикоментов
    /// Staff список персонала
    /// NumberLicense номер лицензии
    /// DateLicense дата выдачи лицензии
    /// </summary>
    {
        public static string Name { get; set; }
        public static string Adress { get; set; }
        public List<Medicine> Medicine { get; set; }
        public List<Employee> Staff { get; set; }
        public static string NumberLicense { get; set; }
        public static DateTime DateLicense { get; set; }
    }
    /// <summary>
    /// Класс медикоменты
    /// MedicineName наименование медикамента
    /// Type тип упаковки(капли, таблетки, шипучие таблетки... и объем упаковки)
    /// BarCode штрих код
    /// QuantityDepot количество на складе
    /// QuantityPharmacy количество в аптеке
    /// </summary>
    public class Medicine
    {
        public static string MedicineName { get; set; }
        public static string Type { get; set; }
        public static string BarCode { get; set; }
        public static int QuantityDepot { get; set; }
        public static  QuantityPharmacy { get; set; }
    }
    /// <summary>
    /// Класс работник
    /// EmployeeName ФИО работника
    /// Post его должность
    /// Salary зарплата
    /// </summary>
public class Employee
    {
        public static string EmployeeName { get; set; }
        public static string Post { get; set; }
        public static double Salary { get; set; }
    }
}
