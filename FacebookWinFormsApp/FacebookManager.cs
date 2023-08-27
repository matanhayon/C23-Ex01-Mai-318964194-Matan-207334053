using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    using FacebookWrapper;
    using FacebookWrapper.ObjectModel;
    using System;

    namespace BasicFacebookFeatures
    {
        internal class FacebookManager
        {
            private static readonly object s_Lock = new object();
            private static FacebookManager s_Instance;
            private FacebookWrapper.LoginResult m_LoginResult;
            private AlbumsManager m_albumsManager;
            private PostsManager m_postsManager;
            private PagesManager m_pagesManager;

            private FacebookManager(FacebookWrapper.LoginResult i_LoginResult)
            {
                m_LoginResult = i_LoginResult;
                m_albumsManager = new AlbumsManager(i_LoginResult.LoggedInUser.Albums);
                m_postsManager = new PostsManager(i_LoginResult.LoggedInUser);
                m_pagesManager = new PagesManager(i_LoginResult.LoggedInUser);
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

            public static void Initialize(FacebookWrapper.LoginResult loginResult)
            {
                if (s_Instance == null)
                {
                    lock (s_Lock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new FacebookManager(loginResult);
                        }
                    }
                }
                else
                {
                    throw new Exception("FacebookManager instance has already been initialized.");
                }
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

}

