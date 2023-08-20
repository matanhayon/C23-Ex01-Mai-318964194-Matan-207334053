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
        private AlbumsManager m_albumsManager;
        private PostsManager m_postsManager;
        private PagesManager m_pagesManager;
        
        public FacebookManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_albumsManager = new AlbumsManager(i_LoginResult.LoggedInUser.Albums);
            m_postsManager = new PostsManager(i_LoginResult.LoggedInUser);
            m_pagesManager = new PagesManager(i_LoginResult.LoggedInUser);
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

