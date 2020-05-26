using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Histogram.ViewModel
{
    public static class HistogramHelper
    {
        public static void SetPointsList(ref PointPairList destination, string path)
        {
            string row;
            double x, y;
            
          
            using (StreamReader streamReader = File.OpenText(path))
            {
                while ((row = streamReader.ReadLine()) != null)
                {
                    string[] parts = row.Split(new[] { '\t' });

                    if (parts.Length != 2)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    if (!double.TryParse(parts[0], out x) || !double.TryParse(parts[1], out y))
                    {
                        throw new FormatException();
                    }
                    if (double.Parse(parts[1]) < 0)
                    {
                        destination.Add(new PointPair(x, 0));
                    }
                    else
                    {
                        destination.Add(new PointPair(x, y));
                    }
                }
            }
        }

        public static void AddAcHistogram(GraphPane pane, ZedGraphControl control, PointPairList pairs)
        {
            GraphPane context = control.GraphPane;
            control.GraphPane.CurveList.Clear();
            control.Refresh();
            LineItem coordinates = pane.AddCurve("AC", pairs, Color.Blue, SymbolType.None);
            coordinates.Line.Fill = new Fill(Color.White, Color.Blue, 45f);
            context.XAxis.Scale.Max = 1225;
            context.XAxis.Scale.Min = 0;
            context.Title.Text = "AC electrocity";
            context.XAxis.Title.Text = "Electrocity [A]";
            context.YAxis.Title.Text = "Voltage [V]";
            control.AxisChange();
        }

        public static void AddDcHistogram(GraphPane pane, ZedGraphControl control, PointPairList pairs)
        {
            GraphPane context = control.GraphPane;
            control.GraphPane.CurveList.Clear();
            control.Refresh();
            LineItem coordinates = pane.AddCurve("DC", pairs, Color.Red, SymbolType.None);
            coordinates.Line.Fill = new Fill(Color.White, Color.Red, 45f);
            context.XAxis.Scale.Max = 1225;
            context.XAxis.Scale.Min = 0;
            context.Title.Text = "DC electrocity";
            context.XAxis.Title.Text = "Electrocity [A]";
            context.YAxis.Title.Text = "Voltage [V]";
            control.AxisChange();
        }

        public static void AddPadHistogram(GraphPane pane, ZedGraphControl control, PointPairList pairs)
        {
            GraphPane context = control.GraphPane;
            control.GraphPane.CurveList.Clear();
            control.Refresh();
            LineItem coordinates = pane.AddCurve("PAD", pairs, Color.Green, SymbolType.None);
            coordinates.Line.Fill = new Fill(Color.White, Color.Green, 45f);
            context.XAxis.Scale.Max = 1225;
            context.XAxis.Scale.Min = 0;
            context.Title.Text = "PAD electrocity";
            context.XAxis.Title.Text = "Electrocity [A]";
            context.YAxis.Title.Text = "Voltage [V]";
            control.AxisChange();
        }

        //Ta metoda nie jest obecnie wykorzystywana, służyła tylko do połączenia wszystkich plików txt z jednego folderu w jeden plik txt.
        public static void JoinFiles()
        {
            List<string> filesList = new List<string>();
            string[] filesArray = Directory.GetFiles(@"PathsPad");

            foreach(var file in filesArray)
            {
                filesList.Add(System.IO.File.ReadAllText(file));
            }

            string resultText = string.Join("", filesList.ToArray());

            using(StreamWriter outFile = new StreamWriter(@"PathsPad/result.txt"))
            {
                outFile.Write(resultText);
            }
        }
    }
}
