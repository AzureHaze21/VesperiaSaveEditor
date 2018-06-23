using System;
using System.IO;
using System.Windows.Forms;
using VesperiaSE;

namespace VesperiaSaveEditor
{
    public partial class Form1 : Form
    {
        private byte[] data = new byte[Constants.SAVEDATA_SIZE];

        public Form1()
        {
            InitializeComponent();
            InitalizeDlcGridView();
        }

        #region init static grids
        private void InitalizeDlcGridView()
        {
            foreach (var dlc in Constants.DlcNames)
                dlcGridView.Rows.Add(new string[] { dlc, "0" });
        }

        #endregion

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

        public static string GetFileName(string fullPath)
        {
            int i = fullPath.Length;
            while (--i > 0)
                if (fullPath[i] == '/' || fullPath[i] == '\\')
                    return fullPath.Substring(i + 1);
            return "";
        }
        #endregion

        #region Update UI
        private void UpdateMiscUi()
        {
            galdValueBox.Value = ReadInt(Offsets.Misc.Gald.startAddr, (UInt32)galdValueBox.Maximum);
        }

        private void UpdateDlcView()
        {
            UInt32[] dlcValues = new UInt32[Constants.DlcNames.Length];
            for (UInt32 i = 0; i < Constants.DlcNames.Length; i++)
                dlcValues[i] = ReadInt(Offsets.Misc.Dlc.startAddr + (i * sizeof(UInt32)));
            for (int i = 0; i <  Constants.DlcNames.Length; i++)
                dlcGridView.Rows[i].Cells["DlcQty"].Value = dlcValues[i].ToString();

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
            yuriCurrSp.Value = ReadInt(Offsets.Characters.Yuri.spAddr, (UInt32)yuriCurrSp.Maximum);
            yuriMaxSp.Value = ReadInt(Offsets.Characters.Yuri.maxSpAddr, (UInt32)yuriMaxSp.Maximum);
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
            repedeCurrSp.Value = ReadInt(Offsets.Characters.Repede.spAddr, (UInt32)repedeCurrSp.Maximum);
            repedeMaxSp.Value = ReadInt(Offsets.Characters.Repede.maxSpAddr, (UInt32)repedeMaxSp.Maximum);
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
            estelleCurrSp.Value = ReadInt(Offsets.Characters.Estelle.spAddr, (UInt32)estelleCurrSp.Maximum);
            estelleMaxSp.Value = ReadInt(Offsets.Characters.Estelle.maxSpAddr, (UInt32)estelleMaxSp.Maximum);
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
            karolCurrSp.Value = ReadInt(Offsets.Characters.Karol.spAddr, (UInt32)karolCurrSp.Maximum);
            karolMaxSp.Value = ReadInt(Offsets.Characters.Karol.maxSpAddr, (UInt32)karolMaxSp.Maximum);
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
            ritaCurrSp.Value = ReadInt(Offsets.Characters.Rita.spAddr, (UInt32)ritaCurrSp.Maximum);
            ritaMaxSp.Value = ReadInt(Offsets.Characters.Rita.maxSpAddr, (UInt32)ritaMaxSp.Maximum);
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
            ravenCurrSp.Value = ReadInt(Offsets.Characters.Raven.spAddr, (UInt32)ravenCurrSp.Maximum);
            ravenMaxSp.Value = ReadInt(Offsets.Characters.Raven.maxSpAddr, (UInt32)ravenMaxSp.Maximum);
        }

        private void UpdateJudith()
        {
            judithLvl.Value = ReadInt(Offsets.Characters.Judith.lvlAddr, (UInt32)judithLvl.Maximum);
            judithMaxHp.Value = ReadInt(Offsets.Characters.Judith.maxHPAddr, (UInt32)judithMaxHp.Maximum);
            judithMaxTp.Value = ReadInt(Offsets.Characters.Judith.maxTPAddr, (UInt32)judithMaxTp.Maximum);
            judithExp.Value = ReadInt(Offsets.Characters.Judith.expAddr, (UInt32)judithExp.Maximum);
            judithPAtk.Value = ReadInt(Offsets.Characters.Judith.pAtkAddr, (UInt32)judithPAtk.Maximum);
            judithMAtk.Value = ReadInt(Offsets.Characters.Judith.mAtkAddr, (UInt32)judithMAtk.Maximum);
            judithPDef.Value = ReadInt(Offsets.Characters.Judith.pDefAddr, (UInt32)judithPDef.Maximum);
            judithMDef.Value = ReadInt(Offsets.Characters.Judith.mDefAddr, (UInt32)judithMDef.Maximum);
            judithAgi.Value = ReadInt(Offsets.Characters.Judith.agiAddr, (UInt32)judithAgi.Maximum);
            judithLuck.Value = ReadInt(Offsets.Characters.Judith.luckAddr, (UInt32)judithLuck.Maximum);
            judithCurrSp.Value = ReadInt(Offsets.Characters.Judith.spAddr, (UInt32)judithCurrSp.Maximum);
            judithMaxSp.Value = ReadInt(Offsets.Characters.Judith.maxSpAddr, (UInt32)judithMaxSp.Maximum);
        }

        private void UpdateFlynn()
        {
            flynnLvl.Value = ReadInt(Offsets.Characters.Flynn.lvlAddr, (UInt32)flynnLvl.Maximum);
            flynnMaxHp.Value = ReadInt(Offsets.Characters.Flynn.maxHPAddr, (UInt32)flynnMaxHp.Maximum);
            flynnMaxTp.Value = ReadInt(Offsets.Characters.Flynn.maxTPAddr, (UInt32)flynnMaxTp.Maximum);
            flynnExp.Value = ReadInt(Offsets.Characters.Flynn.expAddr, (UInt32)flynnExp.Maximum);
            flynnPAtk.Value = ReadInt(Offsets.Characters.Flynn.pAtkAddr, (UInt32)flynnPAtk.Maximum);
            flynnMAtk.Value = ReadInt(Offsets.Characters.Flynn.mAtkAddr, (UInt32)flynnMAtk.Maximum);
            flynnPDef.Value = ReadInt(Offsets.Characters.Flynn.pDefAddr, (UInt32)flynnPDef.Maximum);
            flynnMDef.Value = ReadInt(Offsets.Characters.Flynn.mDefAddr, (UInt32)flynnMDef.Maximum);
            flynnAgi.Value = ReadInt(Offsets.Characters.Flynn.agiAddr, (UInt32)flynnAgi.Maximum);
            flynnLuck.Value = ReadInt(Offsets.Characters.Flynn.luckAddr, (UInt32)flynnLuck.Maximum);
            flynnCurrSp.Value = ReadInt(Offsets.Characters.Flynn.spAddr, (UInt32)flynnCurrSp.Maximum);
            flynnMaxSp.Value = ReadInt(Offsets.Characters.Flynn.maxSpAddr, (UInt32)flynnMaxSp.Maximum);
        }

        private void UpdatePatty()
        {
            pattyLvl.Value = ReadInt(Offsets.Characters.Patty.lvlAddr, (UInt32)pattyLvl.Maximum);
            pattyMaxHp.Value = ReadInt(Offsets.Characters.Patty.maxHPAddr, (UInt32)pattyMaxHp.Maximum);
            pattyMaxTp.Value = ReadInt(Offsets.Characters.Patty.maxTPAddr, (UInt32)pattyMaxTp.Maximum);
            pattyExp.Value = ReadInt(Offsets.Characters.Patty.expAddr, (UInt32)pattyExp.Maximum);
            pattyPAtk.Value = ReadInt(Offsets.Characters.Patty.pAtkAddr, (UInt32)pattyPAtk.Maximum);
            pattyMAtk.Value = ReadInt(Offsets.Characters.Patty.mAtkAddr, (UInt32)pattyMAtk.Maximum);
            pattyPDef.Value = ReadInt(Offsets.Characters.Patty.pDefAddr, (UInt32)pattyPDef.Maximum);
            pattyMDef.Value = ReadInt(Offsets.Characters.Patty.mDefAddr, (UInt32)pattyMDef.Maximum);
            pattyAgi.Value = ReadInt(Offsets.Characters.Patty.agiAddr, (UInt32)pattyAgi.Maximum);
            pattyLuck.Value = ReadInt(Offsets.Characters.Patty.luckAddr, (UInt32)pattyLuck.Maximum);
            pattyCurrSp.Value = ReadInt(Offsets.Characters.Patty.spAddr, (UInt32)pattyCurrSp.Maximum);
            pattyMaxSp.Value = ReadInt(Offsets.Characters.Patty.maxSpAddr, (UInt32)pattyMaxSp.Maximum);
        }

        private void UpdateCharacters()
        {
            UpdateYuri();
            UpdateRepede();
            UpdateEstelle();
            UpdateKarol();
            UpdateRita();
            UpdateRaven();
            UpdateJudith();
            UpdateFlynn();
            UpdatePatty();
        }

        private void UpdateUi()
        {
            UpdateMiscUi();
            UpdateCharacters();
            UpdateDlcView();
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
            WriteInt(Offsets.Characters.Yuri.spAddr, (UInt32)yuriCurrSp.Value);
            WriteInt(Offsets.Characters.Yuri.maxSpAddr, (UInt32)yuriMaxSp.Value);

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
            WriteInt(Offsets.Characters.Repede.spAddr, (UInt32)repedeCurrSp.Value);
            WriteInt(Offsets.Characters.Repede.maxSpAddr, (UInt32)repedeMaxSp.Value);

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
            WriteInt(Offsets.Characters.Estelle.spAddr, (UInt32)estelleCurrSp.Value);
            WriteInt(Offsets.Characters.Estelle.maxSpAddr, (UInt32)estelleMaxSp.Value);

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
            WriteInt(Offsets.Characters.Karol.spAddr, (UInt32)karolCurrSp.Value);
            WriteInt(Offsets.Characters.Karol.maxSpAddr, (UInt32)karolMaxSp.Value);

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
            WriteInt(Offsets.Characters.Rita.spAddr, (UInt32)ritaCurrSp.Value);
            WriteInt(Offsets.Characters.Rita.maxSpAddr, (UInt32)ritaMaxSp.Value);

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
            WriteInt(Offsets.Characters.Raven.spAddr, (UInt32)ravenCurrSp.Value);
            WriteInt(Offsets.Characters.Raven.maxSpAddr, (UInt32)ravenMaxSp.Value);

            /* Judith's data */
            WriteInt(Offsets.Characters.Judith.lvlAddr, (UInt32)judithLvl.Value);
            WriteInt(Offsets.Characters.Judith.maxHPAddr, (UInt32)judithMaxHp.Value);
            WriteInt(Offsets.Characters.Judith.maxTPAddr, (UInt32)judithMaxTp.Value);
            WriteInt(Offsets.Characters.Judith.expAddr, (UInt32)judithExp.Value);
            WriteInt(Offsets.Characters.Judith.pAtkAddr, (UInt32)judithPAtk.Value);
            WriteInt(Offsets.Characters.Judith.mAtkAddr, (UInt32)judithMAtk.Value);
            WriteInt(Offsets.Characters.Judith.pDefAddr, (UInt32)judithPDef.Value);
            WriteInt(Offsets.Characters.Judith.mDefAddr, (UInt32)judithMDef.Value);
            WriteInt(Offsets.Characters.Judith.agiAddr, (UInt32)judithAgi.Value);
            WriteInt(Offsets.Characters.Judith.luckAddr, (UInt32)judithLuck.Value);
            WriteInt(Offsets.Characters.Judith.spAddr, (UInt32)judithCurrSp.Value);
            WriteInt(Offsets.Characters.Judith.maxSpAddr, (UInt32)judithMaxSp.Value);

            /* Flynn's data */
            WriteInt(Offsets.Characters.Flynn.lvlAddr, (UInt32)flynnLvl.Value);
            WriteInt(Offsets.Characters.Flynn.maxHPAddr, (UInt32)flynnMaxHp.Value);
            WriteInt(Offsets.Characters.Flynn.maxTPAddr, (UInt32)flynnMaxTp.Value);
            WriteInt(Offsets.Characters.Flynn.expAddr, (UInt32)flynnExp.Value);
            WriteInt(Offsets.Characters.Flynn.pAtkAddr, (UInt32)flynnPAtk.Value);
            WriteInt(Offsets.Characters.Flynn.mAtkAddr, (UInt32)flynnMAtk.Value);
            WriteInt(Offsets.Characters.Flynn.pDefAddr, (UInt32)flynnPDef.Value);
            WriteInt(Offsets.Characters.Flynn.mDefAddr, (UInt32)flynnMDef.Value);
            WriteInt(Offsets.Characters.Flynn.agiAddr, (UInt32)flynnAgi.Value);
            WriteInt(Offsets.Characters.Flynn.luckAddr, (UInt32)flynnLuck.Value);
            WriteInt(Offsets.Characters.Flynn.spAddr, (UInt32)flynnCurrSp.Value);
            WriteInt(Offsets.Characters.Flynn.maxSpAddr, (UInt32)flynnMaxSp.Value);

            /* Patty's data */
            WriteInt(Offsets.Characters.Patty.lvlAddr, (UInt32)pattyLvl.Value);
            WriteInt(Offsets.Characters.Patty.maxHPAddr, (UInt32)pattyMaxHp.Value);
            WriteInt(Offsets.Characters.Patty.maxTPAddr, (UInt32)pattyMaxTp.Value);
            WriteInt(Offsets.Characters.Patty.expAddr, (UInt32)pattyExp.Value);
            WriteInt(Offsets.Characters.Patty.pAtkAddr, (UInt32)pattyPAtk.Value);
            WriteInt(Offsets.Characters.Patty.mAtkAddr, (UInt32)pattyMAtk.Value);
            WriteInt(Offsets.Characters.Patty.pDefAddr, (UInt32)pattyPDef.Value);
            WriteInt(Offsets.Characters.Patty.mDefAddr, (UInt32)pattyMDef.Value);
            WriteInt(Offsets.Characters.Patty.agiAddr, (UInt32)pattyAgi.Value);
            WriteInt(Offsets.Characters.Patty.luckAddr, (UInt32)pattyLuck.Value);
            WriteInt(Offsets.Characters.Patty.spAddr, (UInt32)pattyCurrSp.Value);
            WriteInt(Offsets.Characters.Patty.maxSpAddr, (UInt32)pattyMaxSp.Value);

            /* Dlc data */
            for (int i = 0; i < Constants.DlcNames.Length; i++)
                WriteInt(Offsets.Misc.Dlc.startAddr + (UInt32)(i*4), UInt32.Parse(dlcGridView.Rows[i].Cells["DlcQty"].Value as string));
            
            /* Gald */
            WriteInt(Offsets.Misc.Gald.startAddr, (UInt32)galdValueBox.Value);
        }
        #endregion

        private bool ReadSave(string file)
        {
            data = System.IO.File.ReadAllBytes(file);
            if (data.Length == Constants.SAVEDATA_SIZE)
            {
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
                fileSaved.Visible = false;
                fileLoaded.Visible = true;
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
                fileSaved.Visible = false;
                successLabel.Visible = false;
                UpdateData();
                File.WriteAllBytes(saveFileDialog1.FileName, data);
                progressBar1.Value = progressBar1.Maximum;
                successLabel.Visible = true;
                fileLoaded.Visible = false;
                fileSaved.Text = GetFileName(saveFileDialog1.FileName) + " saved successfully!";
                fileSaved.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dlcGridView.Rows)
                row.Cells["DlcQty"].Value = "99";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dlcGridView.Rows)
                row.Cells["DlcQty"].Value = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dlcGridView.Rows)
                row.Cells["DlcQty"].Value = "1";
        }
    }
}
