namespace Task.Services;
using Task.Users;
using Task.Equipment;

public class Rental
{
    public User user{set;get;}
    public Equipment equipment{set;get;}

    public Rental(User user, Equipment equipment)
    {
        this.user = user;
        this.equipment = equipment;
    }
}