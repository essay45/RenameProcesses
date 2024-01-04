using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RenameProcesses.Models;

namespace RenameProcesses
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Process pro = new Process() { Name = "EP", SubProcesses = new List<Process>() };
            // 添加子节点
            pro.SubProcesses.Add(new Process { Name = "SubProcess1" });
            pro.SubProcesses.Add(new Process { Name = "SubProcess2" });


            treeView.ItemsSource = new List<Process> { pro };

        }
    }
}
