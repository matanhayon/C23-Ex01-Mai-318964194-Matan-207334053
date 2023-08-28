namespace BasicFacebookFeatures
{
    public class FormComposer
    {
        private FormBuilder m_formBuilder;
        public bool IsShowAlbums { get; set; }
        public bool IsShowPages { get; set; }
        public bool IsShowPosts { get; set; }


        public FormComposer(bool i_isShowAlbums, bool i_isShowPages, bool i_isShowPosts)
        {
            IsShowAlbums = i_isShowAlbums;
            IsShowPages = i_isShowPages;
            IsShowPosts = i_isShowPosts;
            m_formBuilder = new FormBuilder(this);
        }

        public FormMain Build()
        {
            return m_formBuilder.Build();
        }


    }
}
