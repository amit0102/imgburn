using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using NEROLib;
using System.IO;
using System.Threading;
using BlueFlame.Classes;
using BlueFlame.Classes.DatabaseObjects;
using BlueFlame.Classes.MySql;

namespace BlueFlame.Forms
{
    public partial class BurnProgress : Form
    {
        private bool _abort;
        private double _timeSec;
        private Disc _disc;

        public BurnProgress(Disc disc, int speed)
        {
            InitializeComponent();
            _disc = disc;
            _abort = false;
            
            double size = new FileInfo(disc.FullName).Length;
            GetTime(size, speed);

            l_duration.Text = Math.Round((_timeSec / 60), 2) + " Minuten";
            l_speed.Text = speed + "x (" + speed * 150 + " kb/s )";

            uint flags = 0;
            flags |= (uint)NERO_BURN_FLAGS.NERO_BURN_FLAG_CD_TEXT;
            flags |= (uint)NERO_BURN_FLAGS.NERO_BURN_FLAG_CLOSE_SESSION;
            flags |= (uint)NERO_BURN_FLAGS.NERO_BURN_FLAG_DISABLE_EJECT;
            flags |= (uint)NERO_BURN_FLAGS.NERO_BURN_FLAG_WRITE;
            flags |= (uint)NERO_BURN_FLAGS.NERO_BURN_FLAG_BUF_UNDERRUN_PROT;
            

            Burn.Drive.OnDoneBurn += new _INeroDriveEvents_OnDoneBurnEventHandler(_drive_OnDoneBurn);
            Burn.Drive.OnProgress += new _INeroDriveEvents_OnProgressEventHandler(_drive_OnProgress);

            Cursor = Cursors.WaitCursor;

            switch (disc.MediaType)
            {
                case MediaType.CompactDisc:
                    Burn.Drive.BurnImage(disc.FullName , (NERO_BURN_FLAGS)flags, speed);
                    break;
                case MediaType.DigitalVersatileDisc:
                    Burn.Drive.BurnImage2(disc.FullName, (NERO_BURN_FLAGS)flags, speed, NERO_MEDIA_TYPE.NERO_MEDIA_DVD_ANY);
                    break;
            }
        }

        void _drive_OnProgress(ref int ProgressInPercent, ref bool Abort)
        {
            Abort = _abort;

            double time = (_timeSec / 100)  * ProgressInPercent;

            l_duration.Text = Math.Round(((_timeSec - time) / 60), 2) + " Minuten";

            
            l_percentage.Text = ProgressInPercent + " %";
            pB_staus.Value = ProgressInPercent;
        }

        void _drive_OnDoneBurn(ref NERO_BURN_ERROR StatusCode)
        {
            Cursor = Cursors.Default;
            Burn.Drive.OnDoneBurn -= new _INeroDriveEvents_OnDoneBurnEventHandler(_drive_OnDoneBurn);
            Burn.Drive.OnProgress -= new _INeroDriveEvents_OnProgressEventHandler(_drive_OnProgress);

            DisplayMessage(StatusCode);

            Burn.Drive.EjectCD();
            this.DialogResult = DialogResult.OK;
        }

        private void DisplayMessage(NERO_BURN_ERROR StatusCode)
        {
            switch (StatusCode)
            {
                case NERO_BURN_ERROR.NERO_BURN_OK:
                    if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                        MessageBox.Show("The writing process was successfully completed!",
                            "Done!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Der Brennvorgang wurde erfolgreich abgeschlossen!",
                            "Brennen erfolgreich!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    break;

                case NERO_BURN_ERROR.NERO_BURN_USER_ABORT:
                    if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                        MessageBox.Show("The writing process was aborted.",
                            "Abortion!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Der Brennvorgang wurde abgebrochen",
                            "Brennen abgebrochen!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    
                    break;

                case NERO_BURN_ERROR.NERO_BURN_FAILED:
                    if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                        MessageBox.Show("An error occured while writing on the media!",
                            "A writing error occured!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Der Brennvorgang konnte leider nicht erfolgreich abgeschlossen werden!",
                            "Fehler beim Brennen!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                   
                    break;

                default:
                    if (Thread.CurrentThread.CurrentUICulture.Name == "en")
                        MessageBox.Show("An error occured while writing on the media!",
                            "A writing error occured!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Der Brennvorgang konnte leider nicht erfolgreich abgeschlossen werden!",
                            "Fehler beim Brennen!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    
                    break;
            }

            if(StatusCode == NERO_BURN_ERROR.NERO_BURN_OK)
                NotifyImagesLog(1000, (int)StatusCode);
            else
                NotifyImagesLog(1001, (int)StatusCode);
        }

        private void GetTime(double size, int speed)
        {
            //1024; // size in kb
            double kbPerSecond = speed * 150; //* 60; // speed by 150 kb per second by 60 seconds = kilobit per minute
            double sizeKb = size / 1024;
            _timeSec = (sizeKb / kbPerSecond + 1);
            _timeSec += 120; // lead in + lead out
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            _abort = true;
            MainForm.Nero.Abort();
        }

        private void NotifyImagesLog(int messageId, int rc)
        {
            // Insert the licenskey into the log
            string sqlString = "INSERT INTO IMAGESLOG VALUES(?user,?file,NOW(),?message,?rc,?domain)";

            MainForm.MySql.Statement(sqlString,
                new MySqlDataParameter("user", MainForm.AccountName),
                new MySqlDataParameter("file", _disc.FileId),
                new MySqlDataParameter("message", messageId),
                new MySqlDataParameter("rc", rc),
                new MySqlDataParameter("domain", MainForm.Domain));
        }
    }      
}