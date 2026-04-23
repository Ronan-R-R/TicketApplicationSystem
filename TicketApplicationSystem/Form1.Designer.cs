namespace TicketApplicationSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.lblTravelDate = new System.Windows.Forms.Label();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();
            this.chkPeakHour = new System.Windows.Forms.CheckBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.lblTicketRef = new System.Windows.Forms.Label();
            this.lblTicketRefValue = new System.Windows.Forms.Label();
            this.grpGender.SuspendLayout();
            this.grpSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(248, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TICKET APPLICATION";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblName.Location = new System.Drawing.Point(34, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(110, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Passenger Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.Location = new System.Drawing.Point(34, 145);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 19);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAge.Location = new System.Drawing.Point(34, 210);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(33, 19);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.Location = new System.Drawing.Point(34, 263);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 19);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDistance.Location = new System.Drawing.Point(34, 316);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(61, 19);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "Distance";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.Location = new System.Drawing.Point(170, 89);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(244, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAge.Location = new System.Drawing.Point(170, 207);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(244, 25);
            this.txtAge.TabIndex = 7;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDistance.Location = new System.Drawing.Point(170, 313);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(244, 25);
            this.txtDistance.TabIndex = 8;
            this.txtDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistance_KeyPress);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoMale.Location = new System.Drawing.Point(17, 22);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(57, 23);
            this.rdoMale.TabIndex = 9;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rdoFemale.Location = new System.Drawing.Point(103, 22);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(71, 23);
            this.rdoFemale.TabIndex = 10;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(170, 260);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(244, 25);
            this.cmbCategory.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(38, 441);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 41);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate Ticket";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(202, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 41);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(322, 441);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 41);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.rdoMale);
            this.grpGender.Controls.Add(this.rdoFemale);
            this.grpGender.Location = new System.Drawing.Point(170, 132);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(244, 58);
            this.grpGender.TabIndex = 15;
            this.grpGender.TabStop = false;
            // 
            // lblTravelDate
            // 
            this.lblTravelDate.AutoSize = true;
            this.lblTravelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTravelDate.Location = new System.Drawing.Point(34, 369);
            this.lblTravelDate.Name = "lblTravelDate";
            this.lblTravelDate.Size = new System.Drawing.Size(78, 19);
            this.lblTravelDate.TabIndex = 16;
            this.lblTravelDate.Text = "Travel Date";
            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTravelDate.Location = new System.Drawing.Point(170, 365);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(244, 25);
            this.dtpTravelDate.TabIndex = 17;
            // 
            // chkPeakHour
            // 
            this.chkPeakHour.AutoSize = true;
            this.chkPeakHour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkPeakHour.Location = new System.Drawing.Point(170, 400);
            this.chkPeakHour.Name = "chkPeakHour";
            this.chkPeakHour.Size = new System.Drawing.Size(135, 23);
            this.chkPeakHour.TabIndex = 18;
            this.chkPeakHour.Text = "Peak Hour Travel";
            this.chkPeakHour.UseVisualStyleBackColor = true;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.rtbSummary);
            this.grpSummary.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSummary.Location = new System.Drawing.Point(453, 89);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(330, 393);
            this.grpSummary.TabIndex = 19;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Ticket Summary";
            // 
            // rtbSummary
            // 
            this.rtbSummary.Font = new System.Drawing.Font("Consolas", 10F);
            this.rtbSummary.Location = new System.Drawing.Point(15, 27);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.ReadOnly = true;
            this.rtbSummary.Size = new System.Drawing.Size(299, 347);
            this.rtbSummary.TabIndex = 0;
            this.rtbSummary.Text = "";
            // 
            // lblTicketRef
            // 
            this.lblTicketRef.AutoSize = true;
            this.lblTicketRef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTicketRef.Location = new System.Drawing.Point(34, 56);
            this.lblTicketRef.Name = "lblTicketRef";
            this.lblTicketRef.Size = new System.Drawing.Size(100, 19);
            this.lblTicketRef.TabIndex = 20;
            this.lblTicketRef.Text = "Ticket Ref No:";
            // 
            // lblTicketRefValue
            // 
            this.lblTicketRefValue.AutoSize = true;
            this.lblTicketRefValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTicketRefValue.Location = new System.Drawing.Point(166, 56);
            this.lblTicketRefValue.Name = "lblTicketRefValue";
            this.lblTicketRefValue.Size = new System.Drawing.Size(43, 19);
            this.lblTicketRefValue.TabIndex = 21;
            this.lblTicketRefValue.Text = "None";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(812, 515);
            this.Controls.Add(this.lblTicketRefValue);
            this.Controls.Add(this.lblTicketRef);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.chkPeakHour);
            this.Controls.Add(this.dtpTravelDate);
            this.Controls.Add(this.lblTravelDate);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Application System";
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.Label lblTravelDate;
        private System.Windows.Forms.DateTimePicker dtpTravelDate;
        private System.Windows.Forms.CheckBox chkPeakHour;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.RichTextBox rtbSummary;
        private System.Windows.Forms.Label lblTicketRef;
        private System.Windows.Forms.Label lblTicketRefValue;
    }
}