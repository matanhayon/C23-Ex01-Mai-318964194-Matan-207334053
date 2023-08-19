using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class PagesManager
    {
        private User m_LoggedInUser;
        private List<Page> m_pages;

        public PagesManager(User loggedInUser)
        {
            m_LoggedInUser = loggedInUser;
        }

        private List<Page> FetchAllPages()
        {
            List<Page> allPosts = new List<Page>();

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                allPosts.Add(page);
            }

            return allPosts;
        }

        public List<Page> AllPages
        {
            get
            {
                if(m_pages == null)
                {
                    m_pages = FetchAllPages();
                }

                return m_pages;
            }

        }
    }
}
