using System.Xml.Linq;

var phone = new Phone("df", 0);
Console.WriteLine(phone.Name + " "  + phone.Cost);
public class Phone
{
    

    public string Name
    {
        get;    
    }
    public decimal Cost
    {
        get;
    }

    public Phone(string name, decimal cost)
    {
         
            if (name.Length < 2 || name.Length > 50)
            {
                throw new ArgumentException("Имя должно содержать от 2 до 50 символов!");
            }
            if (name == null)
            {
                throw new ArgumentNullException("Имя не может быть равно null!");
            }

            Name = name;

        if (cost <= 0)
        {
            throw new ArgumentException("Значение цены должно быть положительным!");
        }
        Cost = cost;



    }
}

