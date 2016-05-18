using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                labelLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // create folders
            var rootdir = System.IO.Directory.CreateDirectory(labelLocation.Text + @"\" + txtPluginName.Text);
            var srcdir = System.IO.Directory.CreateDirectory(labelLocation.Text + @"\" + txtPluginName.Text + @"\src");
            var wpdir = System.IO.Directory.CreateDirectory(labelLocation.Text + @"\" + txtPluginName.Text + @"\src\wp");
            var windowsdir = System.IO.Directory.CreateDirectory(labelLocation.Text + @"\" + txtPluginName.Text + @"\src\windows");
            var wwwdir = System.IO.Directory.CreateDirectory(labelLocation.Text + @"\" + txtPluginName.Text + @"\www");

            string pluginName = txtPluginName.Text;
            string methodName = txtMethodName.Text;

            // create files
            string csfilename = wpdir.FullName + @"\" + txtPluginName.Text + ".cs";
            string proxyfilename = windowsdir.FullName + @"\" + txtPluginName.Text + "Proxy.js";
            string jsfilename = wwwdir.FullName + @"\" + txtPluginName.Text + ".js";
            string xmlfilename = rootdir.FullName + @"\" + "plugin.xml";
            System.IO.File.WriteAllText(csfilename, "");
            System.IO.File.WriteAllText(proxyfilename, "");
            System.IO.File.WriteAllText(jsfilename, "");
            System.IO.File.WriteAllText(xmlfilename, "");

            // create the cs file
            string csfile = PluginGenerator.Properties.Resources.code;
            csfile = csfile.Replace("$PluginName$", pluginName).Replace("$MethodName$", methodName);
            System.IO.File.WriteAllText(csfilename, csfile);

            // create the js proxy file
            string proxyfile = PluginGenerator.Properties.Resources.proxy;
            proxyfile = proxyfile.Replace("$PluginName$", pluginName).Replace("$MethodName$", methodName);
            System.IO.File.WriteAllText(proxyfilename, proxyfile);

            // create the js file
            string jsfile = PluginGenerator.Properties.Resources.javascript;
            jsfile = jsfile.Replace("$PluginName$", pluginName).Replace("$MethodName$", methodName);
            System.IO.File.WriteAllText(jsfilename, jsfile);

            // create the xml file
            string xmlfile = PluginGenerator.Properties.Resources.plugin;
            xmlfile = xmlfile.Replace("$PluginName$", pluginName).Replace("$MethodName$", methodName);
            System.IO.File.WriteAllText(xmlfilename, xmlfile);


        }
    }
}


