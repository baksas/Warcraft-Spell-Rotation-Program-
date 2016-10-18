using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WacraftColorProgram
{
    public partial class FrmMain : Form
    {
        // private readonly Frmoptions _option;
        //     private bool _allowtoTik;
        private UserActivityHook _hooker;

        //  private int _tik;
        private int _singleMouseX;
        private int _singleMouseY;
        private int _aoeMouseX;
        private int _aoeMouseY;
        private int _thirdMouseX;
        private int _thirdMouseY;


        private ItemListItems _classItems;
        MouseLocation _mouselocation;
        private Boolean _firstTargetButtonPressed;
        private Boolean _secondTargetButtonPressed;
        private Boolean _thirdTargetButtonPressed;
        public string ColorCodeFirst { set; get; }
        public string ColorCodeSecond { set; get; }
        public string ColorCodeThird { set; get; }

        public Hashtable LogData { get; set; }

        public Stack AppNames { get; set; }

        // private string _logfilepath = Application.StartupPath + @"\Acitivitylog.xml";

        public FrmMain()
        {
            InitializeComponent();
            //   _option = new Frmoptions();
        }



        private void MainFormLoad(object sender, EventArgs e)
        {
            _mouselocation = MouseLocation.Load();

            if (_mouselocation != null)
            {
                _singleMouseX = _mouselocation.XCoordinateSingle;
                _singleMouseY = _mouselocation.YCcoordinateSingle;

                _aoeMouseX = _mouselocation.XcoordinateAoe;
                _aoeMouseY = _mouselocation.YcoordinateAoe;

                _thirdMouseX = _mouselocation.XcoordinateThird;
                _thirdMouseY = _mouselocation.YcoordinateThird;

            }

            ItemListItems items = ItemListItems.Load();

            if (items != null)
            {
                _classItems = items;
                FillItemList();
            }

            _hooker = new UserActivityHook();
            _hooker.OnMouseActivity += MouseMoved;
            _hooker.KeyPress += HookerKeyPress;


            AppNames = new Stack();
        }

        private void FillItemList()
        {

            if (_classItems.ClassList != null)
            {
                foreach (WarcraftClass item in _classItems.ClassList)
                {
                    ItemList.Items.Add(item.Name);
                    if (_classItems.SelectedItem.Equals(item.Name))
                    {
                        ItemList.SelectedItem = item.Name;
                    }
                }
            }
            ItemList.Sorted = true;
        }

        public void MouseMoved(object sender, MouseEventArgs e)
        {
            if (editMousePosition.Checked && e.Clicks > 0)
            {
                _singleMouseY = e.Y;
                _singleMouseX = e.X;
                editMousePosition.Checked = false;

                _mouselocation.XCoordinateSingle = _singleMouseX;
                _mouselocation.YCcoordinateSingle = _singleMouseY;
                _mouselocation.Save();
            }

            if (AoeCheckBox.Checked && e.Clicks > 0)
            {
                _aoeMouseY = e.Y;
                _aoeMouseX = e.X;
                AoeCheckBox.Checked = false;

                _mouselocation.XcoordinateAoe = _aoeMouseX;
                _mouselocation.YcoordinateAoe = _aoeMouseY;
                _mouselocation.Save();
            }

            if (ThirdCheckBox.Checked && e.Clicks > 0)
            {
                _thirdMouseY = e.Y;
                _thirdMouseX = e.X;
                ThirdCheckBox.Checked = false;

                _mouselocation.XcoordinateThird = _thirdMouseX;
                _mouselocation.YcoordinateThird = _thirdMouseY;
                _mouselocation.Save();
            }

            if (editMousePosition.Checked)
            {

                _singleMouseY = e.Y;
                _singleMouseX = e.X;
            }

            if (AoeCheckBox.Checked)
            {

                _aoeMouseY = e.Y;
                _aoeMouseX = e.X;
            }


            if (ThirdCheckBox.Checked)
            {

                _thirdMouseY = e.Y;
                _thirdMouseX = e.X;
            }

            mousePositionTop.Text = String.Format("X:{0},Y={1}", e.X, e.Y);
            mouseSinglePositionSaved.Text = String.Format("X:{0},Y={1}", _singleMouseX, _singleMouseY);
            AoeMousePositionSaved.Text = String.Format("X:{0},Y={1}", _aoeMouseX, _aoeMouseY);
            ThirdMousePositionSaved.Text = String.Format("X:{0},Y={1}", _thirdMouseX, _thirdMouseY);
        }

        public void HookerKeyPress(object sender, KeyPressEventArgs e)
        {

            _firstTargetButtonPressed = false;
            _secondTargetButtonPressed = false;
            _thirdTargetButtonPressed = false;

            if (!e.KeyChar.ToString(CultureInfo.InvariantCulture).Equals("`") && !e.KeyChar.ToString(CultureInfo.InvariantCulture).Equals("'") && !e.KeyChar.ToString(CultureInfo.InvariantCulture).Equals(";")) return;

            if (e.KeyChar.ToString(CultureInfo.InvariantCulture).Equals("`"))
            {
                _firstTargetButtonPressed = true;
            }

            if (e.KeyChar.ToString(CultureInfo.InvariantCulture).Equals("'"))
            {
                _secondTargetButtonPressed = true;
            }

            if (e.KeyChar.ToString(CultureInfo.InvariantCulture).Equals(";"))
            {
                _thirdTargetButtonPressed = true;
            }


            var thread = new Thread(PictureAction);
            thread.Start(this);
            thread.Join();

            // pictureAction(this);
        }


        private void PictureAction(object dd)
        {
            var parameter = (FrmMain)dd;

            if (parameter.EditModeCheckbox.Checked)
            {
                FirstColorRead();
                SecondColorRead();
                ThirdColorRead();
                return;
            }
            
            if (parameter._firstTargetButtonPressed)
            {
                FirstColorRead();
                PressSpell(parameter, ColorCodeFirst, 0);
                return;
            }

            if (parameter._secondTargetButtonPressed)
            {
                SecondColorRead();
                PressSpell(parameter, ColorCodeSecond, 1);
                return;
            }

            if (parameter._thirdTargetButtonPressed)
            {
                ThirdColorRead();
                PressSpell(parameter, ColorCodeThird, 2);
                return;
            }
        }

        private void ThirdColorRead()
        {
            var boundsAoe = new Rectangle(_thirdMouseX - 1, _thirdMouseY + 1, 3, 3);
            var bitmapAoe = new Bitmap(boundsAoe.Width, boundsAoe.Height);
            var g1 = Graphics.FromImage(bitmapAoe);
            g1.CopyFromScreen(boundsAoe.Left, boundsAoe.Top, 0, 0, bitmapAoe.Size, CopyPixelOperation.SourceCopy);
            var b = bitmapAoe.GetPixel(1, 1);
            var codeAoe = b.A * 3 + b.B * 2 + b.G * 4;
            ColorCodeThird = Convert.ToString(codeAoe);
        }

        private void SecondColorRead()
        {
            var boundsAoe = new Rectangle(_aoeMouseX - 1, _aoeMouseY + 1, 3, 3);
            var bitmapAoe = new Bitmap(boundsAoe.Width, boundsAoe.Height);
            var g1 = Graphics.FromImage(bitmapAoe);
            g1.CopyFromScreen(boundsAoe.Left, boundsAoe.Top, 0, 0, bitmapAoe.Size, CopyPixelOperation.SourceCopy);
            var b = bitmapAoe.GetPixel(1, 1);
            var codeAoe = b.A * 3 + b.B * 2 + b.G * 4;
            ColorCodeSecond = Convert.ToString(codeAoe);
        }

        private void FirstColorRead()
        {
            var boundsSingle = new Rectangle(_singleMouseX - 1, _singleMouseY + 1, 3, 3);
            var bitmapSingle = new Bitmap(boundsSingle.Width, boundsSingle.Height);
            var g = Graphics.FromImage(bitmapSingle);
            g.CopyFromScreen(boundsSingle.Left, boundsSingle.Top, 0, 0, bitmapSingle.Size, CopyPixelOperation.SourceCopy);
            var c = bitmapSingle.GetPixel(1, 1);
            int codeSingle = c.A * 5 + c.B * 4 + c.G * 2;
            ColorCodeFirst = Convert.ToString(codeSingle);
        }

        private static void PressSpell(FrmMain parameter, String code, int button)
        {
            foreach (WarcraftClass wcClass in parameter._classItems.ClassList)
            {
                foreach (Spell spell in wcClass.Spells)
                {
                    string[] words = spell.Color.Split('/');
                    
                    if (words.Length == 0 || words.Length <= button)
                    {
                        continue;
                    }

                    if (!code.Equals(words[button])) continue;
                    if (!parameter.EditModeCheckbox.Checked)
                    {
                        SendKeys.SendWait(spell.Key);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ci = new ClassItem(_classItems, ItemList, false, this);
            ci.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = "";
            if (ItemList.SelectedItem != null)
            {
                curItem = ItemList.SelectedItem.ToString();
            }
            _classItems.SelectedItem = curItem;
            _classItems.Save();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string curItem = ItemList.SelectedItem.ToString();
            WarcraftClass itemToRemove = null;
            foreach (WarcraftClass item in _classItems.ClassList)
            {
                if (item.Name.Equals(curItem))
                {
                    itemToRemove = item;
                }
            }

            if (itemToRemove != null)
            {
                ItemList.Items.Remove(itemToRemove.Name);
                _classItems.ClassList.Remove(itemToRemove);
                _classItems.Save();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var ci = new ClassItem(_classItems, ItemList, true, this);
            ci.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


