using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    internal class PostsManager
    {
        private User m_LoggedInUser;
        private List<Post> m_posts;

        public PostsManager(User loggedInUser)
        {
            m_LoggedInUser = loggedInUser;
        }

        private List<Post> FetchAllPosts()
        {
            List<Post> allPosts = new List<Post>();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                allPosts.Add(post);
            }

            return allPosts;
        }

        public List<Post> AllPosts
        {
            get
            {
                if (m_posts == null)
                {
                    m_posts = FetchAllPosts();
                }

                return m_posts;
            }
        }

        public Dictionary<int, int> CalculatePostCountByMonth(int selectedYear)
        {
            Dictionary<int, int> postsByMonth = new Dictionary<int, int>();

            foreach (Post post in m_posts)
            {
                int year = DateTime.Parse(post.CreatedTime.ToString()).Year;
                int month = DateTime.Parse(post.CreatedTime.ToString()).Month;
                if (year == selectedYear)
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

            foreach (Post post in m_posts)
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

    }
}
