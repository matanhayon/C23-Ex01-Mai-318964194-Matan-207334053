using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PagesManager
    {
        private User m_LoggedInUser;
        private List<Page> m_Pages;

        public PagesManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public List<Page> AllPages
        {
            get
            {
                if (m_Pages == null)
                {
                    m_Pages = fetchAllPages();
                }

                return m_Pages;
            }
        }

        private List<Page> fetchAllPages()
        {
            List<Page> allPosts = new List<Page>();

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                allPosts.Add(page);
            }

            return allPosts;
        }
    }
}
