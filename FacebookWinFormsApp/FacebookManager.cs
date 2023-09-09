using System;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FacebookManager
    {
        private static readonly object s_Lock = new object();
        private static FacebookManager s_Instance;
        private FacebookWrapper.LoginResult m_LoginResult;
        private AlbumsManager m_AlbumsManager;
        private PostsManager m_PostsManager;
        private PagesManager m_PagesManager;

        private FacebookManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_AlbumsManager = new AlbumsManager(i_LoginResult.LoggedInUser.Albums);
            m_PostsManager = new PostsManager(i_LoginResult.LoggedInUser);
            m_PagesManager = new PagesManager(i_LoginResult.LoggedInUser);
        }

        public static FacebookManager Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_Lock)
                    {
                        if (s_Instance == null)
                        {
                            throw new Exception("FacebookManager instance has not been initialized.");
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User User
        {
            get { return m_LoginResult.LoggedInUser; }
        }

        public static bool IsLoggedIn()
        {
            return s_Instance != null;
        }

        public AlbumsManager Albums
        {
            get { return m_AlbumsManager; }
        }

        public PostsManager Posts
        {
            get { return m_PostsManager; }
        }

        public PagesManager LikedPages
        {
            get { return m_PagesManager; }
        }

        public static void Initialize(FacebookWrapper.LoginResult i_LoginResult)
        {
            if (s_Instance == null)
            {
                lock (s_Lock)
                {
                    if (s_Instance == null)
                    {
                        s_Instance = new FacebookManager(i_LoginResult);
                    }
                }
            }
            else
            {
                throw new Exception("FacebookManager instance has already been initialized.");
            }
        }

        public void Reset()
        {
            s_Instance = null;
            m_LoginResult = null;
            m_AlbumsManager = null;
            m_PostsManager = null;
            m_PagesManager = null;
        }
    }
}
