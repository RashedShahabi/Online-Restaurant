namespace Resturant
{
    partial class Factor
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
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.resturanDataSet = new Resturant.ResturanDataSet();
            this.rezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervTableAdapter = new Resturant.ResturanDataSetTableAdapters.RezervTableAdapter();
            this.iDDeskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRezervDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namefoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFoodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namedeserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDeserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemilkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countMilkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemokhalafatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countMokhalafatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.AutoGenerateColumns = false;
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDeskDataGridViewTextBoxColumn,
            this.dateRezervDataGridViewTextBoxColumn,
            this.timeStartDataGridViewTextBoxColumn,
            this.timeEndDataGridViewTextBoxColumn,
            this.iDClientDataGridViewTextBoxColumn,
            this.namefoodDataGridViewTextBoxColumn,
            this.countFoodDataGridViewTextBoxColumn,
            this.namedeserDataGridViewTextBoxColumn,
            this.countDeserDataGridViewTextBoxColumn,
            this.namemilkDataGridViewTextBoxColumn,
            this.countMilkDataGridViewTextBoxColumn,
            this.namemokhalafatDataGridViewTextBoxColumn,
            this.countMokhalafatDataGridViewTextBoxColumn});
            this.foodDataGridView.DataSource = this.rezervBindingSource;
            this.foodDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foodDataGridView.Location = new System.Drawing.Point(0, 0);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.Size = new System.Drawing.Size(1050, 416);
            this.foodDataGridView.TabIndex = 1;
            // 
            // resturanDataSet
            // 
            this.resturanDataSet.DataSetName = "ResturanDataSet";
            this.resturanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rezervBindingSource
            // 
            this.rezervBindingSource.DataMember = "Rezerv";
            this.rezervBindingSource.DataSource = this.resturanDataSet;
            // 
            // rezervTableAdapter
            // 
            this.rezervTableAdapter.ClearBeforeFill = true;
            // 
            // iDDeskDataGridViewTextBoxColumn
            // 
            this.iDDeskDataGridViewTextBoxColumn.DataPropertyName = "IDDesk";
            this.iDDeskDataGridViewTextBoxColumn.HeaderText = "شماره میز";
            this.iDDeskDataGridViewTextBoxColumn.Name = "iDDeskDataGridViewTextBoxColumn";
            this.iDDeskDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateRezervDataGridViewTextBoxColumn
            // 
            this.dateRezervDataGridViewTextBoxColumn.DataPropertyName = "DateRezerv";
            this.dateRezervDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.dateRezervDataGridViewTextBoxColumn.Name = "dateRezervDataGridViewTextBoxColumn";
            // 
            // timeStartDataGridViewTextBoxColumn
            // 
            this.timeStartDataGridViewTextBoxColumn.DataPropertyName = "TimeStart";
            this.timeStartDataGridViewTextBoxColumn.HeaderText = "زمان شروع";
            this.timeStartDataGridViewTextBoxColumn.Name = "timeStartDataGridViewTextBoxColumn";
            // 
            // timeEndDataGridViewTextBoxColumn
            // 
            this.timeEndDataGridViewTextBoxColumn.DataPropertyName = "TimeEnd";
            this.timeEndDataGridViewTextBoxColumn.HeaderText = "زمان پایان";
            this.timeEndDataGridViewTextBoxColumn.Name = "timeEndDataGridViewTextBoxColumn";
            // 
            // iDClientDataGridViewTextBoxColumn
            // 
            this.iDClientDataGridViewTextBoxColumn.DataPropertyName = "IDClient";
            this.iDClientDataGridViewTextBoxColumn.HeaderText = "کد مشتری";
            this.iDClientDataGridViewTextBoxColumn.Name = "iDClientDataGridViewTextBoxColumn";
            this.iDClientDataGridViewTextBoxColumn.Width = 50;
            // 
            // namefoodDataGridViewTextBoxColumn
            // 
            this.namefoodDataGridViewTextBoxColumn.DataPropertyName = "namefood";
            this.namefoodDataGridViewTextBoxColumn.HeaderText = "نام غذا";
            this.namefoodDataGridViewTextBoxColumn.Name = "namefoodDataGridViewTextBoxColumn";
            // 
            // countFoodDataGridViewTextBoxColumn
            // 
            this.countFoodDataGridViewTextBoxColumn.DataPropertyName = "CountFood";
            this.countFoodDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.countFoodDataGridViewTextBoxColumn.Name = "countFoodDataGridViewTextBoxColumn";
            this.countFoodDataGridViewTextBoxColumn.Width = 50;
            // 
            // namedeserDataGridViewTextBoxColumn
            // 
            this.namedeserDataGridViewTextBoxColumn.DataPropertyName = "namedeser";
            this.namedeserDataGridViewTextBoxColumn.HeaderText = "نام دسر";
            this.namedeserDataGridViewTextBoxColumn.Name = "namedeserDataGridViewTextBoxColumn";
            // 
            // countDeserDataGridViewTextBoxColumn
            // 
            this.countDeserDataGridViewTextBoxColumn.DataPropertyName = "CountDeser";
            this.countDeserDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.countDeserDataGridViewTextBoxColumn.Name = "countDeserDataGridViewTextBoxColumn";
            this.countDeserDataGridViewTextBoxColumn.Width = 50;
            // 
            // namemilkDataGridViewTextBoxColumn
            // 
            this.namemilkDataGridViewTextBoxColumn.DataPropertyName = "namemilk";
            this.namemilkDataGridViewTextBoxColumn.HeaderText = "نام نوشیدنی";
            this.namemilkDataGridViewTextBoxColumn.Name = "namemilkDataGridViewTextBoxColumn";
            // 
            // countMilkDataGridViewTextBoxColumn
            // 
            this.countMilkDataGridViewTextBoxColumn.DataPropertyName = "CountMilk";
            this.countMilkDataGridViewTextBoxColumn.HeaderText = "تعداد ";
            this.countMilkDataGridViewTextBoxColumn.Name = "countMilkDataGridViewTextBoxColumn";
            this.countMilkDataGridViewTextBoxColumn.Width = 50;
            // 
            // namemokhalafatDataGridViewTextBoxColumn
            // 
            this.namemokhalafatDataGridViewTextBoxColumn.DataPropertyName = "namemokhalafat";
            this.namemokhalafatDataGridViewTextBoxColumn.HeaderText = "نام مخلفات";
            this.namemokhalafatDataGridViewTextBoxColumn.Name = "namemokhalafatDataGridViewTextBoxColumn";
            // 
            // countMokhalafatDataGridViewTextBoxColumn
            // 
            this.countMokhalafatDataGridViewTextBoxColumn.DataPropertyName = "CountMokhalafat";
            this.countMokhalafatDataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.countMokhalafatDataGridViewTextBoxColumn.Name = "countMokhalafatDataGridViewTextBoxColumn";
            this.countMokhalafatDataGridViewTextBoxColumn.Width = 50;
            // 
            // Factor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 416);
            this.Controls.Add(this.foodDataGridView);
            this.Name = "Factor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Factor";
            this.Load += new System.EventHandler(this.Factor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resturanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDfoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdeserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmilkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmokhalafatDataGridViewTextBoxColumn;
        private ResturanDataSet resturanDataSet;
        private System.Windows.Forms.BindingSource rezervBindingSource;
        private ResturanDataSetTableAdapters.RezervTableAdapter rezervTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDeskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRezervDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namefoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFoodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedeserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDeserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemilkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countMilkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemokhalafatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countMokhalafatDataGridViewTextBoxColumn;
    }
}