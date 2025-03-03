public class UserSession
{
    private User _currentUser;

    public User GetUser()
    {
        return _currentUser;
    }

    public void SetUser(User user)
    {
        _currentUser = user;
    }

    public void ClearUser()
    {
        _currentUser = null;
    }

    public bool IsUserLoggedIn()
    {
        return _currentUser != null;
    }
}
