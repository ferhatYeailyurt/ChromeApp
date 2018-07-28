using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace ChromeWinFormApplicaiton
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppContainer container = new AppContainer();

            //add init tab
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new Form1
                    {
                        Text = "Yeni Sekme"
                    }
                }
                );
            //set intail tab
            container.SelectedTabIndex = 0;


            //create tab 

            TitleBarTabsApplicationContext applicaitonContext = new TitleBarTabsApplicationContext();
            applicaitonContext.Start(container);

            Application.Run(applicaitonContext);

        }
    }
}
