namespace PerceptronOkno
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trainFileSource = new System.Windows.Forms.TextBox();
            this.testFileSource = new System.Windows.Forms.TextBox();
            this.dividerBox = new System.Windows.Forms.TextBox();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.StałaUczeniaBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SeekedValueCombo = new System.Windows.Forms.ComboBox();
            this.SecoundSetCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FileClasButton = new System.Windows.Forms.Button();
            this.UserInputTextBox = new System.Windows.Forms.TextBox();
            this.UserClasifyButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Acc1Text = new System.Windows.Forms.TextBox();
            this.Acc2Text = new System.Windows.Forms.TextBox();
            this.AccSumTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StałaUczeniaBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(183, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "divider";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(40, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "test file path";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(42, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "train file path";
            // 
            // trainFileSource
            // 
            this.trainFileSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trainFileSource.Location = new System.Drawing.Point(43, 73);
            this.trainFileSource.Name = "trainFileSource";
            this.trainFileSource.Size = new System.Drawing.Size(210, 20);
            this.trainFileSource.TabIndex = 17;
            this.trainFileSource.Text = "train.csv";
            this.trainFileSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trainFileSource_MouseDoubleClick);
            // 
            // testFileSource
            // 
            this.testFileSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.testFileSource.Location = new System.Drawing.Point(45, 28);
            this.testFileSource.Name = "testFileSource";
            this.testFileSource.Size = new System.Drawing.Size(210, 20);
            this.testFileSource.TabIndex = 16;
            this.testFileSource.Text = "test.csv";
            this.testFileSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.testFileSource_MouseDoubleClick);
            // 
            // dividerBox
            // 
            this.dividerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dividerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.dividerBox.Location = new System.Drawing.Point(229, 51);
            this.dividerBox.Name = "dividerBox";
            this.dividerBox.Size = new System.Drawing.Size(24, 21);
            this.dividerBox.TabIndex = 15;
            this.dividerBox.Text = ";";
            this.dividerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetDataButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GetDataButton.Location = new System.Drawing.Point(43, 125);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(210, 44);
            this.GetDataButton.TabIndex = 14;
            this.GetDataButton.Text = "IMPORT DATA";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // StałaUczeniaBox
            // 
            this.StałaUczeniaBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StałaUczeniaBox.DecimalPlaces = 2;
            this.StałaUczeniaBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.StałaUczeniaBox.Location = new System.Drawing.Point(133, 99);
            this.StałaUczeniaBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StałaUczeniaBox.Name = "StałaUczeniaBox";
            this.StałaUczeniaBox.Size = new System.Drawing.Size(120, 20);
            this.StałaUczeniaBox.TabIndex = 21;
            this.StałaUczeniaBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Alpha";
            // 
            // SeekedValueCombo
            // 
            this.SeekedValueCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SeekedValueCombo.FormattingEnabled = true;
            this.SeekedValueCombo.Location = new System.Drawing.Point(45, 193);
            this.SeekedValueCombo.Name = "SeekedValueCombo";
            this.SeekedValueCombo.Size = new System.Drawing.Size(93, 21);
            this.SeekedValueCombo.TabIndex = 23;
            // 
            // SecoundSetCombo
            // 
            this.SecoundSetCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecoundSetCombo.FormattingEnabled = true;
            this.SecoundSetCombo.Location = new System.Drawing.Point(158, 193);
            this.SecoundSetCombo.Name = "SecoundSetCombo";
            this.SecoundSetCombo.Size = new System.Drawing.Size(93, 21);
            this.SecoundSetCombo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "USED SETS";
            // 
            // FileClasButton
            // 
            this.FileClasButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FileClasButton.Location = new System.Drawing.Point(45, 221);
            this.FileClasButton.Name = "FileClasButton";
            this.FileClasButton.Size = new System.Drawing.Size(210, 43);
            this.FileClasButton.TabIndex = 26;
            this.FileClasButton.Text = "LEARN";
            this.FileClasButton.UseVisualStyleBackColor = true;
            this.FileClasButton.Click += new System.EventHandler(this.FileClasButton_Click);
            // 
            // UserInputTextBox
            // 
            this.UserInputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputTextBox.Location = new System.Drawing.Point(45, 271);
            this.UserInputTextBox.Name = "UserInputTextBox";
            this.UserInputTextBox.Size = new System.Drawing.Size(206, 20);
            this.UserInputTextBox.TabIndex = 27;
            // 
            // UserClasifyButton
            // 
            this.UserClasifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserClasifyButton.Location = new System.Drawing.Point(43, 297);
            this.UserClasifyButton.Name = "UserClasifyButton";
            this.UserClasifyButton.Size = new System.Drawing.Size(210, 43);
            this.UserClasifyButton.TabIndex = 28;
            this.UserClasifyButton.Text = "CLASIFY";
            this.UserClasifyButton.UseVisualStyleBackColor = true;
            this.UserClasifyButton.Click += new System.EventHandler(this.UserClasifyButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Accuracy 1";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Accuracy 2";
            // 
            // Acc1Text
            // 
            this.Acc1Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Acc1Text.Location = new System.Drawing.Point(106, 343);
            this.Acc1Text.Name = "Acc1Text";
            this.Acc1Text.ReadOnly = true;
            this.Acc1Text.Size = new System.Drawing.Size(115, 20);
            this.Acc1Text.TabIndex = 31;
            // 
            // Acc2Text
            // 
            this.Acc2Text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Acc2Text.Location = new System.Drawing.Point(107, 370);
            this.Acc2Text.Name = "Acc2Text";
            this.Acc2Text.ReadOnly = true;
            this.Acc2Text.Size = new System.Drawing.Size(114, 20);
            this.Acc2Text.TabIndex = 32;
            // 
            // AccSumTextBox
            // 
            this.AccSumTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccSumTextBox.Location = new System.Drawing.Point(106, 396);
            this.AccSumTextBox.Name = "AccSumTextBox";
            this.AccSumTextBox.ReadOnly = true;
            this.AccSumTextBox.Size = new System.Drawing.Size(114, 20);
            this.AccSumTextBox.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Accuracy Overall";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 433);
            this.Controls.Add(this.AccSumTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Acc2Text);
            this.Controls.Add(this.Acc1Text);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserClasifyButton);
            this.Controls.Add(this.UserInputTextBox);
            this.Controls.Add(this.FileClasButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecoundSetCombo);
            this.Controls.Add(this.SeekedValueCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StałaUczeniaBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trainFileSource);
            this.Controls.Add(this.testFileSource);
            this.Controls.Add(this.dividerBox);
            this.Controls.Add(this.GetDataButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StałaUczeniaBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox trainFileSource;
        public System.Windows.Forms.TextBox testFileSource;
        public System.Windows.Forms.TextBox dividerBox;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.NumericUpDown StałaUczeniaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SeekedValueCombo;
        private System.Windows.Forms.ComboBox SecoundSetCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FileClasButton;
        private System.Windows.Forms.TextBox UserInputTextBox;
        private System.Windows.Forms.Button UserClasifyButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Acc1Text;
        private System.Windows.Forms.TextBox Acc2Text;
        private System.Windows.Forms.TextBox AccSumTextBox;
        private System.Windows.Forms.Label label8;
    }
}

