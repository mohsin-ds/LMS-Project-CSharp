using System.Drawing;
using System.Windows.Forms;

namespace MyLms
{
    partial class Stuednt_UploadAssignment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelSubmitAssignmet = new Panel();
            btnViewFile = new RoundedButton();
            panelSubmitAssignmetInner = new Panel();
            btnBackToAssignmentsQuizzesFromAssignment = new RoundedButton();
            lblSubmitAssignmet = new Label();
            btnSubmitAssignment = new RoundedButton();
            panelChooseFile = new Panel();
            lblFileName = new Label();
            btnChooseFile = new Button();
            lblUploadFile = new Label();
            studentSidebar1 = new StudentSidebar();
            panelSubmitAssignmet.SuspendLayout();
            panelSubmitAssignmetInner.SuspendLayout();
            panelChooseFile.SuspendLayout();
            SuspendLayout();
            // 
            // panelSubmitAssignmet
            // 
            panelSubmitAssignmet.BackColor = Color.White;
            panelSubmitAssignmet.Controls.Add(btnViewFile);
            panelSubmitAssignmet.Controls.Add(panelSubmitAssignmetInner);
            panelSubmitAssignmet.Controls.Add(btnSubmitAssignment);
            panelSubmitAssignmet.Controls.Add(panelChooseFile);
            panelSubmitAssignmet.Controls.Add(lblUploadFile);
            panelSubmitAssignmet.Location = new Point(301, 0);
            panelSubmitAssignmet.Name = "panelSubmitAssignmet";
            panelSubmitAssignmet.Size = new Size(980, 752);
            panelSubmitAssignmet.TabIndex = 24;
            // 
            // btnViewFile
            // 
            btnViewFile.BackColor = Color.FromArgb(79, 70, 229);
            btnViewFile.Cursor = Cursors.Hand;
            btnViewFile.FlatAppearance.BorderSize = 0;
            btnViewFile.FlatStyle = FlatStyle.Flat;
            btnViewFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewFile.ForeColor = Color.White;
            btnViewFile.Location = new Point(798, 247);
            btnViewFile.Name = "btnViewFile";
            btnViewFile.Size = new Size(125, 47);
            btnViewFile.TabIndex = 11;
            btnViewFile.Text = "View File";
            btnViewFile.UseVisualStyleBackColor = false;
            btnViewFile.Click += btnViewFile_Click;
            // 
            // panelSubmitAssignmetInner
            // 
            panelSubmitAssignmetInner.BackColor = Color.FromArgb(249, 250, 251);
            panelSubmitAssignmetInner.Controls.Add(btnBackToAssignmentsQuizzesFromAssignment);
            panelSubmitAssignmetInner.Controls.Add(lblSubmitAssignmet);
            panelSubmitAssignmetInner.Location = new Point(0, 0);
            panelSubmitAssignmetInner.Name = "panelSubmitAssignmetInner";
            panelSubmitAssignmetInner.Size = new Size(980, 92);
            panelSubmitAssignmetInner.TabIndex = 10;
            // 
            // btnBackToAssignmentsQuizzesFromAssignment
            // 
            btnBackToAssignmentsQuizzesFromAssignment.BackColor = Color.FromArgb(229, 231, 235);
            btnBackToAssignmentsQuizzesFromAssignment.FlatAppearance.BorderSize = 0;
            btnBackToAssignmentsQuizzesFromAssignment.FlatStyle = FlatStyle.Flat;
            btnBackToAssignmentsQuizzesFromAssignment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackToAssignmentsQuizzesFromAssignment.ForeColor = Color.Black;
            btnBackToAssignmentsQuizzesFromAssignment.Location = new Point(627, 18);
            btnBackToAssignmentsQuizzesFromAssignment.Name = "btnBackToAssignmentsQuizzesFromAssignment";
            btnBackToAssignmentsQuizzesFromAssignment.Size = new Size(296, 56);
            btnBackToAssignmentsQuizzesFromAssignment.TabIndex = 8;
            btnBackToAssignmentsQuizzesFromAssignment.Text = "Back to Assignments && Quizzes";
            btnBackToAssignmentsQuizzesFromAssignment.UseVisualStyleBackColor = false;
            btnBackToAssignmentsQuizzesFromAssignment.Click += btnBackToAssignmentsQuizzesFromAssignment_Click;
            // 
            // lblSubmitAssignmet
            // 
            lblSubmitAssignmet.AutoSize = true;
            lblSubmitAssignmet.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblSubmitAssignmet.ForeColor = Color.FromArgb(17, 24, 39);
            lblSubmitAssignmet.Location = new Point(24, 24);
            lblSubmitAssignmet.Name = "lblSubmitAssignmet";
            lblSubmitAssignmet.Size = new Size(269, 37);
            lblSubmitAssignmet.TabIndex = 7;
            lblSubmitAssignmet.Text = "Upload Assignment";
            // 
            // btnSubmitAssignment
            // 
            btnSubmitAssignment.BackColor = Color.FromArgb(79, 70, 229);
            btnSubmitAssignment.Cursor = Cursors.Hand;
            btnSubmitAssignment.FlatAppearance.BorderSize = 0;
            btnSubmitAssignment.FlatStyle = FlatStyle.Flat;
            btnSubmitAssignment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitAssignment.ForeColor = Color.White;
            btnSubmitAssignment.Location = new Point(24, 247);
            btnSubmitAssignment.Name = "btnSubmitAssignment";
            btnSubmitAssignment.Size = new Size(104, 47);
            btnSubmitAssignment.TabIndex = 9;
            btnSubmitAssignment.Text = "Submit";
            btnSubmitAssignment.UseVisualStyleBackColor = false;
            btnSubmitAssignment.Click += btnSubmitAssignment_Click;
            // 
            // panelChooseFile
            // 
            panelChooseFile.BorderStyle = BorderStyle.FixedSingle;
            panelChooseFile.Controls.Add(lblFileName);
            panelChooseFile.Controls.Add(btnChooseFile);
            panelChooseFile.Location = new Point(30, 153);
            panelChooseFile.Name = "panelChooseFile";
            panelChooseFile.Size = new Size(893, 68);
            panelChooseFile.TabIndex = 1;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.Black;
            lblFileName.Location = new Point(153, 22);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(119, 23);
            lblFileName.TabIndex = 1;
            lblFileName.Text = "No file chosen";
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = SystemColors.ButtonFace;
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseFile.Location = new Point(21, 16);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(126, 34);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // lblUploadFile
            // 
            lblUploadFile.AutoSize = true;
            lblUploadFile.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUploadFile.Location = new Point(24, 117);
            lblUploadFile.Name = "lblUploadFile";
            lblUploadFile.Size = new Size(96, 23);
            lblUploadFile.TabIndex = 0;
            lblUploadFile.Text = "Upload File";
            // 
            // studentSidebar1
            // 
            studentSidebar1.BackColor = Color.FromArgb(31, 41, 55);
            studentSidebar1.Location = new Point(0, 0);
            studentSidebar1.Name = "studentSidebar1";
            studentSidebar1.Size = new Size(300, 752);
            studentSidebar1.TabIndex = 25;
            // 
            // Stuednt_UploadAssignment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 753);
            Controls.Add(studentSidebar1);
            Controls.Add(panelSubmitAssignmet);
            Name = "Stuednt_UploadAssignment";
            Text = "Stuednt_UploadAssignment";
            panelSubmitAssignmet.ResumeLayout(false);
            panelSubmitAssignmet.PerformLayout();
            panelSubmitAssignmetInner.ResumeLayout(false);
            panelSubmitAssignmetInner.PerformLayout();
            panelChooseFile.ResumeLayout(false);
            panelChooseFile.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelSubmitAssignmet;
        private System.Windows.Forms.Panel panelSubmitAssignmetInner;
        private MyLms.RoundedButton btnBackToAssignmentsQuizzesFromAssignment;
        private System.Windows.Forms.Label lblSubmitAssignmet;
        private MyLms.RoundedButton btnSubmitAssignment;
        private System.Windows.Forms.Panel panelChooseFile;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblUploadFile;
        private RoundedButton btnViewFile;
        private StudentSidebar studentSidebar1;
    }
}