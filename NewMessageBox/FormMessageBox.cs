namespace NewMessageBox
{
    public partial class FormMessageBox : Form
    {
        public FormMessageBox()
        {
            InitializeComponent();
            ControlsNewMethods.RoundingControl  rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = this;
            rc.CornerRadius = 10;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonAbort;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonCancel;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonContinue;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonIgnore;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonNo;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonOk;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonRetry;
            rc.CornerRadius = 15;
            rc = new ControlsNewMethods.RoundingControl();
            rc.TargetControl = buttonYes;
            rc.CornerRadius = 15;
        }
        private int all_size_btn_with = 75;

        public void SetIcon(MessageBoxIcon icon)
        {
            if (icon == MessageBoxIcon.None)
            {
                pictureBoxIcon.Hide();
            }
            else if(icon == MessageBoxIcon.Hand)
            {
                pictureBoxIcon.Image = SystemIcons.Hand.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Asterisk)
            {
                pictureBoxIcon.Image = SystemIcons.Asterisk.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Question)
            {
                pictureBoxIcon.Image = SystemIcons.Question.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Warning)
            {
                pictureBoxIcon.Image = SystemIcons.Warning.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Information)
            {
                pictureBoxIcon.Image = SystemIcons.Information.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Stop)
            {
                pictureBoxIcon.Image = SystemIcons.Error.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Error)
            {
                pictureBoxIcon.Image = SystemIcons.Error.ToBitmap();
            }
            else if(icon == MessageBoxIcon.Exclamation)
            {
                pictureBoxIcon.Image = SystemIcons.Exclamation.ToBitmap();
            }
        }

        public void SetButtons(MessageBoxButtons buttons)
        {
            this.SuspendLayout();
            if (buttons == MessageBoxButtons.OK)
            {
                buttonCancel.Hide();
                buttonOk.Show();
                buttonContinue.Hide();
                buttonAbort.Hide();
                buttonIgnore.Hide();
                buttonNo.Hide();
                buttonYes.Hide();
                buttonRetry.Hide();
                all_size_btn_with = buttonOk.Width;
            }
            else if (buttons == MessageBoxButtons.YesNo)
            {
                buttonCancel.Hide();
                buttonOk.Hide();
                buttonContinue.Hide();
                buttonAbort.Hide();
                buttonIgnore.Hide();
                buttonNo.Show();
                buttonYes.Show();
                buttonRetry.Hide();
                all_size_btn_with = buttonYes.Width + buttonNo.Width;
            }
            else if (buttons == MessageBoxButtons.YesNoCancel)
            {
                buttonCancel.Show();
                buttonOk.Hide();
                buttonContinue.Hide();
                buttonAbort.Hide();
                buttonIgnore.Hide();
                buttonNo.Show();
                buttonYes.Show();
                buttonRetry.Hide();
                all_size_btn_with = buttonYes.Width + buttonNo.Width + buttonCancel.Width;
            }
            else if (buttons == MessageBoxButtons.OKCancel)
            {
                buttonCancel.Show();
                buttonOk.Show();
                buttonContinue.Hide();
                buttonAbort.Hide();
                buttonIgnore.Hide();
                buttonNo.Hide();
                buttonYes.Hide();
                buttonRetry.Hide();
                all_size_btn_with = buttonOk.Width + buttonCancel.Width;
            }
            else if (buttons == MessageBoxButtons.RetryCancel)
            {
                buttonCancel.Show();
                buttonOk.Hide();
                buttonContinue.Hide();
                buttonAbort.Hide();
                buttonIgnore.Hide();
                buttonNo.Hide();
                buttonYes.Hide();
                buttonRetry.Show();
                all_size_btn_with = buttonRetry.Width + buttonCancel.Width;
            }
            else if (buttons == MessageBoxButtons.AbortRetryIgnore)
            {
                buttonCancel.Hide();
                buttonOk.Hide();
                buttonContinue.Hide();
                buttonAbort.Show();
                buttonIgnore.Show();
                buttonNo.Hide();
                buttonYes.Hide();
                buttonRetry.Show();
                all_size_btn_with = buttonAbort.Width + buttonRetry.Width+ buttonIgnore.Width;
            }
            else if (buttons == MessageBoxButtons.CancelTryContinue)
            {
                buttonCancel.Show();
                buttonOk.Hide();
                buttonContinue.Show();
                buttonAbort.Hide();
                buttonIgnore.Hide();
                buttonNo.Hide();
                buttonYes.Hide();
                buttonRetry.Show();
                all_size_btn_with = buttonCancel.Width + buttonRetry.Width+ buttonContinue.Width;
            }
            all_size_btn_with += panelBtn.Padding.Left + panelBtn.Padding.Right;
            this.ResumeLayout();
        }

        public void EndConfiguration()
        {
            int lab_size_with = 35;
            if(labelText.Width > labelCaption.Width)
            {
                this.Size = new Size(labelText.Width + buttonClose.Width + 10, Height);
                lab_size_with = this.Size.Width;
            }
            else
            {
                this.Size = new Size(labelCaption.Width + buttonClose.Width + 10, Height);
                lab_size_with = this.Size.Width;
            }

            if(all_size_btn_with > lab_size_with)
            {
                this.Size = new Size(all_size_btn_with, Height);
            }
            this.Text = labelCaption.Text;
        }

        public void ChangeTheme(bool f)
        {
            if(f)
            {
                this.BackColor = Color.FromArgb(25,25,25);
                this.ForeColor = Color.White;
                panelBtn.BackColor = Color.Black;//FromArgb(35,35,35);
                panelBtn.ForeColor = Color.White;

                buttonCancel.BackColor = Color.FromArgb(25, 25, 25);
                buttonOk.BackColor = Color.FromArgb(25, 25, 25);
                buttonContinue.BackColor = Color.FromArgb(25, 25, 25);
                buttonAbort.BackColor = Color.FromArgb(25, 25, 25);
                buttonIgnore.BackColor = Color.FromArgb(25, 25, 25);
                buttonNo.BackColor = Color.FromArgb(25, 25, 25);
                buttonYes.BackColor = Color.FromArgb(25, 25, 25);
                buttonRetry.BackColor = Color.FromArgb(25, 25, 25);

                buttonCancel.ForeColor = Color.White;
                buttonOk.ForeColor = Color.White;
                buttonContinue.ForeColor = Color.White;
                buttonAbort.ForeColor = Color.White;
                buttonIgnore.ForeColor = Color.White;
                buttonNo.ForeColor = Color.White;
                buttonYes.ForeColor = Color.White;
                buttonRetry.ForeColor = Color.White;
            }
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Continue;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.Abort;
        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }

        private void buttonIgnore_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Ignore;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
    public static class NewMessageBox
    {
        public static DialogResult ShowDialog(string text, string caption=null,
            MessageBoxButtons buttons= MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon= MessageBoxIcon.None, bool dark =false)
        {
            FormMessageBox form = new FormMessageBox();
            form.labelText.Text = text;
            if(caption != null)
            {
                form.labelCaption.Text = caption;
            }
            form.SetButtons(buttons);
            form.SetIcon(messageBoxIcon);
            form.EndConfiguration();
            form.ChangeTheme(dark);
            DialogResult dr = form.ShowDialog();
            form.Dispose();
            return dr;
        }
    }
}