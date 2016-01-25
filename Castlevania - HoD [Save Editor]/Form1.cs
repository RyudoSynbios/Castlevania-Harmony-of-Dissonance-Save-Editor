using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Castlevania___HoD__Save_Editor_
{
    public partial class Form1 : Form
    {
        private Editor savEdit = null;
        private int saveID = 1;

        #region Offsets
        
        private Object[] checkSaveHex1 = { (Int32)0x0, 1 };
        private Object[] checkSaveHex2 = { (Int32)0x1, 1 };
        private Object[] checkSaveHex3 = { (Int32)0x2, 1 };
        private Object[] checkSaveHex4 = { (Int32)0x3, 1 };
        private Object[] checkSaveHex5 = { (Int32)0x4, 1 };
        private Object[] checkSaveHex6 = { (Int32)0x5, 1 };
        private Object[] checkSaveHex7 = { (Int32)0x6, 1 };
        private Object[] checkSaveHex8 = { (Int32)0x7, 1 };
        private Object[] checkSaveHex9 = { (Int32)0x8, 1 };
        private Object[] checkSaveHex10 = { (Int32)0x9, 1 };
        private Object[] checkSaveHex11 = { (Int32)0xa, 1 };
        private Object[] checkSaveHex12 = { (Int32)0xb, 1 };
        private Object[] checkSaveHex13 = { (Int32)0xc, 1 };
        private Object[] checkSaveHex14 = { (Int32)0xd, 1 };
        private Object[] checkSaveHex15 = { (Int32)0xe, 1 };

        private Object[] generalBonusHex = { (Int32)0xbf8, 1 };

        private Object[] statsStatusmenuHex = { (Int32)0x3cf, 1 };
        private Object[] statsName1Hex = { (Int32)0x124, 1 };
        private Object[] statsName2Hex = { (Int32)0x125, 1 };
        private Object[] statsName3Hex = { (Int32)0x126, 1 };
        private Object[] statsName4Hex = { (Int32)0x127, 1 };
        private Object[] statsName5Hex = { (Int32)0x128, 1 };
        private Object[] statsName6Hex = { (Int32)0x129, 1 };
        private Object[] statsName7Hex = { (Int32)0x12a, 1 };
        private Object[] statsName8Hex = { (Int32)0x12b, 1 };
        //private Object[] statsMappercentSavsc   = { (Int32)0x12e, 2 };
        private Object[] statsLvlHex = { (Int32)0x1c, 1 };
        private Object[] statsLvlSavscHex = { (Int32)0x12d, 1 };
        private Object[] statsExpHex = { (Int32)0x38, 4 };
        private Object[] statsHpmaxHex = { (Int32)0x26, 2 };
        private Object[] statsMpmaxHex = { (Int32)0x28, 2 };
        private Object[] statsSubweaponHex = { (Int32)0x1e, 1 };
        private Object[] statsHeartsHex = { (Int32)0x34, 2 };
        private Object[] statsHeartsmaxHex = { (Int32)0x2a, 2 };
        private Object[] statsStrHex = { (Int32)0x2c, 2 };
        private Object[] statsDefHex = { (Int32)0x2e, 2 };
        private Object[] statsIntHex = { (Int32)0x30, 2 };
        private Object[] statsLckHex = { (Int32)0x32, 2 };
        private Object[] statsGoldHex = { (Int32)0x3c, 4 };
        private Object[] statsGoldSavsHex = { (Int32)0x130, 4 };
        private Object[] statsTimeHex = { (Int32)0x134, 4 };

        private Object[] statsEquippedwhipHex = { (Int32)0x24, 1 };
        private Object[] statsEquippedarmorHex = { (Int32)0x20, 1 };
        private Object[] statsEquippedaccessory1Hex = { (Int32)0x21, 1 };
        private Object[] statsEquippedaccessory2Hex = { (Int32)0x22, 1 };
        private Object[] statsEquippedaccessory3Hex = { (Int32)0x23, 1 };

        private Object[] mapsLocation = { (Int32)0x3b8, 2 };

        private Object[] abilitiesWhipsHex = { (Int32)0x5c, 2 };

        private Object[] armors1Hex = { (Int32)0x5e, 1 };
        private Object[] armors2Hex = { (Int32)0x5f, 1 };
        private Object[] armors3Hex = { (Int32)0x60, 1 };
        private Object[] armors4Hex = { (Int32)0x61, 1 };
        private Object[] armors5Hex = { (Int32)0x62, 1 };
        private Object[] armors6Hex = { (Int32)0x63, 1 };
        private Object[] armors7Hex = { (Int32)0x64, 1 };
        private Object[] armors8Hex = { (Int32)0x65, 1 };
        private Object[] armors9Hex = { (Int32)0x66, 1 };
        private Object[] armors10Hex = { (Int32)0x67, 1 };
        private Object[] armors11Hex = { (Int32)0x68, 1 };
        private Object[] armors12Hex = { (Int32)0x69, 1 };
        private Object[] armors13Hex = { (Int32)0x6a, 1 };
        private Object[] armors14Hex = { (Int32)0x6b, 1 };
        private Object[] armors15Hex = { (Int32)0x6c, 1 };
        private Object[] armors16Hex = { (Int32)0x6d, 1 };
        private Object[] armors17Hex = { (Int32)0x6e, 1 };
        private Object[] armors18Hex = { (Int32)0x6f, 1 };
        private Object[] armors19Hex = { (Int32)0x70, 1 };
        private Object[] armors20Hex = { (Int32)0x71, 1 };
        private Object[] armors21Hex = { (Int32)0x72, 1 };
        private Object[] armors22Hex = { (Int32)0x73, 1 };
        private Object[] armors23Hex = { (Int32)0x74, 1 };
        private Object[] armors24Hex = { (Int32)0x75, 1 };
        private Object[] armors25Hex = { (Int32)0x76, 1 };
        private Object[] armors26Hex = { (Int32)0x77, 1 };
        private Object[] armors27Hex = { (Int32)0x78, 1 };
        private Object[] armors28Hex = { (Int32)0x79, 1 };
        private Object[] armors29Hex = { (Int32)0x7a, 1 };
        private Object[] armors30Hex = { (Int32)0x7b, 1 };
        private Object[] armors31Hex = { (Int32)0x7c, 1 };
        private Object[] armors32Hex = { (Int32)0x7d, 1 };
        private Object[] armors33Hex = { (Int32)0x7e, 1 };
        private Object[] armors34Hex = { (Int32)0x7f, 1 };
        private Object[] armors35Hex = { (Int32)0x80, 1 };
        private Object[] armors36Hex = { (Int32)0x81, 1 };
        private Object[] armors37Hex = { (Int32)0x82, 1 };
        private Object[] armors38Hex = { (Int32)0x83, 1 };
        private Object[] armors39Hex = { (Int32)0x84, 1 };
        private Object[] armors40Hex = { (Int32)0x85, 1 };
        private Object[] armors41Hex = { (Int32)0x86, 1 };
        private Object[] armors42Hex = { (Int32)0x87, 1 };

        private Object[] accessories1Hex = { (Int32)0x88, 1 };
        private Object[] accessories2Hex = { (Int32)0x89, 1 };
        private Object[] accessories3Hex = { (Int32)0x8a, 1 };
        private Object[] accessories4Hex = { (Int32)0x8b, 1 };
        private Object[] accessories5Hex = { (Int32)0x8c, 1 };
        private Object[] accessories6Hex = { (Int32)0x8d, 1 };
        private Object[] accessories7Hex = { (Int32)0x8e, 1 };
        private Object[] accessories8Hex = { (Int32)0x8f, 1 };
        private Object[] accessories9Hex = { (Int32)0x90, 1 };
        private Object[] accessories10Hex = { (Int32)0x91, 1 };
        private Object[] accessories11Hex = { (Int32)0x92, 1 };
        private Object[] accessories12Hex = { (Int32)0x93, 1 };
        private Object[] accessories13Hex = { (Int32)0x94, 1 };
        private Object[] accessories14Hex = { (Int32)0x95, 1 };
        private Object[] accessories15Hex = { (Int32)0x96, 1 };
        private Object[] accessories16Hex = { (Int32)0x97, 1 };
        private Object[] accessories17Hex = { (Int32)0x98, 1 };
        private Object[] accessories18Hex = { (Int32)0x99, 1 };
        private Object[] accessories19Hex = { (Int32)0x9a, 1 };
        private Object[] accessories20Hex = { (Int32)0x9b, 1 };
        private Object[] accessories21Hex = { (Int32)0x9c, 1 };
        private Object[] accessories22Hex = { (Int32)0x9d, 1 };
        private Object[] accessories23Hex = { (Int32)0x9e, 1 };
        private Object[] accessories24Hex = { (Int32)0x9f, 1 };
        private Object[] accessories25Hex = { (Int32)0xa0, 1 };
        private Object[] accessories26Hex = { (Int32)0xa1, 1 };
        private Object[] accessories27Hex = { (Int32)0xa2, 1 };
        private Object[] accessories28Hex = { (Int32)0xa3, 1 };
        private Object[] accessories29Hex = { (Int32)0xa4, 1 };
        private Object[] accessories30Hex = { (Int32)0xa5, 1 };
        private Object[] accessories31Hex = { (Int32)0xa6, 1 };
        private Object[] accessories32Hex = { (Int32)0xa7, 1 };
        private Object[] accessories33Hex = { (Int32)0xa8, 1 };
        private Object[] accessories34Hex = { (Int32)0xa9, 1 };
        private Object[] accessories35Hex = { (Int32)0xaa, 1 };
        private Object[] accessories36Hex = { (Int32)0xab, 1 };
        private Object[] accessories37Hex = { (Int32)0xac, 1 };
        private Object[] accessories38Hex = { (Int32)0xad, 1 };
        private Object[] accessories39Hex = { (Int32)0xae, 1 };
        private Object[] accessories40Hex = { (Int32)0xaf, 1 };
        private Object[] accessories41Hex = { (Int32)0xb0, 1 };
        private Object[] accessories42Hex = { (Int32)0xb1, 1 };
        private Object[] accessories43Hex = { (Int32)0xb2, 1 };
        private Object[] accessories44Hex = { (Int32)0xb3, 1 };
        private Object[] accessories45Hex = { (Int32)0xb4, 1 };
        private Object[] accessories46Hex = { (Int32)0xb5, 1 };
        private Object[] accessories47Hex = { (Int32)0xb6, 1 };
        private Object[] accessories48Hex = { (Int32)0xb7, 1 };
        private Object[] accessories49Hex = { (Int32)0xb8, 1 };
        private Object[] accessories50Hex = { (Int32)0xb9, 1 };
        private Object[] accessories51Hex = { (Int32)0xba, 1 };
        private Object[] accessories52Hex = { (Int32)0xbb, 1 };
        private Object[] accessories53Hex = { (Int32)0xbc, 1 };
        private Object[] accessories54Hex = { (Int32)0xbd, 1 };
        private Object[] accessories55Hex = { (Int32)0xbe, 1 };
        private Object[] accessories56Hex = { (Int32)0xbf, 1 };
        private Object[] accessories57Hex = { (Int32)0xc0, 1 };
        private Object[] accessories58Hex = { (Int32)0xc1, 1 };
        private Object[] accessories59Hex = { (Int32)0xc2, 1 };
        private Object[] accessories60Hex = { (Int32)0xc3, 1 };
        private Object[] accessories61Hex = { (Int32)0xc4, 1 };
        private Object[] accessories62Hex = { (Int32)0xc5, 1 };
        private Object[] accessories63Hex = { (Int32)0xc6, 1 };
        private Object[] accessories64Hex = { (Int32)0xc7, 1 };
        private Object[] accessories65Hex = { (Int32)0xc8, 1 };
        private Object[] accessories66Hex = { (Int32)0xc9, 1 };
        private Object[] accessories67Hex = { (Int32)0xca, 1 };
        private Object[] accessories68Hex = { (Int32)0xcb, 1 };
        private Object[] accessories69Hex = { (Int32)0xcc, 1 };
        private Object[] accessories70Hex = { (Int32)0xcd, 1 };
        private Object[] accessories71Hex = { (Int32)0xce, 1 };
        private Object[] accessories72Hex = { (Int32)0xcf, 1 };
        private Object[] accessories73Hex = { (Int32)0xd0, 1 };
        private Object[] accessories74Hex = { (Int32)0xd1, 1 };
        private Object[] accessories75Hex = { (Int32)0xd2, 1 };
        private Object[] accessories76Hex = { (Int32)0xd3, 1 };
        private Object[] accessories77Hex = { (Int32)0xd4, 1 };
        private Object[] accessories78Hex = { (Int32)0xd5, 1 };
        private Object[] accessories79Hex = { (Int32)0xd6, 1 };
        private Object[] accessories80Hex = { (Int32)0xd7, 1 };
        private Object[] accessories81Hex = { (Int32)0xd8, 1 };
        private Object[] accessories82Hex = { (Int32)0xd9, 1 };
        private Object[] accessories83Hex = { (Int32)0xda, 1 };
        private Object[] accessories84Hex = { (Int32)0xdb, 1 };
        private Object[] accessories85Hex = { (Int32)0xdc, 1 };
        private Object[] accessories86Hex = { (Int32)0xdd, 1 };

        private Object[] items1Hex = { (Int32)0x40, 1 };
        private Object[] items2Hex = { (Int32)0x41, 1 };
        private Object[] items3Hex = { (Int32)0x42, 1 };
        private Object[] items4Hex = { (Int32)0x43, 1 };
        private Object[] items5Hex = { (Int32)0x44, 1 };
        private Object[] items6Hex = { (Int32)0x45, 1 };
        private Object[] items7Hex = { (Int32)0x46, 1 };
        private Object[] items8Hex = { (Int32)0x47, 1 };
        private Object[] items9Hex = { (Int32)0x48, 1 };
        private Object[] items10Hex = { (Int32)0x49, 1 };
        private Object[] items11Hex = { (Int32)0x4a, 1 };
        private Object[] items12Hex = { (Int32)0x4b, 1 };
        private Object[] items13Hex = { (Int32)0x4c, 1 };
        private Object[] items14Hex = { (Int32)0x4d, 1 };
        private Object[] items15Hex = { (Int32)0x4e, 1 };
        private Object[] items16Hex = { (Int32)0x4f, 1 };
        private Object[] items17Hex = { (Int32)0x50, 1 };
        private Object[] items18Hex = { (Int32)0x51, 1 };
        private Object[] items19Hex = { (Int32)0x52, 1 };
        private Object[] items20Hex = { (Int32)0x53, 1 };
        private Object[] items21Hex = { (Int32)0x54, 1 };
        private Object[] items22Hex = { (Int32)0x55, 1 };
        private Object[] items23Hex = { (Int32)0x56, 1 };
        private Object[] items24Hex = { (Int32)0x57, 1 };
        private Object[] items25Hex = { (Int32)0x58, 1 };
        private Object[] items26Hex = { (Int32)0x59, 1 };
        private Object[] items27Hex = { (Int32)0x5a, 1 };
        private Object[] items28Hex = { (Int32)0x5b, 1 };

        private Object[] abilitiesSpellbooksHex = { (Int32)0xde, 1 };
        private Object[] abilitiesRelicsHex = { (Int32)0xdf, 2 };

        private Object[] encyclopedia1Hex = { (Int32)0xf4, 1 };
        private Object[] encyclopedia2Hex = { (Int32)0xf5, 1 };
        private Object[] encyclopedia3Hex = { (Int32)0xf6, 1 };
        private Object[] encyclopedia4Hex = { (Int32)0xf7, 1 };
        private Object[] encyclopedia5Hex = { (Int32)0xf8, 1 };
        private Object[] encyclopedia6Hex = { (Int32)0xf9, 1 };
        private Object[] encyclopedia7Hex = { (Int32)0xfa, 1 };
        private Object[] encyclopedia8Hex = { (Int32)0xfb, 1 };
        private Object[] encyclopedia9Hex = { (Int32)0xfc, 1 };
        private Object[] encyclopedia10Hex = { (Int32)0xfd, 1 };
        private Object[] encyclopedia11Hex = { (Int32)0xfe, 1 };
        private Object[] encyclopedia12Hex = { (Int32)0xff, 1 };
        private Object[] encyclopedia13Hex = { (Int32)0x100, 1 };

        private Object[] collectibles1Hex = { (Int32)0xe3, 1 };
        private Object[] collectibles2Hex = { (Int32)0xe4, 1 };
        private Object[] collectibles3Hex = { (Int32)0xe5, 1 };
        private Object[] collectibles4Hex = { (Int32)0xe6, 1 };

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            writeStats();
        }

        private void openFileDialog_FileOk(object sender, EventArgs e)
        {
            savEdit = new Editor(openFileDialog.FileName);
            readStats();
        }

        private void consoleLog(String message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        private void writeMessage(String message)
        {
            debug.Text = message;
        }

        private string readConvertToName(Decimal hex)
        {
            hex -= 1;

            if (hex <= 0) { hex = 0; }

            var index = (int)hex;

            String[] letter = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "&", ".", "-", "'", "!", "★", "@", " " };

            return letter[index];
        }

        private int writeConvertToName(char input)
        {
            String[] letter = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "&", ".", "-", "'", "!", "★", "@", " " };
            
            return Array.IndexOf(letter, input.ToString()) + 1;
        }

        private int readConvertToTime(Decimal hex)
        {
            var time = (int)hex;

            return time / 60;
        }

        private int writeConvertToTime(Decimal input)
        {
            var time = (int)input;

            return time * 60;
        }

        public void readWhips(Decimal hex)
        {
            int[] whips = { 256, 128, 64, 32, 16, 8, 4, 2, 1 };

            int index = 8;

            foreach (int whip in whips)
            {
                if (hex - whip >= 0)
                {
                    abilitiesWhipsInput.SetItemChecked(index, true);
                    hex -= whip;
                }
                else
                {
                    abilitiesWhipsInput.SetItemChecked(index, false);
                }
                index -= 1;
            }
        }

        public int writeWhips(CheckedListBox input)
        {
            int[] whips = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };

            int hex = 0;

            foreach (var checkbox in input.CheckedIndices)
            {
                hex += whips[(int)checkbox];
            }

            return hex;
        }

        public void readSpellbooks(Decimal hex)
        {
            int[] spellBooks = { 16, 8, 4, 2, 1 };

            int index = 4;

            foreach (int spellBook in spellBooks)
            {
                if (hex - spellBook >= 0)
                {
                    abilitiesSpellbooksInput.SetItemChecked(index, true);
                    hex -= spellBook;
                }
                else
                {
                    abilitiesSpellbooksInput.SetItemChecked(index, false);
                }
                index -= 1;
            }
        }

        public int writeSpellbooks(CheckedListBox input)
        {
            int[] spellBooks = { 1, 2, 4, 8, 16 };

            int hex = 0;

            foreach (var checkbox in input.CheckedIndices)
            {
                hex += spellBooks[(int)checkbox];
            }

            return hex;
        }

        public void readRelics(Decimal hex)
        {
            int[] relics = { 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

            int index = 11;

            foreach (int relic in relics)
            {
                if (hex - relic >= 0)
                {
                    abilitiesRelicsInput.SetItemChecked(index, true);
                    hex -= relic;
                }
                else
                {
                    abilitiesRelicsInput.SetItemChecked(index, false);
                }
                index -= 1;
            }
        }

        public int writeRelics(CheckedListBox input)
        {
            int[] relics = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048 };

            int hex = 0;

            foreach (var checkbox in input.CheckedIndices)
            {
                hex += relics[(int)checkbox];
            }

            return hex;
        }

        public void readEncyclopedia(Decimal hex, int page)
        {
            int[] encyclopedia = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int index = 7;
                
            foreach (int entry in encyclopedia)
            {
                if (hex - entry >= 0)
                {
                    collectibleInput[1, index + (8 * page)].Value = true;
                    hex -= entry;
                }
                else
                {
                    if ((index + (8 * page)) <= 99)
                    {
                        collectibleInput[1, index + (8 * page)].Value = false;
                    }
                }
                index -= 1;
            }
        }

        public int writeEncyclopedia(DataGridView input, int page)
        {
            int[] encyclopedia = { 1, 2, 4, 8, 16, 32, 64, 128 };
            
            int hex = 0;

            for (int index = (8 * page); index <= (7 + (8 * page)); index++)
            {
                if(index <= 99)
                {
                    if ((bool)input[1, index].Value)
                    {
                        hex += encyclopedia[(index - (8 * page))];
                    }
                }
            }

            return hex;
        }

        public void readCollectibles(Decimal hex, int page)
        {
            int[] collectibles = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int index = 7;

            foreach (int collectible in collectibles)
            {
                if (hex - collectible >= 0)
                {
                    collectiblesInput[1, index + (8 * page)].Value = true;
                    hex -= collectible;
                }
                else
                {
                    if ((index + (8 * page)) <= 30)
                    {
                        collectiblesInput[1, index + (8 * page)].Value = false;
                    }
                }
                index -= 1;
            }
        }

        public int writeCollectibles(DataGridView input, int page)
        {
            int[] collectibles = { 1, 2, 4, 8, 16, 32, 64, 128 };

            int hex = 0;

            for (int index = (8 * page); index <= (7 + (8 * page)); index++)
            {
                if (index <= 30)
                {
                    if ((bool)input[1, index].Value)
                    {
                        hex += collectibles[(index - (8 * page))];
                    }
                }
            }

            return hex;
        }

        public void readMap(Decimal hex)
        {
            //0x138 > 0x3b7 > Map complète

            //0x138 > 0x273 > 1er moitié verticale
            //0x278 > 0x3b7 > 2eme moitié verticale

            //1  = X
            //2  =  X
            //4  =   X
            //8  =    X
            //10 =    X
            //20 =     X
            //40 =      X
            //80 =       X
            //84 =   X   X

            //Blocs de 4 octets maps A > 4 octets maps B > 4 octects maps A...
        }

        private void readStats()
        {
            try
            {
                writeMessage("Loading...");

                tabControl.SelectedTab = tabCharacter;

                if (
                    savEdit.readData((int)checkSaveHex1[0], (int)checkSaveHex1[1]) != 67 ||
                    savEdit.readData((int)checkSaveHex2[0], (int)checkSaveHex2[1]) != 65 ||
                    savEdit.readData((int)checkSaveHex3[0], (int)checkSaveHex3[1]) != 83 ||
                    savEdit.readData((int)checkSaveHex4[0], (int)checkSaveHex4[1]) != 84 ||
                    savEdit.readData((int)checkSaveHex5[0], (int)checkSaveHex5[1]) != 76 ||
                    savEdit.readData((int)checkSaveHex6[0], (int)checkSaveHex6[1]) != 69 ||
                    savEdit.readData((int)checkSaveHex7[0], (int)checkSaveHex7[1]) != 86 ||
                    savEdit.readData((int)checkSaveHex8[0], (int)checkSaveHex8[1]) != 65 ||
                    savEdit.readData((int)checkSaveHex9[0], (int)checkSaveHex9[1]) != 78 ||
                    savEdit.readData((int)checkSaveHex10[0], (int)checkSaveHex10[1]) != 73 ||
                    savEdit.readData((int)checkSaveHex11[0], (int)checkSaveHex11[1]) != 65 ||
                    savEdit.readData((int)checkSaveHex12[0], (int)checkSaveHex12[1]) != 49 ||
                    savEdit.readData((int)checkSaveHex13[0], (int)checkSaveHex13[1]) != 46 ||
                    savEdit.readData((int)checkSaveHex14[0], (int)checkSaveHex14[1]) != 48 ||
                    savEdit.readData((int)checkSaveHex15[0], (int)checkSaveHex15[1]) != 48
                   )
                {
                    enableForm(false);
                    writeMessage("Wrong save data...");
                    return;
                }

                int locationValue = 0;

                switch (saveID)
                {
                    case 1:
                        locationValue = 0;
                        break;
                    case 2:
                        locationValue = 1016;
                        break;
                    case 3:
                        locationValue = 2032;
                        break;
                }

                enableForm(true);

                if (savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 0)
                {
                    generalBonusInput.SelectedIndex = 0;

                }
                else if (
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 1 ||
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 65 ||
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 129 ||
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 193
                        )
                {
                    generalBonusInput.SelectedIndex = 1;
                }
                else if (
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 2 ||
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 66 ||
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 130 ||
                         savEdit.readData((int)generalBonusHex[0], (int)generalBonusHex[1]) == 194
                        )
                {
                    generalBonusInput.SelectedIndex = 2;
                }

                if (savEdit.readData((int)statsStatusmenuHex[0] + locationValue, (int)statsStatusmenuHex[1]) < 255)
                {
                    statsStatusmenuInput.SelectedIndex = 0;
                }
                else
                {
                    statsStatusmenuInput.SelectedIndex = 1;
                }

                if (savEdit.readData((int)statsLvlSavscHex[0] + locationValue, (int)statsLvlSavscHex[1]) <= 99)
                {
                    characterImage.Image = Properties.Resources.character_juste;
                    statsCharacterInput.SelectedIndex = 0;
                }
                else
                {
                    characterImage.Image = Properties.Resources.character_maxime;
                    statsCharacterInput.SelectedIndex = 1;
                }

                statsNameInput.Text = readConvertToName(savEdit.readData((int)statsName1Hex[0] + locationValue, (int)statsName1Hex[1])) + readConvertToName(savEdit.readData((int)statsName2Hex[0] + locationValue, (int)statsName2Hex[1])) + readConvertToName(savEdit.readData((int)statsName3Hex[0] + locationValue, (int)statsName3Hex[1])) + readConvertToName(savEdit.readData((int)statsName4Hex[0] + locationValue, (int)statsName4Hex[1])) + readConvertToName(savEdit.readData((int)statsName5Hex[0] + locationValue, (int)statsName5Hex[1])) + readConvertToName(savEdit.readData((int)statsName6Hex[0] + locationValue, (int)statsName6Hex[1])) + readConvertToName(savEdit.readData((int)statsName7Hex[0] + locationValue, (int)statsName7Hex[1])) + readConvertToName(savEdit.readData((int)statsName8Hex[0] + locationValue, (int)statsName8Hex[1]));

                statsLvlInput.Value = savEdit.readData((int)statsLvlHex[0] + locationValue, (int)statsLvlHex[1]);
                statsExpInput.Value = savEdit.readData((int)statsExpHex[0] + locationValue, (int)statsExpHex[1]);
                statsHpmaxInput.Value = savEdit.readData((int)statsHpmaxHex[0] + locationValue, (int)statsHpmaxHex[1]);
                statsMpmaxInput.Value = savEdit.readData((int)statsMpmaxHex[0] + locationValue, (int)statsMpmaxHex[1]);
                statsSubweaponInput.SelectedIndex = (int)savEdit.readData((int)statsSubweaponHex[0] + locationValue, (int)statsSubweaponHex[1]);
                statsHeartsInput.Value = savEdit.readData((int)statsHeartsHex[0] + locationValue, (int)statsHeartsHex[1]);
                statsHeartsmaxInput.Value = savEdit.readData((int)statsHeartsmaxHex[0] + locationValue, (int)statsHeartsmaxHex[1]);
                statsStrInput.Value = savEdit.readData((int)statsStrHex[0] + locationValue, (int)statsStrHex[1]);
                statsDefInput.Value = savEdit.readData((int)statsDefHex[0] + locationValue, (int)statsDefHex[1]);
                statsIntInput.Value = savEdit.readData((int)statsIntHex[0] + locationValue, (int)statsIntHex[1]);
                statsLckInput.Value = savEdit.readData((int)statsLckHex[0] + locationValue, (int)statsLckHex[1]);
                statsGoldInput.Value = savEdit.readData((int)statsGoldHex[0] + locationValue, (int)statsGoldHex[1]);
                statsTimeInput.Value = readConvertToTime(savEdit.readData((int)statsTimeHex[0] + locationValue, (int)statsTimeHex[1]));
                
                statsEquippedwhipInput.SelectedIndex = ((int)savEdit.readData((int)statsEquippedwhipHex[0] + locationValue, (int)statsEquippedwhipHex[1]) != 255 ? ((int)savEdit.readData((int)statsEquippedwhipHex[0] + locationValue, (int)statsEquippedwhipHex[1]) + 1) : 0);
                statsEquippedarmorInput.SelectedIndex = ((int)savEdit.readData((int)statsEquippedarmorHex[0] + locationValue, (int)statsEquippedarmorHex[1]) != 255 ? ((int)savEdit.readData((int)statsEquippedarmorHex[0] + locationValue, (int)statsEquippedarmorHex[1]) + 1) : 0);
                statsEquippedaccessory1Input.SelectedIndex = ((int)savEdit.readData((int)statsEquippedaccessory1Hex[0] + locationValue, (int)statsEquippedaccessory1Hex[1]) != 255 ? ((int)savEdit.readData((int)statsEquippedaccessory1Hex[0] + locationValue, (int)statsEquippedaccessory1Hex[1]) - 41) : 0);
                statsEquippedaccessory2Input.SelectedIndex = ((int)savEdit.readData((int)statsEquippedaccessory2Hex[0] + locationValue, (int)statsEquippedaccessory2Hex[1]) != 255 ? ((int)savEdit.readData((int)statsEquippedaccessory2Hex[0] + locationValue, (int)statsEquippedaccessory2Hex[1]) - 41) : 0);
                statsEquippedaccessory3Input.SelectedIndex = ((int)savEdit.readData((int)statsEquippedaccessory3Hex[0] + locationValue, (int)statsEquippedaccessory3Hex[1]) != 255 ? ((int)savEdit.readData((int)statsEquippedaccessory3Hex[0] + locationValue, (int)statsEquippedaccessory3Hex[1]) - 41) : 0);
                
                readWhips(savEdit.readData((int)abilitiesWhipsHex[0] + locationValue, (int)abilitiesWhipsHex[1]));
                
                armorsInput[1, 0].Value = savEdit.readData((int)armors1Hex[0] + locationValue, (int)armors1Hex[1]);
                armorsInput[1, 1].Value = savEdit.readData((int)armors2Hex[0] + locationValue, (int)armors2Hex[1]);
                armorsInput[1, 2].Value = savEdit.readData((int)armors3Hex[0] + locationValue, (int)armors3Hex[1]);
                armorsInput[1, 3].Value = savEdit.readData((int)armors4Hex[0] + locationValue, (int)armors4Hex[1]);
                armorsInput[1, 4].Value = savEdit.readData((int)armors5Hex[0] + locationValue, (int)armors5Hex[1]);
                armorsInput[1, 5].Value = savEdit.readData((int)armors6Hex[0] + locationValue, (int)armors6Hex[1]);
                armorsInput[1, 6].Value = savEdit.readData((int)armors7Hex[0] + locationValue, (int)armors7Hex[1]);
                armorsInput[1, 7].Value = savEdit.readData((int)armors8Hex[0] + locationValue, (int)armors8Hex[1]);
                armorsInput[1, 8].Value = savEdit.readData((int)armors9Hex[0] + locationValue, (int)armors9Hex[1]);
                armorsInput[1, 9].Value = savEdit.readData((int)armors10Hex[0] + locationValue, (int)armors10Hex[1]);
                armorsInput[1, 10].Value = savEdit.readData((int)armors11Hex[0] + locationValue, (int)armors11Hex[1]);
                armorsInput[1, 11].Value = savEdit.readData((int)armors12Hex[0] + locationValue, (int)armors12Hex[1]);
                armorsInput[1, 12].Value = savEdit.readData((int)armors13Hex[0] + locationValue, (int)armors13Hex[1]);
                armorsInput[1, 13].Value = savEdit.readData((int)armors14Hex[0] + locationValue, (int)armors14Hex[1]);
                armorsInput[1, 14].Value = savEdit.readData((int)armors15Hex[0] + locationValue, (int)armors15Hex[1]);
                armorsInput[1, 15].Value = savEdit.readData((int)armors16Hex[0] + locationValue, (int)armors16Hex[1]);
                armorsInput[1, 16].Value = savEdit.readData((int)armors17Hex[0] + locationValue, (int)armors17Hex[1]);
                armorsInput[1, 17].Value = savEdit.readData((int)armors18Hex[0] + locationValue, (int)armors18Hex[1]);
                armorsInput[1, 18].Value = savEdit.readData((int)armors19Hex[0] + locationValue, (int)armors19Hex[1]);
                armorsInput[1, 19].Value = savEdit.readData((int)armors20Hex[0] + locationValue, (int)armors20Hex[1]);
                armorsInput[1, 20].Value = savEdit.readData((int)armors21Hex[0] + locationValue, (int)armors21Hex[1]);
                armorsInput[1, 21].Value = savEdit.readData((int)armors22Hex[0] + locationValue, (int)armors22Hex[1]);
                armorsInput[1, 22].Value = savEdit.readData((int)armors23Hex[0] + locationValue, (int)armors23Hex[1]);
                armorsInput[1, 23].Value = savEdit.readData((int)armors24Hex[0] + locationValue, (int)armors24Hex[1]);
                armorsInput[1, 24].Value = savEdit.readData((int)armors25Hex[0] + locationValue, (int)armors25Hex[1]);
                armorsInput[1, 25].Value = savEdit.readData((int)armors26Hex[0] + locationValue, (int)armors26Hex[1]);
                armorsInput[1, 26].Value = savEdit.readData((int)armors27Hex[0] + locationValue, (int)armors27Hex[1]);
                armorsInput[1, 27].Value = savEdit.readData((int)armors28Hex[0] + locationValue, (int)armors28Hex[1]);
                armorsInput[1, 28].Value = savEdit.readData((int)armors29Hex[0] + locationValue, (int)armors29Hex[1]);
                armorsInput[1, 29].Value = savEdit.readData((int)armors30Hex[0] + locationValue, (int)armors30Hex[1]);
                armorsInput[1, 30].Value = savEdit.readData((int)armors31Hex[0] + locationValue, (int)armors31Hex[1]);
                armorsInput[1, 31].Value = savEdit.readData((int)armors32Hex[0] + locationValue, (int)armors32Hex[1]);
                armorsInput[1, 32].Value = savEdit.readData((int)armors33Hex[0] + locationValue, (int)armors33Hex[1]);
                armorsInput[1, 33].Value = savEdit.readData((int)armors34Hex[0] + locationValue, (int)armors34Hex[1]);
                armorsInput[1, 34].Value = savEdit.readData((int)armors35Hex[0] + locationValue, (int)armors35Hex[1]);
                armorsInput[1, 35].Value = savEdit.readData((int)armors36Hex[0] + locationValue, (int)armors36Hex[1]);
                armorsInput[1, 36].Value = savEdit.readData((int)armors37Hex[0] + locationValue, (int)armors37Hex[1]);
                armorsInput[1, 37].Value = savEdit.readData((int)armors38Hex[0] + locationValue, (int)armors38Hex[1]);
                armorsInput[1, 38].Value = savEdit.readData((int)armors39Hex[0] + locationValue, (int)armors39Hex[1]);
                armorsInput[1, 39].Value = savEdit.readData((int)armors40Hex[0] + locationValue, (int)armors40Hex[1]);
                armorsInput[1, 40].Value = savEdit.readData((int)armors41Hex[0] + locationValue, (int)armors41Hex[1]);
                armorsInput[1, 41].Value = savEdit.readData((int)armors42Hex[0] + locationValue, (int)armors42Hex[1]);
                
                accessoriesInput[1, 0].Value = savEdit.readData((int)accessories1Hex[0] + locationValue, (int)accessories1Hex[1]);
                accessoriesInput[1, 1].Value = savEdit.readData((int)accessories2Hex[0] + locationValue, (int)accessories2Hex[1]);
                accessoriesInput[1, 2].Value = savEdit.readData((int)accessories3Hex[0] + locationValue, (int)accessories3Hex[1]);
                accessoriesInput[1, 3].Value = savEdit.readData((int)accessories4Hex[0] + locationValue, (int)accessories4Hex[1]);
                accessoriesInput[1, 4].Value = savEdit.readData((int)accessories5Hex[0] + locationValue, (int)accessories5Hex[1]);
                accessoriesInput[1, 5].Value = savEdit.readData((int)accessories6Hex[0] + locationValue, (int)accessories6Hex[1]);
                accessoriesInput[1, 6].Value = savEdit.readData((int)accessories7Hex[0] + locationValue, (int)accessories7Hex[1]);
                accessoriesInput[1, 7].Value = savEdit.readData((int)accessories8Hex[0] + locationValue, (int)accessories8Hex[1]);
                accessoriesInput[1, 8].Value = savEdit.readData((int)accessories9Hex[0] + locationValue, (int)accessories9Hex[1]);
                accessoriesInput[1, 9].Value = savEdit.readData((int)accessories10Hex[0] + locationValue, (int)accessories10Hex[1]);
                accessoriesInput[1, 10].Value = savEdit.readData((int)accessories11Hex[0] + locationValue, (int)accessories11Hex[1]);
                accessoriesInput[1, 11].Value = savEdit.readData((int)accessories12Hex[0] + locationValue, (int)accessories12Hex[1]);
                accessoriesInput[1, 12].Value = savEdit.readData((int)accessories13Hex[0] + locationValue, (int)accessories13Hex[1]);
                accessoriesInput[1, 13].Value = savEdit.readData((int)accessories14Hex[0] + locationValue, (int)accessories14Hex[1]);
                accessoriesInput[1, 14].Value = savEdit.readData((int)accessories15Hex[0] + locationValue, (int)accessories15Hex[1]);
                accessoriesInput[1, 15].Value = savEdit.readData((int)accessories16Hex[0] + locationValue, (int)accessories16Hex[1]);
                accessoriesInput[1, 16].Value = savEdit.readData((int)accessories17Hex[0] + locationValue, (int)accessories17Hex[1]);
                accessoriesInput[1, 17].Value = savEdit.readData((int)accessories18Hex[0] + locationValue, (int)accessories18Hex[1]);
                accessoriesInput[1, 18].Value = savEdit.readData((int)accessories19Hex[0] + locationValue, (int)accessories19Hex[1]);
                accessoriesInput[1, 19].Value = savEdit.readData((int)accessories20Hex[0] + locationValue, (int)accessories20Hex[1]);
                accessoriesInput[1, 20].Value = savEdit.readData((int)accessories21Hex[0] + locationValue, (int)accessories21Hex[1]);
                accessoriesInput[1, 21].Value = savEdit.readData((int)accessories22Hex[0] + locationValue, (int)accessories22Hex[1]);
                accessoriesInput[1, 22].Value = savEdit.readData((int)accessories23Hex[0] + locationValue, (int)accessories23Hex[1]);
                accessoriesInput[1, 23].Value = savEdit.readData((int)accessories24Hex[0] + locationValue, (int)accessories24Hex[1]);
                accessoriesInput[1, 24].Value = savEdit.readData((int)accessories25Hex[0] + locationValue, (int)accessories25Hex[1]);
                accessoriesInput[1, 25].Value = savEdit.readData((int)accessories26Hex[0] + locationValue, (int)accessories26Hex[1]);
                accessoriesInput[1, 26].Value = savEdit.readData((int)accessories27Hex[0] + locationValue, (int)accessories27Hex[1]);
                accessoriesInput[1, 27].Value = savEdit.readData((int)accessories28Hex[0] + locationValue, (int)accessories28Hex[1]);
                accessoriesInput[1, 28].Value = savEdit.readData((int)accessories29Hex[0] + locationValue, (int)accessories29Hex[1]);
                accessoriesInput[1, 29].Value = savEdit.readData((int)accessories30Hex[0] + locationValue, (int)accessories30Hex[1]);
                accessoriesInput[1, 30].Value = savEdit.readData((int)accessories31Hex[0] + locationValue, (int)accessories31Hex[1]);
                accessoriesInput[1, 31].Value = savEdit.readData((int)accessories32Hex[0] + locationValue, (int)accessories32Hex[1]);
                accessoriesInput[1, 32].Value = savEdit.readData((int)accessories33Hex[0] + locationValue, (int)accessories33Hex[1]);
                accessoriesInput[1, 33].Value = savEdit.readData((int)accessories34Hex[0] + locationValue, (int)accessories34Hex[1]);
                accessoriesInput[1, 34].Value = savEdit.readData((int)accessories35Hex[0] + locationValue, (int)accessories35Hex[1]);
                accessoriesInput[1, 35].Value = savEdit.readData((int)accessories36Hex[0] + locationValue, (int)accessories36Hex[1]);
                accessoriesInput[1, 36].Value = savEdit.readData((int)accessories37Hex[0] + locationValue, (int)accessories37Hex[1]);
                accessoriesInput[1, 37].Value = savEdit.readData((int)accessories38Hex[0] + locationValue, (int)accessories38Hex[1]);
                accessoriesInput[1, 38].Value = savEdit.readData((int)accessories39Hex[0] + locationValue, (int)accessories39Hex[1]);
                accessoriesInput[1, 39].Value = savEdit.readData((int)accessories40Hex[0] + locationValue, (int)accessories40Hex[1]);
                accessoriesInput[1, 40].Value = savEdit.readData((int)accessories41Hex[0] + locationValue, (int)accessories41Hex[1]);
                accessoriesInput[1, 41].Value = savEdit.readData((int)accessories42Hex[0] + locationValue, (int)accessories42Hex[1]);
                accessoriesInput[1, 42].Value = savEdit.readData((int)accessories43Hex[0] + locationValue, (int)accessories43Hex[1]);
                accessoriesInput[1, 43].Value = savEdit.readData((int)accessories44Hex[0] + locationValue, (int)accessories44Hex[1]);
                accessoriesInput[1, 44].Value = savEdit.readData((int)accessories45Hex[0] + locationValue, (int)accessories45Hex[1]);
                accessoriesInput[1, 45].Value = savEdit.readData((int)accessories46Hex[0] + locationValue, (int)accessories46Hex[1]);
                accessoriesInput[1, 46].Value = savEdit.readData((int)accessories47Hex[0] + locationValue, (int)accessories47Hex[1]);
                accessoriesInput[1, 47].Value = savEdit.readData((int)accessories48Hex[0] + locationValue, (int)accessories48Hex[1]);
                accessoriesInput[1, 48].Value = savEdit.readData((int)accessories49Hex[0] + locationValue, (int)accessories49Hex[1]);
                accessoriesInput[1, 49].Value = savEdit.readData((int)accessories50Hex[0] + locationValue, (int)accessories50Hex[1]);
                accessoriesInput[1, 50].Value = savEdit.readData((int)accessories51Hex[0] + locationValue, (int)accessories51Hex[1]);
                accessoriesInput[1, 51].Value = savEdit.readData((int)accessories52Hex[0] + locationValue, (int)accessories52Hex[1]);
                accessoriesInput[1, 52].Value = savEdit.readData((int)accessories53Hex[0] + locationValue, (int)accessories53Hex[1]);
                accessoriesInput[1, 53].Value = savEdit.readData((int)accessories54Hex[0] + locationValue, (int)accessories54Hex[1]);
                accessoriesInput[1, 54].Value = savEdit.readData((int)accessories55Hex[0] + locationValue, (int)accessories55Hex[1]);
                accessoriesInput[1, 55].Value = savEdit.readData((int)accessories56Hex[0] + locationValue, (int)accessories56Hex[1]);
                accessoriesInput[1, 56].Value = savEdit.readData((int)accessories57Hex[0] + locationValue, (int)accessories57Hex[1]);
                accessoriesInput[1, 57].Value = savEdit.readData((int)accessories58Hex[0] + locationValue, (int)accessories58Hex[1]);
                accessoriesInput[1, 58].Value = savEdit.readData((int)accessories59Hex[0] + locationValue, (int)accessories59Hex[1]);
                accessoriesInput[1, 59].Value = savEdit.readData((int)accessories60Hex[0] + locationValue, (int)accessories60Hex[1]);
                accessoriesInput[1, 60].Value = savEdit.readData((int)accessories61Hex[0] + locationValue, (int)accessories61Hex[1]);
                accessoriesInput[1, 61].Value = savEdit.readData((int)accessories62Hex[0] + locationValue, (int)accessories62Hex[1]);
                accessoriesInput[1, 62].Value = savEdit.readData((int)accessories63Hex[0] + locationValue, (int)accessories63Hex[1]);
                accessoriesInput[1, 63].Value = savEdit.readData((int)accessories64Hex[0] + locationValue, (int)accessories64Hex[1]);
                accessoriesInput[1, 64].Value = savEdit.readData((int)accessories65Hex[0] + locationValue, (int)accessories65Hex[1]);
                accessoriesInput[1, 65].Value = savEdit.readData((int)accessories66Hex[0] + locationValue, (int)accessories66Hex[1]);
                accessoriesInput[1, 66].Value = savEdit.readData((int)accessories67Hex[0] + locationValue, (int)accessories67Hex[1]);
                accessoriesInput[1, 67].Value = savEdit.readData((int)accessories68Hex[0] + locationValue, (int)accessories68Hex[1]);
                accessoriesInput[1, 68].Value = savEdit.readData((int)accessories69Hex[0] + locationValue, (int)accessories69Hex[1]);
                accessoriesInput[1, 69].Value = savEdit.readData((int)accessories70Hex[0] + locationValue, (int)accessories70Hex[1]);
                accessoriesInput[1, 70].Value = savEdit.readData((int)accessories71Hex[0] + locationValue, (int)accessories71Hex[1]);
                accessoriesInput[1, 71].Value = savEdit.readData((int)accessories72Hex[0] + locationValue, (int)accessories72Hex[1]);
                accessoriesInput[1, 72].Value = savEdit.readData((int)accessories73Hex[0] + locationValue, (int)accessories73Hex[1]);
                accessoriesInput[1, 73].Value = savEdit.readData((int)accessories74Hex[0] + locationValue, (int)accessories74Hex[1]);
                accessoriesInput[1, 74].Value = savEdit.readData((int)accessories75Hex[0] + locationValue, (int)accessories75Hex[1]);
                accessoriesInput[1, 75].Value = savEdit.readData((int)accessories76Hex[0] + locationValue, (int)accessories76Hex[1]);
                accessoriesInput[1, 76].Value = savEdit.readData((int)accessories77Hex[0] + locationValue, (int)accessories77Hex[1]);
                accessoriesInput[1, 77].Value = savEdit.readData((int)accessories78Hex[0] + locationValue, (int)accessories78Hex[1]);
                accessoriesInput[1, 78].Value = savEdit.readData((int)accessories79Hex[0] + locationValue, (int)accessories79Hex[1]);
                accessoriesInput[1, 79].Value = savEdit.readData((int)accessories80Hex[0] + locationValue, (int)accessories80Hex[1]);
                accessoriesInput[1, 80].Value = savEdit.readData((int)accessories81Hex[0] + locationValue, (int)accessories81Hex[1]);
                accessoriesInput[1, 81].Value = savEdit.readData((int)accessories82Hex[0] + locationValue, (int)accessories82Hex[1]);
                accessoriesInput[1, 82].Value = savEdit.readData((int)accessories83Hex[0] + locationValue, (int)accessories83Hex[1]);
                accessoriesInput[1, 83].Value = savEdit.readData((int)accessories84Hex[0] + locationValue, (int)accessories84Hex[1]);
                accessoriesInput[1, 84].Value = savEdit.readData((int)accessories85Hex[0] + locationValue, (int)accessories85Hex[1]);
                accessoriesInput[1, 85].Value = savEdit.readData((int)accessories86Hex[0] + locationValue, (int)accessories86Hex[1]);

                itemsInput[1, 0].Value = savEdit.readData((int)items1Hex[0] + locationValue, (int)items1Hex[1]);
                itemsInput[1, 1].Value = savEdit.readData((int)items2Hex[0] + locationValue, (int)items2Hex[1]);
                itemsInput[1, 2].Value = savEdit.readData((int)items3Hex[0] + locationValue, (int)items3Hex[1]);
                itemsInput[1, 3].Value = savEdit.readData((int)items4Hex[0] + locationValue, (int)items4Hex[1]);
                itemsInput[1, 4].Value = savEdit.readData((int)items5Hex[0] + locationValue, (int)items5Hex[1]);
                itemsInput[1, 5].Value = savEdit.readData((int)items6Hex[0] + locationValue, (int)items6Hex[1]);
                itemsInput[1, 6].Value = savEdit.readData((int)items7Hex[0] + locationValue, (int)items7Hex[1]);
                itemsInput[1, 7].Value = savEdit.readData((int)items8Hex[0] + locationValue, (int)items8Hex[1]);
                itemsInput[1, 8].Value = savEdit.readData((int)items9Hex[0] + locationValue, (int)items9Hex[1]);
                itemsInput[1, 9].Value = savEdit.readData((int)items10Hex[0] + locationValue, (int)items10Hex[1]);
                itemsInput[1, 10].Value = savEdit.readData((int)items11Hex[0] + locationValue, (int)items11Hex[1]);
                itemsInput[1, 11].Value = savEdit.readData((int)items12Hex[0] + locationValue, (int)items12Hex[1]);
                itemsInput[1, 12].Value = savEdit.readData((int)items13Hex[0] + locationValue, (int)items13Hex[1]);
                itemsInput[1, 13].Value = savEdit.readData((int)items14Hex[0] + locationValue, (int)items14Hex[1]);
                itemsInput[1, 14].Value = savEdit.readData((int)items15Hex[0] + locationValue, (int)items15Hex[1]);
                itemsInput[1, 15].Value = savEdit.readData((int)items16Hex[0] + locationValue, (int)items16Hex[1]);
                itemsInput[1, 16].Value = savEdit.readData((int)items17Hex[0] + locationValue, (int)items17Hex[1]);
                itemsInput[1, 17].Value = savEdit.readData((int)items18Hex[0] + locationValue, (int)items18Hex[1]);
                itemsInput[1, 18].Value = savEdit.readData((int)items19Hex[0] + locationValue, (int)items19Hex[1]);
                itemsInput[1, 19].Value = savEdit.readData((int)items20Hex[0] + locationValue, (int)items20Hex[1]);
                itemsInput[1, 20].Value = savEdit.readData((int)items21Hex[0] + locationValue, (int)items21Hex[1]);
                itemsInput[1, 21].Value = savEdit.readData((int)items22Hex[0] + locationValue, (int)items22Hex[1]);
                itemsInput[1, 22].Value = savEdit.readData((int)items23Hex[0] + locationValue, (int)items23Hex[1]);
                itemsInput[1, 23].Value = savEdit.readData((int)items24Hex[0] + locationValue, (int)items24Hex[1]);
                itemsInput[1, 24].Value = savEdit.readData((int)items25Hex[0] + locationValue, (int)items25Hex[1]);
                itemsInput[1, 25].Value = savEdit.readData((int)items26Hex[0] + locationValue, (int)items26Hex[1]);
                itemsInput[1, 26].Value = savEdit.readData((int)items27Hex[0] + locationValue, (int)items27Hex[1]);
                itemsInput[1, 27].Value = savEdit.readData((int)items28Hex[0] + locationValue, (int)items28Hex[1]);

                readSpellbooks(savEdit.readData((int)abilitiesSpellbooksHex[0] + locationValue, (int)abilitiesSpellbooksHex[1]));
                readRelics(savEdit.readData((int)abilitiesRelicsHex[0] + locationValue, (int)abilitiesRelicsHex[1]));

                readEncyclopedia(savEdit.readData((int)encyclopedia1Hex[0] + locationValue, (int)encyclopedia1Hex[1]), 0);
                readEncyclopedia(savEdit.readData((int)encyclopedia2Hex[0] + locationValue, (int)encyclopedia2Hex[1]), 1);
                readEncyclopedia(savEdit.readData((int)encyclopedia3Hex[0] + locationValue, (int)encyclopedia3Hex[1]), 2);
                readEncyclopedia(savEdit.readData((int)encyclopedia4Hex[0] + locationValue, (int)encyclopedia4Hex[1]), 3);
                readEncyclopedia(savEdit.readData((int)encyclopedia5Hex[0] + locationValue, (int)encyclopedia5Hex[1]), 4);
                readEncyclopedia(savEdit.readData((int)encyclopedia6Hex[0] + locationValue, (int)encyclopedia6Hex[1]), 5);
                readEncyclopedia(savEdit.readData((int)encyclopedia7Hex[0] + locationValue, (int)encyclopedia7Hex[1]), 6);
                readEncyclopedia(savEdit.readData((int)encyclopedia8Hex[0] + locationValue, (int)encyclopedia8Hex[1]), 7);
                readEncyclopedia(savEdit.readData((int)encyclopedia9Hex[0] + locationValue, (int)encyclopedia9Hex[1]), 8);
                readEncyclopedia(savEdit.readData((int)encyclopedia10Hex[0] + locationValue, (int)encyclopedia10Hex[1]), 9);
                readEncyclopedia(savEdit.readData((int)encyclopedia11Hex[0] + locationValue, (int)encyclopedia11Hex[1]), 10);
                readEncyclopedia(savEdit.readData((int)encyclopedia12Hex[0] + locationValue, (int)encyclopedia12Hex[1]), 11);
                readEncyclopedia(savEdit.readData((int)encyclopedia13Hex[0] + locationValue, (int)encyclopedia13Hex[1]), 12);

                readCollectibles(savEdit.readData((int)collectibles1Hex[0] + locationValue, (int)collectibles1Hex[1]), 0);
                readCollectibles(savEdit.readData((int)collectibles2Hex[0] + locationValue, (int)collectibles2Hex[1]), 1);
                readCollectibles(savEdit.readData((int)collectibles3Hex[0] + locationValue, (int)collectibles3Hex[1]), 2);
                readCollectibles(savEdit.readData((int)collectibles4Hex[0] + locationValue, (int)collectibles4Hex[1]), 3);

                writeMessage("Loaded.");
            }
            catch (Exception err)
            {
                writeMessage("Error...");
                MessageBox.Show(err.Message);
            }

        }

        private void writeStats()
        {
            try
            {
                writeMessage("Saving...");

                slot1Button.Focus();

                int locationValue = 0;

                switch (saveID)
                {
                    case 1:
                        locationValue = 0;
                        break;
                    case 2:
                        locationValue = 1016;
                        break;
                    case 3:
                        locationValue = 2032;
                        break;
                }

                char statsNameInput1 = ' ';
                char statsNameInput2 = ' ';
                char statsNameInput3 = ' ';
                char statsNameInput4 = ' ';
                char statsNameInput5 = ' ';
                char statsNameInput6 = ' ';
                char statsNameInput7 = ' ';
                char statsNameInput8 = ' ';

                if (statsNameInput.Text.Length >= 1) { statsNameInput1 = statsNameInput.Text[0]; }
                if (statsNameInput.Text.Length >= 2) { statsNameInput2 = statsNameInput.Text[1]; }
                if (statsNameInput.Text.Length >= 3) { statsNameInput3 = statsNameInput.Text[2]; }
                if (statsNameInput.Text.Length >= 4) { statsNameInput4 = statsNameInput.Text[3]; }
                if (statsNameInput.Text.Length >= 5) { statsNameInput5 = statsNameInput.Text[4]; }
                if (statsNameInput.Text.Length >= 6) { statsNameInput6 = statsNameInput.Text[5]; }
                if (statsNameInput.Text.Length >= 7) { statsNameInput7 = statsNameInput.Text[6]; }
                if (statsNameInput.Text.Length >= 8) { statsNameInput8 = statsNameInput.Text[7]; }

                savEdit.writeData((int)generalBonusHex[0], (int)generalBonusHex[1], generalBonusInput.SelectedIndex);

                if (statsStatusmenuInput.SelectedIndex == 0)
                {
                    savEdit.writeData((int)statsStatusmenuHex[0] + locationValue, (int)statsStatusmenuHex[1], 0);
                }
                else
                {
                    savEdit.writeData((int)statsStatusmenuHex[0] + locationValue, (int)statsStatusmenuHex[1], 255);
                }

                if (statsCharacterInput.SelectedIndex == 0)
                {
                    savEdit.writeData((int)statsLvlSavscHex[0] + locationValue, (int)statsLvlSavscHex[1], statsLvlInput.Value);
                }
                else
                {
                    savEdit.writeData((int)statsLvlSavscHex[0] + locationValue, (int)statsLvlSavscHex[1], 255);
                }

                savEdit.writeData((int)statsName1Hex[0] + locationValue, (int)statsName1Hex[1], writeConvertToName(statsNameInput1));
                savEdit.writeData((int)statsName2Hex[0] + locationValue, (int)statsName2Hex[1], writeConvertToName(statsNameInput2));
                savEdit.writeData((int)statsName3Hex[0] + locationValue, (int)statsName3Hex[1], writeConvertToName(statsNameInput3));
                savEdit.writeData((int)statsName4Hex[0] + locationValue, (int)statsName4Hex[1], writeConvertToName(statsNameInput4));
                savEdit.writeData((int)statsName5Hex[0] + locationValue, (int)statsName5Hex[1], writeConvertToName(statsNameInput5));
                savEdit.writeData((int)statsName6Hex[0] + locationValue, (int)statsName6Hex[1], writeConvertToName(statsNameInput6));
                savEdit.writeData((int)statsName7Hex[0] + locationValue, (int)statsName7Hex[1], writeConvertToName(statsNameInput7));
                savEdit.writeData((int)statsName8Hex[0] + locationValue, (int)statsName8Hex[1], writeConvertToName(statsNameInput8));

                savEdit.writeData((int)statsLvlHex[0] + locationValue, (int)statsLvlHex[1], statsLvlInput.Value);
                savEdit.writeData((int)statsExpHex[0] + locationValue, (int)statsExpHex[1], statsExpInput.Value);
                savEdit.writeData((int)statsHpmaxHex[0] + locationValue, (int)statsHpmaxHex[1], statsHpmaxInput.Value);
                savEdit.writeData((int)statsMpmaxHex[0] + locationValue, (int)statsMpmaxHex[1], statsMpmaxInput.Value);
                savEdit.writeData((int)statsSubweaponHex[0] + locationValue, (int)statsSubweaponHex[1], statsSubweaponInput.SelectedIndex);
                savEdit.writeData((int)statsHeartsHex[0] + locationValue, (int)statsHeartsHex[1], statsHeartsInput.Value);
                savEdit.writeData((int)statsHeartsmaxHex[0] + locationValue, (int)statsHeartsmaxHex[1], statsHeartsmaxInput.Value);
                savEdit.writeData((int)statsStrHex[0] + locationValue, (int)statsStrHex[1], statsStrInput.Value);
                savEdit.writeData((int)statsDefHex[0] + locationValue, (int)statsDefHex[1], statsDefInput.Value);
                savEdit.writeData((int)statsIntHex[0] + locationValue, (int)statsIntHex[1], statsIntInput.Value);
                savEdit.writeData((int)statsLckHex[0] + locationValue, (int)statsLckHex[1], statsLckInput.Value);
                savEdit.writeData((int)statsGoldHex[0] + locationValue, (int)statsGoldHex[1], statsGoldInput.Value);
                savEdit.writeData((int)statsGoldSavsHex[0] + locationValue, (int)statsGoldSavsHex[1], statsGoldInput.Value);
                savEdit.writeData((int)statsTimeHex[0] + locationValue, (int)statsTimeHex[1], writeConvertToTime(statsTimeInput.Value));
                
                savEdit.writeData((int)statsEquippedwhipHex[0] + locationValue, (int)statsEquippedwhipHex[1], (statsEquippedwhipInput.SelectedIndex > 0 ? (statsEquippedwhipInput.SelectedIndex - 1) : 255));
                savEdit.writeData((int)statsEquippedarmorHex[0] + locationValue, (int)statsEquippedarmorHex[1], (statsEquippedarmorInput.SelectedIndex > 0 ? (statsEquippedarmorInput.SelectedIndex - 1) : 255));
                savEdit.writeData((int)statsEquippedaccessory1Hex[0] + locationValue, (int)statsEquippedaccessory1Hex[1], (statsEquippedaccessory1Input.SelectedIndex > 0 ? (statsEquippedaccessory1Input.SelectedIndex +41) : 255));
                savEdit.writeData((int)statsEquippedaccessory2Hex[0] + locationValue, (int)statsEquippedaccessory2Hex[1], (statsEquippedaccessory2Input.SelectedIndex > 0 ? (statsEquippedaccessory2Input.SelectedIndex +41) : 255));
                savEdit.writeData((int)statsEquippedaccessory3Hex[0] + locationValue, (int)statsEquippedaccessory3Hex[1], (statsEquippedaccessory3Input.SelectedIndex > 0 ? (statsEquippedaccessory3Input.SelectedIndex +41) : 255));

                savEdit.writeData((int)abilitiesWhipsHex[0] + locationValue, (int)abilitiesWhipsHex[1], writeWhips(abilitiesWhipsInput));

                savEdit.writeData((int)armors1Hex[0] + locationValue, (int)armors1Hex[1], Convert.ToDecimal(armorsInput[1, 0].Value));
                savEdit.writeData((int)armors2Hex[0] + locationValue, (int)armors2Hex[1], Convert.ToDecimal(armorsInput[1, 1].Value));
                savEdit.writeData((int)armors3Hex[0] + locationValue, (int)armors3Hex[1], Convert.ToDecimal(armorsInput[1, 2].Value));
                savEdit.writeData((int)armors4Hex[0] + locationValue, (int)armors4Hex[1], Convert.ToDecimal(armorsInput[1, 3].Value));
                savEdit.writeData((int)armors5Hex[0] + locationValue, (int)armors5Hex[1], Convert.ToDecimal(armorsInput[1, 4].Value));
                savEdit.writeData((int)armors6Hex[0] + locationValue, (int)armors6Hex[1], Convert.ToDecimal(armorsInput[1, 5].Value));
                savEdit.writeData((int)armors7Hex[0] + locationValue, (int)armors7Hex[1], Convert.ToDecimal(armorsInput[1, 6].Value));
                savEdit.writeData((int)armors8Hex[0] + locationValue, (int)armors8Hex[1], Convert.ToDecimal(armorsInput[1, 7].Value));
                savEdit.writeData((int)armors9Hex[0] + locationValue, (int)armors9Hex[1], Convert.ToDecimal(armorsInput[1, 8].Value));
                savEdit.writeData((int)armors10Hex[0] + locationValue, (int)armors10Hex[1], Convert.ToDecimal(armorsInput[1, 9].Value));
                savEdit.writeData((int)armors11Hex[0] + locationValue, (int)armors11Hex[1], Convert.ToDecimal(armorsInput[1, 10].Value));
                savEdit.writeData((int)armors12Hex[0] + locationValue, (int)armors12Hex[1], Convert.ToDecimal(armorsInput[1, 11].Value));
                savEdit.writeData((int)armors13Hex[0] + locationValue, (int)armors13Hex[1], Convert.ToDecimal(armorsInput[1, 12].Value));
                savEdit.writeData((int)armors14Hex[0] + locationValue, (int)armors14Hex[1], Convert.ToDecimal(armorsInput[1, 13].Value));
                savEdit.writeData((int)armors15Hex[0] + locationValue, (int)armors15Hex[1], Convert.ToDecimal(armorsInput[1, 14].Value));
                savEdit.writeData((int)armors16Hex[0] + locationValue, (int)armors16Hex[1], Convert.ToDecimal(armorsInput[1, 15].Value));
                savEdit.writeData((int)armors17Hex[0] + locationValue, (int)armors17Hex[1], Convert.ToDecimal(armorsInput[1, 16].Value));
                savEdit.writeData((int)armors18Hex[0] + locationValue, (int)armors18Hex[1], Convert.ToDecimal(armorsInput[1, 17].Value));
                savEdit.writeData((int)armors19Hex[0] + locationValue, (int)armors19Hex[1], Convert.ToDecimal(armorsInput[1, 18].Value));
                savEdit.writeData((int)armors20Hex[0] + locationValue, (int)armors20Hex[1], Convert.ToDecimal(armorsInput[1, 19].Value));
                savEdit.writeData((int)armors21Hex[0] + locationValue, (int)armors21Hex[1], Convert.ToDecimal(armorsInput[1, 20].Value));
                savEdit.writeData((int)armors22Hex[0] + locationValue, (int)armors22Hex[1], Convert.ToDecimal(armorsInput[1, 21].Value));
                savEdit.writeData((int)armors23Hex[0] + locationValue, (int)armors23Hex[1], Convert.ToDecimal(armorsInput[1, 22].Value));
                savEdit.writeData((int)armors24Hex[0] + locationValue, (int)armors24Hex[1], Convert.ToDecimal(armorsInput[1, 23].Value));
                savEdit.writeData((int)armors25Hex[0] + locationValue, (int)armors25Hex[1], Convert.ToDecimal(armorsInput[1, 24].Value));
                savEdit.writeData((int)armors26Hex[0] + locationValue, (int)armors26Hex[1], Convert.ToDecimal(armorsInput[1, 25].Value));
                savEdit.writeData((int)armors27Hex[0] + locationValue, (int)armors27Hex[1], Convert.ToDecimal(armorsInput[1, 26].Value));
                savEdit.writeData((int)armors28Hex[0] + locationValue, (int)armors28Hex[1], Convert.ToDecimal(armorsInput[1, 27].Value));
                savEdit.writeData((int)armors29Hex[0] + locationValue, (int)armors29Hex[1], Convert.ToDecimal(armorsInput[1, 28].Value));
                savEdit.writeData((int)armors30Hex[0] + locationValue, (int)armors30Hex[1], Convert.ToDecimal(armorsInput[1, 29].Value));
                savEdit.writeData((int)armors31Hex[0] + locationValue, (int)armors31Hex[1], Convert.ToDecimal(armorsInput[1, 30].Value));
                savEdit.writeData((int)armors32Hex[0] + locationValue, (int)armors32Hex[1], Convert.ToDecimal(armorsInput[1, 31].Value));
                savEdit.writeData((int)armors33Hex[0] + locationValue, (int)armors33Hex[1], Convert.ToDecimal(armorsInput[1, 32].Value));
                savEdit.writeData((int)armors34Hex[0] + locationValue, (int)armors34Hex[1], Convert.ToDecimal(armorsInput[1, 33].Value));
                savEdit.writeData((int)armors35Hex[0] + locationValue, (int)armors35Hex[1], Convert.ToDecimal(armorsInput[1, 34].Value));
                savEdit.writeData((int)armors36Hex[0] + locationValue, (int)armors36Hex[1], Convert.ToDecimal(armorsInput[1, 35].Value));
                savEdit.writeData((int)armors37Hex[0] + locationValue, (int)armors37Hex[1], Convert.ToDecimal(armorsInput[1, 36].Value));
                savEdit.writeData((int)armors38Hex[0] + locationValue, (int)armors38Hex[1], Convert.ToDecimal(armorsInput[1, 37].Value));
                savEdit.writeData((int)armors39Hex[0] + locationValue, (int)armors39Hex[1], Convert.ToDecimal(armorsInput[1, 38].Value));
                savEdit.writeData((int)armors40Hex[0] + locationValue, (int)armors40Hex[1], Convert.ToDecimal(armorsInput[1, 39].Value));
                savEdit.writeData((int)armors41Hex[0] + locationValue, (int)armors41Hex[1], Convert.ToDecimal(armorsInput[1, 40].Value));
                savEdit.writeData((int)armors42Hex[0] + locationValue, (int)armors42Hex[1], Convert.ToDecimal(armorsInput[1, 41].Value));

                savEdit.writeData((int)accessories1Hex[0] + locationValue, (int)accessories1Hex[1], Convert.ToDecimal(accessoriesInput[1, 0].Value));
                savEdit.writeData((int)accessories2Hex[0] + locationValue, (int)accessories2Hex[1], Convert.ToDecimal(accessoriesInput[1, 1].Value));
                savEdit.writeData((int)accessories3Hex[0] + locationValue, (int)accessories3Hex[1], Convert.ToDecimal(accessoriesInput[1, 2].Value));
                savEdit.writeData((int)accessories4Hex[0] + locationValue, (int)accessories4Hex[1], Convert.ToDecimal(accessoriesInput[1, 3].Value));
                savEdit.writeData((int)accessories5Hex[0] + locationValue, (int)accessories5Hex[1], Convert.ToDecimal(accessoriesInput[1, 4].Value));
                savEdit.writeData((int)accessories6Hex[0] + locationValue, (int)accessories6Hex[1], Convert.ToDecimal(accessoriesInput[1, 5].Value));
                savEdit.writeData((int)accessories7Hex[0] + locationValue, (int)accessories7Hex[1], Convert.ToDecimal(accessoriesInput[1, 6].Value));
                savEdit.writeData((int)accessories8Hex[0] + locationValue, (int)accessories8Hex[1], Convert.ToDecimal(accessoriesInput[1, 7].Value));
                savEdit.writeData((int)accessories9Hex[0] + locationValue, (int)accessories9Hex[1], Convert.ToDecimal(accessoriesInput[1, 8].Value));
                savEdit.writeData((int)accessories10Hex[0] + locationValue, (int)accessories10Hex[1], Convert.ToDecimal(accessoriesInput[1, 9].Value));
                savEdit.writeData((int)accessories11Hex[0] + locationValue, (int)accessories11Hex[1], Convert.ToDecimal(accessoriesInput[1, 10].Value));
                savEdit.writeData((int)accessories12Hex[0] + locationValue, (int)accessories12Hex[1], Convert.ToDecimal(accessoriesInput[1, 11].Value));
                savEdit.writeData((int)accessories13Hex[0] + locationValue, (int)accessories13Hex[1], Convert.ToDecimal(accessoriesInput[1, 12].Value));
                savEdit.writeData((int)accessories14Hex[0] + locationValue, (int)accessories14Hex[1], Convert.ToDecimal(accessoriesInput[1, 13].Value));
                savEdit.writeData((int)accessories15Hex[0] + locationValue, (int)accessories15Hex[1], Convert.ToDecimal(accessoriesInput[1, 14].Value));
                savEdit.writeData((int)accessories16Hex[0] + locationValue, (int)accessories16Hex[1], Convert.ToDecimal(accessoriesInput[1, 15].Value));
                savEdit.writeData((int)accessories17Hex[0] + locationValue, (int)accessories17Hex[1], Convert.ToDecimal(accessoriesInput[1, 16].Value));
                savEdit.writeData((int)accessories18Hex[0] + locationValue, (int)accessories18Hex[1], Convert.ToDecimal(accessoriesInput[1, 17].Value));
                savEdit.writeData((int)accessories19Hex[0] + locationValue, (int)accessories19Hex[1], Convert.ToDecimal(accessoriesInput[1, 18].Value));
                savEdit.writeData((int)accessories20Hex[0] + locationValue, (int)accessories20Hex[1], Convert.ToDecimal(accessoriesInput[1, 19].Value));
                savEdit.writeData((int)accessories21Hex[0] + locationValue, (int)accessories21Hex[1], Convert.ToDecimal(accessoriesInput[1, 20].Value));
                savEdit.writeData((int)accessories22Hex[0] + locationValue, (int)accessories22Hex[1], Convert.ToDecimal(accessoriesInput[1, 21].Value));
                savEdit.writeData((int)accessories23Hex[0] + locationValue, (int)accessories23Hex[1], Convert.ToDecimal(accessoriesInput[1, 22].Value));
                savEdit.writeData((int)accessories24Hex[0] + locationValue, (int)accessories24Hex[1], Convert.ToDecimal(accessoriesInput[1, 23].Value));
                savEdit.writeData((int)accessories25Hex[0] + locationValue, (int)accessories25Hex[1], Convert.ToDecimal(accessoriesInput[1, 24].Value));
                savEdit.writeData((int)accessories26Hex[0] + locationValue, (int)accessories26Hex[1], Convert.ToDecimal(accessoriesInput[1, 25].Value));
                savEdit.writeData((int)accessories27Hex[0] + locationValue, (int)accessories27Hex[1], Convert.ToDecimal(accessoriesInput[1, 26].Value));
                savEdit.writeData((int)accessories28Hex[0] + locationValue, (int)accessories28Hex[1], Convert.ToDecimal(accessoriesInput[1, 27].Value));
                savEdit.writeData((int)accessories29Hex[0] + locationValue, (int)accessories29Hex[1], Convert.ToDecimal(accessoriesInput[1, 28].Value));
                savEdit.writeData((int)accessories30Hex[0] + locationValue, (int)accessories30Hex[1], Convert.ToDecimal(accessoriesInput[1, 29].Value));
                savEdit.writeData((int)accessories31Hex[0] + locationValue, (int)accessories31Hex[1], Convert.ToDecimal(accessoriesInput[1, 30].Value));
                savEdit.writeData((int)accessories32Hex[0] + locationValue, (int)accessories32Hex[1], Convert.ToDecimal(accessoriesInput[1, 31].Value));
                savEdit.writeData((int)accessories33Hex[0] + locationValue, (int)accessories33Hex[1], Convert.ToDecimal(accessoriesInput[1, 32].Value));
                savEdit.writeData((int)accessories34Hex[0] + locationValue, (int)accessories34Hex[1], Convert.ToDecimal(accessoriesInput[1, 33].Value));
                savEdit.writeData((int)accessories35Hex[0] + locationValue, (int)accessories35Hex[1], Convert.ToDecimal(accessoriesInput[1, 34].Value));
                savEdit.writeData((int)accessories36Hex[0] + locationValue, (int)accessories36Hex[1], Convert.ToDecimal(accessoriesInput[1, 35].Value));
                savEdit.writeData((int)accessories37Hex[0] + locationValue, (int)accessories37Hex[1], Convert.ToDecimal(accessoriesInput[1, 36].Value));
                savEdit.writeData((int)accessories38Hex[0] + locationValue, (int)accessories38Hex[1], Convert.ToDecimal(accessoriesInput[1, 37].Value));
                savEdit.writeData((int)accessories39Hex[0] + locationValue, (int)accessories39Hex[1], Convert.ToDecimal(accessoriesInput[1, 38].Value));
                savEdit.writeData((int)accessories40Hex[0] + locationValue, (int)accessories40Hex[1], Convert.ToDecimal(accessoriesInput[1, 39].Value));
                savEdit.writeData((int)accessories41Hex[0] + locationValue, (int)accessories41Hex[1], Convert.ToDecimal(accessoriesInput[1, 40].Value));
                savEdit.writeData((int)accessories42Hex[0] + locationValue, (int)accessories42Hex[1], Convert.ToDecimal(accessoriesInput[1, 41].Value));
                savEdit.writeData((int)accessories43Hex[0] + locationValue, (int)accessories43Hex[1], Convert.ToDecimal(accessoriesInput[1, 42].Value));
                savEdit.writeData((int)accessories44Hex[0] + locationValue, (int)accessories44Hex[1], Convert.ToDecimal(accessoriesInput[1, 43].Value));
                savEdit.writeData((int)accessories45Hex[0] + locationValue, (int)accessories45Hex[1], Convert.ToDecimal(accessoriesInput[1, 44].Value));
                savEdit.writeData((int)accessories46Hex[0] + locationValue, (int)accessories46Hex[1], Convert.ToDecimal(accessoriesInput[1, 45].Value));
                savEdit.writeData((int)accessories47Hex[0] + locationValue, (int)accessories47Hex[1], Convert.ToDecimal(accessoriesInput[1, 46].Value));
                savEdit.writeData((int)accessories48Hex[0] + locationValue, (int)accessories48Hex[1], Convert.ToDecimal(accessoriesInput[1, 47].Value));
                savEdit.writeData((int)accessories49Hex[0] + locationValue, (int)accessories49Hex[1], Convert.ToDecimal(accessoriesInput[1, 48].Value));
                savEdit.writeData((int)accessories50Hex[0] + locationValue, (int)accessories50Hex[1], Convert.ToDecimal(accessoriesInput[1, 49].Value));
                savEdit.writeData((int)accessories51Hex[0] + locationValue, (int)accessories51Hex[1], Convert.ToDecimal(accessoriesInput[1, 50].Value));
                savEdit.writeData((int)accessories52Hex[0] + locationValue, (int)accessories52Hex[1], Convert.ToDecimal(accessoriesInput[1, 51].Value));
                savEdit.writeData((int)accessories53Hex[0] + locationValue, (int)accessories53Hex[1], Convert.ToDecimal(accessoriesInput[1, 52].Value));
                savEdit.writeData((int)accessories54Hex[0] + locationValue, (int)accessories54Hex[1], Convert.ToDecimal(accessoriesInput[1, 53].Value));
                savEdit.writeData((int)accessories55Hex[0] + locationValue, (int)accessories55Hex[1], Convert.ToDecimal(accessoriesInput[1, 54].Value));
                savEdit.writeData((int)accessories56Hex[0] + locationValue, (int)accessories56Hex[1], Convert.ToDecimal(accessoriesInput[1, 55].Value));
                savEdit.writeData((int)accessories57Hex[0] + locationValue, (int)accessories57Hex[1], Convert.ToDecimal(accessoriesInput[1, 56].Value));
                savEdit.writeData((int)accessories58Hex[0] + locationValue, (int)accessories58Hex[1], Convert.ToDecimal(accessoriesInput[1, 57].Value));
                savEdit.writeData((int)accessories59Hex[0] + locationValue, (int)accessories59Hex[1], Convert.ToDecimal(accessoriesInput[1, 58].Value));
                savEdit.writeData((int)accessories60Hex[0] + locationValue, (int)accessories60Hex[1], Convert.ToDecimal(accessoriesInput[1, 59].Value));
                savEdit.writeData((int)accessories61Hex[0] + locationValue, (int)accessories61Hex[1], Convert.ToDecimal(accessoriesInput[1, 60].Value));
                savEdit.writeData((int)accessories62Hex[0] + locationValue, (int)accessories62Hex[1], Convert.ToDecimal(accessoriesInput[1, 61].Value));
                savEdit.writeData((int)accessories63Hex[0] + locationValue, (int)accessories63Hex[1], Convert.ToDecimal(accessoriesInput[1, 62].Value));
                savEdit.writeData((int)accessories64Hex[0] + locationValue, (int)accessories64Hex[1], Convert.ToDecimal(accessoriesInput[1, 63].Value));
                savEdit.writeData((int)accessories65Hex[0] + locationValue, (int)accessories65Hex[1], Convert.ToDecimal(accessoriesInput[1, 64].Value));
                savEdit.writeData((int)accessories66Hex[0] + locationValue, (int)accessories66Hex[1], Convert.ToDecimal(accessoriesInput[1, 65].Value));
                savEdit.writeData((int)accessories67Hex[0] + locationValue, (int)accessories67Hex[1], Convert.ToDecimal(accessoriesInput[1, 66].Value));
                savEdit.writeData((int)accessories68Hex[0] + locationValue, (int)accessories68Hex[1], Convert.ToDecimal(accessoriesInput[1, 67].Value));
                savEdit.writeData((int)accessories69Hex[0] + locationValue, (int)accessories69Hex[1], Convert.ToDecimal(accessoriesInput[1, 68].Value));
                savEdit.writeData((int)accessories70Hex[0] + locationValue, (int)accessories70Hex[1], Convert.ToDecimal(accessoriesInput[1, 69].Value));
                savEdit.writeData((int)accessories71Hex[0] + locationValue, (int)accessories71Hex[1], Convert.ToDecimal(accessoriesInput[1, 70].Value));
                savEdit.writeData((int)accessories72Hex[0] + locationValue, (int)accessories72Hex[1], Convert.ToDecimal(accessoriesInput[1, 71].Value));
                savEdit.writeData((int)accessories73Hex[0] + locationValue, (int)accessories73Hex[1], Convert.ToDecimal(accessoriesInput[1, 72].Value));
                savEdit.writeData((int)accessories74Hex[0] + locationValue, (int)accessories74Hex[1], Convert.ToDecimal(accessoriesInput[1, 73].Value));
                savEdit.writeData((int)accessories75Hex[0] + locationValue, (int)accessories75Hex[1], Convert.ToDecimal(accessoriesInput[1, 74].Value));
                savEdit.writeData((int)accessories76Hex[0] + locationValue, (int)accessories76Hex[1], Convert.ToDecimal(accessoriesInput[1, 75].Value));
                savEdit.writeData((int)accessories77Hex[0] + locationValue, (int)accessories77Hex[1], Convert.ToDecimal(accessoriesInput[1, 76].Value));
                savEdit.writeData((int)accessories78Hex[0] + locationValue, (int)accessories78Hex[1], Convert.ToDecimal(accessoriesInput[1, 77].Value));
                savEdit.writeData((int)accessories79Hex[0] + locationValue, (int)accessories79Hex[1], Convert.ToDecimal(accessoriesInput[1, 78].Value));
                savEdit.writeData((int)accessories80Hex[0] + locationValue, (int)accessories80Hex[1], Convert.ToDecimal(accessoriesInput[1, 79].Value));
                savEdit.writeData((int)accessories81Hex[0] + locationValue, (int)accessories81Hex[1], Convert.ToDecimal(accessoriesInput[1, 80].Value));
                savEdit.writeData((int)accessories82Hex[0] + locationValue, (int)accessories82Hex[1], Convert.ToDecimal(accessoriesInput[1, 81].Value));
                savEdit.writeData((int)accessories83Hex[0] + locationValue, (int)accessories83Hex[1], Convert.ToDecimal(accessoriesInput[1, 82].Value));
                savEdit.writeData((int)accessories84Hex[0] + locationValue, (int)accessories84Hex[1], Convert.ToDecimal(accessoriesInput[1, 83].Value));
                savEdit.writeData((int)accessories85Hex[0] + locationValue, (int)accessories85Hex[1], Convert.ToDecimal(accessoriesInput[1, 84].Value));
                savEdit.writeData((int)accessories86Hex[0] + locationValue, (int)accessories86Hex[1], Convert.ToDecimal(accessoriesInput[1, 85].Value));

                savEdit.writeData((int)items1Hex[0] + locationValue, (int)items1Hex[1], Convert.ToDecimal(itemsInput[1, 0].Value));
                savEdit.writeData((int)items2Hex[0] + locationValue, (int)items2Hex[1], Convert.ToDecimal(itemsInput[1, 1].Value));
                savEdit.writeData((int)items3Hex[0] + locationValue, (int)items3Hex[1], Convert.ToDecimal(itemsInput[1, 2].Value));
                savEdit.writeData((int)items4Hex[0] + locationValue, (int)items4Hex[1], Convert.ToDecimal(itemsInput[1, 3].Value));
                savEdit.writeData((int)items5Hex[0] + locationValue, (int)items5Hex[1], Convert.ToDecimal(itemsInput[1, 4].Value));
                savEdit.writeData((int)items6Hex[0] + locationValue, (int)items6Hex[1], Convert.ToDecimal(itemsInput[1, 5].Value));
                savEdit.writeData((int)items7Hex[0] + locationValue, (int)items7Hex[1], Convert.ToDecimal(itemsInput[1, 6].Value));
                savEdit.writeData((int)items8Hex[0] + locationValue, (int)items8Hex[1], Convert.ToDecimal(itemsInput[1, 7].Value));
                savEdit.writeData((int)items9Hex[0] + locationValue, (int)items9Hex[1], Convert.ToDecimal(itemsInput[1, 8].Value));
                savEdit.writeData((int)items10Hex[0] + locationValue, (int)items10Hex[1], Convert.ToDecimal(itemsInput[1, 9].Value));
                savEdit.writeData((int)items11Hex[0] + locationValue, (int)items11Hex[1], Convert.ToDecimal(itemsInput[1, 10].Value));
                savEdit.writeData((int)items12Hex[0] + locationValue, (int)items12Hex[1], Convert.ToDecimal(itemsInput[1, 11].Value));
                savEdit.writeData((int)items13Hex[0] + locationValue, (int)items13Hex[1], Convert.ToDecimal(itemsInput[1, 12].Value));
                savEdit.writeData((int)items14Hex[0] + locationValue, (int)items14Hex[1], Convert.ToDecimal(itemsInput[1, 13].Value));
                savEdit.writeData((int)items15Hex[0] + locationValue, (int)items15Hex[1], Convert.ToDecimal(itemsInput[1, 14].Value));
                savEdit.writeData((int)items16Hex[0] + locationValue, (int)items16Hex[1], Convert.ToDecimal(itemsInput[1, 15].Value));
                savEdit.writeData((int)items17Hex[0] + locationValue, (int)items17Hex[1], Convert.ToDecimal(itemsInput[1, 16].Value));
                savEdit.writeData((int)items18Hex[0] + locationValue, (int)items18Hex[1], Convert.ToDecimal(itemsInput[1, 17].Value));
                savEdit.writeData((int)items19Hex[0] + locationValue, (int)items19Hex[1], Convert.ToDecimal(itemsInput[1, 18].Value));
                savEdit.writeData((int)items20Hex[0] + locationValue, (int)items20Hex[1], Convert.ToDecimal(itemsInput[1, 19].Value));
                savEdit.writeData((int)items21Hex[0] + locationValue, (int)items21Hex[1], Convert.ToDecimal(itemsInput[1, 20].Value));
                savEdit.writeData((int)items22Hex[0] + locationValue, (int)items22Hex[1], Convert.ToDecimal(itemsInput[1, 21].Value));
                savEdit.writeData((int)items23Hex[0] + locationValue, (int)items23Hex[1], Convert.ToDecimal(itemsInput[1, 22].Value));
                savEdit.writeData((int)items24Hex[0] + locationValue, (int)items24Hex[1], Convert.ToDecimal(itemsInput[1, 23].Value));
                savEdit.writeData((int)items25Hex[0] + locationValue, (int)items25Hex[1], Convert.ToDecimal(itemsInput[1, 24].Value));
                savEdit.writeData((int)items26Hex[0] + locationValue, (int)items26Hex[1], Convert.ToDecimal(itemsInput[1, 25].Value));
                savEdit.writeData((int)items27Hex[0] + locationValue, (int)items27Hex[1], Convert.ToDecimal(itemsInput[1, 26].Value));
                savEdit.writeData((int)items28Hex[0] + locationValue, (int)items28Hex[1], Convert.ToDecimal(itemsInput[1, 27].Value));

                savEdit.writeData((int)abilitiesSpellbooksHex[0] + locationValue, (int)abilitiesSpellbooksHex[1], writeSpellbooks(abilitiesSpellbooksInput));

                savEdit.writeData((int)abilitiesRelicsHex[0] + locationValue, (int)abilitiesRelicsHex[1], writeRelics(abilitiesRelicsInput));

                savEdit.writeData((int)encyclopedia1Hex[0] + locationValue, (int)encyclopedia1Hex[1], writeEncyclopedia(collectibleInput, 0));
                savEdit.writeData((int)encyclopedia2Hex[0] + locationValue, (int)encyclopedia2Hex[1], writeEncyclopedia(collectibleInput, 1));
                savEdit.writeData((int)encyclopedia3Hex[0] + locationValue, (int)encyclopedia3Hex[1], writeEncyclopedia(collectibleInput, 2));
                savEdit.writeData((int)encyclopedia4Hex[0] + locationValue, (int)encyclopedia4Hex[1], writeEncyclopedia(collectibleInput, 3));
                savEdit.writeData((int)encyclopedia5Hex[0] + locationValue, (int)encyclopedia5Hex[1], writeEncyclopedia(collectibleInput, 4));
                savEdit.writeData((int)encyclopedia6Hex[0] + locationValue, (int)encyclopedia6Hex[1], writeEncyclopedia(collectibleInput, 5));
                savEdit.writeData((int)encyclopedia7Hex[0] + locationValue, (int)encyclopedia7Hex[1], writeEncyclopedia(collectibleInput, 6));
                savEdit.writeData((int)encyclopedia8Hex[0] + locationValue, (int)encyclopedia8Hex[1], writeEncyclopedia(collectibleInput, 7));
                savEdit.writeData((int)encyclopedia9Hex[0] + locationValue, (int)encyclopedia9Hex[1], writeEncyclopedia(collectibleInput, 8));
                savEdit.writeData((int)encyclopedia10Hex[0] + locationValue, (int)encyclopedia10Hex[1], writeEncyclopedia(collectibleInput, 9));
                savEdit.writeData((int)encyclopedia11Hex[0] + locationValue, (int)encyclopedia11Hex[1], writeEncyclopedia(collectibleInput, 10));
                savEdit.writeData((int)encyclopedia12Hex[0] + locationValue, (int)encyclopedia12Hex[1], writeEncyclopedia(collectibleInput, 11));
                savEdit.writeData((int)encyclopedia13Hex[0] + locationValue, (int)encyclopedia13Hex[1], writeEncyclopedia(collectibleInput, 12));

                savEdit.writeData((int)collectibles1Hex[0] + locationValue, (int)collectibles1Hex[1], writeCollectibles(collectiblesInput, 0));
                savEdit.writeData((int)collectibles2Hex[0] + locationValue, (int)collectibles2Hex[1], writeCollectibles(collectiblesInput, 1));
                savEdit.writeData((int)collectibles3Hex[0] + locationValue, (int)collectibles3Hex[1], writeCollectibles(collectiblesInput, 2));
                savEdit.writeData((int)collectibles4Hex[0] + locationValue, (int)collectibles4Hex[1], writeCollectibles(collectiblesInput, 3));

                writeMessage("Saved.");
            }
            catch (Exception err)
            {
                writeMessage("Error...");
                MessageBox.Show(err.Message);
            }
        }

        private void enableForm(bool val)
        {
            saveButton.Visible = val;
            groupBox.Enabled = val;
            tabControl.Enabled = val;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            loadArmors();
            loadAccessories();
            loadItems();
            loadEncyclopedia();
            loadCollectibles();
        }

        private void slot1Button_CheckedChanged(object sender, EventArgs e)
        {
            if(slot1Button.Checked)
            {
                saveID = 1;
                readStats();
            }
        }

        private void slot2Button_CheckedChanged(object sender, EventArgs e)
        {
            if (slot2Button.Checked)
            {
                saveID = 2;
                readStats();
            }
        }

        private void slot3Button_CheckedChanged(object sender, EventArgs e)
        {
            if (slot3Button.Checked)
            {
                saveID = 3;
                readStats();
            }
        }

        private void statsCharacterInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(statsCharacterInput.SelectedIndex == 0)
            {
                characterImage.Image = Properties.Resources.character_juste;
            }
            else
            {
                characterImage.Image = Properties.Resources.character_maxime;
            }
        }
    }
}