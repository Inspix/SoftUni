using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Company;
using DropNet;
using DropNet.Exceptions;
using DropNet.Models;

namespace BusinessReportApplication
{
    public partial class Form1 : Form
    {
        private Dictionary<string,IEmployee> reportSelected = new Dictionary<string, IEmployee>();
        private List<Employee> employees = Data.GetEmployees();
        private DropNetClient client;
        private UserLogin userLogin; // not used
        public Form1()
        {
            InitializeComponent();
        }

        private int counter = 1;
        private void importButton_Click(object sender, EventArgs e)
        {
            var hasSales = Data.GetEmployees().OfType<SalesEmployee>().Select(s => s).ToList();
            var developers = Data.GetEmployees().OfType<Developer>().Select(s => s).ToList();
            treeView1.CheckBoxes = true;
            if (hasSales.Count > 0)
            {
                treeView1.Nodes.Add("0","Sales Reports");
                foreach (var salesEmployee in hasSales)
                {
                    
                    treeView1.Nodes[0].Nodes.Add("number" + counter++,salesEmployee.FirstName + " " + salesEmployee.LastName+"'s report");
                }
            }
            if (developers.Count > 0)
            {
                treeView1.Nodes.Add("1","Project Reports");
                foreach (var developer in developers)
                {
                    treeView1.Nodes[1].Nodes.Add("number" + counter++, developer.FirstName + " " + developer.LastName + "'s report");
                }
            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Console.WriteLine(e.Node.Name);
            if (e.Node.Name != "1" && e.Node.Name != "0")
            {
                string[] tags = e.Node.Text.Split(' ');
                var report = employees.Select(s => s).First(s => s.FirstName == tags[0] && s.LastName == tags[1].Remove(tags[1].Length - 2));
                List<string> text = new List<string>();
                text.Add(string.Format("{0} {1} : {2} report\n", report.FirstName, report.LastName, report is Developer ? "Project " : "Sales "));
                text.Add(report.ToString());
                richTextBox1.Lines = text.ToArray();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var report in reportSelected)
            {
                DocumentGenerator.GenerateReport(report.Value);
            }
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name != "1"&& e.Node.Name != "0")
            {
                string[] tags = e.Node.Text.Split(' ');
                var report = employees.Select(s => s).First(s => s.FirstName == tags[0] && s.LastName == tags[1].Remove(tags[1].Length - 2));

                //string result = string.Format("{0} {1} : {2} report\n\n{3}", report.FirstName, report.LastName, report is Developer ? "Project " : "Sales ", report);

                if (e.Node.Checked)
                {
                    SelectParents(e.Node,true);
                    reportSelected.Add(e.Node.Name, report);
                }
                else
                {
                    SelectParents(e.Node, false);
                    reportSelected.Remove(e.Node.Name);
                }
            }
            
        }

        private void SelectParents(TreeNode node, bool isChecked)
        {
            var parent = node.Parent;

            if (parent == null)
                return;

            if (!isChecked && HasCheckedNode(parent))
                return;

            parent.Checked = isChecked;
            SelectParents(parent, isChecked);
        }

        private bool HasCheckedNode(TreeNode node)
        {
            return node.Nodes.Cast<TreeNode>().Any(n => n.Checked);
        }

        private void exportToDropBox_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            //client = new DropNetClient("----", "-----"); // Use your dropbox api tookens
            //var url = client.GetTokenAndBuildUrl("http://www.google.com");
            webBrowser1.DocumentCompleted += WebBrowser1OnDocumentCompleted;
            //webBrowser1.Navigate(url);
            webBrowser1.Navigate("http://www.google.com"); // temp url to avoid crashes

            MessageBox.Show(
                "You have to use your own DropBox api tookens to sync with dropbox\nThe upload is not implemented because no one will make a dev app at dropbox just to test it");

        }

        private void WebBrowser1OnDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Hide();
            if (e.Url.Host.Contains("google"))
            {
                client.GetAccessTokenAsync(
                    user =>
                {
                    userLogin = user;
                    Invoke((MethodInvoker)
                    delegate
                    {
                        webBrowser1.Visible = false;
                    });

                    AccountInfo x = client.AccountInfo();

                    MessageBox.Show(x.display_name.ToString());
                },
                    error =>
                    {
                        var xError = error as DropboxRestException;
                        if (xError != null)
                        {
                            MessageBox.Show(xError.Response.Content);
                        }
                        else
                        {
                            MessageBox.Show(error.Message);
                        }
                    });
            }
        }
    }
}

       //     textBox1.Text = string.Format("{0} {1} : {2} report\r{3}",report.FirstName,report.LastName,report is Developer ? "Project " : "Sales ", report);
//
