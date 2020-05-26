using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO;
using Histogram.ViewModel;

namespace Histogram
{
    public partial class Form1 : Form
    {
        private PointPairList pointsAC = new PointPairList();
        private PointPairList pointsDC = new PointPairList();
        private PointPairList pointsPAD = new PointPairList();
        private const string acPath =  @"PathsAC/AC.txt";
        private const string dcPath = @"PathsDC/DC.txt";
        private const string padPath = @"PathsPad/PAD.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                HistogramHelper.SetPointsList(ref pointsAC, acPath);
                GraphPane graphPane = histogramControl.GraphPane;
                HistogramHelper.AddAcHistogram(graphPane, histogramControl, pointsAC);

                //HistogramHelper.JoinFiles();
            }
            catch(Exception)
            {
                MessageBox.Show("Fail to load histogram!");
            }
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void acButton_Click(object sender, EventArgs e)
        {
            try
            {
                GraphPane graphPane = histogramControl.GraphPane;
                HistogramHelper.SetPointsList(ref pointsAC, acPath);
                HistogramHelper.AddAcHistogram(graphPane, histogramControl, pointsAC);
            }
            catch(Exception)
            {
                MessageBox.Show("Fail to load histogram!");
            }
        }

        private void dcButton_Click(object sender, EventArgs e)
        {
            try
            {
                GraphPane graphPane = histogramControl.GraphPane;
                HistogramHelper.SetPointsList(ref pointsDC, dcPath);
                HistogramHelper.AddDcHistogram(graphPane, histogramControl, pointsDC);
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to load histogram!");
            }
        }

        private void padButton_Click(object sender, EventArgs e)
        {
            try
            {
                GraphPane graphPane = histogramControl.GraphPane;
                HistogramHelper.SetPointsList(ref pointsPAD, padPath);
                HistogramHelper.AddPadHistogram(graphPane, histogramControl, pointsPAD);
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to load histogram!");
            }
        }
    }
}
