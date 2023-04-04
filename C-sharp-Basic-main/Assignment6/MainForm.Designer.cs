namespace Assignment6
{
    partial class MainForm
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStripToDo = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatafileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDataTime = new System.Windows.Forms.Label();
            this.labelToDo = new System.Windows.Forms.Label();
            this.textBoxToDo = new System.Windows.Forms.TextBox();
            this.labelPriority1 = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxToDo = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPriority2 = new System.Windows.Forms.Label();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.toolTipDate = new System.Windows.Forms.ToolTip(this.components);
            this.timerLocalTime = new System.Windows.Forms.Timer(this.components);
            this.labelLocalTime = new System.Windows.Forms.Label();
            this.menuStripToDo.SuspendLayout();
            this.groupBoxToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(194, 49);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(301, 26);
            this.dateTimePicker.TabIndex = 0;
            // 
            // menuStripToDo
            // 
            this.menuStripToDo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStripToDo.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripToDo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripToDo.Location = new System.Drawing.Point(0, 0);
            this.menuStripToDo.Name = "menuStripToDo";
            this.menuStripToDo.Size = new System.Drawing.Size(789, 24);
            this.menuStripToDo.TabIndex = 1;
            this.menuStripToDo.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileToolStripMenuItem,
            this.openDatafileToolStripMenuItem,
            this.saveDatafileToolStripMenuItem,
            this.exitAltToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(12, 29);
            // 
            // newFileToolStripMenuItem
            // 
            this.newFileToolStripMenuItem.Name = "newFileToolStripMenuItem";
            this.newFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newFileToolStripMenuItem.ShowShortcutKeys = false;
            this.newFileToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            this.newFileToolStripMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openDatafileToolStripMenuItem
            // 
            this.openDatafileToolStripMenuItem.Name = "openDatafileToolStripMenuItem";
            this.openDatafileToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            // 
            // saveDatafileToolStripMenuItem
            // 
            this.saveDatafileToolStripMenuItem.Name = "saveDatafileToolStripMenuItem";
            this.saveDatafileToolStripMenuItem.Size = new System.Drawing.Size(291, 30);
            // 
            // exitAltToolStripMenuItem
            // 
            this.exitAltToolStripMenuItem.Name = "exitAltToolStripMenuItem";
            this.exitAltToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitAltToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitAltToolStripMenuItem.Click += new System.EventHandler(this.exitAltToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(12, 28);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelDataTime
            // 
            this.labelDataTime.AutoSize = true;
            this.labelDataTime.Location = new System.Drawing.Point(26, 48);
            this.labelDataTime.Name = "labelDataTime";
            this.labelDataTime.Size = new System.Drawing.Size(0, 20);
            this.labelDataTime.TabIndex = 2;
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Location = new System.Drawing.Point(26, 91);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(0, 20);
            this.labelToDo.TabIndex = 3;
            // 
            // textBoxToDo
            // 
            this.textBoxToDo.Location = new System.Drawing.Point(106, 85);
            this.textBoxToDo.Name = "textBoxToDo";
            this.textBoxToDo.Size = new System.Drawing.Size(661, 26);
            this.textBoxToDo.TabIndex = 4;
            // 
            // labelPriority1
            // 
            this.labelPriority1.AutoSize = true;
            this.labelPriority1.Location = new System.Drawing.Point(529, 49);
            this.labelPriority1.Name = "labelPriority1";
            this.labelPriority1.Size = new System.Drawing.Size(0, 20);
            this.labelPriority1.TabIndex = 5;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(618, 46);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(148, 28);
            this.comboBoxPriority.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(194, 128);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(110, 34);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(355, 128);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(108, 33);
            this.buttonChange.TabIndex = 8;
            this.buttonChange.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(511, 128);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 30);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // groupBoxToDo
            // 
            this.groupBoxToDo.Controls.Add(this.listBox);
            this.groupBoxToDo.Controls.Add(this.labelDescription);
            this.groupBoxToDo.Controls.Add(this.labelPriority2);
            this.groupBoxToDo.Controls.Add(this.labelHour);
            this.groupBoxToDo.Controls.Add(this.labelDate);
            this.groupBoxToDo.Location = new System.Drawing.Point(30, 168);
            this.groupBoxToDo.Name = "groupBoxToDo";
            this.groupBoxToDo.Size = new System.Drawing.Size(734, 282);
            this.groupBoxToDo.TabIndex = 10;
            this.groupBoxToDo.TabStop = false;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(23, 65);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(700, 204);
            this.listBox.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(504, 33);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 20);
            this.labelDescription.TabIndex = 3;
            // 
            // labelPriority2
            // 
            this.labelPriority2.AutoSize = true;
            this.labelPriority2.Location = new System.Drawing.Point(362, 35);
            this.labelPriority2.Name = "labelPriority2";
            this.labelPriority2.Size = new System.Drawing.Size(0, 20);
            this.labelPriority2.TabIndex = 2;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(188, 33);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(0, 20);
            this.labelHour.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(22, 32);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 20);
            this.labelDate.TabIndex = 0;
            // 
            // timerLocalTime
            // 
            this.timerLocalTime.Enabled = true;
            this.timerLocalTime.Interval = 1000;
            this.timerLocalTime.Tick += new System.EventHandler(this.timerLocalTime_Tick);
            // 
            // labelLocalTime
            // 
            this.labelLocalTime.AutoSize = true;
            this.labelLocalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocalTime.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelLocalTime.Location = new System.Drawing.Point(677, 460);
            this.labelLocalTime.Name = "labelLocalTime";
            this.labelLocalTime.Size = new System.Drawing.Size(0, 25);
            this.labelLocalTime.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 488);
            this.Controls.Add(this.labelLocalTime);
            this.Controls.Add(this.groupBoxToDo);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.labelPriority1);
            this.Controls.Add(this.textBoxToDo);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.labelDataTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.menuStripToDo);
            this.MainMenuStrip = this.menuStripToDo;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStripToDo.ResumeLayout(false);
            this.menuStripToDo.PerformLayout();
            this.groupBoxToDo.ResumeLayout(false);
            this.groupBoxToDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MenuStrip menuStripToDo;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatafileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label labelDataTime;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.TextBox textBoxToDo;
        private System.Windows.Forms.Label labelPriority1;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxToDo;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPriority2;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ToolTip toolTipDate;
        private System.Windows.Forms.ToolStripMenuItem exitAltToolStripMenuItem;
        private System.Windows.Forms.Timer timerLocalTime;
        private System.Windows.Forms.Label labelLocalTime;
    }
}

