using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeersTool
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Image imgFile;
        public List<Image> imgFiles;
        public List<PictureBox> picBoxes;
        public XDocument document;
        public int finished, sheet, frame, lastID;
        public long ownerID;
        public XElement root, things, thingsaved;
        public string structureType;
        public int x, y, z;
        public Button addLayerButton;
        public Form1()
        {
            InitializeComponent();
            imgFiles = new List<Image>();
            picBoxes = new List<PictureBox>();
            addLayerButton = new Button();
            addLayerButton.Parent = layerPanel;
            addLayerButton.Text = "+ \n Add Layer";
            addLayerButton.Height = layerPanel.Height;
            addLayerButton.FlatStyle = 0;
            addLayerButton.Click += new EventHandler(imgUpload_Click);

        }
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void structureTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (structureTypeCombo.SelectedIndex) {
                case 0:
                    structureType = "StructureFrameIron";
                    Console.WriteLine("Frame Iron");
                    break;
                case 1:
                    structureType = "StructureFrame";
                    Console.WriteLine("Frame Steel");
                    break;
                default:
                    structureType = null;
                    break;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void imgUpload_Click(object sender, EventArgs e)
        {

            OpenFileDialog fileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" ;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
               
                try
                {
                    imgFileLabel.Text = "";
                    int prevX = layerPanel.Width / openFileDialog1.FileNames.Length;
                    for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {
                        imgFiles.Add(new Bitmap(openFileDialog1.FileNames[i]));
                        imgFileLabel.Text += openFileDialog1.SafeFileNames[i]+", ";

                        PictureBox picBox = new PictureBox();
                        picBox.Left = prevX;
                        picBox.Top = (layerPanel.Height / 2) - (picBox.Height / 2);
                        picBox.Image = imgFiles[i];
                        picBox.Parent = layerPanel;
                        picBox.Click += new EventHandler(testEvent);


                        Label layerLabel = new Label();
                        layerLabel.Top = layerPanel.Height/2;
                        layerLabel.Text = openFileDialog1.SafeFileNames[i];
                        layerLabel.Parent = picBox;
                        layerLabel.BackColor = Color.Transparent;
                        layerLabel.ForeColor = debug1.ForeColor;
                        layerLabel.Font = new Font("Roboto", 10);
                        
                        prevX += picBox.Width;
                    }
                    // Console.WriteLine(openFileDialog1.FileName);
                    //imgFile = new Bitmap(openFileDialog1.FileName);
                    //pictureBox1.Image = imgFile;
                    //imgFileLabel.Text = openFileDialog1.FileName;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            

        }

        private void worldFileUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "XML File(*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    document = XDocument.Load(openFileDialog1.FileName);
                    worldDataFileLabel.Text = openFileDialog1.SafeFileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "XML File(*.xml)|world.xml";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    document.Save(fileDialog.FileName);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong! Make sure you have the PNG and Save file selected, and you pressed the Process button!");
                }
            }
        }
        public void readXML() {
            root = document.Root;
            things = root.Elements("Things").First();
            thingsaved = things.Elements("ThingSaveData").Last();

            lastID = Int32.Parse(thingsaved.Elements("ReferenceId").First().Value);
            ownerID = Int64.Parse(thingsaved.Elements("OwnerSteamId").First().Value);         
        }

        public void readPixels(Image img, int z)
        {
            x = 0;
            y = 0;
            lastID++;
            try
            {
                //finished = 0;
                //sheet = 0;
                //frame = 0;
                for (int i = 1; i < img.Width+1; i++)
                {
                    for (int j = 1; j < img.Height+1; j++)
                    {
                        Bitmap bitmap = new Bitmap(img);

                        x = i + (i - 1);
                        y = j + (j - 1);

                        //Console.WriteLine("(X:" + x + " : Y:" + y + " J: "+j+")");

                        Color pixel = bitmap.GetPixel(i-1, j-1);
                        //Finished Frame
                        if (pixel.R == 0 && pixel.G == 0 && pixel.B == 0)
                        {
                            // Console.WriteLine(" Finished Frame at: " + "(" + i + "," + j + ")");
                            finished++;
                            lastID = lastID + 1;
                            XNamespace ns = "http://www.w3.org/2001/XMLSchema-instance";
                            things.Add(new XElement("ThingSaveData",
                                new XAttribute(ns + "type","StructureSaveData"),
                                new XElement("ReferenceId",lastID),
                                new XElement("PrefabName", structureType),
                                new XElement("CustomName"),
                                new XElement("WorldPosition",
                                    new XElement("x",x),
                                    new XElement("y", z),
                                    new XElement("z", y)),
                                new XElement("WorldRotation", 
                                    new XElement("x",0),
                                    new XElement("y", 0),
                                    new XElement("z", 0),
                                    new XElement("w", 1),
                                    new XElement("eulerAngles",
                                        new XElement("x", 0),
                                        new XElement("y", 0),
                                        new XElement("z", 0))),
                                new XElement("States"),
                                new XElement("IsCustomName","false"),
                                new XElement("CustomColorIndex",-1),
                                new XElement("OwnerSteamId", ownerID),
                                new XElement("Reavents"),
                                new XElement("Indestructable","false"),
                                new XElement("CurrentBuildState",2),
                                new XElement("MothershipReferenceId", 0)
                                ));
                        }

                        //1 Sheet Frame
                        if (pixel.R == 85 && pixel.G == 85 && pixel.B == 85)
                        {
                            sheet++;
                            lastID = lastID + 1;
                            XNamespace ns = "http://www.w3.org/2001/XMLSchema-instance";
                            things.Add(new XElement("ThingSaveData",
                                new XAttribute(ns + "type", "StructureSaveData"),
                                new XElement("ReferenceId", lastID),
                                new XElement("PrefabName", structureType),
                                new XElement("CustomName"),
                                new XElement("WorldPosition",
                                    new XElement("x", x),
                                    new XElement("y", z),
                                    new XElement("z", y)),
                                new XElement("WorldRotation",
                                    new XElement("x", 0),
                                    new XElement("y", 0),
                                    new XElement("z", 0),
                                    new XElement("w", 1),
                                    new XElement("eulerAngles",
                                        new XElement("x", 0),
                                        new XElement("y", 0),
                                        new XElement("z", 0))),
                                new XElement("States"),
                                new XElement("IsCustomName", "false"),
                                new XElement("CustomColorIndex", -1),
                                new XElement("OwnerSteamId", ownerID),
                                new XElement("Reavents"),
                                new XElement("Indestructable", "false"),
                                new XElement("CurrentBuildState", 1),
                                new XElement("MothershipReferenceId", 0)
                                ));
                        }

                        //Just Frame
                        if (pixel.R == 170 && pixel.G == 170 && pixel.B == 170)
                        {
                            frame++;
                            lastID = lastID + 1;
                            XNamespace ns = "http://www.w3.org/2001/XMLSchema-instance";
                            things.Add(new XElement("ThingSaveData",
                                new XAttribute(ns + "type", "StructureSaveData"),
                                new XElement("ReferenceId", lastID),
                                new XElement("PrefabName", structureType),
                                new XElement("CustomName"),
                                new XElement("WorldPosition",
                                    new XElement("x", x),
                                    new XElement("y", z),
                                    new XElement("z", y)),
                                new XElement("WorldRotation",
                                    new XElement("x", 0),
                                    new XElement("y", 0),
                                    new XElement("z", 0),
                                    new XElement("w", 1),
                                    new XElement("eulerAngles",
                                        new XElement("x", 0),
                                        new XElement("y", 0),
                                        new XElement("z", 0))),
                                new XElement("States"),
                                new XElement("IsCustomName", "false"),
                                new XElement("CustomColorIndex", -1),
                                new XElement("OwnerSteamId", ownerID),
                                new XElement("Reavents"),
                                new XElement("Indestructable", "false"),
                                new XElement("CurrentBuildState", 0),
                                new XElement("MothershipReferenceId", 0)
                                ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Make sure you have your structure img and world save file selected! " + ex);
            }
            

            debug1.Text ="Finished: " + finished + " 1 Sheet: " + sheet + " Just Frame: " + frame;
        }

        private void processImg_Click(object sender, EventArgs e)
        {
            if (imgFiles != null && document != null && structureType != null)
            {
                readXML();

                for (int i = 0; i < imgFiles.Count(); i++)
                {

                    int y = (i + (i - 1)) + (int)numericUpDown1.Value + 1;
                    Console.WriteLine(y);
                    readPixels(imgFiles[i], y);
                }

                richTextBox1.Text += root;
            }

        }
        void testEvent(object sender, EventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox1.Image = pictureBox.Image;
            Console.WriteLine("Clicked on: " + pictureBox.Name);
        }


    }
}


/*
 * <ThingSaveData xsi:type="StructureSaveData">
      <ReferenceId>97</ReferenceId>
      <PrefabName>StructureFrameIron</PrefabName>
      <CustomName />
      <WorldPosition>
        <x>29</x>
        <y>1</y>
        <z>-5</z>
      </WorldPosition>
      <WorldRotation>
        <x>0</x>
        <y>0</y>
        <z>0</z>
        <w>1</w>
        <eulerAngles>
          <x>0</x>
          <y>0</y>
          <z>0</z>
        </eulerAngles>
      </WorldRotation>
      <States />
      <IsCustomName>false</IsCustomName>
      <CustomColorIndex>-1</CustomColorIndex>
      <OwnerSteamId>****Steam ID****</OwnerSteamId>
      <Reagents />
      <Indestructable>false</Indestructable>
      <CurrentBuildState>2</CurrentBuildState>
      <MothershipReferenceId>0</MothershipReferenceId>
    </ThingSaveData>
 * 
 * 
 * 
 */
