using System;
using System.Collections.Generic;
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
        public Image imgFile;
        public List<Image> imgFiles;
        public XDocument document;
        public int finished, sheet, frame, lastID;
        public long ownerID;
        public XElement root, things, thingsaved;
        public string structureType;
        public int x, y, z;

        public Form1()
        {
            InitializeComponent();
            imgFiles = new List<Image>();
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
                    for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {
                        imgFiles.Add(new Bitmap(openFileDialog1.FileNames[i]));
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
                    worldDataFileLabel.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            openFileDialog1.Filter = "XML File(*.xml)|world.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    document.Save(openFileDialog1.FileName);


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



            //things.Add(new XElement("ThingSaveData"));

            //foreach (var thing in root) {
            //richTextBox1.Text += root;
            //}
            //var structures = from things in root.Elements("Things") where (string)things.Element("ThingSaveData") select things;

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
            if (imgFiles != null && document != null && structureType != null) {
                readXML();

                for (int i = 0; i < imgFiles.Count(); i++)
                {
                    readPixels(imgFiles[i], (i + (i - 1)));
                }

                richTextBox1.Text += root;
            }

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
