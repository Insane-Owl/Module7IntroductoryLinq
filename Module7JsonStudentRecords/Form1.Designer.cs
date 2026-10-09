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
            gtpQueryOptions = new GroupBox();
            tlpOptionsContainer = new TableLayoutPanel();
            tlpSelections = new TableLayoutPanel();
            lblProgram = new Label();
            cboProgram = new ComboBox();
            lblMinGPA = new Label();
            numMinGPA = new NumericUpDown();
            lblQuery = new Label();
            txtQuery = new TextBox();
            tlpQueryButtons = new TableLayoutPanel();
            tlpRowTop = new TableLayoutPanel();
            btnSearchStudent = new Button();
            btnFilterGPA = new Button();
            btnFilterProgram = new Button();
            btnShowAll = new Button();
            tlpRowBottom = new TableLayoutPanel();
            btnCombinedQuery = new Button();
            btnDisplaySummary = new Button();
            btnSortGPA = new Button();
            btnSortLastName = new Button();
            grpStudentRecords = new GroupBox();
            tlpRecords = new TableLayoutPanel();
            dgvStudentRecords = new DataGridView();
            tlpResults = new TableLayoutPanel();
            lblResults = new Label();
            lblDetails = new Label();
            tlpMain = new TableLayoutPanel();
            gtpQueryOptions.SuspendLayout();
            tlpOptionsContainer.SuspendLayout();
            tlpSelections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinGPA).BeginInit();
            tlpQueryButtons.SuspendLayout();
            tlpRowTop.SuspendLayout();
            tlpRowBottom.SuspendLayout();
            grpStudentRecords.SuspendLayout();
            tlpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).BeginInit();
            tlpResults.SuspendLayout();
            tlpMain.SuspendLayout();
            SuspendLayout();
            // 
            // gtpQueryOptions
            // 
            gtpQueryOptions.Controls.Add(tlpOptionsContainer);
            gtpQueryOptions.Dock = DockStyle.Fill;
            gtpQueryOptions.Location = new Point(3, 3);
            gtpQueryOptions.Name = "gtpQueryOptions";
            gtpQueryOptions.Size = new Size(654, 130);
            gtpQueryOptions.TabIndex = 0;
            gtpQueryOptions.TabStop = false;
            gtpQueryOptions.Text = "Query Options";
            // 
            // tlpOptionsContainer
            // 
            tlpOptionsContainer.ColumnCount = 1;
            tlpOptionsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpOptionsContainer.Controls.Add(tlpSelections, 0, 0);
            tlpOptionsContainer.Controls.Add(tlpQueryButtons, 0, 1);
            tlpOptionsContainer.Dock = DockStyle.Fill;
            tlpOptionsContainer.Location = new Point(3, 19);
            tlpOptionsContainer.Name = "tlpOptionsContainer";
            tlpOptionsContainer.RowCount = 2;
            tlpOptionsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpOptionsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tlpOptionsContainer.Size = new Size(648, 108);
            tlpOptionsContainer.TabIndex = 1;
            // 
            // tlpSelections
            // 
            tlpSelections.ColumnCount = 6;
            tlpSelections.ColumnStyles.Add(new ColumnStyle());
            tlpSelections.ColumnStyles.Add(new ColumnStyle());
            tlpSelections.ColumnStyles.Add(new ColumnStyle());
            tlpSelections.ColumnStyles.Add(new ColumnStyle());
            tlpSelections.ColumnStyles.Add(new ColumnStyle());
            tlpSelections.ColumnStyles.Add(new ColumnStyle());
            tlpSelections.Controls.Add(lblProgram, 0, 0);
            tlpSelections.Controls.Add(cboProgram, 1, 0);
            tlpSelections.Controls.Add(lblMinGPA, 2, 0);
            tlpSelections.Controls.Add(numMinGPA, 3, 0);
            tlpSelections.Controls.Add(lblQuery, 4, 0);
            tlpSelections.Controls.Add(txtQuery, 5, 0);
            tlpSelections.Dock = DockStyle.Fill;
            tlpSelections.Location = new Point(3, 3);
            tlpSelections.Name = "tlpSelections";
            tlpSelections.RowCount = 1;
            tlpSelections.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSelections.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpSelections.Size = new Size(642, 29);
            tlpSelections.TabIndex = 1;
            // 
            // lblProgram
            // 
            lblProgram.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(3, 0);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(59, 29);
            lblProgram.TabIndex = 0;
            lblProgram.Text = "Program: ";
            lblProgram.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboProgram
            // 
            cboProgram.FormattingEnabled = true;
            cboProgram.Location = new Point(68, 3);
            cboProgram.Name = "cboProgram";
            cboProgram.Size = new Size(141, 23);
            cboProgram.TabIndex = 1;
            // 
            // lblMinGPA
            // 
            lblMinGPA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblMinGPA.AutoSize = true;
            lblMinGPA.Location = new Point(215, 0);
            lblMinGPA.Name = "lblMinGPA";
            lblMinGPA.Size = new Size(91, 29);
            lblMinGPA.TabIndex = 2;
            lblMinGPA.Text = "Minimum GPA: ";
            lblMinGPA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numMinGPA
            // 
            numMinGPA.DecimalPlaces = 2;
            numMinGPA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMinGPA.Location = new Point(312, 3);
            numMinGPA.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numMinGPA.Name = "numMinGPA";
            numMinGPA.Size = new Size(58, 23);
            numMinGPA.TabIndex = 3;
            // 
            // lblQuery
            // 
            lblQuery.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblQuery.AutoSize = true;
            lblQuery.Location = new Point(376, 0);
            lblQuery.Name = "lblQuery";
            lblQuery.Size = new Size(117, 29);
            lblQuery.TabIndex = 4;
            lblQuery.Text = "Student ID or Name: ";
            lblQuery.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuery
            // 
            txtQuery.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtQuery.Location = new Point(499, 3);
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(140, 23);
            txtQuery.TabIndex = 5;
            // 
            // tlpQueryButtons
            // 
            tlpQueryButtons.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tlpQueryButtons.ColumnCount = 1;
            tlpQueryButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpQueryButtons.Controls.Add(tlpRowTop, 0, 0);
            tlpQueryButtons.Controls.Add(tlpRowBottom, 0, 1);
            tlpQueryButtons.Location = new Point(3, 38);
            tlpQueryButtons.Name = "tlpQueryButtons";
            tlpQueryButtons.RowCount = 2;
            tlpQueryButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpQueryButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpQueryButtons.Size = new Size(642, 67);
            tlpQueryButtons.TabIndex = 0;
            // 
            // tlpRowTop
            // 
            tlpRowTop.ColumnCount = 4;
            tlpRowTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowTop.Controls.Add(btnSearchStudent, 3, 0);
            tlpRowTop.Controls.Add(btnFilterGPA, 2, 0);
            tlpRowTop.Controls.Add(btnFilterProgram, 1, 0);
            tlpRowTop.Controls.Add(btnShowAll, 0, 0);
            tlpRowTop.Dock = DockStyle.Fill;
            tlpRowTop.Location = new Point(0, 0);
            tlpRowTop.Margin = new Padding(0);
            tlpRowTop.Name = "tlpRowTop";
            tlpRowTop.RowCount = 1;
            tlpRowTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRowTop.Size = new Size(642, 33);
            tlpRowTop.TabIndex = 6;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Dock = DockStyle.Fill;
            btnSearchStudent.Location = new Point(483, 3);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(156, 27);
            btnSearchStudent.TabIndex = 3;
            btnSearchStudent.Text = "Search for Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += BtnSearchStudent_Click;
            // 
            // btnFilterGPA
            // 
            btnFilterGPA.Dock = DockStyle.Fill;
            btnFilterGPA.Location = new Point(323, 3);
            btnFilterGPA.Name = "btnFilterGPA";
            btnFilterGPA.Size = new Size(154, 27);
            btnFilterGPA.TabIndex = 2;
            btnFilterGPA.Text = "Filter by GPA";
            btnFilterGPA.UseVisualStyleBackColor = true;
            btnFilterGPA.Click += BtnFilterGPA_Click;
            // 
            // btnFilterProgram
            // 
            btnFilterProgram.Dock = DockStyle.Fill;
            btnFilterProgram.Location = new Point(163, 3);
            btnFilterProgram.Name = "btnFilterProgram";
            btnFilterProgram.Size = new Size(154, 27);
            btnFilterProgram.TabIndex = 1;
            btnFilterProgram.Text = "Filter by Program";
            btnFilterProgram.UseVisualStyleBackColor = true;
            btnFilterProgram.Click += BtnFilterProgram_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Dock = DockStyle.Fill;
            btnShowAll.Location = new Point(3, 3);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(154, 27);
            btnShowAll.TabIndex = 0;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += BtnShowAll_Click;
            // 
            // tlpRowBottom
            // 
            tlpRowBottom.ColumnCount = 4;
            tlpRowBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpRowBottom.Controls.Add(btnCombinedQuery, 3, 0);
            tlpRowBottom.Controls.Add(btnDisplaySummary, 2, 0);
            tlpRowBottom.Controls.Add(btnSortGPA, 1, 0);
            tlpRowBottom.Controls.Add(btnSortLastName, 0, 0);
            tlpRowBottom.Dock = DockStyle.Fill;
            tlpRowBottom.Location = new Point(0, 33);
            tlpRowBottom.Margin = new Padding(0);
            tlpRowBottom.Name = "tlpRowBottom";
            tlpRowBottom.RowCount = 1;
            tlpRowBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRowBottom.Size = new Size(642, 34);
            tlpRowBottom.TabIndex = 7;
            // 
            // btnCombinedQuery
            // 
            btnCombinedQuery.Dock = DockStyle.Fill;
            btnCombinedQuery.Location = new Point(483, 3);
            btnCombinedQuery.Name = "btnCombinedQuery";
            btnCombinedQuery.Size = new Size(156, 28);
            btnCombinedQuery.TabIndex = 7;
            btnCombinedQuery.Text = "Combined Query";
            btnCombinedQuery.UseVisualStyleBackColor = true;
            btnCombinedQuery.Click += BtnCombinedQuery_Click;
            // 
            // btnDisplaySummary
            // 
            btnDisplaySummary.Dock = DockStyle.Fill;
            btnDisplaySummary.Location = new Point(323, 3);
            btnDisplaySummary.Name = "btnDisplaySummary";
            btnDisplaySummary.Size = new Size(154, 28);
            btnDisplaySummary.TabIndex = 6;
            btnDisplaySummary.Text = "Display Summary";
            btnDisplaySummary.UseVisualStyleBackColor = true;
            btnDisplaySummary.Click += BtnDisplaySummary_Click;
            // 
            // btnSortGPA
            // 
            btnSortGPA.Dock = DockStyle.Fill;
            btnSortGPA.Location = new Point(163, 3);
            btnSortGPA.Name = "btnSortGPA";
            btnSortGPA.Size = new Size(154, 28);
            btnSortGPA.TabIndex = 5;
            btnSortGPA.Text = "Sort by GPA";
            btnSortGPA.UseVisualStyleBackColor = true;
            btnSortGPA.Click += BtnSortGPA_Click;
            // 
            // btnSortLastName
            // 
            btnSortLastName.Dock = DockStyle.Fill;
            btnSortLastName.Location = new Point(3, 3);
            btnSortLastName.Name = "btnSortLastName";
            btnSortLastName.Size = new Size(154, 28);
            btnSortLastName.TabIndex = 4;
            btnSortLastName.Text = "Sort by Last Name";
            btnSortLastName.UseVisualStyleBackColor = true;
            btnSortLastName.Click += BtnSortLastName_Click;
            // 
            // grpStudentRecords
            // 
            grpStudentRecords.AutoSize = true;
            grpStudentRecords.Controls.Add(tlpRecords);
            grpStudentRecords.Dock = DockStyle.Fill;
            grpStudentRecords.Location = new Point(3, 139);
            grpStudentRecords.Name = "grpStudentRecords";
            grpStudentRecords.Size = new Size(654, 281);
            grpStudentRecords.TabIndex = 1;
            grpStudentRecords.TabStop = false;
            grpStudentRecords.Text = "Student Records";
            // 
            // tlpRecords
            // 
            tlpRecords.ColumnCount = 1;
            tlpRecords.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRecords.Controls.Add(dgvStudentRecords, 0, 0);
            tlpRecords.Controls.Add(tlpResults, 0, 1);
            tlpRecords.Dock = DockStyle.Fill;
            tlpRecords.Location = new Point(3, 19);
            tlpRecords.Name = "tlpRecords";
            tlpRecords.RowCount = 2;
            tlpRecords.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpRecords.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpRecords.Size = new Size(648, 259);
            tlpRecords.TabIndex = 1;
            // 
            // dgvStudentRecords
            // 
            dgvStudentRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentRecords.Dock = DockStyle.Fill;
            dgvStudentRecords.Location = new Point(3, 3);
            dgvStudentRecords.Name = "dgvStudentRecords";
            dgvStudentRecords.Size = new Size(642, 193);
            dgvStudentRecords.TabIndex = 0;
            // 
            // tlpResults
            // 
            tlpResults.ColumnCount = 1;
            tlpResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResults.Controls.Add(lblResults, 0, 0);
            tlpResults.Controls.Add(lblDetails, 0, 1);
            tlpResults.Dock = DockStyle.Fill;
            tlpResults.Location = new Point(0, 199);
            tlpResults.Margin = new Padding(0);
            tlpResults.Name = "tlpResults";
            tlpResults.RowCount = 2;
            tlpResults.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResults.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResults.Size = new Size(648, 60);
            tlpResults.TabIndex = 1;
            // 
            // lblResults
            // 
            lblResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblResults.Location = new Point(3, 0);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(79, 30);
            lblResults.TabIndex = 0;
            lblResults.Text = "Results:";
            lblResults.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDetails
            // 
            lblDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 12F);
            lblDetails.Location = new Point(3, 30);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(0, 30);
            lblDetails.TabIndex = 1;
            lblDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(gtpQueryOptions, 0, 0);
            tlpMain.Controls.Add(grpStudentRecords, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(660, 423);
            tlpMain.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 423);
            Controls.Add(tlpMain);
            Name = "Form1";
            Text = "Form1";
            gtpQueryOptions.ResumeLayout(false);
            tlpOptionsContainer.ResumeLayout(false);
            tlpSelections.ResumeLayout(false);
            tlpSelections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinGPA).EndInit();
            tlpQueryButtons.ResumeLayout(false);
            tlpRowTop.ResumeLayout(false);
            tlpRowBottom.ResumeLayout(false);
            grpStudentRecords.ResumeLayout(false);
            tlpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentRecords).EndInit();
            tlpResults.ResumeLayout(false);
            tlpResults.PerformLayout();
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gtpQueryOptions;
        private GroupBox grpStudentRecords;
        private TableLayoutPanel tlpMain;
        private DataGridView dgvStudentRecords;
        private TableLayoutPanel tlpQueryButtons;
        private TableLayoutPanel tlpOptionsContainer;
        private TableLayoutPanel tlpSelections;
        private Label lblProgram;
        private ComboBox cboProgram;
        private Label lblMinGPA;
        private NumericUpDown numMinGPA;
        private Label lblQuery;
        private TextBox txtQuery;
        private Button btnShowAll;
        private Button btnFilterProgram;
        private Button btnFilterGPA;
        private Button btnSearchStudent;
        private Button btnSortLastName;
        private Button btnSortGPA;
        private Button btnDisplaySummary;
        private TableLayoutPanel tlpRowTop;
        private TableLayoutPanel tlpRowBottom;
        private TableLayoutPanel tlpRecords;
        private TableLayoutPanel tlpResults;
        private Label lblResults;
        private Label lblDetails;
        private Button btnCombinedQuery;
    }
}
