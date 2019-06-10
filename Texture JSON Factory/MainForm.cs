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
                textures.Add(new Bitmap(16, 16));
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
            Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\");
            Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\blockstates\\");
            Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\models\\block\\");
            Directory.CreateDirectory(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\");
            MessageBox.Show("Successfully Output to " + path + "\\" + tb_BlockName.Text + "\\" + "!");
            createBlockModel(permanentPath);
            createBlockState(permanentPath);

            textures.ElementAt(0).Save(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\" + tb_BlockName.Text + "\\" + "sideUp.png", System.Drawing.Imaging.ImageFormat.Png);
            textures.ElementAt(1).Save(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\" + tb_BlockName.Text + "\\" + "sideWest.png", System.Drawing.Imaging.ImageFormat.Png);
            textures.ElementAt(2).Save(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\" + tb_BlockName.Text + "\\" + "sideNorth.png", System.Drawing.Imaging.ImageFormat.Png);
            textures.ElementAt(3).Save(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\" + tb_BlockName.Text + "\\" + "sideEast.png", System.Drawing.Imaging.ImageFormat.Png);
            textures.ElementAt(4).Save(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\" + tb_BlockName.Text + "\\" + "sideSouth.png", System.Drawing.Imaging.ImageFormat.Png);
            textures.ElementAt(5).Save(path + "\\" + tb_BlockName.Text + "\\textures\\blocks\\" + tb_BlockName.Text + "\\" + "sideDown.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        public void createBlockModel(String path)
        {
            path = path + "\\" + tb_BlockName.Text + "\\models\\block\\";

            Block block = new Block();
            block.parent = "block/cube";
            block.textures = new Textures();
            block.textures.particle = tb_ModName.Text.Trim(' ') + ":blocks/sideNorth";
            block.textures.down = tb_ModName.Text.Trim(' ') + ":blocks/sideDown";
            block.textures.up = tb_ModName.Text.Trim(' ') + ":blocks/sideUp";
            block.textures.east = tb_ModName.Text.Trim(' ') + ":blocks/sideEast";
            block.textures.west = tb_ModName.Text.Trim(' ') + ":blocks/sideWest";
            block.textures.north = tb_ModName.Text.Trim(' ') + ":blocks/sideNorth";
            block.textures.south = tb_ModName.Text.Trim(' ') + ":blocks/sideSouth";

            String converted = JsonConvert.SerializeObject(block);
            //richTextBox1.Text = JToken.Parse(converted).ToString();
            File.WriteAllText(path + tb_BlockName.Text + ".json", JToken.Parse(converted).ToString());
        }

        public void createBlockState(String path)
        {
            path = path + "\\" + tb_BlockName.Text + "\\blockstates\\";
            BlockState bs = new BlockState();
            bs.defaults = new Defaults();
            bs.variants = new Variants();
            bs.variants.facing = new Facing();
            bs.variants.facing.south = new South();
            bs.variants.facing.north = new North();
            bs.variants.facing.east = new East();
            bs.variants.facing.west = new West();
            bs.variants.facing.up = new Up();
            bs.variants.facing.down = new Down();

            bs.forge_marker = 1;
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
