namespace WinFormsAppX
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
            textBoxA = new TextBox();
            labelA = new Label();
            textBoxX = new TextBox();
            labelScheitel = new Label();
            textBoxB = new TextBox();
            labelB = new Label();
            textBoxC = new TextBox();
            textBoxScheitelY = new TextBox();
            labelC = new Label();
            labelFunktionswert = new Label();
            buttonRechnePotenz = new Button();
            labelNullstellen = new Label();
            textBoxScheitelX = new TextBox();
            labelX = new Label();
            labelY = new Label();
            textBoxY = new TextBox();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(12, 55);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(125, 27);
            textBoxA.TabIndex = 0;
            textBoxA.TextChanged += textBoxA_TextChanged;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(12, 32);
            labelA.Name = "labelA";
            labelA.Size = new Size(17, 20);
            labelA.TabIndex = 1;
            labelA.Text = "a";
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(37, 258);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 2;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // labelScheitel
            // 
            labelScheitel.AutoSize = true;
            labelScheitel.Location = new Point(12, 110);
            labelScheitel.Name = "labelScheitel";
            labelScheitel.Size = new Size(61, 20);
            labelScheitel.TabIndex = 3;
            labelScheitel.Text = "Scheitel";
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(143, 55);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(125, 27);
            textBoxB.TabIndex = 4;
            textBoxB.TextChanged += textBoxB_TextChanged;
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(143, 32);
            labelB.Name = "labelB";
            labelB.Size = new Size(18, 20);
            labelB.TabIndex = 5;
            labelB.Text = "b";
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(274, 55);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(125, 27);
            textBoxC.TabIndex = 6;
            textBoxC.TextChanged += textBoxC_TextChanged;
            // 
            // textBoxScheitelY
            // 
            textBoxScheitelY.Location = new Point(274, 110);
            textBoxScheitelY.Name = "textBoxScheitelY";
            textBoxScheitelY.Size = new Size(125, 27);
            textBoxScheitelY.TabIndex = 7;
            textBoxScheitelY.TextChanged += textBoxScheitelY_TextChanged;
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(274, 32);
            labelC.Name = "labelC";
            labelC.Size = new Size(16, 20);
            labelC.TabIndex = 8;
            labelC.Text = "c";
            // 
            // labelFunktionswert
            // 
            labelFunktionswert.AutoSize = true;
            labelFunktionswert.Location = new Point(12, 208);
            labelFunktionswert.Name = "labelFunktionswert";
            labelFunktionswert.Size = new Size(100, 20);
            labelFunktionswert.TabIndex = 9;
            labelFunktionswert.Text = "Funktionswert";
            // 
            // buttonRechnePotenz
            // 
            buttonRechnePotenz.Location = new Point(12, 334);
            buttonRechnePotenz.Name = "buttonRechnePotenz";
            buttonRechnePotenz.Size = new Size(94, 29);
            buttonRechnePotenz.TabIndex = 14;
            buttonRechnePotenz.Text = "Rechne!";
            buttonRechnePotenz.UseVisualStyleBackColor = true;
            buttonRechnePotenz.Click += buttonRechnePotenz_Click;
            // 
            // labelNullstellen
            // 
            labelNullstellen.AutoSize = true;
            labelNullstellen.Location = new Point(12, 161);
            labelNullstellen.Name = "labelNullstellen";
            labelNullstellen.Size = new Size(215, 20);
            labelNullstellen.TabIndex = 18;
            labelNullstellen.Text = "Diese Funktion hat _ Nullstellen";
            // 
            // textBoxScheitelX
            // 
            textBoxScheitelX.Location = new Point(143, 110);
            textBoxScheitelX.Name = "textBoxScheitelX";
            textBoxScheitelX.Size = new Size(125, 27);
            textBoxScheitelX.TabIndex = 19;
            textBoxScheitelX.TextChanged += textBoxScheitelX_TextChanged;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(12, 258);
            labelX.Name = "labelX";
            labelX.Size = new Size(19, 20);
            labelX.TabIndex = 20;
            labelX.Text = "x:";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(193, 261);
            labelY.Name = "labelY";
            labelY.Size = new Size(19, 20);
            labelY.TabIndex = 21;
            labelY.Text = "y:";
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(218, 258);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(125, 27);
            textBoxY.TabIndex = 22;
            textBoxY.TextChanged += textBoxY_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxY);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(textBoxScheitelX);
            Controls.Add(labelNullstellen);
            Controls.Add(buttonRechnePotenz);
            Controls.Add(labelFunktionswert);
            Controls.Add(labelC);
            Controls.Add(textBoxScheitelY);
            Controls.Add(textBoxC);
            Controls.Add(labelB);
            Controls.Add(textBoxB);
            Controls.Add(labelScheitel);
            Controls.Add(textBoxX);
            Controls.Add(labelA);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private Label labelA;
        private TextBox textBoxX;
        private Label labelScheitel;
        private TextBox textBoxB;
        private Label labelB;
        private TextBox textBoxC;
        private TextBox textBoxScheitelY;
        private Label labelC;
        private Label labelFunktionswert;
        private Button buttonRechnePotenz;
        private Label labelNullstellen;
        private TextBox textBoxScheitelX;
        private Label labelX;
        private Label labelY;
        private TextBox textBoxY;
    }
}