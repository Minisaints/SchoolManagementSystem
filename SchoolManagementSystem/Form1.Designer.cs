namespace SchoolManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.pupil_datagrid = new System.Windows.Forms.DataGridView();
            this.pupilsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet1 = new SchoolManagementSystem.schoolDataSet1();
            this.pupil_combobox = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDataSet = new SchoolManagementSystem.schoolDataSet();
            this.classesTableAdapter = new SchoolManagementSystem.schoolDataSetTableAdapters.classesTableAdapter();
            this.pupilsTableAdapter = new SchoolManagementSystem.schoolDataSet1TableAdapters.pupilsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.allpupils_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pupil_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(624, 31);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // pupil_datagrid
            // 
            this.pupil_datagrid.AutoGenerateColumns = false;
            this.pupil_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pupil_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.classidDataGridViewTextBoxColumn,
            this.addedByDataGridViewTextBoxColumn,
            this.addedDateDataGridViewTextBoxColumn});
            this.pupil_datagrid.DataSource = this.pupilsBindingSource;
            this.pupil_datagrid.Location = new System.Drawing.Point(13, 193);
            this.pupil_datagrid.Name = "pupil_datagrid";
            this.pupil_datagrid.Size = new System.Drawing.Size(675, 150);
            this.pupil_datagrid.TabIndex = 2;
            this.pupil_datagrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.pupil_datagrid_CellEndEdit);
            this.pupil_datagrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.pupil_datagrid_UserDeletingRow);
            // 
            // pupilsBindingSource
            // 
            this.pupilsBindingSource.DataMember = "pupils";
            this.pupilsBindingSource.DataSource = this.schoolDataSet1;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet1";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pupil_combobox
            // 
            this.pupil_combobox.DataSource = this.classesBindingSource;
            this.pupil_combobox.DisplayMember = "ClassSubject";
            this.pupil_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pupil_combobox.FormattingEnabled = true;
            this.pupil_combobox.Location = new System.Drawing.Point(497, 33);
            this.pupil_combobox.Name = "pupil_combobox";
            this.pupil_combobox.Size = new System.Drawing.Size(121, 21);
            this.pupil_combobox.TabIndex = 3;
            this.pupil_combobox.ValueMember = "id";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "classes";
            this.classesBindingSource.DataSource = this.schoolDataSet;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // pupilsTableAdapter
            // 
            this.pupilsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Class Subject";
            // 
            // allpupils_btn
            // 
            this.allpupils_btn.Location = new System.Drawing.Point(624, 63);
            this.allpupils_btn.Name = "allpupils_btn";
            this.allpupils_btn.Size = new System.Drawing.Size(75, 23);
            this.allpupils_btn.TabIndex = 5;
            this.allpupils_btn.Text = "All Pupils";
            this.allpupils_btn.UseVisualStyleBackColor = true;
            this.allpupils_btn.Click += new System.EventHandler(this.allpupils_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(13, 158);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(102, 29);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // classidDataGridViewTextBoxColumn
            // 
            this.classidDataGridViewTextBoxColumn.DataPropertyName = "Classid";
            this.classidDataGridViewTextBoxColumn.HeaderText = "Classid";
            this.classidDataGridViewTextBoxColumn.Name = "classidDataGridViewTextBoxColumn";
            // 
            // addedByDataGridViewTextBoxColumn
            // 
            this.addedByDataGridViewTextBoxColumn.DataPropertyName = "AddedBy";
            this.addedByDataGridViewTextBoxColumn.HeaderText = "AddedBy";
            this.addedByDataGridViewTextBoxColumn.Name = "addedByDataGridViewTextBoxColumn";
            this.addedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addedDateDataGridViewTextBoxColumn
            // 
            this.addedDateDataGridViewTextBoxColumn.DataPropertyName = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.HeaderText = "AddedDate";
            this.addedDateDataGridViewTextBoxColumn.Name = "addedDateDataGridViewTextBoxColumn";
            this.addedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 355);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.allpupils_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pupil_combobox);
            this.Controls.Add(this.pupil_datagrid);
            this.Controls.Add(this.refresh_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pupil_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pupilsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.DataGridView pupil_datagrid;
        private System.Windows.Forms.ComboBox pupil_combobox;
        private schoolDataSet schoolDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private schoolDataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private schoolDataSet1 schoolDataSet1;
        private System.Windows.Forms.BindingSource pupilsBindingSource;
        private schoolDataSet1TableAdapters.pupilsTableAdapter pupilsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button allpupils_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addedDateDataGridViewTextBoxColumn;
    }
}

