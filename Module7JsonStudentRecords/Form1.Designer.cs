namespace Module7JsonStudentRecords
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpStudentInformation = new GroupBox();
            tlpInformation = new TableLayoutPanel();
            btnAddStudent = new Button();
            tlpForms = new TableLayoutPanel();
            tlpTopForms = new TableLayoutPanel();
            lblStudentId = new Label();
            numStudentId = new NumericUpDown();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            tlpBottomForms = new TableLayoutPanel();
            lblProgramName = new Label();
            txtProgramName = new TextBox();
            lblGPA = new Label();
            numGPA = new NumericUpDown();
            grpStudentRecords = new GroupBox();
            dgvStudentRecords = new DataGridView();
            tlpMain = new TableLayoutPanel();
            tlpButtons = new TableLayoutPanel();
            btnSaveJSON = new Button();
            btnLoadJSON = new Button();
            btnClear = new Button();
            lblStatus = new Label();
            grpStudentInformation.SuspendLayout();
            tlpInformation.SuspendLayout();
            tlpForms.SuspendLayout();
            tlpTopForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStudentId).BeginInit();
            tlpBottomForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGPA).BeginInit();
            grpStudentRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).BeginInit();
            tlpMain.SuspendLayout();
            tlpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpStudentInformation
            // 
            grpStudentInformation.Controls.Add(tlpInformation);
            grpStudentInformation.Dock = DockStyle.Fill;
            grpStudentInformation.Location = new Point(3, 3);
            grpStudentInformation.Name = "grpStudentInformation";
            grpStudentInformation.Size = new Size(608, 130);
            grpStudentInformation.TabIndex = 0;
            grpStudentInformation.TabStop = false;
            grpStudentInformation.Text = "Student Information";
            // 
            // tlpInformation
            // 
            tlpInformation.ColumnCount = 1;
            tlpInformation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpInformation.Controls.Add(btnAddStudent, 0, 1);
            tlpInformation.Controls.Add(tlpForms, 0, 0);
            tlpInformation.Dock = DockStyle.Fill;
            tlpInformation.Location = new Point(3, 19);
            tlpInformation.Name = "tlpInformation";
            tlpInformation.RowCount = 2;
            tlpInformation.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpInformation.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tlpInformation.Size = new Size(602, 108);
            tlpInformation.TabIndex = 2;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Dock = DockStyle.Fill;
            btnAddStudent.Location = new Point(3, 81);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(596, 24);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            // 
            // tlpForms
            // 
            tlpForms.AutoSize = true;
            tlpForms.ColumnCount = 1;
            tlpForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpForms.Controls.Add(tlpTopForms, 0, 0);
            tlpForms.Controls.Add(tlpBottomForms, 0, 1);
            tlpForms.Dock = DockStyle.Fill;
            tlpForms.Location = new Point(3, 3);
            tlpForms.Name = "tlpForms";
            tlpForms.RowCount = 2;
            tlpForms.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpForms.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpForms.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpForms.Size = new Size(596, 72);
            tlpForms.TabIndex = 0;
            // 
            // tlpTopForms
            // 
            tlpTopForms.ColumnCount = 6;
            tlpTopForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpTopForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpTopForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpTopForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpTopForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpTopForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpTopForms.Controls.Add(lblStudentId, 0, 0);
            tlpTopForms.Controls.Add(numStudentId, 1, 0);
            tlpTopForms.Controls.Add(lblFirstName, 2, 0);
            tlpTopForms.Controls.Add(txtFirstName, 3, 0);
            tlpTopForms.Controls.Add(lblLastName, 4, 0);
            tlpTopForms.Controls.Add(txtLastName, 5, 0);
            tlpTopForms.Dock = DockStyle.Fill;
            tlpTopForms.Location = new Point(3, 3);
            tlpTopForms.Name = "tlpTopForms";
            tlpTopForms.RowCount = 1;
            tlpTopForms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTopForms.Size = new Size(590, 30);
            tlpTopForms.TabIndex = 0;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Dock = DockStyle.Fill;
            lblStudentId.Location = new Point(3, 0);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(92, 30);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Student ID:";
            lblStudentId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numStudentId
            // 
            numStudentId.AutoSize = true;
            numStudentId.Dock = DockStyle.Fill;
            numStudentId.Location = new Point(101, 3);
            numStudentId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numStudentId.Name = "numStudentId";
            numStudentId.Size = new Size(92, 23);
            numStudentId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(199, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Padding = new Padding(4, 0, 0, 0);
            lblFirstName.Size = new Size(92, 30);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(297, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(92, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(395, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Padding = new Padding(4, 0, 0, 0);
            lblLastName.Size = new Size(92, 30);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(493, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(94, 23);
            txtLastName.TabIndex = 5;
            // 
            // tlpBottomForms
            // 
            tlpBottomForms.ColumnCount = 4;
            tlpBottomForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66333F));
            tlpBottomForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.01F));
            tlpBottomForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66333F));
            tlpBottomForms.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.66333F));
            tlpBottomForms.Controls.Add(lblProgramName, 0, 0);
            tlpBottomForms.Controls.Add(txtProgramName, 1, 0);
            tlpBottomForms.Controls.Add(lblGPA, 2, 0);
            tlpBottomForms.Controls.Add(numGPA, 3, 0);
            tlpBottomForms.Dock = DockStyle.Fill;
            tlpBottomForms.Location = new Point(3, 39);
            tlpBottomForms.Name = "tlpBottomForms";
            tlpBottomForms.RowCount = 1;
            tlpBottomForms.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBottomForms.Size = new Size(590, 30);
            tlpBottomForms.TabIndex = 1;
            // 
            // lblProgramName
            // 
            lblProgramName.AutoSize = true;
            lblProgramName.Dock = DockStyle.Fill;
            lblProgramName.Location = new Point(3, 0);
            lblProgramName.Name = "lblProgramName";
            lblProgramName.Size = new Size(92, 30);
            lblProgramName.TabIndex = 1;
            lblProgramName.Text = "Program Name:";
            lblProgramName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtProgramName
            // 
            txtProgramName.Dock = DockStyle.Fill;
            txtProgramName.Location = new Point(101, 3);
            txtProgramName.Name = "txtProgramName";
            txtProgramName.Size = new Size(289, 23);
            txtProgramName.TabIndex = 4;
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Dock = DockStyle.Fill;
            lblGPA.Location = new Point(396, 0);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(92, 30);
            lblGPA.TabIndex = 5;
            lblGPA.Text = "Program Name:";
            lblGPA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numGPA
            // 
            numGPA.AutoSize = true;
            numGPA.DecimalPlaces = 2;
            numGPA.Dock = DockStyle.Fill;
            numGPA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numGPA.Location = new Point(494, 3);
            numGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numGPA.Name = "numGPA";
            numGPA.Size = new Size(93, 23);
            numGPA.TabIndex = 6;
            // 
            // grpStudentRecords
            // 
            grpStudentRecords.AutoSize = true;
            grpStudentRecords.Controls.Add(dgvStudentRecords);
            grpStudentRecords.Dock = DockStyle.Fill;
            grpStudentRecords.Location = new Point(3, 139);
            grpStudentRecords.Name = "grpStudentRecords";
            grpStudentRecords.Size = new Size(608, 22);
            grpStudentRecords.TabIndex = 1;
            grpStudentRecords.TabStop = false;
            grpStudentRecords.Text = "Student Records";
            // 
            // dgvStudentRecords
            // 
            dgvStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRecords.Dock = DockStyle.Fill;
            dgvStudentRecords.Location = new Point(3, 19);
            dgvStudentRecords.Name = "dgvStudentRecords";
            dgvStudentRecords.Size = new Size(602, 0);
            dgvStudentRecords.TabIndex = 0;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(grpStudentInformation, 0, 0);
            tlpMain.Controls.Add(grpStudentRecords, 0, 1);
            tlpMain.Controls.Add(tlpButtons, 0, 2);
            tlpMain.Controls.Add(lblStatus, 0, 3);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 4;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            tlpMain.RowStyles.Add(new RowStyle());
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(614, 423);
            tlpMain.TabIndex = 2;
            // 
            // tlpButtons
            // 
            tlpButtons.AutoScroll = true;
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpButtons.Controls.Add(btnSaveJSON, 0, 0);
            tlpButtons.Controls.Add(btnLoadJSON, 1, 0);
            tlpButtons.Controls.Add(btnClear, 2, 0);
            tlpButtons.Dock = DockStyle.Fill;
            tlpButtons.Location = new Point(3, 167);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(608, 34);
            tlpButtons.TabIndex = 2;
            // 
            // btnSaveJSON
            // 
            btnSaveJSON.AutoSize = true;
            btnSaveJSON.Dock = DockStyle.Fill;
            btnSaveJSON.Location = new Point(3, 3);
            btnSaveJSON.Name = "btnSaveJSON";
            btnSaveJSON.Size = new Size(196, 28);
            btnSaveJSON.TabIndex = 0;
            btnSaveJSON.Text = "Save to JSON";
            btnSaveJSON.UseVisualStyleBackColor = true;
            // 
            // btnLoadJSON
            // 
            btnLoadJSON.AutoSize = true;
            btnLoadJSON.Dock = DockStyle.Fill;
            btnLoadJSON.Location = new Point(205, 3);
            btnLoadJSON.Name = "btnLoadJSON";
            btnLoadJSON.Size = new Size(196, 28);
            btnLoadJSON.TabIndex = 1;
            btnLoadJSON.Text = "Load from JSON";
            btnLoadJSON.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.AutoSize = true;
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(407, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(198, 28);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear Display";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(3, 204);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(608, 219);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 423);
            Controls.Add(tlpMain);
            Name = "Form1";
            Text = "Form1";
            grpStudentInformation.ResumeLayout(false);
            tlpInformation.ResumeLayout(false);
            tlpInformation.PerformLayout();
            tlpForms.ResumeLayout(false);
            tlpTopForms.ResumeLayout(false);
            tlpTopForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStudentId).EndInit();
            tlpBottomForms.ResumeLayout(false);
            tlpBottomForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGPA).EndInit();
            grpStudentRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).EndInit();
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            tlpButtons.ResumeLayout(false);
            tlpButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpStudentInformation;
        private Button btnAddStudent;
        private TableLayoutPanel tlpForms;
        private GroupBox grpStudentRecords;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpInformation;
        private TableLayoutPanel tlpTopForms;
        private TableLayoutPanel tlpBottomForms;
        private Label lblStudentId;
        private NumericUpDown numStudentId;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblProgramName;
        private TextBox txtProgramName;
        private Label lblGPA;
        private NumericUpDown numGPA;
        private DataGridView dgvStudentRecords;
        private TableLayoutPanel tlpButtons;
        private Button btnSaveJSON;
        private Button btnLoadJSON;
        private Button btnClear;
        private Label lblStatus;
    }
}
