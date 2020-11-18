using log4net;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOCio.Settings
{
    public class About
    {

        #region Constants

        public ILog Logger { get; set; }

        #endregion

        public About(MainMenu form)
        {
            this.Logger = LogManager.GetLogger(Assembly.GetExecutingAssembly().GetTypes().First());
            log4net.Config.XmlConfigurator.Configure();

            form.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start($"https://github.com/juanpas97");

        }

    }
}
