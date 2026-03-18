using Task.Users;

namespace Task.Services;

public class UserService
{
    List<User> users = new List<User>();

    public void addUser(User user)
    {
        users.Add(user);
    }

    public User findUser(String firstName, String lastName)
    {
        User user;

        foreach (User user1 in users)
        {
            if (user1.firstName == firstName && user1.lastName == lastName)
            {
                return user1;
            }
        }
        return null;
    }
}