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
        private User m_LoggedInUser;
        private AlbumsManager m_albumsManager;


        public FacebookManager(FacebookWrapper.LoginResult i_LoginResult)
        {
            m_LoggedInUser = i_LoginResult.LoggedInUser;
            m_albumsManager = new AlbumsManager(m_LoggedInUser.Albums);
        }
        /*
        public bool Login(string appId, params string[] permissions)
        {
            // Perform Facebook login logic
        }

        public void Logout()
        {
            // Perform logout logic
        }
        */
       

        internal AlbumsManager Albums
        {
            get { return m_albumsManager; }
        }

        // Other methods for working with data
    }
}

