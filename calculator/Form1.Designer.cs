
namespace calculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Results = new System.Windows.Forms.TextBox();
            this.Clear_Entry = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Times = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Slash = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(5, 12);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(191, 22);
            this.Results.TabIndex = 0;
            this.Results.Text = "\r\n";
            this.Results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear_Entry
            // 
            this.Clear_Entry.Location = new System.Drawing.Point(104, 40);
            this.Clear_Entry.Name = "Clear_Entry";
            this.Clear_Entry.Size = new System.Drawing.Size(40, 23);
            this.Clear_Entry.TabIndex = 1;
            this.Clear_Entry.Text = "CE";
            this.Clear_Entry.UseVisualStyleBackColor = true;
            this.Clear_Entry.Click += new System.EventHandler(this.Clear_Entry_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(151, 40);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(40, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(104, 69);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(40, 23);
            this.Nine.TabIndex = 3;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(151, 69);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(40, 23);
            this.Plus.TabIndex = 4;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(58, 69);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(40, 23);
            this.Eight.TabIndex = 5;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 69);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(40, 23);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 97);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(40, 23);
            this.Four.TabIndex = 10;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(58, 97);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(40, 23);
            this.Five.TabIndex = 9;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(151, 97);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(40, 23);
            this.Minus.TabIndex = 8;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(104, 97);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(40, 23);
            this.Six.TabIndex = 7;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(12, 126);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(40, 23);
            this.One.TabIndex = 14;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(58, 126);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(40, 23);
            this.Two.TabIndex = 13;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Times
            // 
            this.Times.Location = new System.Drawing.Point(151, 126);
            this.Times.Name = "Times";
            this.Times.Size = new System.Drawing.Size(40, 23);
            this.Times.TabIndex = 12;
            this.Times.Text = "x";
            this.Times.UseVisualStyleBackColor = true;
            this.Times.Click += new System.EventHandler(this.Times_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(104, 126);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(40, 23);
            this.Three.TabIndex = 11;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(12, 155);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(40, 23);
            this.Zero.TabIndex = 18;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(58, 155);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(40, 23);
            this.Dot.TabIndex = 17;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Slash
            // 
            this.Slash.Location = new System.Drawing.Point(151, 155);
            this.Slash.Name = "Slash";
            this.Slash.Size = new System.Drawing.Size(40, 23);
            this.Slash.TabIndex = 16;
            this.Slash.Text = "/";
            this.Slash.UseVisualStyleBackColor = true;
            this.Slash.Click += new System.EventHandler(this.Slash_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(104, 155);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(40, 23);
            this.Equal.TabIndex = 15;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 192);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Slash);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Times);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Clear_Entry);
            this.Controls.Add(this.Results);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Button Clear_Entry;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Times;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Slash;
        private System.Windows.Forms.Button Equal;
    }
}

