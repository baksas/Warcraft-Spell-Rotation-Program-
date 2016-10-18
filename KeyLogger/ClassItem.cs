using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WacraftColorProgram.Properties;

namespace WacraftColorProgram
{
    public partial class ClassItem : Form
    {

        private ItemListItems _listItems;
        private readonly ListBox _listboxItems;
        private readonly Boolean _edit;
        private readonly FrmMain _mainform;

        public ClassItem(ItemListItems listItems, ListBox listboxItems, Boolean edit, FrmMain mainform)
        {
            _listItems = listItems;
            _listboxItems = listboxItems;
            _edit = edit;
            _mainform = mainform;
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            
            if (_edit)
            {
                foreach (var item in _listItems.ClassList)
                {

                    if (_listboxItems.SelectedItem != null)
                    {
                        if (item.Name.Equals(_listboxItems.SelectedItem.ToString()))
                        {
                            SetFieldValues(item);
                        }
                    }
                }
            }
        }

          
        private void button1_Click(object sender, EventArgs e)
        {
            if (_edit)
            {
                WarcraftClass itemToRemove = null;
                var strItemToRemove = "";
                foreach (var item in _listItems.ClassList)
                {
                    if (item.Name.Equals(_listboxItems.SelectedItem.ToString()))
                    {
                        itemToRemove = item;
                        strItemToRemove = _listboxItems.SelectedItem.ToString();
                    }
                }

                if (itemToRemove != null)
                {
                    _listboxItems.Items.Remove(strItemToRemove);
                    _listItems.ClassList.Remove(itemToRemove);
                }
            }

            if (_listItems == null)
            {
                _listItems = new ItemListItems();
            }

            if (string.IsNullOrEmpty(ClassNameField.Text))
            {
                Close();
            }

            var wcClass = new WarcraftClass {Name = ClassNameField.Text, Spells = GetSpells()};

            _listItems.ClassList.Add(wcClass);
            _listItems.Save();
            _listboxItems.Items.Add(wcClass.Name);

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CpColor_Click(object sender, EventArgs e)
        {
            colorCodeTextBox.Text = _mainform.ColorCodeFirst + Resources.ClassItem_CpColor_Click__ + _mainform.ColorCodeSecond + Resources.ClassItem_CpColor_Click__ + _mainform.ColorCodeThird;
        }

        private List<Spell> GetSpells()
        {
            var spells = new List<Spell>();
            var a1 = new Spell {Name = SpellName1.Text, Color = ColorCode1.Text, Key = KeyCode1.Text};
            spells.Add(a1);

            var a2 = new Spell {Name = SpellName2.Text, Color = ColorCode2.Text, Key = KeyCode2.Text};
            spells.Add(a2);

            var a3 = new Spell {Name = SpellName3.Text, Color = ColorCode3.Text, Key = KeyCode3.Text};
            spells.Add(a3);

            var a4 = new Spell {Name = SpellName4.Text, Color = ColorCode4.Text, Key = KeyCode4.Text};
            spells.Add(a4);

            var a5 = new Spell {Name = SpellName5.Text, Color = ColorCode5.Text, Key = KeyCode5.Text};
            spells.Add(a5);

            var a6 = new Spell {Name = SpellName6.Text, Color = ColorCode6.Text, Key = KeyCode6.Text};
            spells.Add(a6);

            var a7 = new Spell {Name = SpellName7.Text, Color = ColorCode7.Text, Key = KeyCode7.Text};
            spells.Add(a7);

            var a8 = new Spell {Name = SpellName8.Text, Color = ColorCode8.Text, Key = KeyCode8.Text};
            spells.Add(a8);

            var a9 = new Spell {Name = SpellName9.Text, Color = ColorCode9.Text, Key = KeyCode9.Text};
            spells.Add(a9);

            var a10 = new Spell {Name = SpellName10.Text, Color = ColorCode10.Text, Key = KeyCode10.Text};
            spells.Add(a10);

            var a11 = new Spell {Name = SpellName11.Text, Color = ColorCode11.Text, Key = KeyCode11.Text};
            spells.Add(a11);

            var a12 = new Spell {Name = SpellName12.Text, Color = ColorCode12.Text, Key = KeyCode12.Text};
            spells.Add(a12);

            var a13 = new Spell {Name = SpellName13.Text, Color = ColorCode13.Text, Key = KeyCode13.Text};
            spells.Add(a13);

            var a14 = new Spell {Name = SpellName14.Text, Color = ColorCode14.Text, Key = KeyCode14.Text};
            spells.Add(a14);

            var a15 = new Spell {Name = SpellName15.Text, Color = ColorCode15.Text, Key = KeyCode15.Text};
            spells.Add(a15);

            var a16 = new Spell {Name = SpellName16.Text, Color = ColorCode16.Text, Key = KeyCode16.Text};
            spells.Add(a16);

            var a17 = new Spell {Name = SpellName17.Text, Color = ColorCode17.Text, Key = KeyCode17.Text};
            spells.Add(a17);

            var a18 = new Spell {Name = SpellName18.Text, Color = ColorCode18.Text, Key = KeyCode18.Text};
            spells.Add(a18);

            var a19 = new Spell {Name = SpellName19.Text, Color = ColorCode19.Text, Key = KeyCode19.Text};
            spells.Add(a19);

            return spells;
        }



        private void SetFieldValues(WarcraftClass item)
        {
            ClassNameField.Text = item.Name;

            SpellName1.Text = item.Spells[0].Name;
            ColorCode1.Text = item.Spells[0].Color;
            KeyCode1.Text = item.Spells[0].Key;

            SpellName2.Text = item.Spells[1].Name;
            ColorCode2.Text = item.Spells[1].Color;
            KeyCode2.Text = item.Spells[1].Key;

            SpellName3.Text = item.Spells[2].Name;
            ColorCode3.Text = item.Spells[2].Color;
            KeyCode3.Text = item.Spells[2].Key;

            SpellName4.Text = item.Spells[3].Name;
            ColorCode4.Text = item.Spells[3].Color;
            KeyCode4.Text = item.Spells[3].Key;

            SpellName5.Text = item.Spells[4].Name;
            ColorCode5.Text = item.Spells[4].Color;
            KeyCode5.Text = item.Spells[4].Key;

            SpellName6.Text = item.Spells[5].Name;
            ColorCode6.Text = item.Spells[5].Color;
            KeyCode6.Text = item.Spells[5].Key;

            SpellName7.Text = item.Spells[6].Name;
            ColorCode7.Text = item.Spells[6].Color;
            KeyCode7.Text = item.Spells[6].Key;

            SpellName8.Text = item.Spells[7].Name;
            ColorCode8.Text = item.Spells[7].Color;
            KeyCode8.Text = item.Spells[7].Key;

            SpellName9.Text = item.Spells[8].Name;
            ColorCode9.Text = item.Spells[8].Color;
            KeyCode9.Text = item.Spells[8].Key;

            SpellName10.Text = item.Spells[9].Name;
            ColorCode10.Text = item.Spells[9].Color;
            KeyCode10.Text = item.Spells[9].Key;

            SpellName11.Text = item.Spells[10].Name;
            ColorCode11.Text = item.Spells[10].Color;
            KeyCode11.Text = item.Spells[10].Key;

            SpellName12.Text = item.Spells[11].Name;
            ColorCode12.Text = item.Spells[11].Color;
            KeyCode12.Text = item.Spells[11].Key;

            SpellName13.Text = item.Spells[12].Name;
            ColorCode13.Text = item.Spells[12].Color;
            KeyCode13.Text = item.Spells[12].Key;

            SpellName14.Text = item.Spells[13].Name;
            ColorCode14.Text = item.Spells[13].Color;
            KeyCode14.Text = item.Spells[13].Key;

            SpellName15.Text = item.Spells[14].Name;
            ColorCode15.Text = item.Spells[14].Color;
            KeyCode15.Text = item.Spells[14].Key;

            SpellName16.Text = item.Spells[15].Name;
            ColorCode16.Text = item.Spells[15].Color;
            KeyCode16.Text = item.Spells[15].Key;

            SpellName17.Text = item.Spells[16].Name;
            ColorCode17.Text = item.Spells[16].Color;
            KeyCode17.Text = item.Spells[16].Key;

            SpellName18.Text = item.Spells[17].Name;
            ColorCode18.Text = item.Spells[17].Color;
            KeyCode18.Text = item.Spells[17].Key;

            SpellName19.Text = item.Spells[18].Name;
            ColorCode19.Text = item.Spells[18].Color;
            KeyCode19.Text = item.Spells[18].Key;
        }

        private void ColorCode1_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode1.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode1.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode2_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode2.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode2.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode3_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode3.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode3.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode4_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode4.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode4.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode5_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode5.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode5.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode6_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode6.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode6.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode7_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode7.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode7.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode8_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode8.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode8.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode9_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode9.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode9.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode10_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode10.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode10.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode11_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode11.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode11.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode12_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode12.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode12.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode13_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode13.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode13.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode14_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode14.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode14.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode15_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode15.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode15.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode16_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode16.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode16.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode17_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode17.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode17.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode18_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode18.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode18.Text = _mainform.ColorCodeFirst + @"/" + _mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }

        private void ColorCode19_TextChanged(object sender, EventArgs e)
        {
            if (ColorCode19.Text.Length != 1) return;
            SendKeys.SendWait("`");
            ColorCode19.Text = _mainform.ColorCodeFirst + @"/" +_mainform.ColorCodeSecond + @"/" + _mainform.ColorCodeThird;
        }
    }
}
