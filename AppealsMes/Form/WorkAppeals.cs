using Appeals_Mes.Class;
using AppealsMes.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appeals_Mes
{
    public partial class WorkAppeals : Form
    {
        TabPage TabPageAppeals = new TabPage();
        TabPage TabPageProblem = new TabPage();
        TabPage TabPageSolvingProblem = new TabPage();
        TabPage TabPageLetters = new TabPage();
        public WorkAppeals(string form)
        {
            InitializeComponent();
            switch (form)
            {
                case "AppealsForm":
                    AppealsCH.Checked = true;
                    AppealsFormAddRed appealsFormAddRed = new AppealsFormAddRed();
                    TabPageAppeals.Text = "Обращения";
                    tabControl1.TabPages.Add(TabPageAppeals);
                    appealsFormAddRed.TopLevel = false;
                    appealsFormAddRed.Anchor = AnchorStyles.Top;
                    appealsFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    appealsFormAddRed.Dock = DockStyle.Fill;
                    TabPageAppeals.Controls.Add(appealsFormAddRed);
                    TabPageAppeals.Tag = appealsFormAddRed;
                    appealsFormAddRed.BringToFront();
                    appealsFormAddRed.Show();
                    break;
                case "ProbleamAppeals":
                    ProblemAppealsCH.Checked = true;
                    ProblemAppealsFormAddRed problemAppealsFormAddRed = new ProblemAppealsFormAddRed();
                    TabPageProblem.Text = "Проблема обращений";
                    tabControl1.TabPages.Add(TabPageProblem);
                    problemAppealsFormAddRed.TopLevel = false;
                    problemAppealsFormAddRed.Anchor = AnchorStyles.Top;
                    problemAppealsFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    problemAppealsFormAddRed.Dock = DockStyle.Fill;
                    TabPageProblem.Controls.Add(problemAppealsFormAddRed);
                    TabPageProblem.Tag = problemAppealsFormAddRed;
                    problemAppealsFormAddRed.BringToFront();
                    problemAppealsFormAddRed.Show();
                    break;
                case "SolvingProblem":
                    SolvingProblemCH.Checked = true;
                    SolvingProblemFormAddRed solvingProblemForm = new SolvingProblemFormAddRed();
                    TabPageSolvingProblem.Text = "Решение проблемы";
                    tabControl1.TabPages.Add(TabPageSolvingProblem);
                    solvingProblemForm.TopLevel = false;
                    solvingProblemForm.Anchor = AnchorStyles.Top;
                    solvingProblemForm.FormBorderStyle = FormBorderStyle.None;
                    solvingProblemForm.Dock = DockStyle.Fill;
                    TabPageSolvingProblem.Controls.Add(solvingProblemForm);
                    TabPageSolvingProblem.Tag = solvingProblemForm;
                    solvingProblemForm.BringToFront();
                    solvingProblemForm.Show();
                    break;
                case "Letters":
                    LettersCH.Checked = true;
                    LettersFormAddRed lettersFormAddRed = new LettersFormAddRed();
                    TabPageLetters.Text = "Письма";
                    tabControl1.TabPages.Add(TabPageLetters);
                    lettersFormAddRed.TopLevel = false;
                    lettersFormAddRed.Anchor = AnchorStyles.Top;
                    lettersFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    lettersFormAddRed.Dock = DockStyle.Fill;
                    TabPageLetters.Controls.Add(lettersFormAddRed);
                    TabPageLetters.Tag = lettersFormAddRed;
                    lettersFormAddRed.BringToFront();
                    lettersFormAddRed.Show();
                    break;
            }
            AppealsCH.CheckedChanged += (s, e) =>
            {
                AppealsFormAddRed appealsFormAddRed = new AppealsFormAddRed();
                if (AppealsCH.Checked == true)
                {
                    TabPageAppeals.Text = "Обращения";
                    tabControl1.TabPages.Add(TabPageAppeals);
                    appealsFormAddRed.TopLevel = false;
                    appealsFormAddRed.Anchor = AnchorStyles.Top;
                    appealsFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    appealsFormAddRed.Dock = DockStyle.Fill;
                    TabPageAppeals.Controls.Add(appealsFormAddRed);
                    TabPageAppeals.Tag = appealsFormAddRed;
                    appealsFormAddRed.BringToFront();
                    appealsFormAddRed.Show();
                }
                else if (AppealsCH.Checked == false)
                {
                    tabControl1.TabPages.Remove(TabPageAppeals);
                }
            };
            ProblemAppealsCH.CheckedChanged += (s, e) =>
            {
                ProblemAppealsFormAddRed problemAppealsFormAddRed = new ProblemAppealsFormAddRed();
                if (ProblemAppealsCH.Checked == true)
                {
                    TabPageProblem.Text = "Проблема обращений";
                    tabControl1.TabPages.Add(TabPageProblem);
                    problemAppealsFormAddRed.TopLevel = false;
                    problemAppealsFormAddRed.Anchor = AnchorStyles.Top;
                    problemAppealsFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    problemAppealsFormAddRed.Dock = DockStyle.Fill;
                    TabPageProblem.Controls.Add(problemAppealsFormAddRed);
                    TabPageProblem.Tag = problemAppealsFormAddRed;
                    problemAppealsFormAddRed.BringToFront();
                    problemAppealsFormAddRed.Show();
                }
                else if (ProblemAppealsCH.Checked == false)
                {
                    tabControl1.TabPages.Remove(TabPageProblem);
                }
            };
            SolvingProblemCH.CheckedChanged += (s, e) =>
            {
                SolvingProblemFormAddRed solvingProblemFormAddRed = new SolvingProblemFormAddRed();
                if (SolvingProblemCH.Checked == true)
                {
                    TabPageSolvingProblem.Text = "Решение проблемы";
                    tabControl1.TabPages.Add(TabPageSolvingProblem);
                    solvingProblemFormAddRed.TopLevel = false;
                    solvingProblemFormAddRed.Anchor = AnchorStyles.Top;
                    solvingProblemFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    solvingProblemFormAddRed.Dock = DockStyle.Fill;
                    TabPageSolvingProblem.Controls.Add(solvingProblemFormAddRed);
                    TabPageSolvingProblem.Tag = solvingProblemFormAddRed;
                    solvingProblemFormAddRed.BringToFront();
                    solvingProblemFormAddRed.Show();
                }
                else if (SolvingProblemCH.Checked == false)
                {
                    tabControl1.TabPages.Remove(TabPageSolvingProblem);
                }
            };
            LettersCH.CheckedChanged += (s, e) =>
            {
                LettersFormAddRed lettersFormAddRed = new LettersFormAddRed();
                if (SolvingProblemCH.Checked == true)
                {
                    TabPageLetters.Text = "Письма";
                    tabControl1.TabPages.Add(TabPageLetters);
                    lettersFormAddRed.TopLevel = false;
                    lettersFormAddRed.Anchor = AnchorStyles.Top;
                    lettersFormAddRed.FormBorderStyle = FormBorderStyle.None;
                    lettersFormAddRed.Dock = DockStyle.Fill;
                    TabPageLetters.Controls.Add(lettersFormAddRed);
                    TabPageLetters.Tag = lettersFormAddRed;
                    lettersFormAddRed.BringToFront();
                    lettersFormAddRed.Show();
                }
                else if (SolvingProblemCH.Checked == false)
                {
                    tabControl1.TabPages.Remove(TabPageLetters);
                }
            };
        }
    }
}
