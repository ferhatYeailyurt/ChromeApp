using System;
using EasyTabs;

namespace ChromeWinFormApplicaiton
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();


            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this); 
        }
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "Yeni Sekme"
                }
            };
        }
        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
