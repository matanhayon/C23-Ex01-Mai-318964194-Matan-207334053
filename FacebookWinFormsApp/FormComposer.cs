namespace BasicFacebookFeatures
{
    public class FormComposer
    {
        private FormBuilder m_FormBuilder;

        public FormComposer(bool i_IsShowAlbums, bool i_IsShowPages, bool i_IsShowPosts)
        {
            IsShowAlbums = i_IsShowAlbums;
            IsShowPages = i_IsShowPages;
            IsShowPosts = i_IsShowPosts;
            m_FormBuilder = new FormBuilder(this);
        }
       

        public bool IsShowAlbums { get; set; }

        public bool IsShowPages { get; set; }

        public bool IsShowPosts { get; set; }

        public FormMain Build()
        {
            return m_FormBuilder.Build();
        }
    }
}
