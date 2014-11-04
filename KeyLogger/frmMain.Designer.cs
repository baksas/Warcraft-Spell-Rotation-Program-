using System.Windows.Forms;

namespace WacraftColorProgram
{
    partial class FrmMain
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
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mousePosition = new System.Windows.Forms.Label();
            this.mousePositionTop = new System.Windows.Forms.Label();
            this.editMousePosition = new System.Windows.Forms.CheckBox();
            this.mousePositionSavedLabel = new System.Windows.Forms.Label();
            this.mouseSinglePositionSaved = new System.Windows.Forms.Label();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.AoeLabel = new System.Windows.Forms.Label();
            this.AoeCheckBox = new System.Windows.Forms.CheckBox();
            this.AoeMousePositionSaved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditModeCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(349, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 333);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(99, 333);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 16;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(180, 333);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 17;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // mousePosition
            // 
            this.mousePosition.AutoSize = true;
            this.mousePosition.Location = new System.Drawing.Point(12, 9);
            this.mousePosition.Name = "mousePosition";
            this.mousePosition.Size = new System.Drawing.Size(86, 13);
            this.mousePosition.TabIndex = 18;
            this.mousePosition.Text = "MOUSE Position";
            // 
            // mousePositionTop
            // 
            this.mousePositionTop.AutoSize = true;
            this.mousePositionTop.Location = new System.Drawing.Point(104, 9);
            this.mousePositionTop.Name = "mousePositionTop";
            this.mousePositionTop.Size = new System.Drawing.Size(0, 13);
            this.mousePositionTop.TabIndex = 19;
            // 
            // editMousePosition
            // 
            this.editMousePosition.AutoSize = true;
            this.editMousePosition.Location = new System.Drawing.Point(147, 30);
            this.editMousePosition.Name = "editMousePosition";
            this.editMousePosition.Size = new System.Drawing.Size(15, 14);
            this.editMousePosition.TabIndex = 20;
            this.editMousePosition.UseVisualStyleBackColor = true;
            // 
            // mousePositionSavedLabel
            // 
            this.mousePositionSavedLabel.AutoSize = true;
            this.mousePositionSavedLabel.Location = new System.Drawing.Point(15, 31);
            this.mousePositionSavedLabel.Name = "mousePositionSavedLabel";
            this.mousePositionSavedLabel.Size = new System.Drawing.Size(36, 13);
            this.mousePositionSavedLabel.TabIndex = 21;
            this.mousePositionSavedLabel.Text = "Single";
            // 
            // mouseSinglePositionSaved
            // 
            this.mouseSinglePositionSaved.AutoSize = true;
            this.mouseSinglePositionSaved.Location = new System.Drawing.Point(70, 30);
            this.mouseSinglePositionSaved.Name = "mouseSinglePositionSaved";
            this.mouseSinglePositionSaved.Size = new System.Drawing.Size(0, 13);
            this.mouseSinglePositionSaved.TabIndex = 22;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(18, 149);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(312, 160);
            this.ItemList.TabIndex = 23;
            this.ItemList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AoeLabel
            // 
            this.AoeLabel.AutoSize = true;
            this.AoeLabel.Location = new System.Drawing.Point(18, 66);
            this.AoeLabel.Name = "AoeLabel";
            this.AoeLabel.Size = new System.Drawing.Size(26, 13);
            this.AoeLabel.TabIndex = 24;
            this.AoeLabel.Text = "Aoe";
            // 
            // AoeCheckBox
            // 
            this.AoeCheckBox.AutoSize = true;
            this.AoeCheckBox.Location = new System.Drawing.Point(147, 65);
            this.AoeCheckBox.Name = "AoeCheckBox";
            this.AoeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AoeCheckBox.TabIndex = 25;
            this.AoeCheckBox.UseVisualStyleBackColor = true;
            // 
            // AoeMousePositionSaved
            // 
            this.AoeMousePositionSaved.AutoSize = true;
            this.AoeMousePositionSaved.Location = new System.Drawing.Point(70, 66);
            this.AoeMousePositionSaved.Name = "AoeMousePositionSaved";
            this.AoeMousePositionSaved.Size = new System.Drawing.Size(0, 13);
            this.AoeMousePositionSaved.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Edit Mode";
            // 
            // EditModeCheckbox
            // 
            this.EditModeCheckbox.AutoSize = true;
            this.EditModeCheckbox.Location = new System.Drawing.Point(147, 109);
            this.EditModeCheckbox.Name = "EditModeCheckbox";
            this.EditModeCheckbox.Size = new System.Drawing.Size(15, 14);
            this.EditModeCheckbox.TabIndex = 28;
            this.EditModeCheckbox.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(349, 381);
            this.Controls.Add(this.EditModeCheckbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AoeMousePositionSaved);
            this.Controls.Add(this.AoeCheckBox);
            this.Controls.Add(this.AoeLabel);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.mouseSinglePositionSaved);
            this.Controls.Add(this.mousePositionSavedLabel);
            this.Controls.Add(this.editMousePosition);
            this.Controls.Add(this.mousePositionTop);
            this.Controls.Add(this.mousePosition);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Color Program v1.0]";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
     //   private Timer timer_emailer;
     //   private Timer timer_logsaver;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Label mousePosition;
        private Label mousePositionTop;
        private CheckBox editMousePosition;
        private Label mousePositionSavedLabel;
        private Label mouseSinglePositionSaved;
        private ListBox ItemList;
        private Label AoeLabel;
        private CheckBox AoeCheckBox;
        private Label AoeMousePositionSaved;
        private Label label1;
        private CheckBox EditModeCheckbox;

    }
}

