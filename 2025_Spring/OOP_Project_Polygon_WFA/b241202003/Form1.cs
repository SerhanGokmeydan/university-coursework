//***************************************************************************
//************** STUDENT NAME: SERHAN GÖKMEYDAN *****************************
//************** STUDENT NUMBER: B241202003     *****************************
//***************************************************************************

using b241202003.classes;

namespace b241202003;

public partial class Form1 : Form
{
    // bitmap to draw the polygon on
    private Bitmap Canvas { get; init; }

    // nullable polygon to store the polygon data
    private Polygon? Polygon { get; set; }

    // base x-coordinate of the labels to animate them
    private int LblRedBaseX { get; init; }
    private int LblGreenBaseX { get; init; }
    private int LblBlueBaseX { get; init; }
    private int LblSpinIntervalBaseX { get; init; }

    private float Zoom { get; init; }

    public Form1()
    {
        InitializeComponent();

        // define the base x-coordinate of the labels
        LblRedBaseX = lblRedValue.Location.X;
        LblGreenBaseX = lblGreenValue.Location.X;
        LblBlueBaseX = lblBlueValue.Location.X;
        LblSpinIntervalBaseX = lblSpinIntervalValue.Location.X;

        // define the canvas size and create a new bitmap
        Canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);

        // define the polygon as null
        Polygon = null;

        // define the zoom factor
        Zoom = 12f;
    }

    // method to draw the polygon on the canvas
    // @param polygon: the polygon to draw
    private void DrawPolygon(Polygon polygon)
    {
        using (Graphics g = Graphics.FromImage(Canvas))
        {
            // set the smoothing mode to antialias, set to origin into the center of the picture box, and clear the canvas
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TranslateTransform(pictureBox1.Width / 2f + (polygon.Center.X * Zoom),
                pictureBox1.Height / 2f + (polygon.Center.Y * Zoom));
            g.ScaleTransform(Zoom, Zoom);
            g.Clear(Color.White);

            // draw the polygon
            using (Pen pen = new Pen(Color.FromArgb(polygon.Color.R, polygon.Color.G, polygon.Color.B), 2.5f / Zoom))
            {
                for (int i = 0; i < polygon.Vertexes.Count; i++)
                {
                    float y1 = polygon.Vertexes[i].Y;
                    float x1 = polygon.Vertexes[i].X;

                    // take the modulo of the index to wrap around the list
                    float x2 = polygon.Vertexes[(i + 1) % polygon.Vertexes.Count].X;
                    float y2 = polygon.Vertexes[(i + 1) % polygon.Vertexes.Count].Y;

                    g.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        pictureBox1.Image = Canvas;
    }

    // method to rotate the polygon
    private void RotatePolygon()
    {
        // check if the polygon is null
        if (Polygon == null)
        {
            btnReset.PerformClick();
            MessageBox.Show("Please draw a polygon first.");
            return;
        }

        // check if the angle is valid
        if (!float.TryParse(tbxAngle.Text, out float angle) || angle < 0 || angle > 360)
        {
            timer1.Stop();
            MessageBox.Show("Angle must be between 0 and 360 degrees.");
            return;
        }

        // check if the rotation direction is clockwise or counterclockwise, and call the rotation method
        bool ccw = checkCCW.Checked;
        Polygon.RotatePolygon(angle, ccw);
        DrawPolygon(Polygon);
    }

    // method to update the track bar label and move the label to the correct position
    // @param trackBar: the track bar to update
    // @param label: the label to update
    private void UpdateTrackBarLabel(TrackBar trackBar, Label label)
    {
        label.Text = trackBar.Value.ToString();

        // take the padding into account when calculating the position of the label, multiply by 2 due to being on both sides of the track bar
        int padding = 12;
        int usableWidth = trackBar.Width - (padding * 2);

        // calculate the new position of the label based on the track bar value
        int newX = padding + (int)((float)trackBar.Value / trackBar.Maximum * usableWidth);

        // move the label to the new position and subtract half the width of the label to center it
        int labelX = trackBar.Location.X + newX - (label.Width / 2);
        label.Location = new Point(labelX, label.Location.Y);
    }

    // event handler for the track bar scroll event
    // @param sender: the sender of the event
    private void TrackBarScroll(object sender, EventArgs e)
    {
        TrackBar trackBar = (TrackBar)sender;

        if (trackBar == trackRed)
        {
            UpdateTrackBarLabel(trackBar, lblRedValue);
        }

        if (trackBar == trackGreen)
        {
            UpdateTrackBarLabel(trackBar, lblGreenValue);
        }

        if (trackBar == trackBlue)
        {
            UpdateTrackBarLabel(trackBar, lblBlueValue);
        }

        if (trackBar == trackSpinInterval)
        {
            UpdateTrackBarLabel(trackBar, lblSpinIntervalValue);

            // take the value of the spin interval track bar and convert it to seconds
            int second = trackSpinInterval.Value;

            // check if the spin interval is valid, and if it is, start the timer, otherwise stop the timer and rotate the polygon once
            if (second > 0 )
            {
                // multiply the spin interval by 1000 to convert it to milliseconds
                timer1.Interval = second * 1000;
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }

    // method to check if the label values are valid, this method is used in draw and load methods
    // @param xValue: the x-coordinate of the center
    // @param yValue: the y-coordinate of the center
    // @param length: the length of the edges
    // @param edge: the number of edges
    // @param red: the red value, it is optional and defaults to 0
    // @param green: the green value, it is optional and defaults to 0
    // @param blue: the blue value, it is optional and defaults to 0
    private bool CheckPolygonValues(string xValue, string yValue, string length, string edge, string red = "0",
        string green = "0",
        string blue = "0")
    {
        // check if the center coordinates are valid
        if (!float.TryParse(xValue, out float x) ||
            !float.TryParse(yValue, out float y) || x < 0 || x > 3 || y < 0 || y > 3)
        {
            MessageBox.Show("Invalid center coordinates. Please enter values between 0 and 3.");
            return false;
        }

        // check if the edge length and number of edges are valid
        if (!int.TryParse(length, out int edgeLength) || edgeLength < 3 || edgeLength > 9)
        {
            MessageBox.Show("Length of edges must be at least 3 and no more than 9.");
            return false;
        }

        if (!int.TryParse(edge, out int numberOfEdges) || numberOfEdges < 3 || numberOfEdges > 10)
        {
            MessageBox.Show("Number of edges must be at least 3 and no more than 10.");
            return false;
        }

        // check if the RGB values are valid
        if (!int.TryParse(red, out int r) || !int.TryParse(green, out int g) || !int.TryParse(blue, out int b) ||
            r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
        {
            MessageBox.Show("Invalid color values. Please enter values between 0 and 255.");
            return false;
        }

        return true;
    }

    private void btnDraw_Click(object sender, EventArgs e)
    {
        if (!CheckPolygonValues(tbxX.Text, tbxY.Text, tbxLength.Text, tbxEdge.Text))
        {
            return;
        }

        float x = float.Parse(tbxX.Text);
        float y = float.Parse(tbxY.Text);
        int edgeLength = int.Parse(tbxLength.Text);
        int numberOfEdges = int.Parse(tbxEdge.Text);

        // create a new polygon with the specified center, color, and edge length
        Point2D center = new(x, y);
        ColorRgb color = new(trackRed.Value, trackGreen.Value, trackBlue.Value);
        Polygon = new Polygon(center, color, edgeLength, numberOfEdges);

        DrawPolygon(Polygon);
    }

    private void btnRotate_Click(object sender, EventArgs e)
    {
        RotatePolygon();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        RotatePolygon();
    }

    private void btnSaveFile_Click(object sender, EventArgs e)
    {
        // check if the polygon is null, and if it is, show a message box and return
        if (Polygon == null)
        {
            MessageBox.Show("Please draw a polygon first.");
            return;
        }

        // create a save file dialog and show it to the user
        SaveFileDialog file = new SaveFileDialog();
        file.Filter = "Text Files|*.txt";
        file.Title = "Polygon Data";

        // check if the user selected a file, and if they did, save the polygon data to the file
        if (file.ShowDialog() == DialogResult.OK)
        {
            string data =
                $"{Polygon.Center.X};{Polygon.Center.Y};{Polygon.EdgeLength};{Polygon.NumberOfEdges};{Polygon.Color.R};{Polygon.Color.G};{Polygon.Color.B}";

            File.WriteAllText(file.FileName, data);

            MessageBox.Show("Data saved successfully!");
        }
    }

    private void btnLoadFile_Click(object sender, EventArgs e)
    {
        // create a load file dialog and show it to the user
        OpenFileDialog file = new OpenFileDialog();
        file.Filter = "Text Files|*.txt";
        file.Title = "Load polygon data.";

        // check if the user selected a file, and if they did, load the polygon data from the file
        if (file.ShowDialog() == DialogResult.OK)
        {
            string data = File.ReadAllText(file.FileName);

            string[] values = data.Split(';');

            // check if the file contains the proper number of values, and if it does, set the values and call the draw method
            if (values.Length == 7)
            {
                if (!CheckPolygonValues(values[0], values[1], values[2], values[3], values[4], values[5],
                        values[6]))
                {
                    return;
                }


                tbxX.Text = values[0];
                tbxY.Text = values[1];
                tbxLength.Text = values[2];
                tbxEdge.Text = values[3];
                trackRed.Value = int.Parse(values[4]);
                trackGreen.Value = int.Parse(values[5]);
                trackBlue.Value = int.Parse(values[6]);

                // update the labels with the new values
                UpdateTrackBarLabel(trackRed, lblRedValue);
                UpdateTrackBarLabel(trackGreen, lblGreenValue);
                UpdateTrackBarLabel(trackBlue, lblBlueValue);

                btnDraw.PerformClick();
            }
            else
            {
                MessageBox.Show("Selected file does not include the proper polygon data!");
            }
        }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        // call the form load method to reset the form
        // Form1_Load(sender, e);
        using (Graphics g = Graphics.FromImage(Canvas))
        {
            g.Clear(Color.White);
        }

        pictureBox1.Image = Canvas;

        Polygon = null;
        timer1.Stop();

        tbxX.Text = Random.Shared.Next(0, 4).ToString();
        tbxY.Text = Random.Shared.Next(0, 4).ToString();
        tbxLength.Text = Random.Shared.Next(3, 10).ToString();
        tbxEdge.Text = Random.Shared.Next(3, 11).ToString();
        tbxAngle.Text = "0";

        checkCCW.Checked = false;

        trackRed.Value = Random.Shared.Next(0, 256);
        trackGreen.Value = Random.Shared.Next(0, 256);
        trackBlue.Value = Random.Shared.Next(0, 256);
        trackSpinInterval.Value = 0;

        UpdateTrackBarLabel(trackRed, lblRedValue);
        UpdateTrackBarLabel(trackGreen, lblGreenValue);
        UpdateTrackBarLabel(trackBlue, lblBlueValue);
        UpdateTrackBarLabel(trackSpinInterval, lblSpinIntervalValue);
    }
}