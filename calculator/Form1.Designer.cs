
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
            this._results = new System.Windows.Forms.TextBox();
            this._clearEntry = new System.Windows.Forms.Button();
            this._clear = new System.Windows.Forms.Button();
            this._nine = new System.Windows.Forms.Button();
            this._plus = new System.Windows.Forms.Button();
            this._eight = new System.Windows.Forms.Button();
            this._seven = new System.Windows.Forms.Button();
            this._four = new System.Windows.Forms.Button();
            this._five = new System.Windows.Forms.Button();
            this._minus = new System.Windows.Forms.Button();
            this._six = new System.Windows.Forms.Button();
            this._one = new System.Windows.Forms.Button();
            this._two = new System.Windows.Forms.Button();
            this._times = new System.Windows.Forms.Button();
            this._three = new System.Windows.Forms.Button();
            this._zero = new System.Windows.Forms.Button();
            this._dot = new System.Windows.Forms.Button();
            this._slash = new System.Windows.Forms.Button();
            this._equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _results
            // 
            this._results.Location = new System.Drawing.Point(5, 12);
            this._results.Name = "_results";
            this._results.ReadOnly = true;
            this._results.Size = new System.Drawing.Size(191, 22);
            this._results.TabIndex = 0;
            this._results.Text = "\r\n";
            this._results.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _clearEntry
            // 
            this._clearEntry.Location = new System.Drawing.Point(104, 40);
            this._clearEntry.Name = "_clearEntry";
            this._clearEntry.Size = new System.Drawing.Size(40, 23);
            this._clearEntry.TabIndex = 1;
            this._clearEntry.Text = "CE";
            this._clearEntry.UseVisualStyleBackColor = true;
            this._clearEntry.Click += new System.EventHandler(this.ClearEntryClick);
            // 
            // _clear
            // 
            this._clear.Location = new System.Drawing.Point(151, 40);
            this._clear.Name = "_clear";
            this._clear.Size = new System.Drawing.Size(40, 23);
            this._clear.TabIndex = 2;
            this._clear.Text = "C";
            this._clear.UseVisualStyleBackColor = true;
            this._clear.Click += new System.EventHandler(this.ClearClick);
            // 
            // _nine
            // 
            this._nine.Location = new System.Drawing.Point(104, 69);
            this._nine.Name = "_nine";
            this._nine.Size = new System.Drawing.Size(40, 23);
            this._nine.TabIndex = 3;
            this._nine.Text = "9";
            this._nine.UseVisualStyleBackColor = true;
            this._nine.Click += new System.EventHandler(this.ClickNine);
            // 
            // _plus
            // 
            this._plus.Location = new System.Drawing.Point(151, 69);
            this._plus.Name = "_plus";
            this._plus.Size = new System.Drawing.Size(40, 23);
            this._plus.TabIndex = 4;
            this._plus.Text = "+";
            this._plus.UseVisualStyleBackColor = true;
            this._plus.Click += new System.EventHandler(this.ClickPlus);
            // 
            // _eight
            // 
            this._eight.Location = new System.Drawing.Point(58, 69);
            this._eight.Name = "_eight";
            this._eight.Size = new System.Drawing.Size(40, 23);
            this._eight.TabIndex = 5;
            this._eight.Text = "8";
            this._eight.UseVisualStyleBackColor = true;
            this._eight.Click += new System.EventHandler(this.ClickEight);
            // 
            // _seven
            // 
            this._seven.Location = new System.Drawing.Point(12, 69);
            this._seven.Name = "_seven";
            this._seven.Size = new System.Drawing.Size(40, 23);
            this._seven.TabIndex = 6;
            this._seven.Text = "7";
            this._seven.UseVisualStyleBackColor = true;
            this._seven.Click += new System.EventHandler(this.ClickSeven);
            // 
            // _four
            // 
            this._four.Location = new System.Drawing.Point(12, 97);
            this._four.Name = "_four";
            this._four.Size = new System.Drawing.Size(40, 23);
            this._four.TabIndex = 10;
            this._four.Text = "4";
            this._four.UseVisualStyleBackColor = true;
            this._four.Click += new System.EventHandler(this.ClickFour);
            // 
            // _five
            // 
            this._five.Location = new System.Drawing.Point(58, 97);
            this._five.Name = "_five";
            this._five.Size = new System.Drawing.Size(40, 23);
            this._five.TabIndex = 9;
            this._five.Text = "5";
            this._five.UseVisualStyleBackColor = true;
            this._five.Click += new System.EventHandler(this.ClickFive);
            // 
            // _minus
            // 
            this._minus.Location = new System.Drawing.Point(151, 97);
            this._minus.Name = "_minus";
            this._minus.Size = new System.Drawing.Size(40, 23);
            this._minus.TabIndex = 8;
            this._minus.Text = "-";
            this._minus.UseVisualStyleBackColor = true;
            this._minus.Click += new System.EventHandler(this.ClickMinus);
            // 
            // _six
            // 
            this._six.Location = new System.Drawing.Point(104, 97);
            this._six.Name = "_six";
            this._six.Size = new System.Drawing.Size(40, 23);
            this._six.TabIndex = 7;
            this._six.Text = "6";
            this._six.UseVisualStyleBackColor = true;
            this._six.Click += new System.EventHandler(this.ClickSix);
            // 
            // _one
            // 
            this._one.Location = new System.Drawing.Point(12, 126);
            this._one.Name = "_one";
            this._one.Size = new System.Drawing.Size(40, 23);
            this._one.TabIndex = 14;
            this._one.Text = "1";
            this._one.UseVisualStyleBackColor = true;
            this._one.Click += new System.EventHandler(this.ClickOne);
            // 
            // _two
            // 
            this._two.Location = new System.Drawing.Point(58, 126);
            this._two.Name = "_two";
            this._two.Size = new System.Drawing.Size(40, 23);
            this._two.TabIndex = 13;
            this._two.Text = "2";
            this._two.UseVisualStyleBackColor = true;
            this._two.Click += new System.EventHandler(this.ClickTwo);
            // 
            // _times
            // 
            this._times.Location = new System.Drawing.Point(151, 126);
            this._times.Name = "_times";
            this._times.Size = new System.Drawing.Size(40, 23);
            this._times.TabIndex = 12;
            this._times.Text = "x";
            this._times.UseVisualStyleBackColor = true;
            this._times.Click += new System.EventHandler(this.ClickTimes);
            // 
            // _three
            // 
            this._three.Location = new System.Drawing.Point(104, 126);
            this._three.Name = "_three";
            this._three.Size = new System.Drawing.Size(40, 23);
            this._three.TabIndex = 11;
            this._three.Text = "3";
            this._three.UseVisualStyleBackColor = true;
            this._three.Click += new System.EventHandler(this.ClickThree);
            // 
            // _zero
            // 
            this._zero.Location = new System.Drawing.Point(12, 155);
            this._zero.Name = "_zero";
            this._zero.Size = new System.Drawing.Size(40, 23);
            this._zero.TabIndex = 18;
            this._zero.Text = "0";
            this._zero.UseVisualStyleBackColor = true;
            this._zero.Click += new System.EventHandler(this.ClickZero);
            // 
            // _dot
            // 
            this._dot.Location = new System.Drawing.Point(58, 155);
            this._dot.Name = "_dot";
            this._dot.Size = new System.Drawing.Size(40, 23);
            this._dot.TabIndex = 17;
            this._dot.Text = ".";
            this._dot.UseVisualStyleBackColor = true;
            this._dot.Click += new System.EventHandler(this.ClickDot);
            // 
            // _slash
            // 
            this._slash.Location = new System.Drawing.Point(151, 155);
            this._slash.Name = "_slash";
            this._slash.Size = new System.Drawing.Size(40, 23);
            this._slash.TabIndex = 16;
            this._slash.Text = "/";
            this._slash.UseVisualStyleBackColor = true;
            this._slash.Click += new System.EventHandler(this.ClickSlash);
            // 
            // _equal
            // 
            this._equal.Location = new System.Drawing.Point(104, 155);
            this._equal.Name = "_equal";
            this._equal.Size = new System.Drawing.Size(40, 23);
            this._equal.TabIndex = 15;
            this._equal.Text = "=";
            this._equal.UseVisualStyleBackColor = true;
            this._equal.Click += new System.EventHandler(this.ClickEqual);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 192);
            this.Controls.Add(this._zero);
            this.Controls.Add(this._dot);
            this.Controls.Add(this._slash);
            this.Controls.Add(this._equal);
            this.Controls.Add(this._one);
            this.Controls.Add(this._two);
            this.Controls.Add(this._times);
            this.Controls.Add(this._three);
            this.Controls.Add(this._four);
            this.Controls.Add(this._five);
            this.Controls.Add(this._minus);
            this.Controls.Add(this._six);
            this.Controls.Add(this._seven);
            this.Controls.Add(this._eight);
            this.Controls.Add(this._plus);
            this.Controls.Add(this._nine);
            this.Controls.Add(this._clear);
            this.Controls.Add(this._clearEntry);
            this.Controls.Add(this._results);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _results;
        private System.Windows.Forms.Button _clearEntry;
        private System.Windows.Forms.Button _clear;
        private System.Windows.Forms.Button _nine;
        private System.Windows.Forms.Button _plus;
        private System.Windows.Forms.Button _eight;
        private System.Windows.Forms.Button _seven;
        private System.Windows.Forms.Button _four;
        private System.Windows.Forms.Button _five;
        private System.Windows.Forms.Button _minus;
        private System.Windows.Forms.Button _six;
        private System.Windows.Forms.Button _one;
        private System.Windows.Forms.Button _two;
        private System.Windows.Forms.Button _times;
        private System.Windows.Forms.Button _three;
        private System.Windows.Forms.Button _zero;
        private System.Windows.Forms.Button _dot;
        private System.Windows.Forms.Button _slash;
        private System.Windows.Forms.Button _equal;
    }
}

