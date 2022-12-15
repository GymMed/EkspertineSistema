
namespace EkspertineSistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.NoButton = new System.Windows.Forms.Button();
            this.YesButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.MultiQuestionPanel = new System.Windows.Forms.Panel();
            this.dataGridQuestion = new System.Windows.Forms.DataGridView();
            this.multipleButton = new System.Windows.Forms.Button();
            this.multiQuestionLabel = new System.Windows.Forms.Label();
            this.ConclusionPanel = new System.Windows.Forms.Panel();
            this.AcceptConclusionButton = new System.Windows.Forms.Button();
            this.ConclusionLabel = new System.Windows.Forms.Label();
            this.StartPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartSystemButton = new System.Windows.Forms.Button();
            this.SystemNameLabel = new System.Windows.Forms.Label();
            this.QuestionPanel.SuspendLayout();
            this.MultiQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestion)).BeginInit();
            this.ConclusionPanel.SuspendLayout();
            this.StartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionPanel.Controls.Add(this.NoButton);
            this.QuestionPanel.Controls.Add(this.YesButton);
            this.QuestionPanel.Controls.Add(this.QuestionLabel);
            this.QuestionPanel.Location = new System.Drawing.Point(12, 12);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(776, 297);
            this.QuestionPanel.TabIndex = 0;
            // 
            // NoButton
            // 
            this.NoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoButton.Location = new System.Drawing.Point(388, 265);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(388, 32);
            this.NoButton.TabIndex = 2;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // YesButton
            // 
            this.YesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YesButton.Location = new System.Drawing.Point(0, 265);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(388, 32);
            this.YesButton.TabIndex = 1;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(3, 9);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(147, 31);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "Question?";
            // 
            // MultiQuestionPanel
            // 
            this.MultiQuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiQuestionPanel.Controls.Add(this.dataGridQuestion);
            this.MultiQuestionPanel.Controls.Add(this.multipleButton);
            this.MultiQuestionPanel.Controls.Add(this.multiQuestionLabel);
            this.MultiQuestionPanel.Location = new System.Drawing.Point(12, 12);
            this.MultiQuestionPanel.Name = "MultiQuestionPanel";
            this.MultiQuestionPanel.Size = new System.Drawing.Size(776, 297);
            this.MultiQuestionPanel.TabIndex = 3;
            // 
            // dataGridQuestion
            // 
            this.dataGridQuestion.AllowUserToAddRows = false;
            this.dataGridQuestion.AllowUserToDeleteRows = false;
            this.dataGridQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuestion.Location = new System.Drawing.Point(0, 43);
            this.dataGridQuestion.Name = "dataGridQuestion";
            this.dataGridQuestion.Size = new System.Drawing.Size(776, 216);
            this.dataGridQuestion.TabIndex = 2;
            this.dataGridQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQuestion_CellContentClick);
            this.dataGridQuestion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridQuestion_CellDoubleClick);
            this.dataGridQuestion.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridQuestion_CellMouseUp);
            // 
            // multipleButton
            // 
            this.multipleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multipleButton.Location = new System.Drawing.Point(0, 265);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(776, 32);
            this.multipleButton.TabIndex = 1;
            this.multipleButton.Text = "Pasirinkti";
            this.multipleButton.UseVisualStyleBackColor = true;
            this.multipleButton.Click += new System.EventHandler(this.multipleButton_Click);
            // 
            // multiQuestionLabel
            // 
            this.multiQuestionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiQuestionLabel.AutoSize = true;
            this.multiQuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiQuestionLabel.Location = new System.Drawing.Point(3, 9);
            this.multiQuestionLabel.Name = "multiQuestionLabel";
            this.multiQuestionLabel.Size = new System.Drawing.Size(147, 31);
            this.multiQuestionLabel.TabIndex = 0;
            this.multiQuestionLabel.Text = "Question?";
            // 
            // ConclusionPanel
            // 
            this.ConclusionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConclusionPanel.Controls.Add(this.AcceptConclusionButton);
            this.ConclusionPanel.Controls.Add(this.ConclusionLabel);
            this.ConclusionPanel.Location = new System.Drawing.Point(12, 12);
            this.ConclusionPanel.Name = "ConclusionPanel";
            this.ConclusionPanel.Size = new System.Drawing.Size(776, 297);
            this.ConclusionPanel.TabIndex = 3;
            // 
            // AcceptConclusionButton
            // 
            this.AcceptConclusionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AcceptConclusionButton.Location = new System.Drawing.Point(0, 265);
            this.AcceptConclusionButton.Name = "AcceptConclusionButton";
            this.AcceptConclusionButton.Size = new System.Drawing.Size(776, 32);
            this.AcceptConclusionButton.TabIndex = 1;
            this.AcceptConclusionButton.Text = "Kartoti";
            this.AcceptConclusionButton.UseVisualStyleBackColor = true;
            this.AcceptConclusionButton.Click += new System.EventHandler(this.AcceptConclusionButton_Click);
            // 
            // ConclusionLabel
            // 
            this.ConclusionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConclusionLabel.AutoSize = true;
            this.ConclusionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConclusionLabel.Location = new System.Drawing.Point(3, 9);
            this.ConclusionLabel.Name = "ConclusionLabel";
            this.ConclusionLabel.Size = new System.Drawing.Size(159, 31);
            this.ConclusionLabel.TabIndex = 0;
            this.ConclusionLabel.Text = "Conclusion";
            // 
            // StartPanel
            // 
            this.StartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPanel.Controls.Add(this.pictureBox1);
            this.StartPanel.Controls.Add(this.StartSystemButton);
            this.StartPanel.Controls.Add(this.SystemNameLabel);
            this.StartPanel.Location = new System.Drawing.Point(12, 12);
            this.StartPanel.Name = "StartPanel";
            this.StartPanel.Size = new System.Drawing.Size(776, 297);
            this.StartPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EkspertineSistema.Properties.Resources.ExpertSystem50x50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 218);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StartSystemButton
            // 
            this.StartSystemButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartSystemButton.Location = new System.Drawing.Point(0, 265);
            this.StartSystemButton.Name = "StartSystemButton";
            this.StartSystemButton.Size = new System.Drawing.Size(776, 32);
            this.StartSystemButton.TabIndex = 1;
            this.StartSystemButton.Text = "Pradėti";
            this.StartSystemButton.UseVisualStyleBackColor = true;
            this.StartSystemButton.Click += new System.EventHandler(this.StartSystemButton_Click);
            // 
            // SystemNameLabel
            // 
            this.SystemNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemNameLabel.AutoSize = true;
            this.SystemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemNameLabel.Location = new System.Drawing.Point(218, 56);
            this.SystemNameLabel.Name = "SystemNameLabel";
            this.SystemNameLabel.Size = new System.Drawing.Size(111, 31);
            this.SystemNameLabel.TabIndex = 0;
            this.SystemNameLabel.Text = "System";
            this.SystemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.MultiQuestionPanel);
            this.Controls.Add(this.StartPanel);
            this.Controls.Add(this.ConclusionPanel);
            this.Controls.Add(this.QuestionPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 360);
            this.Name = "MainForm";
            this.Text = "Ekspertinė Sistema";
            this.Load += new System.EventHandler(this.EkspertineSistema_Load);
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            this.MultiQuestionPanel.ResumeLayout(false);
            this.MultiQuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestion)).EndInit();
            this.ConclusionPanel.ResumeLayout(false);
            this.ConclusionPanel.PerformLayout();
            this.StartPanel.ResumeLayout(false);
            this.StartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Panel MultiQuestionPanel;
        private System.Windows.Forms.DataGridView dataGridQuestion;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Label multiQuestionLabel;
        private System.Windows.Forms.Panel ConclusionPanel;
        private System.Windows.Forms.Button AcceptConclusionButton;
        private System.Windows.Forms.Label ConclusionLabel;
        private System.Windows.Forms.Panel StartPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartSystemButton;
        private System.Windows.Forms.Label SystemNameLabel;
    }
}

