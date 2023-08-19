using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class FacebookManager
    {
        private FacebookWrapper.LoginResult m_LoginResult;
        private User m_LoggedInUser;
        private AlbumsManager m_albumsManager;
        private PostsManager m_postsManager;
        private PagesManager m_pagesManager;
        private static bool m_IsLoggedIn = false;
        
        public FacebookManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            m_IsLoggedIn = true;
            m_albumsManager = new AlbumsManager(m_LoggedInUser.Albums);
            m_postsManager = new PostsManager(m_LoggedInUser);
            m_pagesManager = new PagesManager(m_LoggedInUser);
        }

        public static bool isLoggedIn()
        {
            return m_IsLoggedIn;
        }

        public AlbumsManager Albums
        {
            get { return m_albumsManager; }
        }

        public PostsManager Posts
        {
            get { return m_postsManager; }
        }

        public PagesManager LikedPages
        {
            get { return m_pagesManager; }
        }
    }
}

