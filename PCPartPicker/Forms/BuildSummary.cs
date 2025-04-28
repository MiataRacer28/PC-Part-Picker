using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCPartPicker.Models
{
    public partial class BuildSummary : Form
    {
        public BuildSummary(CompletedBuild build)
        {
            InitializeComponent();
            initializeText(build);
        }

        private void BuildSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void initializeText(CompletedBuild build)
        {
            Cpu.Text = "CPU: " + build.Cpu.Name;
            Gpu.Text = "GPU: " + build.Gpu.Name;
            Ram.Text = "RAM: "+ build.Ram.Name;
            Mobo.Text = "Motherboard: " + build.Mobo.Name;

            BuildSum.Text = "Build Summary: " + build.generateBuildSummary();

            CpuSum.Text = build.Cpu.ToString();
            GpuSum.Text = build.Gpu.ToString();
            RamSum.Text = build.Ram.ToString();
            MoboSum.Text = build.Mobo.ToString();
            PerformanceScoreText.Text = "Performance Score: "+ build.avgPerformance().ToString();
        }

        private void BuildSum_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void mainMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); //Main menu form
            mainMenu.Show(); //show main menu
            this.Hide(); //hide database screen
        }
    }
}
