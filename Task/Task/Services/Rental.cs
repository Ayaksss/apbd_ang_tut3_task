namespace Task.Services;
using Task.Users;
using Task.Equipment;

public class Rental
{
    public User user{set;get;}
    public Equipment equipment{set;get;}
    public DateTime rentDate{set;get;}
    public DateTime returnDate{set;get;}
    public double lateFee { set; get; }
    public bool isActive { set; get; }

    public Rental(User user, Equipment equipment, DateTime rentDate, int daysToRent)
    {
        this.user = user;
        this.equipment = equipment;
        
        this.rentDate = rentDate;
        this.returnDate = rentDate.AddDays(daysToRent);
        isActive = true;
        
    }
}