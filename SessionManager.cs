namespace login
{
    public static class SessionManager
    {
        private static User _currentUser;

        public static User CurrentUser 
        { 
            get { return _currentUser; }
            private set { _currentUser = value; }
        }

        public static bool IsLoggedIn => CurrentUser != null;

        public static bool IsAdmin => IsLoggedIn && CurrentUser.Role == 1;

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
