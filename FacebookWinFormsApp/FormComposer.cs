namespace BasicFacebookFeatures
{
    public class FormComposer
    {
        public bool IsShowAlbums { get; set; }
        public bool IsShowPages { get; set; }
        public bool IsShowPosts { get; set; }

        public class Builder
        {
            private FormComposer m_formComposer = new FormComposer();

            public Builder ShowAlbums(bool show)
            {
                m_formComposer.IsShowAlbums = show;
                return this;
            }

            public Builder ShowPages(bool show)
            {
                m_formComposer.IsShowPages = show;
                return this;
            }

            public Builder ShowPosts(bool show)
            {
                m_formComposer.IsShowPosts = show;
                return this;
            }

            public FormComposer Build()
            {
                return m_formComposer;
            }
        }
    }
}
