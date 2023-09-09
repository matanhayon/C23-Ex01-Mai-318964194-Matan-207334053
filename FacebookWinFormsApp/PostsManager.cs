using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostsManager
    {
        private User m_LoggedInUser;
        private List<Post> m_Posts;

        public PostsManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public List<Post> AllPosts
        {
            get
            {
                if (m_Posts == null)
                {
                    m_Posts = fetchAllPosts();
                }

                return m_Posts;
            }
        }

        public Dictionary<int, int> CalculatePostCountByMonth(int i_SelectedYear)
        {
            Dictionary<int, int> postsByMonth = new Dictionary<int, int>();

            foreach (Post post in m_Posts)
            {
                int year = DateTime.Parse(post.CreatedTime.ToString()).Year;
                int month = DateTime.Parse(post.CreatedTime.ToString()).Month;
                if (year == i_SelectedYear)
                {
                    if (postsByMonth.ContainsKey(month))
                    {
                        postsByMonth[month]++;
                    }
                    else
                    {
                        postsByMonth[month] = 1;
                    }
                }
            }

            return postsByMonth;
        }

        public Dictionary<int, int> CalculateTotalPostsByYear()
        {
            Dictionary<int, int> totalPostsByYear = new Dictionary<int, int>();

            foreach (Post post in m_Posts)
            {
                int year = DateTime.Parse(post.CreatedTime.ToString()).Year;
                if (totalPostsByYear.ContainsKey(year))
                {
                    totalPostsByYear[year]++;
                }
                else
                {
                    totalPostsByYear[year] = 1;
                }
            }

            return totalPostsByYear;
        }

        private List<Post> fetchAllPosts()
        {
            List<Post> allPosts = new List<Post>();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                allPosts.Add(post);
            }

            return allPosts;
        }
    }
}
