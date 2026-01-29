using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    public partial class TeacherSidebar : UserControl
    {
        public event EventHandler DashboardClicked;
        public event EventHandler MyCoursesClicked;
        public event EventHandler GradesClicked;
        public event EventHandler LogoutClicked;

        Color activeColor = Color.FromArgb(79, 70, 229);
        Color defaultColor = Color.FromArgb(31, 41, 55);
        Color hoverColor = Color.FromArgb(55, 65, 81);

        public TeacherSidebar()
        {
            InitializeComponent();
            SetupHoverEffects();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TeacherName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public void SetActivePage(string pageName)
        {
            ResetBtn(btnDashboard);
            ResetBtn(btnMyCourses);
            ResetBtn(btnGrades);

            switch (pageName)
            {
                case "Dashboard":
                    HighlightButton(btnDashboard);
                    break;
                case "MyCourses":
                    HighlightButton(btnMyCourses);
                    break;
                case "Grades":
                    HighlightButton(btnGrades);
                    break;
            }
        }

        private void HighlightButton(Button btn)
        {
            if (btn != null)
            {
                btn.BackColor = activeColor;
                btn.ForeColor = Color.White;
            }
        }

        private void ResetBtn(Button btn)
        {
            if (btn != null)
            {
                btn.BackColor = defaultColor;
                btn.ForeColor = Color.FromArgb(156, 163, 175);
            }
        }

        private void SetupHoverEffects()
        {
            AttachHover(btnDashboard);
            AttachHover(btnMyCourses);
            AttachHover(btnGrades);
        }

        private void AttachHover(Button btn)
        {
            if (btn != null)
            {
                btn.MouseEnter += (s, e) =>
                {
                    if (btn.BackColor != activeColor) btn.BackColor = hoverColor;
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (btn.BackColor != activeColor) btn.BackColor = defaultColor;
                };
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e) => DashboardClicked?.Invoke(this, EventArgs.Empty);
        private void btnMyCourses_Click(object sender, EventArgs e) => MyCoursesClicked?.Invoke(this, EventArgs.Empty);
        private void btnGrades_Click(object sender, EventArgs e) => GradesClicked?.Invoke(this, EventArgs.Empty);
        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => LogoutClicked?.Invoke(this, EventArgs.Empty);
    }
}