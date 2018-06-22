using System;
using System.IO;
using System.Windows.Forms;
using VesperiaSE;

namespace VesperiaSaveEditor
{
    public partial class Form1 : Form
    {
        private byte[] data = new byte[Constants.SAVEDATA_SIZE];
        private string path = "/";

        public Form1()
        {
            InitializeComponent();
        }

        #region Utils
        private UInt32 ReadInt(UInt32 addr)
        {
            return (UInt32)(data[addr] << 24 | data[addr + 1] << 16 | data[addr+2] << 8 | data[addr + 3]);
        }

        private UInt32 ReadInt(UInt32 addr, UInt32 max)
        {
            UInt32 val = (UInt32)(data[addr] << 24 | data[addr + 1] << 16 | data[addr + 2] << 8 | data[addr + 3]);
            return val > max ? max : val;
        }

        private void WriteInt(UInt32 addr, UInt32 value)
        {
            data[addr] = (byte)(value >> 24);
            data[addr + 1] = (byte)((value & 0x00FF0000) >> 16);
            data[addr + 2] = (byte)((value & 0x0000FF00) >> 8);
            data[addr + 3] = (byte)(value & 0x000000FF);
        }

        public static string GetPath(string fullPath)
        {
            int i = fullPath.Length;
            while (--i > 0)
                if (fullPath[i] == '/' || fullPath[i] == '\\')
                    return fullPath.Substring(0, i + 1);
            return "/";
        }
        #endregion

        #region Update UI
        private void UpdateMiscUi()
        {
            galdValueBox.Value = ReadInt(Offsets.Misc.Gald.startAddr, (UInt32)galdValueBox.Maximum);
        }

        private void UpdateYuri()
        {
            yuriLvl.Value = ReadInt(Offsets.Characters.Yuri.lvlAddr, (UInt32)yuriLvl.Maximum);
            yuriHp.Value = ReadInt(Offsets.Characters.Yuri.maxHPAddr, (UInt32)yuriHp.Maximum);
            yuriMP.Value = ReadInt(Offsets.Characters.Yuri.maxTPAddr, (UInt32)yuriMP.Maximum);
            yuriExp.Value = ReadInt(Offsets.Characters.Yuri.expAddr, (UInt32)yuriExp.Maximum);
            yuriPATK.Value = ReadInt(Offsets.Characters.Yuri.pAtkAddr, (UInt32)yuriPATK.Maximum);
            yuriMATK.Value = ReadInt(Offsets.Characters.Yuri.mAtkAddr, (UInt32)yuriMATK.Maximum);
            yuriPDEF.Value = ReadInt(Offsets.Characters.Yuri.pDefAddr, (UInt32)yuriPDEF.Maximum);
            yuriMDEF.Value = ReadInt(Offsets.Characters.Yuri.mDefAddr, (UInt32)yuriMDEF.Maximum);
            yuriAgi.Value = ReadInt(Offsets.Characters.Yuri.agiAddr, (UInt32)yuriAgi.Maximum);
            yuriLuck.Value = ReadInt(Offsets.Characters.Yuri.luckAddr, (UInt32)yuriLuck.Maximum);
        }

        private void UpdateRepede()
        {
            repedeLvl.Value = ReadInt(Offsets.Characters.Repede.lvlAddr, (UInt32)repedeLvl.Maximum);
            repedeMaxHp.Value = ReadInt(Offsets.Characters.Repede.maxHPAddr, (UInt32)repedeMaxHp.Maximum);
            repedeMaxTp.Value = ReadInt(Offsets.Characters.Repede.maxTPAddr, (UInt32)repedeMaxTp.Maximum);
            repedeExp.Value = ReadInt(Offsets.Characters.Repede.expAddr, (UInt32)repedeExp.Maximum);
            repedePAtk.Value = ReadInt(Offsets.Characters.Repede.pAtkAddr, (UInt32)repedePAtk.Maximum);
            repedeMAtk.Value = ReadInt(Offsets.Characters.Repede.mAtkAddr, (UInt32)repedeMAtk.Maximum);
            repedePDef.Value = ReadInt(Offsets.Characters.Repede.pDefAddr, (UInt32)repedePDef.Maximum);
            repedeMDef.Value = ReadInt(Offsets.Characters.Repede.mDefAddr, (UInt32)repedeMDef.Maximum);
            repedeAgi.Value = ReadInt(Offsets.Characters.Repede.agiAddr, (UInt32)repedeAgi.Maximum);
            repedeLuck.Value = ReadInt(Offsets.Characters.Repede.luckAddr, (UInt32)repedeLuck.Maximum);
        }

        private void UpdateEstelle()
        {
            estelleLvl.Value = ReadInt(Offsets.Characters.Estelle.lvlAddr, (UInt32)estelleLvl.Maximum);
            estelleMaxHp.Value = ReadInt(Offsets.Characters.Estelle.maxHPAddr, (UInt32)estelleMaxHp.Maximum);
            estelleMaxTp.Value = ReadInt(Offsets.Characters.Estelle.maxTPAddr, (UInt32)estelleMaxTp.Maximum);
            estelleExp.Value = ReadInt(Offsets.Characters.Estelle.expAddr, (UInt32)estelleExp.Maximum);
            estellePAtk.Value = ReadInt(Offsets.Characters.Estelle.pAtkAddr, (UInt32)estellePAtk.Maximum);
            estelleMAtk.Value = ReadInt(Offsets.Characters.Estelle.mAtkAddr, (UInt32)estelleMAtk.Maximum);
            estellePDef.Value = ReadInt(Offsets.Characters.Estelle.pDefAddr, (UInt32)estellePDef.Maximum);
            estelleMDef.Value = ReadInt(Offsets.Characters.Estelle.mDefAddr, (UInt32)estelleMDef.Maximum);
            estelleAgi.Value = ReadInt(Offsets.Characters.Estelle.agiAddr, (UInt32)estelleAgi.Maximum);
            estelleLuck.Value = ReadInt(Offsets.Characters.Estelle.luckAddr, (UInt32)estelleLuck.Maximum);
        }

        private void UpdateKarol()
        {
            karolLvl.Value = ReadInt(Offsets.Characters.Karol.lvlAddr, (UInt32)karolLvl.Maximum);
            karolMaxHp.Value = ReadInt(Offsets.Characters.Karol.maxHPAddr, (UInt32)karolMaxHp.Maximum);
            karolMaxTp.Value = ReadInt(Offsets.Characters.Karol.maxTPAddr, (UInt32)karolMaxTp.Maximum);
            karolExp.Value = ReadInt(Offsets.Characters.Karol.expAddr, (UInt32)karolExp.Maximum);
            karolPAtk.Value = ReadInt(Offsets.Characters.Karol.pAtkAddr, (UInt32)karolPAtk.Maximum);
            karolMAtk.Value = ReadInt(Offsets.Characters.Karol.mAtkAddr, (UInt32)karolMAtk.Maximum);
            karolPDef.Value = ReadInt(Offsets.Characters.Karol.pDefAddr, (UInt32)karolPDef.Maximum);
            karolMDef.Value = ReadInt(Offsets.Characters.Karol.mDefAddr, (UInt32)karolMDef.Maximum);
            karolAgi.Value = ReadInt(Offsets.Characters.Karol.agiAddr, (UInt32)karolAgi.Maximum);
            karolLuck.Value = ReadInt(Offsets.Characters.Karol.luckAddr, (UInt32)estelleLuck.Maximum);
        }

        private void UpdateRita()
        {
            ritaLvl.Value = ReadInt(Offsets.Characters.Rita.lvlAddr, (UInt32)ritaLvl.Maximum);
            ritaMaxHp.Value = ReadInt(Offsets.Characters.Rita.maxHPAddr, (UInt32)ritaMaxHp.Maximum);
            ritaMaxTp.Value = ReadInt(Offsets.Characters.Rita.maxTPAddr, (UInt32)ritaMaxTp.Maximum);
            ritaExp.Value = ReadInt(Offsets.Characters.Rita.expAddr, (UInt32)ritaExp.Maximum);
            ritaPAtk.Value = ReadInt(Offsets.Characters.Rita.pAtkAddr, (UInt32)ritaPAtk.Maximum);
            ritaMAtk.Value = ReadInt(Offsets.Characters.Rita.mAtkAddr, (UInt32)ritaMAtk.Maximum);
            ritaPDef.Value = ReadInt(Offsets.Characters.Rita.pDefAddr, (UInt32)ritaPDef.Maximum);
            ritaMDef.Value = ReadInt(Offsets.Characters.Rita.mDefAddr, (UInt32)ritaMDef.Maximum);
            ritaAgi.Value = ReadInt(Offsets.Characters.Rita.agiAddr, (UInt32)ritaAgi.Maximum);
            ritaLuck.Value = ReadInt(Offsets.Characters.Rita.luckAddr, (UInt32)ritaLuck.Maximum);
        }

        private void UpdateRaven()
        {
            ravenLvl.Value = ReadInt(Offsets.Characters.Raven.lvlAddr, (UInt32)ravenLvl.Maximum);
            ravenMaxHp.Value = ReadInt(Offsets.Characters.Raven.maxHPAddr, (UInt32)ravenMaxHp.Maximum);
            ravenMaxTp.Value = ReadInt(Offsets.Characters.Raven.maxTPAddr, (UInt32)ravenMaxTp.Maximum);
            ravenExp.Value = ReadInt(Offsets.Characters.Raven.expAddr, (UInt32)ravenExp.Maximum);
            ravenPAtk.Value = ReadInt(Offsets.Characters.Raven.pAtkAddr, (UInt32)ravenPAtk.Maximum);
            ravenMAtk.Value = ReadInt(Offsets.Characters.Raven.mAtkAddr, (UInt32)ravenMAtk.Maximum);
            ravenPDef.Value = ReadInt(Offsets.Characters.Raven.pDefAddr, (UInt32)ravenPDef.Maximum);
            ravenMDef.Value = ReadInt(Offsets.Characters.Raven.mDefAddr, (UInt32)ravenMDef.Maximum);
            ravenAgi.Value = ReadInt(Offsets.Characters.Raven.agiAddr, (UInt32)ravenAgi.Maximum);
            ravenLuck.Value = ReadInt(Offsets.Characters.Raven.luckAddr, (UInt32)ravenLuck.Maximum);
        }

        private void UpdateCharacters()
        {
            UpdateYuri();
            UpdateRepede();
            UpdateEstelle();
            UpdateKarol();
            UpdateRita();
            UpdateRaven();
        }

        private void UpdateUi()
        {
            UpdateMiscUi();
            UpdateCharacters();
        }
        #endregion

        #region UpdateData
        private void UpdateData()
        {
            /* Yuri's data */
            WriteInt(Offsets.Characters.Yuri.lvlAddr, (UInt32)yuriLvl.Value);
            WriteInt(Offsets.Characters.Yuri.maxHPAddr, (UInt32)yuriHp.Value);
            WriteInt(Offsets.Characters.Yuri.maxTPAddr, (UInt32)yuriMP.Value);
            WriteInt(Offsets.Characters.Yuri.expAddr, (UInt32)yuriExp.Value);
            WriteInt(Offsets.Characters.Yuri.pAtkAddr, (UInt32)yuriPATK.Value);
            WriteInt(Offsets.Characters.Yuri.mAtkAddr, (UInt32)yuriMATK.Value);
            WriteInt(Offsets.Characters.Yuri.pDefAddr, (UInt32)yuriPDEF.Value);
            WriteInt(Offsets.Characters.Yuri.mDefAddr, (UInt32)yuriMDEF.Value);
            WriteInt(Offsets.Characters.Yuri.agiAddr, (UInt32)yuriAgi.Value);
            WriteInt(Offsets.Characters.Yuri.luckAddr, (UInt32)yuriLuck.Value);

            /* Repede's data */
            WriteInt(Offsets.Characters.Repede.lvlAddr, (UInt32)repedeLvl.Value);
            WriteInt(Offsets.Characters.Repede.maxHPAddr, (UInt32)repedeMaxHp.Value);
            WriteInt(Offsets.Characters.Repede.maxTPAddr, (UInt32)repedeMaxTp.Value);
            WriteInt(Offsets.Characters.Repede.expAddr, (UInt32)repedeExp.Value);
            WriteInt(Offsets.Characters.Repede.pAtkAddr, (UInt32)repedePAtk.Value);
            WriteInt(Offsets.Characters.Repede.mAtkAddr, (UInt32)repedeMAtk.Value);
            WriteInt(Offsets.Characters.Repede.pDefAddr, (UInt32)repedePDef.Value);
            WriteInt(Offsets.Characters.Repede.mDefAddr, (UInt32)repedeMDef.Value);
            WriteInt(Offsets.Characters.Repede.agiAddr, (UInt32)repedeAgi.Value);
            WriteInt(Offsets.Characters.Repede.luckAddr, (UInt32)repedeLuck.Value);

            /* Estelle's data */
            WriteInt(Offsets.Characters.Estelle.lvlAddr, (UInt32)estelleLvl.Value);
            WriteInt(Offsets.Characters.Estelle.maxHPAddr, (UInt32)estelleMaxHp.Value);
            WriteInt(Offsets.Characters.Estelle.maxTPAddr, (UInt32)estelleMaxTp.Value);
            WriteInt(Offsets.Characters.Estelle.expAddr, (UInt32)estelleExp.Value);
            WriteInt(Offsets.Characters.Estelle.pAtkAddr, (UInt32)estellePAtk.Value);
            WriteInt(Offsets.Characters.Estelle.mAtkAddr, (UInt32)estelleMAtk.Value);
            WriteInt(Offsets.Characters.Estelle.pDefAddr, (UInt32)estellePDef.Value);
            WriteInt(Offsets.Characters.Estelle.mDefAddr, (UInt32)estelleMDef.Value);
            WriteInt(Offsets.Characters.Estelle.agiAddr, (UInt32)estelleAgi.Value);
            WriteInt(Offsets.Characters.Estelle.luckAddr, (UInt32)estelleLuck.Value);

            /* Karol's data */
            WriteInt(Offsets.Characters.Karol.lvlAddr, (UInt32)karolLvl.Value);
            WriteInt(Offsets.Characters.Karol.maxHPAddr, (UInt32)karolMaxHp.Value);
            WriteInt(Offsets.Characters.Karol.maxTPAddr, (UInt32)karolMaxTp.Value);
            WriteInt(Offsets.Characters.Karol.expAddr, (UInt32)karolExp.Value);
            WriteInt(Offsets.Characters.Karol.pAtkAddr, (UInt32)karolPAtk.Value);
            WriteInt(Offsets.Characters.Karol.mAtkAddr, (UInt32)karolMAtk.Value);
            WriteInt(Offsets.Characters.Karol.pDefAddr, (UInt32)karolPDef.Value);
            WriteInt(Offsets.Characters.Karol.mDefAddr, (UInt32)karolMDef.Value);
            WriteInt(Offsets.Characters.Karol.agiAddr, (UInt32)karolAgi.Value);
            WriteInt(Offsets.Characters.Karol.luckAddr, (UInt32)karolLuck.Value);

            /* Rita's data */
            WriteInt(Offsets.Characters.Rita.lvlAddr, (UInt32)ritaLvl.Value);
            WriteInt(Offsets.Characters.Rita.maxHPAddr, (UInt32)ritaMaxHp.Value);
            WriteInt(Offsets.Characters.Rita.maxTPAddr, (UInt32)ritaMaxTp.Value);
            WriteInt(Offsets.Characters.Rita.expAddr, (UInt32)ritaExp.Value);
            WriteInt(Offsets.Characters.Rita.pAtkAddr, (UInt32)ritaPAtk.Value);
            WriteInt(Offsets.Characters.Rita.mAtkAddr, (UInt32)ritaMAtk.Value);
            WriteInt(Offsets.Characters.Rita.pDefAddr, (UInt32)ritaPDef.Value);
            WriteInt(Offsets.Characters.Rita.mDefAddr, (UInt32)ritaMDef.Value);
            WriteInt(Offsets.Characters.Rita.agiAddr, (UInt32)ritaAgi.Value);
            WriteInt(Offsets.Characters.Rita.luckAddr, (UInt32)ritaLuck.Value);

            /* Raven's data */
            WriteInt(Offsets.Characters.Raven.lvlAddr, (UInt32)ravenLvl.Value);
            WriteInt(Offsets.Characters.Raven.maxHPAddr, (UInt32)ravenMaxHp.Value);
            WriteInt(Offsets.Characters.Raven.maxTPAddr, (UInt32)ravenMaxTp.Value);
            WriteInt(Offsets.Characters.Raven.expAddr, (UInt32)ravenExp.Value);
            WriteInt(Offsets.Characters.Raven.pAtkAddr, (UInt32)ravenPAtk.Value);
            WriteInt(Offsets.Characters.Raven.mAtkAddr, (UInt32)ravenMAtk.Value);
            WriteInt(Offsets.Characters.Raven.pDefAddr, (UInt32)ravenPDef.Value);
            WriteInt(Offsets.Characters.Raven.mDefAddr, (UInt32)ravenMDef.Value);
            WriteInt(Offsets.Characters.Raven.agiAddr, (UInt32)ravenAgi.Value);
            WriteInt(Offsets.Characters.Raven.luckAddr, (UInt32)ravenLuck.Value);
        }
        #endregion

        private bool ReadSave(string file)
        {
            data = System.IO.File.ReadAllBytes(file);
            if (data.Length == Constants.SAVEDATA_SIZE)
            {
                path = GetPath(file);
                UpdateUi();
            }
            else throw new Exception("Unknown file type");

            return true;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                ReadSave(openFileDialog1.FileName);
                WriteInt(Offsets.Characters.Yuri.lvlAddr, 0xABCDEF88);
            }         
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            galdValueBox.Value = 0;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            galdValueBox.Value = galdValueBox.Maximum;
        }

        private void BtnGradeMin_Click(object sender, EventArgs e)
        {
            gradeBox.Value = 0;
        }

        private void BtnGradeMax_Click(object sender, EventArgs e)
        {
            gradeBox.Value = gradeBox.Maximum;
        }

        private void BtnChipsMin_Click(object sender, EventArgs e)
        {
            chipsBox.Value = 0;
        }

        private void BtnChipsMax_Click(object sender, EventArgs e)
        {
            chipsBox.Value = chipsBox.Maximum;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveTextBox.Text == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveTextBox.Text = saveFileDialog1.FileName;
                }
            }

            if (saveTextBox.Text != "")
            {
                progressBar1.Value = 0;
                successLabel.Visible = false;
                UpdateData();
                File.WriteAllBytes(saveFileDialog1.FileName, data);
                progressBar1.Value = progressBar1.Maximum;
                successLabel.Visible = true;
            }
        }
    }
}
