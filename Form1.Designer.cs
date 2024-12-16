namespace Scramble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            encryptInput = new TextBox();
            encryptOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            decryptOutput = new TextBox();
            decryptInput = new TextBox();
            encryptShift = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            decryptShift = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)encryptShift).BeginInit();
            ((System.ComponentModel.ISupportInitialize)decryptShift).BeginInit();
            SuspendLayout();
            // 
            // encryptInput
            // 
            resources.ApplyResources(encryptInput, "encryptInput");
            encryptInput.Name = "encryptInput";
            // 
            // encryptOutput
            // 
            resources.ApplyResources(encryptOutput, "encryptOutput");
            encryptOutput.Name = "encryptOutput";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // decryptOutput
            // 
            resources.ApplyResources(decryptOutput, "decryptOutput");
            decryptOutput.Name = "decryptOutput";
            // 
            // decryptInput
            // 
            resources.ApplyResources(decryptInput, "decryptInput");
            decryptInput.Name = "decryptInput";
            // 
            // encryptShift
            // 
            resources.ApplyResources(encryptShift, "encryptShift");
            encryptShift.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
            encryptShift.Name = "encryptShift";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // decryptShift
            // 
            resources.ApplyResources(decryptShift, "decryptShift");
            decryptShift.Maximum = new decimal(new int[] { 33, 0, 0, 0 });
            decryptShift.Name = "decryptShift";
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(decryptShift);
            Controls.Add(label7);
            Controls.Add(encryptShift);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(decryptOutput);
            Controls.Add(decryptInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(encryptOutput);
            Controls.Add(encryptInput);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)encryptShift).EndInit();
            ((System.ComponentModel.ISupportInitialize)decryptShift).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox decryptOutput;
        private TextBox decryptInput;
        private NumericUpDown encryptShift;
        private Label label7;
        private Label label8;
        private NumericUpDown decryptShift;
        private Button button1;
        private Button button2;
        public TextBox encryptInput;
        public TextBox encryptOutput;
    }
}
