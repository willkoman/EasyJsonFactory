using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Security.AccessControl;
using System.Drawing.Imaging;

namespace Texture_JSON_Factory
{
    public partial class MainForm : Form
    {

        List<Bitmap> textures = new List<Bitmap>(6);
        Bitmap[] itemTexture;
        String path = @"";
        public MainForm()
        {
            InitializeComponent();
            for (int i = 0; i < textures.Capacity; i++)
                textures.Insert(i,new Bitmap(16, 16));
        }


        private void Btn_Top_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textures.Insert(0, (Bitmap)Bitmap.FromFile(openFileDialog1.FileName));
            btn_Top.BackgroundImage = textures.ElementAt(0);
            
        }

        private void Btn_West_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textures.Insert(1, (Bitmap)Bitmap.FromFile(openFileDialog1.FileName));
            btn_West.BackgroundImage = textures.ElementAt(1);
        }

        private void Btn_North_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textures.Insert(2, (Bitmap)Bitmap.FromFile(openFileDialog1.FileName));
            btn_North.BackgroundImage = textures.ElementAt(2);
        }

        private void Btn_East_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textures.Insert(3, (Bitmap)Bitmap.FromFile(openFileDialog1.FileName));
            btn_East.BackgroundImage = textures.ElementAt(3);
        }

        private void Btn_South_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textures.Insert(4, (Bitmap)Bitmap.FromFile(openFileDialog1.FileName));
            btn_South.BackgroundImage = textures.ElementAt(4);
        }

        private void Btn_Bottom_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textures.Insert(5, (Bitmap)Bitmap.FromFile(openFileDialog1.FileName));
            btn_Bottom.BackgroundImage = textures.ElementAt(5);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            path = folderBrowserDialog1.SelectedPath;
            tb_Path.Text = path;
        }

        private void Btn_export_Click(object sender, EventArgs e)
        {
            String permanentPath = path;
            var baseDir = Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\");
            baseDir.Attributes = FileAttributes.Normal;
            var modelDir = Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\models\\block\\");
            modelDir.Attributes = FileAttributes.Normal;
            var blockstateDir = Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\blockstates\\");
            blockstateDir.Attributes = FileAttributes.Normal;
            var textureDir = Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\"+tb_BlockName.Text);
            textureDir.Attributes &= ~FileAttributes.ReadOnly;

            CreateBlockModel(permanentPath);
            CreateBlockState(permanentPath);

            SavePNG(textureDir.FullName + "\\" + "sideUp.png", textures.ElementAt(0), 100);
            SavePNG(textureDir.FullName + "\\" + "sideWest.png", textures.ElementAt(1), 100);
            SavePNG(textureDir.FullName + "\\" + "sideNorth.png", textures.ElementAt(2), 100);
            SavePNG(textureDir.FullName + "\\" + "sideEast.png", textures.ElementAt(3), 100);
            SavePNG(textureDir.FullName + "\\" + "sideSouth.png", textures.ElementAt(4), 100);
            SavePNG(textureDir.FullName + "\\" + "sideDown.png", textures.ElementAt(5), 100);
            //textures.ElementAt(0).Save(textureDir.FullName + tb_BlockName.Text + "\\" + "sideUp.png", System.Drawing.Imaging.ImageFormat.Jpeg);
            //textures.ElementAt(1).Save(textureDir.FullName + tb_BlockName.Text + "\\" + "sideWest.png", System.Drawing.Imaging.ImageFormat.Png);
            //textures.ElementAt(2).Save(textureDir.FullName + tb_BlockName.Text + "\\" + "sideNorth.png", System.Drawing.Imaging.ImageFormat.Png);
            //textures.ElementAt(3).Save(textureDir.FullName + tb_BlockName.Text + "\\" + "sideEast.png", System.Drawing.Imaging.ImageFormat.Png);
            //textures.ElementAt(4).Save(textureDir.FullName + tb_BlockName.Text + "\\" + "sideSouth.png", System.Drawing.Imaging.ImageFormat.Png);
            //textures.ElementAt(5).Save(textureDir.FullName + tb_BlockName.Text + "\\" + "sideDown.png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Successfully Output to " + path + "\\" + tb_BlockName.Text + "\\" + "!");

        }
        public static void SavePNG (string path, Image img, int quality)
        {
            EncoderParameter qualityParam
            = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

            ImageCodecInfo jpegCodec= GetEncoderInfo(@"image/png");

            EncoderParameters encoderParams
            = new EncoderParameters(1);

            encoderParams.Param[0] = qualityParam;

            System.IO.MemoryStream mss = new System.IO.MemoryStream();

            System.IO.FileStream fs
            = new System.IO.FileStream(path, System.IO.FileMode.Create
            , System.IO.FileAccess.ReadWrite);

            img.Save(mss, jpegCodec, encoderParams);
            byte[] matriz = mss.ToArray();
            fs.Write(matriz, 0, matriz.Length);

            mss.Close();
            fs.Close();
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
        public void CreateBlockModel(String path)
        {
            path = path + "\\" + tb_BlockName.Text + "\\models\\block\\";

            Block block = new Block
            {
                parent = "block/cube",
                textures = new Textures
                {
                    particle = tb_ModName.Text.Trim(' ') + ":blocks/sideNorth",
                    down = tb_ModName.Text.Trim(' ') + ":blocks/sideDown",
                    up = tb_ModName.Text.Trim(' ') + ":blocks/sideUp",
                    east = tb_ModName.Text.Trim(' ') + ":blocks/sideEast",
                    west = tb_ModName.Text.Trim(' ') + ":blocks/sideWest",
                    north = tb_ModName.Text.Trim(' ') + ":blocks/sideNorth",
                    south = tb_ModName.Text.Trim(' ') + ":blocks/sideSouth"
                }
            };

            String converted = JsonConvert.SerializeObject(block);
            //richTextBox1.Text = JToken.Parse(converted).ToString();
            File.WriteAllText(path + tb_BlockName.Text + ".json", JToken.Parse(converted).ToString());
        }

        public void CreateBlockState(String path)
        {
            path = path + "\\" + tb_BlockName.Text + "\\blockstates\\";
            BlockState bs = new BlockState
            {
                defaults = new Defaults(),
                variants = new Variants()
            };
            bs.variants.facing = new Facing
            {
                south = new South(),
                north = new North(),
                east = new East(),
                west = new West(),
                up = new Up(),
                down = new Down()
            };
            bs.defaults.model = tb_ModName.Text + ":" + tb_BlockName.Text;
            bs.variants.normal = null;
            bs.variants.inventory = null;
            bs.variants.facing.north = null;
            bs.variants.facing.south.y = 180;
            bs.variants.facing.west.y = 270;
            bs.variants.facing.east.y = 90;
            bs.variants.facing.up.x = -90;
            bs.variants.facing.down.x = 90;

            String converted = JsonConvert.SerializeObject(bs);
            //richTextBox1.Text = JToken.Parse(converted).ToString();
            File.WriteAllText(path + tb_BlockName.Text + ".json", JToken.Parse(converted).ToString());
        }

        internal class Block
        {
            public string parent { get; set; }
            public Textures textures { get; set; }


        }
        public class Textures
        {
            public string particle { get; set; }
            public string down { get; set; }
            public string up { get; set; }
            public string east { get; set; }
            public string west { get; set; }
            public string north { get; set; }
            public string south { get; set; }
        }
        public class Defaults
        {
            public string model { get; set; }
        }

        public class Normal
        {
        }

        public class Inventory
        {
        }

        public class North
        {
        }

        public class South
        {
            public int y { get; set; }
        }

        public class West
        {
            public int y { get; set; }
        }

        public class East
        {
            public int y { get; set; }
        }

        public class Up
        {
            public int x { get; set; }
        }

        public class Down
        {
            public int x { get; set; }
        }

        public class Facing
        {
            public North north { get; set; }
            public South south { get; set; }
            public West west { get; set; }
            public East east { get; set; }
            public Up up { get; set; }
            public Down down { get; set; }
        }

        public class Variants
        {
            public IList<Normal> normal { get; set; }
            public IList<Inventory> inventory { get; set; }
            public Facing facing { get; set; }
        }

        public class BlockState
        {
            public int forge_marker { get; set; }
            public Defaults defaults { get; set; }
            public Variants variants { get; set; }
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (path == "" || tb_BlockName.Text.Trim(' ') == "" || tb_ModName.Text.Trim(' ') == "")
                btn_export.Enabled = false;
            else
                btn_export.Enabled = true;


        }
    }
}
